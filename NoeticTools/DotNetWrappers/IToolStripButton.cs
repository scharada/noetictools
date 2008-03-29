using System;
using System.Drawing;
using System.Windows.Forms;


namespace NoeticTools.DotNetWrappers
{
	public interface IToolStripButton
	{
		bool AutoToolTip { get; set; }
		bool CanSelect { get; }
		bool CheckOnClick { get; set; }
		bool Checked { get; set; }
		CheckState CheckState { get; set; }

		event EventHandler CheckedChanged;
		event EventHandler CheckStateChanged;

		Size GetPreferredSize(Size constrainingSize);
	}
}