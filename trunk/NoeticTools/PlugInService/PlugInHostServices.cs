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
using WeifenLuo.WinFormsUI.Docking;


namespace NoeticTools.PlugIns
{
	public class PlugInHostServices : IPlugInHostServices
	{
		private readonly DockPanel dockPanel;
		private readonly Form mainForm;
		private readonly List<IOnOpenListener> onOpenListeners = new List<IOnOpenListener>();
		private readonly Dictionary<Type, object> services = new Dictionary<Type, object>();
		private readonly IToolBar toolBar;
		private readonly IStatusBar statusBar;

		public PlugInHostServices(Form mainForm, DockPanel dockPanel, IToolBar toolBar, IStatusBar statusBar)
		{
			mainForm.Load += mainForm_Load;
			this.mainForm = mainForm;
			this.dockPanel = dockPanel;
			this.toolBar = toolBar;
			this.statusBar = statusBar;
		}

		public void AddOnOpenListener(IOnOpenListener listener)
		{
			onOpenListeners.Add(listener);
		}

		public void Show(DockContent view, DockState dockState)
		{
			view.ShowHint = dockState;
			view.Show(dockPanel);
		}

		public Form MainForm
		{
			get { return mainForm; }
		}

		public IToolBar ToolBar
		{
			get { return toolBar; }
		}

		public IToolStripMenuService MenuBar
		{
			get { return GetService<IToolStripMenuService>(); }
		}

		public IStatusBar StatusBar
		{
			get { return statusBar; }
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
	}
}
