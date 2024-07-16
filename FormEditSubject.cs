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
    public partial class FormEditSubject : Form
    {
        private int id;

        public FormEditSubject()
        {
            InitializeComponent();
        }

        private void FormEditSubject_Load(object sender, EventArgs e)
        {

        }

        public void Init(int id, string name)
        {
            this.id = id;
            this.numericUpDown1.Value = id;
            this.textBox1.Text = name;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Configurator configurator = new Configurator();
            configurator.UpdateSubject(this.id, (int)this.numericUpDown1.Value,
           this.textBox1.Text);
            MessageBox.Show("Subject updated successfully!");
            this.Close();
        }

    }
}
