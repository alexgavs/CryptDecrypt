using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security;
using System.Diagnostics;


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        DataEncryptor DataEnc = new DataEncryptor();

        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            // string filename = "C:\\Windows\\System32\\calc.exe";
            // System.Diagnostics.Process.Start(filename);
            string user = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            this.Text = user;
   //         string message = "CALC IS RUNNING for user " + user;
//             MessageBox.Show(message, "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if ((txtEncode.TextLength > 0) || (txtKey.TextLength > 0))
            {
                txtDecode.Text = XORCrypt.Encode(txtEncode.Text, txtKey.Text);
                txtDecode.Update();
            }
            else
                MessageBox.Show("Specify encode and key string");
            txtEncode.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if ((txtDecode.TextLength > 0) || (txtKey.TextLength > 0))
            {
                txtEncode.Text = XORCrypt.Decode(txtDecode.Text, txtKey.Text);
                txtEncode.Update();

            }
            else
                MessageBox.Show("Specify encode and key string");
            txtDecode.Focus();

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnEnc64_Click(object sender, EventArgs e)
        {
              txtDec64.Text= DataEnc.EncryptString(txtEnc64.Text).ToString();
              txtDec64.Update();
              txtDec64.Focus();

        }

        private void btnDec64_Click(object sender, EventArgs e)
        {
            txtEnc64.Text = DataEnc.DecryptString(txtDec64.Text).ToString();
            txtEnc64.Update();
            txtEnc64.Focus();

        }
    }
}


