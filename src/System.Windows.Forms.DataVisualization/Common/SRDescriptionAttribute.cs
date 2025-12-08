// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.ComponentModel;

namespace System.Windows.Forms.DataVisualization.Charting;

[AttributeUsage(AttributeTargets.All)]
internal sealed class SRDescriptionAttribute(string description) : DescriptionAttribute(description)
{
	// Fields
	private bool replaced;

	// Properties
	public override string Description
	{
		get
		{
			if (!replaced)
			{
				replaced = true;
				DescriptionValue = SR.Keys.GetString(base.Description);
			}

			return base.Description;
		}
	}
}


