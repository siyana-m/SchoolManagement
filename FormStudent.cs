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
    public partial class FormStudent : Form
    {
        public FormStudent()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void FormStudent_Load(object sender, EventArgs e)
        {
            Configurator configurator = new Configurator();
            DataTable dTable = configurator.LoadSpecialties();
            this.comboBox1.DataSource = dTable;
            this.comboBox1.ValueMember = "id";
            this.comboBox1.DisplayMember = "name";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Configurator configurator = new Configurator();
            configurator.SaveStudent((int)this.numericUpDown1.Value,
           Convert.ToInt32(this.comboBox1.SelectedValue), this.textBox1.Text,
           this.textBox2.Text, this.textBox3.Text, this.textBox4.Text,
           this.textBox5.Text, this.textBox6.Text);
            MessageBox.Show("Student created successfully!");
            this.Close();
        }
    }
}
