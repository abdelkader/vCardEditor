using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace UIToolbox
{
	/// <summary>
	/// Summary description for CollapsibleGroupBox.
	/// </summary>
	public class CollapsibleGroupBox : System.Windows.Forms.UserControl
	{
		public const int kCollapsedHeight = 20;
		#region Members
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		private CollapseBox						m_CollapseBox;
		private ImageButton						m_TrashIcon;
		public event CollapseBoxClickedEventHandler	CollapseBoxClickedEvent;
		public event TrashCanClickedEventHandler	TrashCanClickedEvent;

		private string							m_Caption;
		//private bool							m_bContainsTrashCan;
		//private System.Windows.Forms.GroupBox	m_GroupBox;
		private Size							m_FullSize;
		private bool							m_bResizingFromCollapse = false;
		#endregion Members


		public CollapsibleGroupBox()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(CollapsibleGroupBox));
			this.m_CollapseBox = new UIToolbox.CollapseBox();
			this.m_TrashIcon = new UIToolbox.ImageButton();
			this.SuspendLayout();
			// 
			// m_CollapseBox
			// 
			this.m_CollapseBox.IsPlus = false;
			this.m_CollapseBox.Location = new System.Drawing.Point(12, 1);
			this.m_CollapseBox.Name = "m_CollapseBox";
			this.m_CollapseBox.Size = new System.Drawing.Size(11, 11);
			this.m_CollapseBox.TabIndex = 1;
			this.m_CollapseBox.Click += new System.EventHandler(this.CollapseBox_Click);
			this.m_CollapseBox.DoubleClick += new System.EventHandler(this.CollapseBox_DoubleClick);
			// 
			// m_TrashIcon
			// 
			this.m_TrashIcon.Location = new System.Drawing.Point(88, 0);
			this.m_TrashIcon.Name = "m_TrashIcon";
			this.m_TrashIcon.NormalImage = ((System.Drawing.Image)(resources.GetObject("m_TrashIcon.NormalImage")));
			this.m_TrashIcon.PressedImage = ((System.Drawing.Image)(resources.GetObject("m_TrashIcon.PressedImage")));
			this.m_TrashIcon.Size = new System.Drawing.Size(16, 16);
			this.m_TrashIcon.TabIndex = 2;
			this.m_TrashIcon.TabStop = false;
			this.m_TrashIcon.Click += new System.EventHandler(this.TrashIcon_Click);
			// 
			// CollapsibleGroupBox
			// 
			this.Controls.Add(this.m_TrashIcon);
			this.Controls.Add(this.m_CollapseBox);
			this.Name = "CollapsibleGroupBox";
			this.Resize += new System.EventHandler(this.CollapsibleGroupBox_Resize);
			this.Load += new System.EventHandler(this.CollapsibleGroupBox_Load);
			this.Paint += new System.Windows.Forms.PaintEventHandler(this.CollapsibleGroupBox_Paint);
			this.ResumeLayout(false);

		}
		#endregion

		#region Events
		private void CollapsibleGroupBox_Load(object sender, System.EventArgs e)
		{
			SetGroupBoxCaption();
		}

		private void CollapsibleGroupBox_Resize(object sender, System.EventArgs e)
		{
			if(m_bResizingFromCollapse != true)
			{
				m_FullSize = this.Size;
			}

			Invalidate();
		}

		private void CollapsibleGroupBox_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
		{
			// UG! I originall added a GroupBox control but ran into problems...
			// Panes derived from CollapsibleGroupBox would "chew up" controls
			// added to them, so I had to get rid of the GroupBox and draw a fake
			// group box myself
			Graphics g = e.Graphics;
			Rectangle theRec = new Rectangle();
			theRec = this.ClientRectangle;

			//Color theEdgeGrayColor = Color.FromArgb(170, 170, 156);
			//Pen thePen = new Pen(theEdgeGrayColor);
			Pen thePen = SystemPens.ControlDark;


			int theTextSize = (int)g.MeasureString(m_Caption, this.Font).Width;
			if(theTextSize < 1)
				theTextSize = 1;

			int theCaptionPosition = (theRec.X + 8) + 2 + m_CollapseBox.Width + 2;
			int theEndPosition = theCaptionPosition + theTextSize + 1;
			if(m_TrashIcon.Visible)
				theEndPosition += (m_TrashIcon.Width + 2);


			g.DrawLine(thePen, theRec.X + 8, theRec.Y + 5,
				theRec.X, theRec.Y + 5);
		
			g.DrawLine(thePen, theRec.X, theRec.Y + 5,
				theRec.X, theRec.Bottom - 2);

			g.DrawLine(thePen, theRec.X, theRec.Bottom - 2,
				theRec.Right - 1, theRec.Bottom - 2);

			g.DrawLine(thePen, theRec.Right - 2, theRec.Bottom - 2,
				theRec.Right - 2, theRec.Y + 5);

			g.DrawLine(thePen, theRec.Right - 2, theRec.Y + 5,
				theRec.X + theEndPosition, theRec.Y + 5);

		

			g.DrawLine(Pens.White, theRec.X + 8, theRec.Y + 6,
				theRec.X + 1, theRec.Y + 6);
		
			g.DrawLine(Pens.White, theRec.X + 1, theRec.Y + 6,
				theRec.X + 1, theRec.Bottom - 3);

			g.DrawLine(Pens.White, theRec.X, theRec.Bottom - 1,
				theRec.Right, theRec.Bottom - 1);

			g.DrawLine(Pens.White, theRec.Right - 1, theRec.Bottom - 1,
				theRec.Right - 1, theRec.Y + 5);

			g.DrawLine(Pens.White, theRec.Right - 3, theRec.Y + 6,
				theRec.X + theEndPosition, theRec.Y + 6);
		
			StringFormat sf = new StringFormat();
			SolidBrush drawBrush = new SolidBrush(Color.Black);

			g.DrawString(m_Caption, this.Font, drawBrush, theCaptionPosition, 0);
		}

		public void CollapseBox_Click(object sender, System.EventArgs e)
		{
			// at this point the control's value has changed but hasn't been
			// redrawn on the screen
			this.IsCollapsed = m_CollapseBox.IsPlus;
			
			if(CollapseBoxClickedEvent != null)
			{
				CollapseBoxClickedEvent(this);
			}
		}
		
		private void CollapseBox_DoubleClick(object sender, System.EventArgs e)
		{
			// fast clicking registers as double-clicking, so map a double-click
			// event into a single click.
			CollapseBox_Click(sender, e);
		}

		private void TrashIcon_Click(object sender, System.EventArgs e)
		{
			if(TrashCanClickedEvent != null)
			{
				TrashCanClickedEvent(this);
			}
		}
		#endregion events
		
		#region Accessors
		[DefaultValue("")]
		public string Caption
		{
			get
			{
				return m_Caption;
			}
			set
			{
				m_Caption = value;
				SetGroupBoxCaption();
				Invalidate();
			}
		}

		[DefaultValue(true)]
		public bool ContainsTrashCan
		{
			get
			{
				return m_TrashIcon.Visible;
			}
			set
			{
				//m_bContainsTrashCan = value;
				m_TrashIcon.Visible = value;
				SetGroupBoxCaption();
				Invalidate();
			}
		}

		[Browsable(false)]
		public int FullHeight
		{
			get
			{
				return m_FullSize.Height;
			}
		}

		[DefaultValue(false), Browsable(false)]
		public bool IsCollapsed
		{
			get
			{
				#if DEBUG
				if(m_CollapseBox.IsPlus)
				{
					Debug.Assert(this.Height == kCollapsedHeight);
				}
				else
				{
					Debug.Assert(this.Height > kCollapsedHeight);
				}
				#endif
				return m_CollapseBox.IsPlus;
			}
			set
			{
				if(m_CollapseBox.IsPlus != value)
				{
					m_CollapseBox.IsPlus = value;
				}

				if(m_CollapseBox.IsPlus != true)
				{
					//Expand();
					this.Size = m_FullSize;
				}
				else
				{
					//Collapse();
					m_bResizingFromCollapse = true;
					Size smallSize = m_FullSize;
					smallSize.Height = kCollapsedHeight;
					this.Size = smallSize;
					m_bResizingFromCollapse = false;
				}

				Invalidate();
			}
		}
		#endregion accessors

		#region Methods
		private void SetGroupBoxCaption()
		{
			RepositionTrashCan();
		}

		private void RepositionTrashCan()
		{
			if(m_TrashIcon.Visible)
			{
				// Since the trash icon's location is a function of the caption's width,
				// we also need to reposition the trash icon
				// first, find the width of the string
				Graphics g = CreateGraphics();
				SizeF theTextSize = new SizeF();
				theTextSize	= g.MeasureString(m_Caption, this.Font);
				// Hmm... MeasureString() doesn't seem to be returning the
				// correct width.  Close... but not exact

				// 11 is the number of pixels from the beginning of the group box
				// to the beginning of text of the group box's caption
				//m_TrashIcon.Left = m_GroupBox.Location.X + 29 + (int)theTextSize.Width - 4;
				m_TrashIcon.Left = this.Location.X + 29 + (int)theTextSize.Width - 4;
				// -4 is a fudge factor.  Hey, what can I say...
			} 
		}
		#endregion Methods


		public delegate void CollapseBoxClickedEventHandler(object sender);
		public delegate void TrashCanClickedEventHandler(object sender);
	}
}
