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
    public partial class FrmOpenFile : Form
    {
        public FrmOpenFile()
        {
            InitializeComponent();
           
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            DisplayToList();
        }

        void DisplayToList()
        {
            openFileDialog1.InitialDirectory = @"C:\Users\HomePC\Documents\Event-File";
            openFileDialog1.Title = "Browse Text Files";
            openFileDialog1.DefaultExt = "txt";
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";O
            openFileDialog1.ShowDialog();

            string path = openFileDialog1.FileName;

            if (File.Exists(path))
            {
                using (StreamReader streamReader = File.OpenText(path))
                {
                    string _getText = "";
                    while ((_getText = streamReader.ReadLine()) != null)
                    {
                        Console.WriteLine(_getText);
                        
                    }
                }
            }
            else
            {
                MessageBox.Show("File Doesn't Exist");
            }
        }


        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lvShowText_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
