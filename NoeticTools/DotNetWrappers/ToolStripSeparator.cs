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
	public class ToolStripSeparator : IToolStripSeparator
	{
		public Size GetPreferredSize(Size constrainingSize)
		{
			return separator.GetPreferredSize(constrainingSize);
		}

		public bool AutoToolTip
		{
			get { return separator.AutoToolTip; }
			set { separator.AutoToolTip = value; }
		}

		public Image BackgroundImage
		{
			get { return separator.BackgroundImage; }
			set { separator.BackgroundImage = value; }
		}

		public ImageLayout BackgroundImageLayout
		{
			get { return separator.BackgroundImageLayout; }
			set { separator.BackgroundImageLayout = value; }
		}

		public bool CanSelect
		{
			get { return separator.CanSelect; }
		}

		public bool DoubleClickEnabled
		{
			get { return separator.DoubleClickEnabled; }
			set { separator.DoubleClickEnabled = value; }
		}

		public bool Enabled
		{
			get { return separator.Enabled; }
			set { separator.Enabled = value; }
		}

		public ToolStripItemDisplayStyle DisplayStyle
		{
			get { return separator.DisplayStyle; }
			set { separator.DisplayStyle = value; }
		}

		public Font Font
		{
			get { return separator.Font; }
			set { separator.Font = value; }
		}

		public ContentAlignment ImageAlign
		{
			get { return separator.ImageAlign; }
			set { separator.ImageAlign = value; }
		}

		public Image Image
		{
			get { return separator.Image; }
			set { separator.Image = value; }
		}

		public int ImageIndex
		{
			get { return separator.ImageIndex; }
			set { separator.ImageIndex = value; }
		}

		public string ImageKey
		{
			get { return separator.ImageKey; }
			set { separator.ImageKey = value; }
		}

		public Color ImageTransparentColor
		{
			get { return separator.ImageTransparentColor; }
			set { separator.ImageTransparentColor = value; }
		}

		public ToolStripItemImageScaling ImageScaling
		{
			get { return separator.ImageScaling; }
			set { separator.ImageScaling = value; }
		}

		public string Text
		{
			get { return separator.Text; }
			set { separator.Text = value; }
		}

		public ContentAlignment TextAlign
		{
			get { return separator.TextAlign; }
			set { separator.TextAlign = value; }
		}

		public ToolStripTextDirection TextDirection
		{
			get { return separator.TextDirection; }
			set { separator.TextDirection = value; }
		}

		public TextImageRelation TextImageRelation
		{
			get { return separator.TextImageRelation; }
			set { separator.TextImageRelation = value; }
		}

		public string ToolTipText
		{
			get { return separator.ToolTipText; }
			set { separator.ToolTipText = value; }
		}

		public bool RightToLeftAutoMirrorImage
		{
			get { return separator.RightToLeftAutoMirrorImage; }
			set { separator.RightToLeftAutoMirrorImage = value; }
		}

		public event EventHandler EnabledChanged
		{
			add { separator.EnabledChanged += value; }
			remove { separator.EnabledChanged -= value; }
		}

		public event EventHandler DisplayStyleChanged
		{
			add { separator.DisplayStyleChanged += value; }
			remove { separator.DisplayStyleChanged -= value; }
		}

		public event EventHandler TextChanged
		{
			add { separator.TextChanged += value; }
			remove { separator.TextChanged -= value; }
		}

		private System.Windows.Forms.ToolStripSeparator separator;

		public ToolStripSeparator(System.Windows.Forms.ToolStripSeparator separator)
		{
			this.separator = separator;
		}
	}
}
