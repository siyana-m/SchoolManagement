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
    public partial class FormEditStudent : Form
    {
        private int fNumber;
        private int specialtyId;

        public FormEditStudent()
        {
            InitializeComponent();
            numericUpDown1.Minimum = 0; 
            numericUpDown1.Maximum = 99999999;
        }
        public void Init(int fNumber, int specialtyId, string fName, string mName, string lName, string address, string phone, string eMail)
        {
            this.fNumber = fNumber;
            this.specialtyId = specialtyId;

            LoadSpecialties();

            if (fNumber >= numericUpDown1.Minimum && fNumber <= numericUpDown1.Maximum)
            {
                numericUpDown1.Value = fNumber;
            }
            this.comboBox1.SelectedValue = specialtyId;
            this.textBox1.Text = fName;
            this.textBox2.Text = mName;
            this.textBox3.Text = lName;
            this.textBox4.Text = address;
            this.textBox5.Text = phone; 
            this.textBox6.Text = eMail;

            numericUpDown1.Enabled = false;
            comboBox1.Enabled = false;        
        }


        private void FormEditStudent_Load(object sender, EventArgs e)
        {
            
        }

        private void LoadSpecialties()
        {
            Configurator configurator = new Configurator();
            DataTable specialties = configurator.LoadSpecialties();

            if (specialties != null && specialties.Rows.Count > 0)
            {
                comboBox1.DataSource = specialties;
                comboBox1.DisplayMember = "name";
                comboBox1.ValueMember = "id";

            }
            else
            {
                MessageBox.Show("No specialties found. Please add specialties before editing students.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Configurator configurator = new Configurator();
            if (comboBox1.SelectedItem != null && comboBox1.SelectedValue != null)
            {
                if (int.TryParse(comboBox1.SelectedValue.ToString(), out int selectedSpecialtyId))
                {
                    configurator.UpdateStudent(this.fNumber, (int)this.numericUpDown1.Value, selectedSpecialtyId, this.textBox1.Text, this.textBox2.Text, this.textBox3.Text, this.textBox4.Text, this.textBox5.Text, this.textBox6.Text); 
                }
            }

            MessageBox.Show("Student updated successfully!"); 

            FormViewStudents formViewStudents = Application.OpenForms["FormViewStudents"] as FormViewStudents;
            if (formViewStudents != null)
            {
                formViewStudents.RefreshData();
            }

            this.Close();
        }
    }
}
