using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web.Security;
using System.Windows.Forms;

namespace CSPCoffee
{
    public partial class FrmMemCenter : Form
    {
        public FrmMemCenter()
        {
            InitializeComponent();
            this.tabMemCen.SelectedIndex = 0;
            LoadMemData();
            labErrHide();
            comBoxYear();
            comboxMonFrom();
            FillCoupon();
            OrderisNull();
            this.splitConOrder.Panel2Collapsed = true;
            FillLike();
        }

        CoffeeEntities1 db = new CoffeeEntities1();
        Form1 f1;
        bool birthHasClick = false;
        int oYear, oMon1, oMon2;

        void LoadMemData()
        {
            this.f1 = (Form1)Application.OpenForms["Form1"];
            var MemRow = this.db.Members.Where(p => p.MemberID == f1.memberID);
            this.txtPhone.Text = MemRow.Select(p => p.MemberPhone).ToList()[0];
            this.txtEmail.Text = MemRow.Select(p => p.MemberEMail).ToList()[0];
            this.txtName.Text = MemRow.Select(p => p.MemberName).ToList()[0];
            this.txtAdress.Text = MemRow.Select(p => p.MemberAddress).ToList()[0];
            this.labBirth.Text = MemRow.Select(p => p.MemberBirthDay).ToList()[0].ToShortDateString();
            var photo = MemRow.Select(p => p.MemberPhoto).ToList()[0];
            if (photo == null)
            {
                return;
            }
            else
            {
                photo = MemRow.Select(p => p.MemberPhoto).ToList()[0];
                MemoryStream ms = new MemoryStream(photo);
                this.pboxPhoto.Image = Image.FromStream(ms);
            }


        }

        void labErrHide()
        {
            this.labEmailErr.Visible = false;
            this.labPWErr.Visible = false;
            this.labNameErr.Visible = false;
            this.labAdressErr.Visible = false;
            this.labSearchErr.Visible = false;
            this.labOrdNull.Visible = false;
        }

       

        string PWHash(TextBox textBox)
        {
            string PW = textBox.Text;
            PW = FormsAuthentication.HashPasswordForStoringInConfigFile(PW, "SHA1");
            return PW;
        }

        #region 橫幅click

        private void labModiMem_Click(object sender, EventArgs e)
        {
            this.tabMemCen.SelectedIndex = 0;
        }
        private void labHis_Click(object sender, EventArgs e)
        {
            this.tabMemCen.SelectedIndex = 1;
        }

        private void labCoupon_Click(object sender, EventArgs e)
        {
            this.tabMemCen.SelectedIndex = 2;
        }

        private void labMyLike_Click(object sender, EventArgs e)
        {
            this.tabMemCen.SelectedIndex = 3;
        }
        #endregion 橫幅click


        private void button1_Click(object sender, EventArgs e)
        {
            var phone = this.db.Members.Where(p => p.MemberID == f1.memberID)/*.Select(p=>p.MemberPhone)*/;
            //this.dataGridView1.DataSource = phone.ToList()[0];
            var a = phone.Select(p => p.MemberPhone).ToList()[0];
            MessageBox.Show(a);
        }



