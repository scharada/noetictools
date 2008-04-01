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
using System.Drawing;
using System.Windows.Forms;


namespace NoeticTools.Windows.Forms
{
	public partial class ErrorForm : Form
	{
		public ErrorForm(string message, Exception exception)
		{
			InitializeComponent();

			AppendText(message + "\n", FontStyle.Regular, 0, 1.25F);

			AppendText(exception);

			if (exception.InnerException != null)
			{
				AppendText("\nInner exception\n", FontStyle.Underline, 0, 1.0F);
				AppendText(exception.InnerException);
			}

			messageRichTextBox.Select(0, 0);
			messageRichTextBox.DeselectAll();
		}

		private void AppendText(Exception exception)
		{
			AppendText("\nException message:\n", FontStyle.Underline, 0, 1.0F);
			AppendText(exception.Message + "\n", FontStyle.Regular, 4, 1.0F);
			AppendText("\n");

			AppendText("Stack trace:\n", FontStyle.Underline, 0, 1.0F);
			AppendText(exception.StackTrace + "\n", FontStyle.Regular, 4, 1.0F);
		}

		private void AppendText(string message)
		{
			AppendText(message, FontStyle.Regular, 0, 1.0F);
		}

		private void AppendText(string message, FontStyle fontStyle, int indent, float fontSize)
		{
			messageRichTextBox.Select(messageRichTextBox.Text.Length, 0);

			int start = messageRichTextBox.SelectionStart;
			messageRichTextBox.AppendText(message);
			int end = messageRichTextBox.SelectionStart;

			messageRichTextBox.Select(start, end - start);

			Font baseFont = messageRichTextBox.Font;
			Font font = new Font(baseFont.FontFamily, baseFont.Size * fontSize, fontStyle);
			messageRichTextBox.SelectionFont = font;
			messageRichTextBox.SelectionIndent = indent;

			messageRichTextBox.DeselectAll();
		}

		private void okButton_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}