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

using System.ComponentModel;
using System.Windows.Forms;
using NoeticTools.Windows.Forms;


namespace NoeticTools.PlugIns.UI
{
	public partial class HeaderPanel : UserControl
	{
		public HeaderPanel()
		{
			InitializeComponent();
		}

		[Category("Appearance")]
		[DefaultValue("Header Text")]
		public string HeaderText
		{
			get { return headerLabel.Text; }
			set { headerLabel.Text = value; }
		}

		[Browsable(false)]
		public override System.Drawing.Color BackColor
		{
			get { return base.BackColor; }
			set { base.BackColor = value; }
		}

		[Browsable(false)]
		public override System.Drawing.Image BackgroundImage
		{
			get { return base.BackgroundImage; }
			set { base.BackgroundImage = value; }
		}

		[Browsable(false)]
		public override System.Drawing.Color ForeColor
		{
			get { return base.ForeColor; }
			set { base.ForeColor = value; }
		}

		public PlaceHolderControl LegacyRightPlaceHolder
		{
			get { return rightPlaceHolder; }
		}
	}
}