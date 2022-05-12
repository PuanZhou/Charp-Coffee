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

namespace CSPCoffee
{
    public partial class CoControl : UserControl
    {
        CoffeeEntities1 db = new CoffeeEntities1();
        int cID = 0;
        int pID = 0;
        int mID = 0;
        public CoControl(int c,int p,int m)
        {
            InitializeComponent();
            cID = c;
            pID = p;
            mID = m;
            LoadComment();
        }

        private void LoadComment()
        {
            var q = db.Comments.AsEnumerable().Where(c => c.CommentID == cID);
            if (q.Count() == 0)
            {
                labName.Text = labDate.Text = labRank.Text = labCom.Text = "";
                btnReply.Enabled = false;
                return;
            }
            labName.Text = q.Select(c => c.Member.MemberName).ToList()[0];
            labDate.Text = q.Select(c => $"購買日期：{c.Order.OrderDate:yyyy.MM.dd}").ToList()[0];
            labRank.Text = q.Select(c => $"評價：{c.Star} 星").ToList()[0];
            labCom.Text = q.Select(c => c.CommentDescription).ToList()[0];
            cID = q.Select(c => c.CommentID).ToList()[0];
            btnReply.Enabled = true;
        }

        private void btnReply_Click(object sender, EventArgs e)
        {
            if (mID == 0)
            {
                MessageBox.Show("請先登入會員");
                return;
            }
            if (db.Members.Any(x => x.MemberID == mID && x.BlackList == true))
            {
                MessageBox.Show("您已被禁言");
                return;
            }

            txtSend.Visible = btnSend.Visible = btnCancel.Visible=true;
            btnReply.Visible = false;
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtSend.Visible = btnSend.Visible = btnCancel.Visible = false;
            btnReply.Visible = true;
        }

        Productdetail f1;
        private void btnSend_Click(object sender, EventArgs e)
        {   
            if (txtSend.Text == "")
            {
                MessageBox.Show("請輸入留言內容");
                return;
            }
            //todo1 memberID
            f1 = (Productdetail)Application.OpenForms["Productdetail"];
            db.Comments.Add(new Comment { ProductID = pID, MemberID = mID, OrderID = 1, CommentParentID = cID, CommentDescription = txtSend.Text });
            db.SaveChanges();

            f1.clearPanel();
            f1.creatComment();
        }

    }
}
