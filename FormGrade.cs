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
    public partial class FormGrade : Form
    {
        public FormGrade()
        {
            InitializeComponent();
        }

        private void FormGrade_Load(object sender, EventArgs e)
        {
            Configurator configurator = new Configurator();
            DataTable dTableStudents = configurator.LoadStudents();
            this.comboBox1.DataSource = dTableStudents;
            this.comboBox1.ValueMember = "fnumber";
            this.comboBox1.DisplayMember = "name";
            DataTable dTableSubjects = configurator.LoadSubjects();
            this.comboBox2.DataSource = dTableSubjects;
            this.comboBox2.ValueMember = "id";
            this.comboBox2.DisplayMember = "name";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Configurator configurator = new Configurator();
            configurator.SaveGrade(Convert.ToInt32(this.comboBox1.SelectedValue),
           Convert.ToInt32(this.comboBox2.SelectedValue),
           (int)this.numericUpDown1.Value);
            MessageBox.Show("Grade created successfully!");
            this.Close();
        }
    }
}
