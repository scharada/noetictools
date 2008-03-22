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

using System.Collections.Generic;
using System.Windows.Forms;
using NoeticTools.PlugIns.UI;


namespace NoeticTools.PlugIns.Options
{
	public partial class OptionsView : ContentForm
	{
		private readonly PropertyGrid propertyGrid;
		private readonly List<object> options;

		public OptionsView()
		{
			InitializeComponent();
		}

		public OptionsView(List<object> options, PropertyGrid propertyGrid) : this()
		{
			this.options = options;
			this.propertyGrid = propertyGrid;
			ContentPlaceHolder.AddControl(propertyGrid);
		}

		private void OptionsView_Load(object sender, System.EventArgs e)
		{
			UpdateProperties();
		}

		private void UpdateProperties()
		{
			if (!DesignMode)
			{
				propertyGrid.SelectedObjects = options.ToArray();
			}
		}
	}
}