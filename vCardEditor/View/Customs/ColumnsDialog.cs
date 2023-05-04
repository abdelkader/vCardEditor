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
        public List<Columns> Columns { get; }

        public ColumnsDialog(List<Columns> columns)
        {
            InitializeComponent();
            _checkBoxes = Controls.OfType<CheckBox>().ToList();
            Columns = columns;

            foreach (var item in columns)
            {
                switch (item)
                {
                    case Model.Columns.FamilyName:
                        cbFamilyName.Checked = true;
                        break;
                    case Model.Columns.Cellular:
                        cbCellular.Checked = true;
                        break;
                    
                }
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Columns.Clear();

            var total = _checkBoxes
                 .Where(checkBox => checkBox.Checked);

            foreach (var item in total)
            {
                var enumType = (Columns)Enum.Parse(typeof(Columns), item.Text, true);
                Columns.Add(enumType);
            }
        }
    }
}