        #region 變更資料
        private void btnEmailUP_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(this.txtEmail.Text))
            {
                this.labEmailErr.Text = "電子信箱不得為空";
                this.labEmailErr.Visible = true;
            }
            else if(this.txtEmail.Text.Contains('@')==false)
            {
                this.labEmailErr.Text = "電子信箱格式有誤";
            }
            else
            {
                this.labEmailErr.Visible = false;
                var q = (from m in this.db.Members
                         where m.MemberID == f1.memberID
                         select m).FirstOrDefault();
                q.MemberEMail = this.txtEmail.Text; ;
                db.SaveChanges();
                MessageBox.Show("變更成功");

            }
        }

        private void btnPWUP_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.txtPW.Text) || this.txtPW.Text=="請輸入新密碼" )
            {
                this.labPWErr.Text = "密碼不得為空";
                this.labPWErr.Visible = true;
            }
            else if (Regex.IsMatch(this.txtPW.Text, "^[a-zA-Z0-9]*$")==false) //是否包含非英數  @"^(.*\W){0,50}$"
            {
                this.labPWErr.Text = "密碼不得包含英數以外字元";
                this.labPWErr.Visible = true;
            }
            else
            {
                this.labPWErr.Visible = false;
                var q= this.db.Members.Where(m => m.MemberID == f1.memberID).Select(m => m).FirstOrDefault();
                string PW = PWHash(this.txtPW);
                q.MemberPassword = PW ;
                db.SaveChanges();
                MessageBox.Show("變更成功");
            }
        }

        private void btnNameUP_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.txtName.Text))
            {
                this.labNameErr.Visible = true;
            }
            else
            {
                this.labNameErr.Visible = false;
                var q = this.db.Members.Where(m => m.MemberID == f1.memberID).Select(m => m).FirstOrDefault();
                q.MemberName = this.txtName.Text; ;
                db.SaveChanges();
                MessageBox.Show("變更成功");
            }
        }

        private void btnAdressUP_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.txtAdress.Text))
            {
                this.labAdressErr.Visible = true;
            }
            else
            {
                this.labNameErr.Visible = false;
                var q = this.db.Members.Where(m => m.MemberID == f1.memberID).Select(m => m).FirstOrDefault();
                q.MemberAddress = this.txtAdress.Text; ;
                db.SaveChanges();
                MessageBox.Show("變更成功");
            }
        }



        private void btnBrowse_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.Filter = "All Images Files (*.png;*.jpeg;*.gif;*.jpg;*.bmp;*.tiff;*.tif)|*.png;*.jpeg;*.gif;*.jpg;*.bmp;*.tiff;*.tif" +
            "|PNG Portable Network Graphics (*.png)|*.png" +
            "|JPEG File Interchange Format (*.jpg *.jpeg *jfif)|*.jpg;*.jpeg;*.jfif" +
            "|BMP Windows Bitmap (*.bmp)|*.bmp" +
            "|TIF Tagged Imaged File Format (*.tif *.tiff)|*.tif;*.tiff" +
            "|GIF Graphics Interchange Format (*.gif)|*.gif";
            if(this.openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                this.pboxPhoto.Image = Image.FromFile(this.openFileDialog1.FileName);
            }
        }

        private void btnPhotoUP_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] bytes = null;
                MemoryStream ms = new MemoryStream();
                this.pboxPhoto.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                bytes = ms.GetBuffer();

                var q = this.db.Members.Where(m => m.MemberID == f1.memberID).Select(m => m).FirstOrDefault();
                q.MemberPhoto = bytes;
                this.db.SaveChanges();
                MessageBox.Show("變更成功");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        #endregion 變更資料

        #region 訂單查詢

        void comBoxYear ()
        {
            var q = this.db.Orders.Where(o => o.MemberID == f1.memberID).GroupBy(o => o.OrderDate.Year).Select(o => o.Key);
           foreach(int item in q)
            {
                this.cBoxY1.Items.Add(item);
            }
        }

        void comboxMonFrom()
        {
            for(int mon=1; mon<13; mon++)
            {
                this.cBoxM1.Items.Add(mon);
            }
        }

        private void cBoxM1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.cBoxM2.Items.Clear();
            comboxMonTo();
        }

        void comboxMonTo()
        {
            for(int monF = int.Parse(this.cBoxM1.Text)+1; monF<13;monF++)
            {
                this.cBoxM2.Items.Add(monF);
            }
        }

        void OrderisNull()
        {
            var q = this.db.Orders.Where(o => o.MemberID == f1.memberID).Select(o =>o);
        if(q.Count()==0)
            {
                this.labOrdNull.Visible = true;
            }
        }



        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(this.cBoxY1.Text==""||this.cBoxM1.Text==""||this.cBoxM2.Text==""||
                int.TryParse(cBoxY1.Text,out oYear)==false|| int.TryParse(this.cBoxM1.Text, out oMon1)==false|| int.TryParse(this.cBoxM2.Text,out oMon2)==false )

            {
                this.labSearchErr.Visible = true;
            }
            else
            {
                this.labSearchErr.Visible = false;


                var q1 = this.db.Orders.AsEnumerable().Where(o => o.MemberID == f1.memberID && o.OrderDate.Year == oYear &&
                o.OrderDate.Month >= oMon1 && o.OrderDate.Month <= oMon2).Select(o=>new
                {訂單編號=o.OrderID , 訂單日期=o.OrderDate , 訂單狀態=o.OrderState.OrderState1 , 
                    付款方式=o.Payment.Payment1 , 訂單金額=o.OrderDetails.Sum(d=>d.Quantity*d.Product.Price ).Value.ToString("C0") });

                if(q1.Count()==0)
                {
                    this.labOrdNull.Visible = true;
                    this.splitConOrder.Panel2Collapsed = true ;
                }
                else
                {
                    this.gridVOrder.DataSource = q1.ToList();
                    var qod = this.db.OrderDetails.AsEnumerable().Where(od => od.Order.MemberID == f1.memberID).
                        Select(od => new { 訂單編號 = od.OrderID, 商品名 = od.Product.ProductName, 單價 = od.Product.Price.Value.ToString("C0"), 
                            數量 = od.Quantity , 合計 = (od.Product.Price * od.Quantity).Value.ToString("C0")
                        });
                    this.gridVOrderDetail.DataSource = qod.ToList();
                    this.splitConOrder.Panel2Collapsed = false;
                }


            }


        }



        #endregion 歷史訂單

        #region Coupon

        void FillCoupon()
        {
            var q = from c in this.db.CouponDetails
                    where c.MemberID == f1.memberID && c.Coupon.CouponDeadline>=DateTime.Now
                    select c;
            //MessageBox.Show(q.Count().ToString());
            foreach (var item in q)
            {
                CouponControl1 cp = new CouponControl1();
                cp.TextCouName = item.Coupon.CouponName;
                cp.TextLabCon = item.Coupon.Condition.ToString("C0");
                cp.TextLabMoney = item.Coupon.Money.ToString("C0");
                cp.TextLabStart = item.Coupon.CouponStartDate.ToShortDateString();
                cp.TextLabEnd = item.Coupon.CouponDeadline.ToShortDateString();
                this.flowLayoutPanel1.Controls.Add(cp);
            }

        }


        #endregion Coupon

        #region 我的最愛

        void FillLike()
        {
            var q = this.db.MyLikes.Where(p => p.MemberID == f1.memberID).Select(p => new { p.ProductID,p.MemberID } );
            if (q.Count() == 0)
            {
                Label lb = new Label();
                lb.Text = "目前尚無任何收藏，趕快去逛逛吧！";
                lb.TextAlign = ContentAlignment.MiddleCenter;
                lb.AutoSize = true;
                lb.ForeColor = Color.SaddleBrown;
                lb.Font = new Font("微軟正黑體", 38, FontStyle.Bold);
                lb.Dock = DockStyle.Top;
                this.fLayPLike.Controls.Add(lb);
            }
            else
            {
                foreach (var item in q)
                {
                    PDcontrol pd = new PDcontrol( item.ProductID ,item.MemberID);
                    this.fLayPLike.Controls.Add(pd);
                }
            }
        }

        #endregion 我的最愛


        private void gridVOrder_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var q = this.db.OrderDetails.AsEnumerable().Where(od => od.OrderID == (int)this.gridVOrder.Rows[e.RowIndex].Cells[0].Value).
                    Select(od => new
                    {
                        訂單編號 = od.OrderID,
                        商品名 = od.Product.ProductName,
                        單價 = od.Product.Price.Value.ToString("C0"),
                        數量 = od.Quantity,
                        合計 = (od.Product.Price * od.Quantity).Value.ToString("C0")
                    });
                this.gridVOrderDetail.DataSource = q.ToList();
            }
        }

        private void txtPW_TextChanged(object sender, EventArgs e)
        {

             if (this.txtPW.Text.Length < 8)
            {
                this.labPWErr.Text = "密碼強度：弱";
                this.labPWErr.ForeColor = Color.Red;
                this.labPWErr.Visible = true;
            }
            else if (this.txtPW.Text.Length > 8 &&
                Regex.IsMatch(this.txtPW.Text, @"^(?=.*\d)(?=.*[a-z]).{8,16}$") &&
                this.txtPW.Text.Length < 16)
            {
                this.labPWErr.Text = "密碼強度：中";
                this.labPWErr.ForeColor = Color.Orange;
                this.labPWErr.Visible = true;
            }
            else if (this.txtPW.Text.Length > 16 &&
                Regex.IsMatch(this.txtPW.Text, @"^(?=.*\d)(?=.*[a-z])(?=.*[A-Z]).{17,50}$") &&
                this.txtPW.Text.Length < 50)
            {
                this.labPWErr.Text = "密碼強度：強";
                this.labPWErr.ForeColor = Color.YellowGreen;
            }
        }

        private void txtPW_Enter(object sender, EventArgs e)
        {
            if (this.txtPW.Text == "請輸入新密碼")
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
                this.txtPW.Text = "請輸入新密碼";
                this.txtPW.ForeColor = Color.FromArgb(192, 192, 192);
                this.txtPW.UseSystemPasswordChar = false;
            }
        }

      

        private void btnCancel_Click(object sender, EventArgs e)
        {
            int oID;

            if (int.TryParse(this.txtOrderID.Text, out oID) == false)
            {
                this.labOIDErr.Text = "請輸入訂單編號";
                this.labOIDErr.Visible = true;
            }
            else
            {
                //尋找「此人」是否有「編號為oID」的訂單
                var q = this.db.Orders.Where(o => o.MemberID == f1.memberID && o.OrderID == oID).Select(o => o);

                if (q.Count() == 0) //如果此人無編號為oID的訂單
                {
                    this.labOIDErr.Text = "查無此訂單";
                    this.labOIDErr.Visible = true;
                }
                else //如果此人有編號為oID的訂單
                {
                    DialogResult dr = MessageBox.Show("確定取消此訂單嗎？", "確認訊息",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dr == DialogResult.Yes)
                    {
                        if (q.FirstOrDefault().OrderStateID == 1) //當訂單為「收到訂單」時
                        {
                            q.FirstOrDefault().OrderStateID = 4;
                            this.db.SaveChanges();
                            MessageBox.Show("取消成功");
                            this.gridVOrder.DataSource = null;
                            var q1 = this.db.Orders.AsEnumerable().Where(o => o.MemberID == f1.memberID && o.OrderDate.Year == oYear &&
                            o.OrderDate.Month >= oMon1 && o.OrderDate.Month <= oMon2).Select(o => new
                            {
                                訂單編號 = o.OrderID,
                                訂單日期 = o.OrderDate,
                                訂單狀態 = o.OrderState.OrderState1,
                                付款方式 = o.Payment.Payment1,
                                訂單金額 = o.OrderDetails.Sum(d => d.Quantity * d.Product.Price).Value.ToString("C0")
                            });
                            this.gridVOrder.DataSource = q1.ToList();
                        }
                        else if (q.FirstOrDefault().OrderStateID == 4)
                        {
                            MessageBox.Show("訂單已是取消過");
                        }
                        else
                        {
                            MessageBox.Show("訂單出貨之後不可取消");
                        }
                    }
                    else { return; } //取消修改訂單
                }
            }
        }

      
    }

}
