// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.ComponentModel;

namespace System.Windows.Forms.DataVisualization.Charting;

[AttributeUsage(AttributeTargets.All)]
internal sealed class SRCategoryAttribute(string category) : CategoryAttribute(category)
{
	protected override string GetLocalizedString(string value)
	{
		return SR.Keys.GetString(value);
	}
}
