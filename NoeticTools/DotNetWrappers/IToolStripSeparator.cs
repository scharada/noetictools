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
using System.Drawing;
using System.Windows.Forms;


namespace NoeticTools.DotNetWrappers
{
	public interface IToolStripSeparator
	{
		bool AutoToolTip { get; set; }

		Image BackgroundImage { get; set; }

		ImageLayout BackgroundImageLayout { get; set; }

		bool CanSelect { get; }

		bool DoubleClickEnabled { get; set; }

		bool Enabled { get; set; }

		ToolStripItemDisplayStyle DisplayStyle { get; set; }

		Font Font { get; set; }

		ContentAlignment ImageAlign { get; set; }

		Image Image { get; set; }

		int ImageIndex { get; set; }

		string ImageKey { get; set; }

		Color ImageTransparentColor { get; set; }

		ToolStripItemImageScaling ImageScaling { get; set; }

		string Text { get; set; }

		ContentAlignment TextAlign { get; set; }

		ToolStripTextDirection TextDirection { get; set; }

		TextImageRelation TextImageRelation { get; set; }

		string ToolTipText { get; set; }

		bool RightToLeftAutoMirrorImage { get; set; }
		Size GetPreferredSize(Size constrainingSize);

		event EventHandler EnabledChanged;

		event EventHandler DisplayStyleChanged;

		event EventHandler TextChanged;
	}
}