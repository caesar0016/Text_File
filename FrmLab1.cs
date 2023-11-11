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
    public partial class FrmLab1 : Form
    {
        public FrmLab1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {   
            //Step 3 instantiate and declare string
            //a. Declare instance frmFIleName
            frmFileName f1 = new frmFileName();
            f1.ShowDialog();

            //b Get the value to getInput
            string getInput = txtInput.Text;

            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, frmFileName.setFileName)))
            {
                outputFile.WriteLine(getInput);
                Console.WriteLine(getInput);
                
            }
        }

        private void FrmLab1_Load(object sender, EventArgs e)
        {

        }
    }
}
