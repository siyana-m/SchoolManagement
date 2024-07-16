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
    public partial class FormViewSubjects : Form
    {
        public FormViewSubjects()
        {
            InitializeComponent();
        }

        private void FormViewSubjects_Load(object sender, EventArgs e)
        {
            Configurator configurator = new Configurator();
            DataTable dTable = configurator.LoadSubjects();
            this.dataGridView1.DataSource = dTable;
            this.dataGridView1.Refresh();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (this.dataGridView1.SelectedRows.Count == 1)
            {
                int id =
               Convert.ToInt32(this.dataGridView1.SelectedRows[0].Cells[0].Value);
                string name =
               this.dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                FormEditSubject formEditSubject = new FormEditSubject();
                formEditSubject.Init(id, name);
                formEditSubject.ShowDialog();
            }
        }
    }
}
