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
    public partial class FormSubject : Form
    {
        public FormSubject()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Configurator configurator = new Configurator();
            configurator.SaveSubject((int)this.numericUpDown1.Value,
           this.textBox1.Text);
            MessageBox.Show("Subject created successfully!");
            this.Close();
        }
    }
}
