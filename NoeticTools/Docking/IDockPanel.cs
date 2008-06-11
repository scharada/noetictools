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