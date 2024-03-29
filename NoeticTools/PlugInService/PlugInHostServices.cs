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

#endregion //Copyright

using System;
using System.Collections.Generic;
using System.Windows.Forms;
using NoeticTools.PlugIns.Menus;
using NoeticTools.PlugIns.ToolBar;
using WeifenLuo.WinFormsUI.Docking;


namespace NoeticTools.PlugIns
{
	public class PlugInHostServices : IPluginHostServices
	{
		private readonly DockPanel dockPanel;
		private readonly Form mainForm;
		private readonly List<IOnOpenListener> onOpenListeners = new List<IOnOpenListener>();
		private readonly Dictionary<Type, object> services = new Dictionary<Type, object>();
		private readonly IOptionsView optionsView;

		public PlugInHostServices(Form mainForm, DockPanel dockPanel, IOptionsView optionsView)
		{
			mainForm.Load += mainForm_Load;
			mainForm.Closing += mainForm_Closing;
			this.mainForm = mainForm;
			this.dockPanel = dockPanel;
			this.optionsView = optionsView;
		}

		void IPluginHostServices.AddOnOpenListener(IOnOpenListener listener)
		{
			onOpenListeners.Add(listener);
		}

		void IPluginHostServices.Show(DockContent view, DockState dockState)
		{
			view.ShowHint = dockState;
			view.Show(dockPanel);
		}

		Form IPluginHostServices.MainForm
		{
			get { return mainForm; }
		}

		public IToolStripMenuService MenuBar
		{
			get { return GetService<IToolStripMenuService>(); }
		}

		public IToolStripService ToolStrip
		{
			get { return GetService<IToolStripService>(); }
		}

		public IOptionsView OptionsView
		{
			get { return optionsView; }
		}

		public void AddService<T>(T service)
		{
			services.Add(typeof (T), service);
		}

		public T GetService<T>()
			where T : class
		{
			object service;
			if (!services.TryGetValue(typeof (T), out service))
			{
				service = null;
			}
			return service as T;
		}

		private void mainForm_Load(object sender, EventArgs e)
		{
			foreach (IOnOpenListener openListener in onOpenListeners)
			{
				openListener.OnOpen(this);
			}
		}

		private void mainForm_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{
			foreach (IOnOpenListener openListener in onOpenListeners)
			{
				openListener.OnClosing();
			}
		}
	}
}
