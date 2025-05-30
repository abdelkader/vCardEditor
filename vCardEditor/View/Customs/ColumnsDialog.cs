using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using vCardEditor.Model;

namespace vCardEditor.View.Customs
{
    public partial class ColumnsDialog : Form
    {
        private readonly List<CheckBox> _checkBoxes;
        public List<Column> Columns { get; }

        public ColumnsDialog(List<Column> columns)
        {
            InitializeComponent();
            _checkBoxes = Controls.OfType<CheckBox>().ToList();
            Columns = columns;

            foreach (Column item in columns)
            {
                switch (item)
                {
                    case Model.Column.FamilyName:
                        cbFamilyName.Checked = true;
                        break;
                    case Model.Column.Cellular:
                        cbCellular.Checked = true;
                        break;
                    
                }
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Columns.Clear();
            foreach (CheckBox item in _checkBoxes.Where(checkBox => checkBox.Checked))
            {
                Column enumType = (Column)Enum.Parse(typeof(Column), item.Text, true);
                Columns.Add(enumType);
            }
        }
    }
}
