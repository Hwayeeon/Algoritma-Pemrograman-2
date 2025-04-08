using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Linq;

namespace Session6
{
    public partial class frmScore: Form
    {
        public frmScore()
        {
            InitializeComponent();
        }

        string fileName = "TxtScore.txt";

        private void clearForm()
        {
            lblAverage.Text = String.Empty;
            lstScore.Items.Clear();
        }

        private bool FileExists(String fileName)
        {
            if (!File.Exists(fileName))
            {
                btnCreate.Enabled = true;
                btnAdd.Enabled = false;
                btnShowScore.Enabled = false;
                txtScore.Enabled = false;
                return false;
            }
            else
            {
                btnCreate.Enabled = false;
                btnAdd.Enabled = true;
                btnShowScore.Enabled = true;
                txtScore.Enabled = true;
                return true;
            }
        }

        private void printData(String fileName)
        {
            try
            {
                string score;
                StreamReader inputFile;
                inputFile = File.OpenText(fileName);
                while (!inputFile.EndOfStream)
                {
                    score = inputFile.ReadLine();
                    lstScore.Items.Add(score);
                }
                inputFile.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmScore_Load(object sender, EventArgs e)
        {
            clearForm();
            FileExists(fileName);
            printData(fileName);
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                StreamWriter outputFile;
                outputFile = File.CreateText(fileName);
                outputFile.Close();
                MessageBox.Show("Create file success");
                FileExists(fileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtScore.Text))
            {
                int score = Int32.Parse(txtScore.Text);
                if (score >= 0 && score < 100)
                {
                    try
                    {
                        StreamWriter outputFile;
                        outputFile = File.AppendText(fileName);
                        outputFile.WriteLine(txtScore.Text);
                        lstScore.Items.Add(txtScore.Text);
                        outputFile.Close();
                        MessageBox.Show("The score was written");
                        txtScore.Clear();
                        txtScore.Focus();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please fill the score");
            }
        }

        private void btnShowScore_Click(object sender, EventArgs e)
        {
            try
            {
                // string score;
                int total = 0; 
                // StreamReader inputFile;
                // inputFile = File.OpenText(fileName);
                // lstScore.Items.Clear();
                // while (!inputFile.EndOfStream)
                // {
                //     score = inputFile.ReadLine();
                //     // lstScore.Items.Add(score);
                //     total = total + Convert.ToInt32(score);
                // }

                // inputFile.Close();
                if (lstScore.Items.Count < 0)
                {
                    for (int i = 0; i < lstScore.Items.Count; i++)
                    {
                        total = total + Convert.ToInt32(lstScore.Items[i]);
                    }

                    total = total / lstScore.Items.Count;
                    lstScore.Text = total.ToString();
                    lblAverage.Text = total.ToString();
                    // MessageBox.Show("Reading File Success");
                }
                else
                {
                    MessageBox.Show("Empty Data, Please add score first");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtScore_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
