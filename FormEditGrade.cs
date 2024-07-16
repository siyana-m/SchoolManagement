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
    public partial class FormEditGrade : Form
    {
        private int fNumber;
        private int subjectId;

        public FormEditGrade()
        {
            InitializeComponent();
            numericUpDown1.Minimum = 0;
            numericUpDown1.Maximum = 99999999;
        }

        public void Init(int fNumber, int subjectId, int finalGrade)
        {
            this.fNumber = fNumber;
            this.subjectId = subjectId;

            if (fNumber >= numericUpDown1.Minimum && fNumber <= numericUpDown1.Maximum)
            {
                numericUpDown1.Value = finalGrade;
            }

            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList; 

            comboBox1.Enabled = false;
            comboBox2.Enabled = false;
        }

        private void FormEditGrade_Load(object sender, EventArgs e)
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
            configurator.UpdateGrade(this.fNumber, this.subjectId, (int)numericUpDown1.Value);

            MessageBox.Show("Grade updated successfully!");
            this.Close();
        }
    }
}   
