using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Text_File
{
    public partial class FrmRegistration : Form
    {
        public FrmRegistration()
        {
            InitializeComponent();
        }

        private void btnAuto_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try {

            string[] registeredInfo = {"Student No: " + txtStudentNo.Text, "Full Name: " + txtLastName.Text + " " + txtFirstName.Text + " " +  txtMiddleInitial.Text, "Age: " +
            txtAge.Text, "Gender: " + cmbGender.Text, "Birthday: " + dtPickerBday.Text, "Contact No: " + txtContactNo.Text, "Program: " + cmbProgram.SelectedItem};

            string docPath2 = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            StreamWriter outputFile = new StreamWriter(Path.Combine(docPath2, frmFileName.setFileName));

            outputFile.WriteLine(txtStudentNo.Text);

            foreach (string info in registeredInfo) {
                outputFile.WriteLine(info);
            }

            outputFile.Close();

            }
            catch (Exception ex) {

                Console.WriteLine("Error: " + ex.Message);

            }
            MessageBox.Show("Registered Successfully");

            clear();
        }

        void clear() {

            txtStudentNo.Text = "";
            txtLastName.Text = "";
            txtFirstName.Text = "";
            txtMiddleInitial.Text = "";
            txtAge.Text = "";
            cmbGender.Text = "";
            txtContactNo.Text = "";
            cmbProgram.Text = "";

        }
    }
}
