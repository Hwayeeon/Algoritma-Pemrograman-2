using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Session6
{
    public partial class frmWriteToFile: Form
    {
        public frmWriteToFile()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            try
            {
                StreamWriter outputFile;
                outputFile = File.CreateText("Listname.txt");
                outputFile.WriteLine(txtName.Text);
                outputFile.Close();
                MessageBox.Show("The name was written");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAppend_Click(object sender, EventArgs e)
        {
            try
            {
                StreamWriter outputFile;
                outputFile = File.AppendText("Listname.txt");
                outputFile.WriteLine(txtName.Text);
                outputFile.Close();
                MessageBox.Show("The name was written");
                txtName.Clear();
                txtName.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            try
            {
                string name;
                StreamReader inputFile;
                inputFile = File.OpenText("Listname.txt");
                lstName.Items.Clear();
                while (!inputFile.EndOfStream)
                {
                    name = inputFile.ReadLine();
                    lstName.Items.Add(name);
                }

                inputFile.Close();
                MessageBox.Show("Reading File Success");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
