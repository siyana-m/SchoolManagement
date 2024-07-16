using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ProjectWFA
{
    public partial class FormViewStudents : Form
    {
        public FormViewStudents()
        {
            InitializeComponent();
        }

        private void FormViewStudents_Load(object sender, EventArgs e)
        {
            RefreshData();
            dataGridView1.CellFormatting += dataGridView1_CellFormatting;
        }

        public void RefreshData()
        {
            Configurator configurator = new Configurator();
            DataTable dTable = configurator.LoadStudents1();
            this.dataGridView1.DataSource = dTable;
            this.dataGridView1.Refresh();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (this.dataGridView1.SelectedRows.Count == 1)
            {
                int fNumber = Convert.ToInt32(this.dataGridView1.SelectedRows[0].Cells["FNumber"].Value);
                int specialtyId = Convert.ToInt32(this.dataGridView1.SelectedRows[0].Cells["SpecialtyId"].Value);
                string fName = this.dataGridView1.SelectedRows[0].Cells["FName"].Value.ToString();
                string mName = this.dataGridView1.SelectedRows[0].Cells["MName"].Value.ToString();
                string lName = this.dataGridView1.SelectedRows[0].Cells["LName"].Value.ToString();
                string address = this.dataGridView1.SelectedRows[0].Cells["Address"].Value.ToString();
                string phone = this.dataGridView1.SelectedRows[0].Cells["Phone"].Value.ToString();
                string eMail = this.dataGridView1.SelectedRows[0].Cells["Email"].Value.ToString();

                FormEditStudent formEditStudent = new FormEditStudent();
                formEditStudent.Init(fNumber, specialtyId, fName, mName, lName, address, phone, eMail);
                formEditStudent.ShowDialog();
            }
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Check if the current column is the Phone column
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Phone")
            {
                if (e.Value != null)
                {
                    string phone = e.Value.ToString();
                    e.Value = phone; // This will force DataGridView to use the string value
                    e.FormattingApplied = true;
                }
            }
        }
    }
}
