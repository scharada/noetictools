#region Copyright

/*---------------------------------------------------------------------------
 * The contents of this file are subject to the Mozilla Public License
 * Version 1.1 (the "License"); you may not use this file except in compliance
 * with the License. You may obtain a copy of the License at
 * 
 * http://www.mozilla.org/MPL/
 * 
 * Software distributed under the License is distributed on an "AS IS"
 * basis, WITHOUT WARRANTY OF ANY KIND, either express or implied. See the
 * License for the specific language governing rights and limitations under 
 * the License.
 * 
 * The Initial Developer of the Original Code is Robert Smyth.
 * Portions created by Robert Smyth are Copyright (C) 2008.
 * 
 * All Rights Reserved.
 *---------------------------------------------------------------------------*/

#endregion

using System;
using System.Windows.Forms;
using NoeticTools.PlugIns.UI;


namespace NoeticTools.PlugIns.Options
{
	public partial class OptionsView : ContentForm
	{
		private readonly IOptions[] options;
		private readonly PropertyGrid propertyGrid;
		private IOptions selectedOptions;

		public OptionsView()
		{
			InitializeComponent();
		}

		public OptionsView(IOptions[] options, PropertyGrid propertyGrid) : this()
		{
			this.options = options;
			this.propertyGrid = propertyGrid;
			splitContainer.Panel2.Controls.Add(propertyGrid);
			propertyGrid.Dock = DockStyle.Fill;
		}

		private void OptionsView_Load(object sender, EventArgs e)
		{
			pluginsListView.Clear();
			foreach (IOptions option in options)
			{
				pluginsListView.Items.Add(option.OptionsName);
			}

			pluginsListView.SelectedIndexChanged += pluginsListView_SelectedIndexChanged;

			if (options.Length > 0)
			{
				selectedOptions = options[0];
				pluginsListView.Select();
				pluginsListView.TopItem.Selected = true;
			}
		}

		private void pluginsListView_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (pluginsListView.SelectedIndices.Count == 1)
			{
				selectedOptions = options[pluginsListView.SelectedIndices[0]];
				UpdateProperties();
			}
		}

		private void UpdateProperties()
		{
			if (!DesignMode)
			{
				if (selectedOptions != null)
				{
					propertyGrid.SelectedObject = selectedOptions;
				}
			}
		}
	}
}