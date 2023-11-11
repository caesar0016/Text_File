using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            autoFill();
        }


        void autoFill() {

            txtStudentNo.Text = 200002686.ToString();
            txtLastName.Text = "Mondragon";
            txtFirstName.Text = "Xiao";
            txtMiddleInitial.Text = "G";
            txtAge.Text = 26.ToString();
            cmbGender.Text = "Male";
            dtPickerBday.Value = DateTime.Today;
            txtContactNo.Text = 099999999123.ToString();
            cmbProgram.Text = "Bsit";
        
        
        
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Registered Successfully");
        }
    }
}
