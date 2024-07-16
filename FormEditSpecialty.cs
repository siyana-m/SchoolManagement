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
    public partial class FormEditSpecialty : Form
    {
        private int id;
        public FormEditSpecialty()
        {
            InitializeComponent();
        }

        private void FormEditSpecialty_Load(object sender, EventArgs e)
        {

        }

        public void Init(int id, string name)
        {
            this.id = id;
            this.numericUpDown1.Value = id;
            this.textBox1.Text = name;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Configurator configurator = new Configurator();
            configurator.UpdateSpecialty(this.id, (int)this.numericUpDown1.Value,
           this.textBox1.Text);
            MessageBox.Show("Specialty updated successfully!");
            this.Close();
        }
    }
}
