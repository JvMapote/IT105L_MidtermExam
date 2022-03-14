using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MAPOTE_JAYVEE_IT105L_C11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = 0;
            if (txtUserName.Text == "MANAGER" && txtPassword.Text == "123456")
            {
                Form2 form2 = new Form2();
                this.Hide();
                form2.ShowDialog();
                this.Close();
            }
            else
            {

                if (x >= 3)
                {
                    Application.Exit();
                }
                else
                {
                    MessageBox.Show("Error");
                    x++;
                }
            }
        }

    }
}