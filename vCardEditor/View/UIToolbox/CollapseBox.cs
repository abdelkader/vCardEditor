using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;

namespace UIToolbox
{
	/// <summary>
	/// Summary description for CollapseBox.
	/// </summary>
	public class CollapseBox : OwnerDrawButton
	{
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		#region Internal variables
		private bool		m_bIsPlus;
		#endregion Internal variables

		public CollapseBox()
		{
			// This call is required by the Windows.Forms Form Designer.
			InitializeComponent();
		}

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Component Designer generated code
		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			// 
			// CollapseBox
			// 
			this.Click += new System.EventHandler(this.CollapseBox_Click);
			this.Paint += new System.Windows.Forms.PaintEventHandler(this.CollapseBox_Paint);
			this.DoubleClick += new System.EventHandler(this.CollapseBox_DoubleClick);

		}
		#endregion

		#region Events
		private void CollapseBox_Click(object sender, System.EventArgs e)
		{
			IsPlus = !IsPlus;
		}
		
		private void CollapseBox_DoubleClick(object sender, System.EventArgs e)
		{
			// fast clicking registers as double-clicking, so map a double-click
			// event into a single click.
			CollapseBox_Click(sender, e);
		}

		private void CollapseBox_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
		{
			Graphics g = e.Graphics;

			if(m_ButtonState == ButtonState.TrackingInside)
				g.FillRectangle(Brushes.LightGray, ClientRectangle);
			else
				g.FillRectangle(Brushes.White, ClientRectangle);

			Rectangle theRec = new Rectangle();
			theRec = ClientRectangle;
			theRec.Width--;
			theRec.Height--;
			g.DrawRectangle(Pens.Black, theRec);
			g.DrawLine(Pens.Black, theRec.X + 2, theRec.Y + (this.Height/2),
				theRec.X + this.Width - 3, theRec.Y + (this.Height/2));
			if(m_bIsPlus)
			{
				g.DrawLine(Pens.Black, theRec.X + (this.Width/2), theRec.Y + 2,
					theRec.X + (this.Width/2), theRec.Y + this.Height - 3);
			}
		}
		#endregion Events

		#region Accessors
		[DefaultValue(false)]
		public bool IsPlus
		{
			get
			{
				return m_bIsPlus;
			}
			set
			{
				if(m_bIsPlus != value)
				{
					m_bIsPlus = value;
					Invalidate();
				}
			}
		}
		#endregion Accessors
	}
}
