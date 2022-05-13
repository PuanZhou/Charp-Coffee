using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSPCoffee
{
    public partial class FrmOLService : Form
    {
        int id = 0;
        public FrmOLService(int mID)
        {
            InitializeComponent();
            SujectTxtQ();
            id = mID;
        }

        CoffeeEntities1 db = new CoffeeEntities1();
        int qFlag = 0;
        

        private void SujectTxtQ()
        {
            string[] s = {"訂單明細","我的訂單","還沒收到","我還沒收到貨","沒到","貨還沒到","退貨"
                    ,"取消訂單","我要退貨","購物車","我的購物車"
                    ,"優惠券","我的優惠券","收藏","喜好","喜愛","最愛","我的收藏"
                    ,"留言","評論","我的留言","我的評論"};
            AutoCompleteStringCollection strings = new AutoCompleteStringCollection();
            strings.AddRange(s);
            txtQuest.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtQuest.AutoCompleteCustomSource = strings;
            txtQuest.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
        }

        private void txtQuest_TextChanged(object sender, EventArgs e)
        {

            dataGridView1.Visible = dataGridView2.Visible = labForD1.Visible = labForD2.Visible = false;

            string q = txtQuest.Text;
            if (q == "") return;

            if (q.Contains("還沒") || q.Contains("沒到"))
            {
                dataGridView1.DataSource = db.Orders.Where(s => s.MemberID == id && s.OrderStateID == 1)
                    .Select(o => new { o.OrderDate, o.OrderAddress, o.Payment.Payment1, State = o.OrderState.OrderState1 }).ToList();
                qFlag = 1;
                labForD1.Text = "尚未出貨的訂單如下，請點擊查閱細節";
                labForD1.Visible = true;
            }
            else if (q.Contains("訂單"))
            {
                if (!(q.Contains("退") || q.Contains("取消")))
                {
                    dataGridView1.DataSource = db.Orders.Where(s => s.MemberID == id)
                        .Select(o => new { o.OrderDate, o.OrderAddress, o.Payment.Payment1, State = o.OrderState.OrderState1 }).ToList();
                    qFlag = 1;
                    labForD1.Text = "您的所有訂單如下，請點擊查閱細節";
                    labForD1.Visible = true;
                }
            }
            else if (q.Contains("退") || q.Contains("取消"))
            {
                dataGridView1.DataSource = db.Orders.Where(s => s.MemberID == id && s.OrderStateID == 1)
                    .Select(o => new { o.OrderDate, o.OrderAddress, o.Payment.Payment1, State = o.OrderState.OrderState1 }).ToList();
                qFlag = 1;
                labForD1.Text = "僅能取消尚未出貨的訂單，請點擊查閱細節，若要取消請到會員中心，訂單查詢中申請取消";
                labForD1.Visible = true;
            }
            else if (q.Contains("購物"))
{
                dataGridView1.DataSource = db.ShoppingCarDetails.Where(s => s.MemberID == id)
                    .Select(o => new { o.Product.ProductName, o.Quantity }).ToList();
                qFlag = 9;
            }
            else if (q.Contains("券"))
            {
                dataGridView1.DataSource = db.CouponDetails.Where(s => s.MemberID == id)
                    .Select(c => new { c.Coupon.CouponName, Discount = c.Coupon.Money, StartDate = c.Coupon.CouponStartDate, ExpirationDate = c.Coupon.CouponDeadline }).ToList();
                qFlag = 9;
            }
            else if (q.Contains("收藏") || q.Contains("喜好") || q.Contains("喜愛") || q.Contains("最愛"))
            {
                dataGridView1.DataSource = db.MyLikes.AsEnumerable().Where(l => l.MemberID == id)
                    .Select(l => new { l.Product.ProductName, Stock = StockLevel(l.Product.Stock) }).ToList();
                qFlag = 9;
            }
            else if (q.Contains("留言") || q.Contains("評"))
            {
                dataGridView1.DataSource = db.Comments.Where(s => s.MemberID == id)
                    .Select(c => new { c.Product.ProductName, Rank = c.Star, Comment = c.CommentDescription }).ToList();
                qFlag = 9;
            }
            else{
                timerforQuest.Enabled = true;
                qFlag = 0;
            }

            if (qFlag != 0) {
                dataGridView1.Visible = true;
                timerforQuest.Enabled = false;
            }
                
        }

        private string StockLevel(int? s)
        {
            if (s == 0 || s == null) return "目前無在庫";
            else if (s <= 10) return "有少量在庫";
            else return "有在庫";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string index = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            if (qFlag == 1)
            {
                dataGridView2.DataSource = db.OrderDetails.Where(o => o.Order.MemberID == id)
                    .Select(o => new { o.Product.ProductName, o.Quantity, Amount = o.Quantity * o.Product.Price }).ToList();
                dataGridView2.Visible = true;
            }
        }

        private void timerforQuest_Tick_1(object sender, EventArgs e)
        {
            labForD1.Text = "您的問題或許需要專人為您服務，請洽：(02)-2XXX-XXXX，謝謝";
            labForD1.Visible = true;
            timerforQuest.Enabled = false;
        }
    }
}
