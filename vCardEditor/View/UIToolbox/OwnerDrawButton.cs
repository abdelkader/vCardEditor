using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;

namespace UIToolbox
{
	/// <summary>
	/// Summary description for OwnerDrawButton.
	/// </summary>
	public class OwnerDrawButton : System.Windows.Forms.Control
	{
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		#region Internal variables
		public enum ButtonState
		{
			Normal,
			TrackingInside,
			TrackingOutside
		}

		protected ButtonState	m_ButtonState = ButtonState.Normal;
		#endregion Internal variables

		public OwnerDrawButton()
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
			// OwnerDrawButton
			// 
			this.Resize += new System.EventHandler(this.OwnerDrawButton_Resize);
			this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OwnerDrawButton_MouseUp);
			this.Paint += new System.Windows.Forms.PaintEventHandler(this.OwnerDrawButton_Paint);
			this.MouseEnter += new System.EventHandler(this.OwnerDrawButton_MouseEnter);
			this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OwnerDrawButton_MouseMove);
			this.MouseLeave += new System.EventHandler(this.OwnerDrawButton_MouseLeave);
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OwnerDrawButton_MouseDown);

		}
		#endregion

		#region Events
		private void OwnerDrawButton_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
		{
			// needs to be implemented by the derived class
		}

		private void OwnerDrawButton_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			m_ButtonState = ButtonState.TrackingInside;
			Invalidate();
		}

		private void OwnerDrawButton_MouseEnter(object sender, System.EventArgs e)
		{
			if(m_ButtonState == ButtonState.TrackingOutside)
			{
				m_ButtonState = ButtonState.TrackingInside;
				Invalidate();
			}
		}

		private void OwnerDrawButton_MouseLeave(object sender, System.EventArgs e)
		{
			if(m_ButtonState == ButtonState.TrackingInside)
			{
				m_ButtonState = ButtonState.TrackingOutside;
				Invalidate();
			}
		}

		private void OwnerDrawButton_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			if(m_ButtonState == ButtonState.Normal)
				return;
			
			Rectangle bounds = new Rectangle(0, 0, this.Width, this.Height);
			if(m_ButtonState == ButtonState.TrackingInside)
			{
				if( !bounds.Contains(e.X, e.Y) )
					OwnerDrawButton_MouseLeave(sender, e);
			}
			else if(m_ButtonState == ButtonState.TrackingOutside)
			{
				if( bounds.Contains(e.X, e.Y) )
					OwnerDrawButton_MouseEnter(sender, e);
			}
		}

		private void OwnerDrawButton_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			if(m_ButtonState != ButtonState.Normal)
			{
				m_ButtonState = ButtonState.Normal;
				Invalidate();
			}
		}

		private void OwnerDrawButton_Resize(object sender, System.EventArgs e)
		{
			Invalidate();
		}
		#endregion Events
	}
}
