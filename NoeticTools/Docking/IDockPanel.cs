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
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;


namespace NoeticTools.Docking
{
    public interface IDockPanel
    {
        IDockContent ActiveContent { get; }

        DockPane ActivePane { get; }

        IDockContent ActiveDocument { get; }

        DockPane ActiveDocumentPane { get; }

        IDockContent ActiveAutoHideContent { get; set; }

        bool AllowEndUserDocking { get; set; }

        bool AllowEndUserNestedDocking { get; set; }

        DockContentCollection Contents { get; }

        bool RightToLeftLayout { get; set; }

        bool ShowDocumentIcon { get; set; }

        DockPanelExtender Extender { get; }

        DockPanelExtender.IDockPaneFactory DockPaneFactory { get; }

        DockPanelExtender.IFloatWindowFactory FloatWindowFactory { get; }

        DockPaneCollection Panes { get; }

        double DockBottomPortion { get; set; }

        double DockLeftPortion { get; set; }

        double DockRightPortion { get; set; }

        double DockTopPortion { get; set; }

        DockWindowCollection DockWindows { get; }

        int DocumentsCount { get; }

        IEnumerable<IDockContent> Documents { get; }

        FloatWindowCollection FloatWindows { get; }

        Size DefaultFloatWindowSize { get; set; }

        DocumentStyle DocumentStyle { get; set; }
        void UpdateDockWindowZOrder(DockStyle dockStyle, bool fullPanelEdge);
        IDockContent[] DocumentsToArray();
        void SetPaneIndex(DockPane pane, int index);
        void SuspendLayout(bool allWindows);
        void ResumeLayout(bool performLayout, bool allWindows);
        void SaveAsXml(string fileName);
        void SaveAsXml(string fileName, Encoding encoding);
        void SaveAsXml(Stream stream, Encoding encoding);
        void SaveAsXml(Stream stream, Encoding encoding, bool upstream);
        void LoadFromXml(string fileName, DeserializeDockContent deserializeContent);
        void LoadFromXml(Stream stream, DeserializeDockContent deserializeContent);
        void LoadFromXml(Stream stream, DeserializeDockContent deserializeContent, bool closeStream);

        event EventHandler ActiveDocumentChanged;

        event EventHandler ActiveContentChanged;

        event EventHandler ActivePaneChanged;

        event EventHandler<DockContentEventArgs> ContentAdded;

        event EventHandler<DockContentEventArgs> ContentRemoved;
    }
}