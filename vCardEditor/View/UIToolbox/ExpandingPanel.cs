using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;

namespace UIToolbox
{
	/// <summary>
	/// Summary description for ExpandingPanel.
	/// </summary>
	public class ExpandingPanel : System.Windows.Forms.Panel
	{
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;
		ArrayList m_GroupArray = null;


		public const int kGap = 6;
		public ExpandingPanel()
		{
			// This call is required by the Windows.Forms Form Designer.
			InitializeComponent();

			m_GroupArray = new ArrayList();
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
			// ExpandingPanel
			// 
			this.Move += new System.EventHandler(this.ExpandingPanel_Move);
			this.Resize += new System.EventHandler(this.ExpandingPanel_Resize);
			this.SizeChanged += new System.EventHandler(this.ExpandingPanel_SizeChanged);
			this.Layout += new System.Windows.Forms.LayoutEventHandler(this.ExpandingPanel_Layout);

		}
		#endregion

	
		public void AddGroup(UIToolbox.CollapsibleGroupBox theGroupBox)
		{
			m_GroupArray.Add(theGroupBox);


			this.SuspendLayout();
			Size theSize = this.AutoScrollMinSize;
			theGroupBox.Location = new System.Drawing.Point(4, theSize.Height + 4);

			
			theSize.Height += (theGroupBox.Height + kGap);
			this.AutoScrollMinSize = theSize;
			theGroupBox.CollapseBoxClickedEvent += new CollapsibleGroupBox.CollapseBoxClickedEventHandler(this.CollapseBox_Click);
			theGroupBox.TrashCanClickedEvent += new CollapsibleGroupBox.TrashCanClickedEventHandler(this.TrashCan_Click);
			this.Controls.Add(theGroupBox);
			this.ResumeLayout(false);
		}

		private void ExpandingPanel_Layout(object sender, System.Windows.Forms.LayoutEventArgs e)
		{
		}

		private void ExpandingPanel_Move(object sender, System.EventArgs e)
		{
		}

		private void ExpandingPanel_Resize(object sender, System.EventArgs e)
		{
		}

		private void ExpandingPanel_SizeChanged(object sender, System.EventArgs e)
		{
		}
	
		private void CollapseBox_Click(object sender)
		{
			int nIndex;
			nIndex = m_GroupArray.IndexOf(sender);
			
			CollapsibleGroupBox theGroupBox;
			theGroupBox = (CollapsibleGroupBox)m_GroupArray[nIndex];
			
			int nDelta;
			if(theGroupBox.Height == CollapsibleGroupBox.kCollapsedHeight)
			{
				nDelta = -(theGroupBox.FullHeight - CollapsibleGroupBox.kCollapsedHeight);
			}
			else
			{
				nDelta = (theGroupBox.FullHeight - CollapsibleGroupBox.kCollapsedHeight);
			}

			for(int i=(nIndex + 1); i<m_GroupArray.Count; i++)
			{
				theGroupBox = (CollapsibleGroupBox)m_GroupArray[i];
				theGroupBox.Top += nDelta;
			}
			
			Size theSize = this.AutoScrollMinSize;
			theSize.Height += nDelta;
			this.AutoScrollMinSize = theSize;
		}

		private void TrashCan_Click(object sender)
		{
			int nIndex;
			nIndex = m_GroupArray.IndexOf(sender);
			
			CollapsibleGroupBox theGroupBox;
			theGroupBox = (CollapsibleGroupBox)m_GroupArray[nIndex];
			
			int nDelta;
			nDelta = theGroupBox.Height + kGap;

			m_GroupArray.RemoveAt(nIndex);
			theGroupBox.Dispose();
			theGroupBox = null;

			for(int i=nIndex; i<m_GroupArray.Count; i++)
			{
				theGroupBox = (CollapsibleGroupBox)m_GroupArray[i];
				theGroupBox.Top -= nDelta;
			}
			
			Size theSize = this.AutoScrollMinSize;
			theSize.Height -= nDelta;
			this.AutoScrollMinSize = theSize;
		}
	}
}



#region NOT USED
class IndexerArray
{
	protected ArrayList data = new ArrayList();

	public object this[int idx]
	{
		get
		{
			if (idx > -1 && idx < data.Count)
			{
				return (data[idx]);
			}
			else
			{
				throw new InvalidOperationException("[IndexerArray.get_Item]Index out of range");
			}
		}
		set
		{
			if (idx > -1 && idx < data.Count)
			{
				data[idx] = value;
			}
			else if (idx == data.Count)
			{
				data.Add(value);
			}
			else
			{
				throw new InvalidOperationException("[IndexerArray.set_Item]Index out of range");
			}
		}
	}
}

#endregion NOT USED
