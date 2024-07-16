using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectWFA
{
    public partial class FormViewGrades : Form
    {
        public FormViewGrades()
        {
            InitializeComponent();
        }

        private void FormViewGrades_Load(object sender, EventArgs e)
        {
            LoadGrades();
        }
        private void LoadGrades()
        {
            Configurator configurator = new Configurator();

            DataTable grades = configurator.LoadGrades();

            if (grades != null && grades.Rows.Count > 0)
            {
                dataGridView1.DataSource = grades;
                dataGridView1.Refresh();
            }
            else
            {
                MessageBox.Show("No grades found.");
            }
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                int fNumber = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["FNumber"].Value);
                int subjectId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["SubjectId"].Value);
                int finalGrade = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["FinalGrade"].Value);

                FormEditGrade formEditGrade = new FormEditGrade();
                formEditGrade.Init(fNumber, subjectId, finalGrade);
                formEditGrade.ShowDialog();
                LoadGrades();
            }
        }
    }
}
