using CSPCoffee.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web.Security;
using System.Windows.Forms;

namespace CSPCoffee
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
            VisibleFalse();
            this.tabMem.SelectedIndex = 0;
            this.tabMem.Size =new Size(505, 487);
            MonCalSet();
            txtdefalt();
        }

        CoffeeEntities1 db = new CoffeeEntities1();
        bool eyeIsClick = false;
        bool birthHasClick = false;
        private Form1 f1;
        

     void VisibleFalse()
        {
            this.labLogErr.Visible = false;
            this.labPhoneErr.Visible = false;
            this.labEmailErr.Visible = false;
            this.labPWStren.Visible = false;
            this.labPWAgain.Visible = false;
            this.labNameErr.Visible = false;
            this.labAdressErr.Visible = false;
            this.labBirthErr.Visible = false;
            this.splitContainer2.Panel1Collapsed = true;
        }
        
        void MonCalSet()
        {
            this.monthCalendar1.MinDate = DateTime.Parse($"{DateTime.Now.Year-100}/{DateTime.Now.Month}/{DateTime.Now.Day}");
            this.monthCalendar1.MaxDate = DateTime.Parse($"{DateTime.Now.Year-18}/{DateTime.Now.Month}/{DateTime.Now.Day}");
        }

        #region tabpage登入
        private void txtAccount_Enter(object sender, EventArgs e)
        {
            if(this.txtAccount.Text == "請輸入手機號碼")
            {
                this.txtAccount.Text = "";
                this.txtAccount.ForeColor = Color.Black;
            }
        }

        private void txtAccount_Leave(object sender, EventArgs e)
        {
            if(this.txtAccount.Text=="")
            {
                this.txtAccount.Text = "請輸入手機號碼";
                this.txtAccount.ForeColor = Color.FromArgb(192, 192, 192);
            }
        }

        private void txtPW_Enter(object sender, EventArgs e)
        {
            if (this.txtPW.Text == "請輸入密碼")
            {
                this.txtPW.Text = "";
                this.txtPW.UseSystemPasswordChar = true;
                this.txtPW.ForeColor = Color.Black;
            }
        }

        private void txtPW_Leave(object sender, EventArgs e)
        {
            if (this.txtPW.Text == "")
            {
                this.txtPW.Text = "請輸入密碼";
                this.txtPW.ForeColor = Color.FromArgb(192, 192, 192);
                this.txtPW.UseSystemPasswordChar = false;
            }
        }


        private void pboxEye_Click(object sender, EventArgs e)
        {

            if (this.txtPW.Text != "請輸入密碼" && txtPW.Text != "")
            {
                eyeIsClick = true;
                this.pboxEye.Image = Resources.eyeopen;

                this.txtPW.UseSystemPasswordChar = false;
                this.timerEye.Enabled = true;
            }
            if(txtPW.Text == "請輸入密碼" || txtPW.Text == "")
            {
                eyeIsClick = false;
            }
        }

        private void timerEye_Tick(object sender, EventArgs e)
        {
            if (eyeIsClick == true)
            {
                this.txtPW.UseSystemPasswordChar = true;
                this.pboxEye.Image = Resources.eyeclose;
                this.timerEye.Enabled = false;
            }
            else
            {
                this.timerEye.Enabled = false;
            }

        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (Regex.IsMatch(this.txtAccount.Text, @"^(?=.*\d).{0,10}$") && Regex.IsMatch(this.txtPW.Text, "^[a-zA-Z0-9]*$") )
            {
                try
                {
                    string PW = PWHash(this.txtPW);
                    //查詢是否是會員
                    var qLogin = db.MemLogin(this.txtAccount.Text, PW);
                    //查詢該會員ID
                    var IDnum = (from m in this.db.Members
                                 where m.MemberPhone == this.txtAccount.Text && m.MemberPassword == PW
                                 select m.MemberID).ToList()[0];

                    if (qLogin.Count() == 1)
                    {
                        MessageBox.Show("登入成功");
                        this.labLogErr.Visible = false;
                        this.f1 = (Form1)Application.OpenForms["Form1"];
                        f1.memberID = IDnum;
                        f1.btnMem.BackgroundImage = Resources._0175;
                        f1.disBanner();
                        f1.CreatBanner();
                        f1.flowLayoutPanel1.Controls.Clear();
                        f1.treeView1.CollapseAll();
                        //coupon
                        takeCsharpcoupon();
                        this.Close();
                    }
                    else
                    {
                        this.labLogErr.Visible = true;
                        return;
                    }

                }
                catch (System.ArgumentOutOfRangeException)
                {
                    this.labLogErr.Visible = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                this.labLogErr.Visible = true;
            }
        }

        private void takeCsharpcoupon()
        {
            var q = this.db.CouponDetails.Any(x => x.MemberID == f1.memberID && x.CouponID == 1);
            if (!q)
            {
                CouponDetail coupon = new CouponDetail
                {
                    MemberID = f1.memberID,
                    CouponID = 1
                };
                this.db.CouponDetails.Add(coupon);
                db.SaveChanges();

                MessageBox.Show("感謝您的支持，已發周年慶送優惠券給您");
            }
        }


        #endregion 登入


        #region 註冊
        #region 浮水印
        private void txtEmail_Enter(object sender, EventArgs e)
        {
            EnterTxt(this.txtEmail, "請輸入電子信箱");
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            LeaveTxt(this.txtEmail, "請輸入電子信箱");
        }

        void EnterTxt(TextBox textBox,string hint)
        {
            if ( textBox.Text == hint)
            {
                textBox.Text = "";
                textBox.ForeColor = Color.Black;
            }
        }
        void LeaveTxt(TextBox textBox, string hint)
        {
            if (textBox.Text == "")
            {
                 textBox.Text = hint;
                 textBox.ForeColor = Color.FromArgb(192, 192, 192);
            }
        }

        private void txtPhone_Enter(object sender, EventArgs e)
        {
            EnterTxt(this.txtPhone, "請輸入手機號碼");
        }

        private void txtPhone_Leave(object sender, EventArgs e)
        {
            LeaveTxt(this.txtPhone, "請輸入手機號碼");
        }

        private void txtPWStren_Enter(object sender, EventArgs e)
        {
            EnterTxt(this.txtPWStren, "請輸入密碼");
            this.txtPWStren.UseSystemPasswordChar = true;
        }

        private void txtPWStren_Leave(object sender, EventArgs e)
        {
            if (this.txtPWStren.Text == "")
            {
                this.txtPWStren.Text = "請輸入密碼";
                this.txtPWStren.ForeColor = Color.FromArgb(192, 192, 192);
                this.txtPWStren.UseSystemPasswordChar = false;
            }

        }

        private void txtPWAgain_Enter(object sender, EventArgs e)
        {
            EnterTxt(this.txtPWAgain, "請再次輸入密碼");
            this.txtPWAgain.UseSystemPasswordChar = true;
        }

        private void txtPWAgain_Leave(object sender, EventArgs e)
        {
            if (this.txtPWAgain.Text == "")
            {
                this.txtPWAgain.Text = "請再次輸入密碼";
                this.txtPWAgain.ForeColor = Color.FromArgb(192, 192, 192);
                this.txtPWAgain.UseSystemPasswordChar = false;
            }
        }

        private void txtName_Enter(object sender, EventArgs e)
        {
            EnterTxt(this.txtName, "請輸入姓名");
        }

        private void txtName_Leave(object sender, EventArgs e)
        {
            LeaveTxt(this.txtName, "請輸入姓名");
        }

        private void txtAdress_Enter(object sender, EventArgs e)
        {
            EnterTxt(this.txtAdress, "請輸入住址");
        }

        private void txtAdress_Leave(object sender, EventArgs e)
        {
            LeaveTxt(this.txtAdress, "請輸入住址");
        }


        #endregion 浮水印

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            this.splitContainer2.Panel1Collapsed = true;
            this.labBirth.ForeColor = Color.Black;
            this.labBirth.Text = this.monthCalendar1.SelectionStart.Date.ToShortDateString();
        }

        private void labBirth_Click(object sender, EventArgs e)
        {
            if (birthHasClick == true)
            {
                this.splitContainer2.Panel1Collapsed = false;
            }
            else
            {
                this.splitContainer2.Panel1Collapsed = true;
            }
            birthHasClick = !birthHasClick;
        }

        private void txtPWStren_TextChanged(object sender, EventArgs e)
        {
            if (this.txtPWStren.Text == "請輸入密碼" || this.txtPWStren.Text == "") return;
            else if (this.txtPWStren.Text.Length < 8)
            {
                this.labPWStren.Text = "密碼強度：弱";
                this.labPWStren.ForeColor = Color.Red;
                this.labPWStren.Visible = true;
            }
            else if (this.txtPWStren.Text.Length > 8 &&
                Regex.IsMatch(this.txtPWStren.Text, @"^(?=.*\d)(?=.*[a-z]).{8,16}$") &&
                this.txtPWStren.Text.Length < 16)
            {
                this.labPWStren.Text = "密碼強度：中";
                this.labPWStren.ForeColor = Color.Orange;
                this.labPWStren.Visible = true;
            }
            else if (this.txtPWStren.Text.Length > 16 &&
                Regex.IsMatch(this.txtPWStren.Text, @"^(?=.*\d)(?=.*[a-z])(?=.*[A-Z]).{17,50}$") &&
                this.txtPWStren.Text.Length < 50)
            {
                this.labPWStren.Text = "密碼強度：強";
                this.labPWStren.ForeColor = Color.YellowGreen;
            }
        }


        private void btnCreate_Click(object sender, EventArgs e)
        {
            uint phoneNum;

            if (string.IsNullOrWhiteSpace(this.txtPhone.Text) || this.txtPhone.Text == "請輸入手機號碼")
            {
                this.labPhoneErr.Text = "手機號碼不得為空";
                this.labPhoneErr.Visible = true;
            }
            else if (uint.TryParse(this.txtPhone.Text, out phoneNum) == false || this.txtPhone.Text.Length != 10 ||
                Regex.IsMatch(this.txtPhone.Text,@"^[0]{1}[9]{1}[0-9]{8}$")==false )
            {
                this.labPhoneErr.Text = "手機號碼格式有誤";
                this.labPhoneErr.Visible = true;
            }

            else if (string.IsNullOrWhiteSpace(this.txtEmail.Text) || this.txtEmail.Text == "請輸入電子信箱")
            {
                this.labEmailErr.Text = "電子信箱不得為空";
                this.labEmailErr.Visible = true;
            }
            else if (txtEmail.Text.Contains('@') == false)
            {
                this.labEmailErr.Text = "電子信箱格式有誤";
                this.labEmailErr.Visible = true;
            }

           else if (string.IsNullOrWhiteSpace(this.txtPWStren.Text) || this.txtPWStren.Text == "請輸入密碼")
            {
                this.labPWStren.Text = "密碼不得為空";
                this.labPWStren.Visible = true;
            }
            else if (Regex.IsMatch(this.txtPWStren.Text, "^[a-zA-Z0-9]*$") == false)
            {
                this.labPWStren.Text = "密碼不得包含英數以外字元";
                this.labPWStren.Visible = true;
            }


            else if (this.txtPWAgain.Text != this.txtPWStren.Text)
            {
                this.labPWAgain.Visible = true;
            }

            else if (string.IsNullOrWhiteSpace(this.txtName.Text) || this.txtName.Text == "請輸入姓名")
            {
                this.labNameErr.Visible = true;
            }

            else if (string.IsNullOrWhiteSpace(this.txtAdress.Text) || this.txtAdress.Text == "請輸入住址")
            {
                this.labAdressErr.Visible = true;
            }

            else if (string.IsNullOrWhiteSpace(this.labBirth.Text) || this.labBirth.Text == "請選擇生日")
            {
                this.labBirthErr.Text = "生日不得為空";
                this.labBirthErr.Visible = true;
            }
            else
            {
                VisibleFalse();
                try
                {
                    var q = from m in this.db.Members
                            where m.MemberPhone == this.txtPhone.Text
                            select new { m.MemberID, m.MemberPhone };
                    #region//加密
                    string PW = PWHash(this.txtPWStren);
                    #endregion 加密
                    //預設圖片↓
                    var pho = this.db.Members.Where(m => m.MemberID == 1).Select(m => m.MemberPhoto).ToList();
                    //預設圖片↑
                    if (q.Count() == 0)
                    {
                        int qSCID = this.db.Members.Select(id => id.MemberID).Max();  //int回傳最新的MemID
                        var qInsert = this.db.InsertMember(txtPhone.Text, qSCID + 1,
                            this.txtEmail.Text, PW, this.txtAdress.Text,
                            this.txtName.Text, this.monthCalendar1.SelectionStart, pho[0]);
                        db.SaveChanges();

                        ShoppingCar sc = new ShoppingCar { MemberID = qSCID + 1 };
                        this.db.ShoppingCars.Add(sc);
                        this.db.SaveChanges();

                        MessageBox.Show("註冊成功，請重新登入");
                        txtdefalt();
                        this.tabMem.SelectedIndex = 0;
                    }
                    else
                    {
                        MessageBox.Show("此帳號已註冊過");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }



        #endregion 註冊

        private void tabMem_Selecting(object sender, TabControlCancelEventArgs e)
        {
           if( this.tabMem.SelectedIndex == 0)
            {
                this.tabMem.Size = new Size(505, 487);
            }
           else
            {
                this.tabMem.Size = new Size(505, 812);
            }
        }

         string PWHash(TextBox textBox)
        {
            string PW = textBox.Text;
            PW = FormsAuthentication.HashPasswordForStoringInConfigFile(PW, "SHA1");
            return PW;
        }


        void txtdefalt()
        {
            this.txtAccount.Text = "請輸入手機號碼";
            this.txtAccount.ForeColor = Color.Silver;
            this.txtPW.Text = "請輸入密碼";
            this.txtPW.ForeColor = Color.Silver;
            this.txtPhone.Text = "請輸入手機號碼";
            this.txtPhone.ForeColor = Color.Silver;
            this.txtEmail.Text = "請輸入電子信箱";
            this.txtEmail.ForeColor = Color.Silver;
            this.txtPWStren.Text = "請輸入密碼";
            this.txtPWStren.UseSystemPasswordChar = false;
            this.txtPWStren.ForeColor = Color.Silver;
            this.txtPWAgain.Text = "請再次輸入密碼";
            this.txtPWAgain.UseSystemPasswordChar = false;
            this.txtPWAgain.ForeColor = Color.Silver;
            this.txtName.Text = "請輸入姓名";
            this.txtName.ForeColor = Color.Silver;
            this.txtAdress.Text = "請輸入住址";
            this.txtAdress.ForeColor = Color.Silver;
            this.labBirth.Text = "請選擇生日";
            this.labBirth.ForeColor = Color.Silver;
        }

        private void linlabForget_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmForget ffg = new FrmForget();
            ffg.ShowDialog();
        }
    }
}
