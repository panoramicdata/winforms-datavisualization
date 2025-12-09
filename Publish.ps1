<#
.SYNOPSIS
    Publishes the NuGet package to nuget.org.

.DESCRIPTION
    This script performs the following steps:
    1. Checks for uncommitted git changes (porcelain)
    2. Determines the Nerdbank GitVersioning version
    3. Validates nuget-key.txt exists, has content, and is gitignored
    4. Runs unit tests (unless -SkipTests is specified)
    5. Publishes the package to nuget.org

.PARAMETER SkipTests
    Skip running unit tests.

.EXAMPLE
    .\Publish.ps1
    .\Publish.ps1 -SkipTests
#>

[CmdletBinding()]
param(
    [switch]$SkipTests
)

$ErrorActionPreference = 'Stop'

# Helper function to exit with error
function Exit-WithError {
    param([string]$Message)
    Write-Error $Message
    exit 1
}

# Step 1: Check for uncommitted git changes
Write-Host "Checking for uncommitted git changes..." -ForegroundColor Cyan
$gitStatus = git status --porcelain
if ($gitStatus) {
    Exit-WithError "There are uncommitted changes in the repository. Please commit or stash them before publishing."
}
Write-Host "Git working directory is clean." -ForegroundColor Green

# Step 2: Determine the Nerdbank GitVersioning version
Write-Host "Determining Nerdbank GitVersioning version..." -ForegroundColor Cyan
$nbgvOutput = nbgv get-version --format json 2>&1
if ($LASTEXITCODE -ne 0) {
    Exit-WithError "Failed to get Nerdbank GitVersioning version. Ensure nbgv is installed (dotnet tool install -g nbgv). Error: $nbgvOutput"
}
$versionInfo = $nbgvOutput | ConvertFrom-Json
$nugetVersion = $versionInfo.NuGetPackageVersion
if (-not $nugetVersion) {
    Exit-WithError "Could not determine NuGet package version from Nerdbank GitVersioning."
}
Write-Host "NuGet Package Version: $nugetVersion" -ForegroundColor Green

# Step 3: Check that nuget-key.txt exists, has content, and is gitignored
Write-Host "Validating nuget-key.txt..." -ForegroundColor Cyan
$nugetKeyPath = Join-Path $PSScriptRoot "nuget-key.txt"

if (-not (Test-Path $nugetKeyPath)) {
    Exit-WithError "nuget-key.txt does not exist. Please create it with your NuGet API key."
}

$nugetKey = (Get-Content $nugetKeyPath -Raw).Trim()
if ([string]::IsNullOrWhiteSpace($nugetKey)) {
    Exit-WithError "nuget-key.txt is empty. Please add your NuGet API key."
}

# Check if nuget-key.txt is gitignored
$gitCheckIgnore = git check-ignore "nuget-key.txt" 2>&1
if ($LASTEXITCODE -ne 0) {
    Exit-WithError "nuget-key.txt is not gitignored. Please add it to .gitignore to prevent accidental exposure of your API key."
}
Write-Host "nuget-key.txt is valid and gitignored." -ForegroundColor Green

# Step 4: Run unit tests (unless -SkipTests is specified)
if (-not $SkipTests) {
    Write-Host "Running unit tests..." -ForegroundColor Cyan
    dotnet test --configuration Release --no-restore
    if ($LASTEXITCODE -ne 0) {
        Exit-WithError "Unit tests failed."
    }
    Write-Host "Unit tests passed." -ForegroundColor Green
} else {
    Write-Host "Skipping unit tests." -ForegroundColor Yellow
}

# Step 5: Build and pack the project
Write-Host "Building and packing the project..." -ForegroundColor Cyan
$projectPath = Join-Path $PSScriptRoot "System.Windows.Forms.DataVisualization\System.Windows.Forms.DataVisualization.csproj"
dotnet pack $projectPath --configuration Release --no-restore
if ($LASTEXITCODE -ne 0) {
    Exit-WithError "Failed to build/pack the project."
}
Write-Host "Project packed successfully." -ForegroundColor Green

# Step 6: Publish to nuget.org
Write-Host "Publishing to nuget.org..." -ForegroundColor Cyan
$nupkgPath = Join-Path $PSScriptRoot "System.Windows.Forms.DataVisualization\bin\Release\PanoramicData.System.Windows.Forms.DataVisualization.$nugetVersion.nupkg"

if (-not (Test-Path $nupkgPath)) {
    Exit-WithError "NuGet package not found at: $nupkgPath"
}

dotnet nuget push $nupkgPath --api-key $nugetKey --source https://api.nuget.org/v3/index.json
if ($LASTEXITCODE -ne 0) {
    Exit-WithError "Failed to publish package to nuget.org."
}

Write-Host "Successfully published PanoramicData.System.Windows.Forms.DataVisualization $nugetVersion to nuget.org!" -ForegroundColor Green
exit 0
