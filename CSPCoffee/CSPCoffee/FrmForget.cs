using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Mail;
using System.Web.Security;
using System.Windows.Forms;

namespace CSPCoffee
{
    public partial class FrmForget : Form
    {
        public FrmForget()
        {
            InitializeComponent();
            this.labErr.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if(string.IsNullOrWhiteSpace(this.txtEmail.Text) || this.txtEmail.Text.Contains('@')==false)
                {
                    this.labErr.Visible = true;
                }
                else
                {
                    this.labErr.Visible = false;
                    DialogResult dr = MessageBox.Show("  已成功寄出\n請至信箱查收", "忘記密碼",
                                          MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    if (dr == DialogResult.OK)
                    {
                        this.Close();
                    }
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
