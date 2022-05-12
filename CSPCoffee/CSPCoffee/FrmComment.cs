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
    public partial class FrmComment : Form
    {
        public FrmComment()
        {
            InitializeComponent();
            cbbProID.DataSource = db.Products.Select(x => x.ProductID).ToList();
        }
        CoffeeEntities1 db = new CoffeeEntities1();
        int cID = 0;
        private void cbbProID_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = int.Parse(cbbProID.Text);
            var q = db.Comments.AsEnumerable().Where(c => c.Product.ProductID == id).Take(1);
            if (q.Count() == 0)
            {
                labName.Text = labDate.Text = labRank.Text = labCom.Text = "";
                btnReply.Enabled = false;
                return;
            }
            labName.Text=q.Select(c => c.Member.MemberName).ToList()[0];
            labDate.Text = q.Select(c => $"購買日期：{c.Order.OrderDate:yyyy.MM.dd}").ToList()[0];
            labRank.Text = q.Select(c => $"您的評價：{c.Star} 星").ToList()[0];
            labCom.Text=q.Select(c => c.CommentDescription).ToList()[0];
            cID = q.Select(c => c.CommentID).ToList()[0];
            btnReply.Enabled = true;
        }

        private void btnReply_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            TextBox txt = new TextBox();
            txt.Location = new Point(btn.Location.X, btn.Location.Y + 30);
            txt.Width = labCom.Width;
            Controls.Add(txt);

            Button btnR = new Button();
            btnR.Location = new Point(btn.Location.X + labCom.Width, btn.Location.Y + 30);
            btnR.Click += ComReply;
            btnR.Text = "回覆";
            btnR.Tag = cID;
            Controls.Add(btnR);
        }

        private void ComReply(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int id = int.Parse(cbbProID.Text);
            db.Comments.Add(new Comment { ProductID = id, MemberID = 1, OrderID = 0, CommentParentID = cID, CommentDescription = "aaaa" }); 
            db.SaveChanges();

        }
    }
}
