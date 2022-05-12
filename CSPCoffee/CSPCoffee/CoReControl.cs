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

    public partial class CoReControl : UserControl
    {
        CoffeeEntities1 db = new CoffeeEntities1();
        int cID = 0;
        int pID = 0;
        int cpID = 0;
        int memberID = 0;
        public CoReControl(int c,int p,int cp,int m)
        {
            InitializeComponent();
            cID = c;
            pID = p;
            cpID = cp;
            memberID = m;
            LoadComment();
        }
        private void LoadComment()
        {
            var q = db.Comments.AsEnumerable().Where(c => c.CommentID == cID);
            if (q.Count() == 0)
            {
                labName.Text = labCom.Text = "";
                btnReply.Enabled = false;
                return;
            }
            labName.Text = q.Select(c => c.Member.MemberName).ToList()[0];
            labCom.Text = q.Select(c => c.CommentDescription).ToList()[0];
            cID = q.Select(c => c.CommentID).ToList()[0];
            btnReply.Enabled = true;
        }

        private void btnReply_Click(object sender, EventArgs e)
        {
            if (memberID == 0)
            {
                MessageBox.Show("請先登入會員");
                return;
            }
            if (db.Members.Any(x => x.MemberID == memberID && x.BlackList == true))
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
        {   //todo2 MemberID 另外DB裡的原本的CommentParentID要改成0
            if (txtSend.Text == "")
            {
                MessageBox.Show("請輸入留言內容");
                return;
            }
            db.Comments.Add(new Comment { ProductID = pID, MemberID = memberID, OrderID = 1, CommentParentID = cID, CommentDescription = txtSend.Text });
            db.SaveChanges();

            f1 = (Productdetail)Application.OpenForms["Productdetail"];
            f1.clearPanel();
            f1.creatComment();
        }
    }
}
