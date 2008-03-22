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
using System.Collections.Generic;
using System.Windows.Forms;
using NoeticTools.PlugIns;
using NoeticTools.PlugIns.Options;
using WeifenLuo.WinFormsUI.Docking;


namespace NoeticTools.PlugIns.Options
{
	public class OptionsViewPlugIn : IPlugIn, IOptionsView
	{
		private readonly List<object> options = new List<object>();
		private IPlugInHostServices hostServices;
		private ToolStripMenuItem menuItem;
		private DockContent optionsView;

		public void Accept(IPlugInHostServices services)
		{
			hostServices = services;

			menuItem = hostServices.MenuBar.AddMenuItem("&Tools|&Options");
			menuItem.Click += menuItem_Click;
		}

		public void AddProperties(object optionProperties)
		{
			options.Add(optionProperties);
		}

		private void menuItem_Click(object sender, EventArgs e)
		{
			if (optionsView == null)
			{
				OptionsView view = new OptionsView(options, new PropertyGrid());
				view.Closed += view_Closed;

				optionsView = view;
				hostServices.Show(optionsView, DockState.Document);
			}
			else
			{
				optionsView.Activate();
			}
		}

		private void view_Closed(object sender, EventArgs e)
		{
			optionsView = null;
		}
	}
}