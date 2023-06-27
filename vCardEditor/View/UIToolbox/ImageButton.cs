using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;

namespace UIToolbox
{
	/// <summary>
	/// Summary description for ImageButton.
	/// </summary>
	public class ImageButton : OwnerDrawButton
	{
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		#region Internal variables
		private Image		m_NormalImage = null;
		private Image		m_PressedImage = null;
		#endregion Internal variables

		public ImageButton()
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
			// ImageButton
			// 
			this.Paint += new System.Windows.Forms.PaintEventHandler(this.ImageButton_Paint);
		}
		#endregion

		#region Events
		private void ImageButton_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
		{
			Graphics g = e.Graphics;

			if(m_ButtonState == ButtonState.TrackingInside)
			{
				if(m_PressedImage != null)
				{
					g.DrawImage(m_PressedImage, 0, 0, m_PressedImage.Width, m_PressedImage.Height);
				}
			}
			else
			{
				if(m_NormalImage != null)
				{
					g.DrawImage(m_NormalImage, 0, 0, m_NormalImage.Width, m_NormalImage.Height);
				}
			}
		}
		#endregion Events

		#region Accessors
		public Image NormalImage
		{
			get
			{
				return m_NormalImage;
			}
			set
			{
				m_NormalImage = value;
				Invalidate();
			}
		}

		public Image PressedImage
		{
			get
			{
				return m_PressedImage;
			}
			set
			{
				m_PressedImage = value;
				Invalidate();
			}
		}
		#endregion Accessors
	}
}
