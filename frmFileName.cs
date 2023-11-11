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
    public partial class frmFileName : Form
    {
        public frmFileName()
        {
            InitializeComponent();
        }
        public static string setFileName;


        //6. Click the okay button
        private void btnOkay_Click(object sender, EventArgs e)
        {

            setFileName = txtFileName.Text + ".txt";
            //Close();
            MessageBox.Show(setFileName);
        }
    }
}


//"C:\Users\dapit\Downloads