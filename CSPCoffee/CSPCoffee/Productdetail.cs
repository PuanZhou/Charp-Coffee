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
    public partial class Productdetail : Form
    {
        CoffeeEntities1 db = new CoffeeEntities1();
        int pID = 0;//added
        int memberID = 0;

        public Productdetail(int productID, int mID)
        {
            InitializeComponent();

            //pictureBox2.Parent = pictureBox1;
            pictureBox1.Parent = pictureBox3;


            cbbStar.SelectedIndex = 4;//added
            pID = productID;//added
            memberID = mID;//added
            var q = db.Products.Where(x => x.ProductID == pID).FirstOrDefault();
            q.ClickCount = q.ClickCount is null ? 1 : q.ClickCount + 1;
            db.SaveChanges();
            var qc = db.OrderDetails.Any(x => x.ProductID == productID && x.Order.MemberID == memberID);
            var qh = !db.Comments.Any(x => x.CommentParentID == 0 && x.MemberID == memberID && x.ProductID == productID);
            var qb = !db.Members.Any(x => x.BlackList == true && x.MemberID==memberID);
            if (qb && qc && qh) btnCom.Visible = txtComment.Visible = cbbStar.Visible = true;
            //Deactivate += (object sender, EventArgs e) => Close();

            creatComment();//added
            var name = db.Products.AsEnumerable().
                Where(p => p.ProductID == productID).
                Select(p =>
                new
                {
                    p.ProductName,
                    p.Category.CategoriesName,
                    p.Price,
                    p.Description,
                    p.Stock,
                }).ToArray();
            label1.Text = name[0].ProductName.ToString();
            lbcate.Text = name[0].CategoriesName.ToString();
            lbstock.Text = name[0].Stock.ToString();
            string pric = $"{name[0].Price:c0}元";
            lbprice.Text = pric;
            lbdescription.Text = name[0].Description.ToString();

            var coffee = db.Products.AsEnumerable().
                Where(p => p.ProductID == productID & p.CategoryID == 1).
                Select(p =>
                new
                {
                    p.ProductName,
                    p.Category.CategoriesName,
                    p.Country.CountryName,
                    p.Coffee.Roasting.RoastingName,
                    p.Coffee.Process.ProcessName,
                    p.Coffee.Package.PackageName,
                    p.Price,
                    p.Description,
                    p.Stock,
                }).ToArray();

            if (coffee.Length != 0)
            {
                lbcountry.Text = coffee[0].CountryName.ToString();
                lbroast.Text = coffee[0].RoastingName.ToString();
                lbprocess.Text = coffee[0].ProcessName.ToString();
                lbpack.Text = coffee[0].PackageName.ToString();
            }
            else
            {
                lbcountry.Text = "";
                lbroast.Text = "";
                lbprocess.Text = "";
                lbpack.Text = "";
            }
            //圖片
            var photo = db.PhotoDetails.AsEnumerable().Where(p => p.ProductID == productID).Select(p => new { p.ProductID, p.Photo.Photo1 }).ToList();
            byte[] bytes = photo[0].Photo1;
            MemoryStream ms = new MemoryStream(bytes);
            pictureBox1.Image = Image.FromStream(ms);
            //combobox

            var stock = db.Products.Where(p => p.ProductID == productID).Select(p => p.Stock).ToArray();
            foreach (int a in stock)
            {
                for (int i = 1; i <= a && i <= 10; i++)
                {
                    comboBox1.Items.Add(i);
                }
                if (stock.Length != 0) comboBox1.SelectedIndex = 0;//added
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (memberID == 0)
            {
                MessageBox.Show("請先登入會員");
            }
            else
            {
                bool qe = db.ShoppingCarDetails.Any(n => n.MemberID == memberID && n.ProductsID == pID);
                if (qe)
                {
                    var qcar = db.ShoppingCarDetails.FirstOrDefault(x => x.ProductsID == pID && x.MemberID == memberID);
                    var q = db.ShoppingCarDetails.Where(x => x.ProductsID == pID && x.MemberID == memberID).ToList();
                    q[0].Quantity = qcar.Quantity + comboBox1.SelectedIndex + 1;
                    db.SaveChanges();
                }
                else
                {
                    var q = new ShoppingCarDetail { MemberID = memberID, ProductsID = pID, Quantity = comboBox1.SelectedIndex + 1 };
                    db.ShoppingCarDetails.Add(q);
                    db.SaveChanges();
                }
                new Car1
                {
                    memID = memberID
                }.Show();
                Close();
            }
        }


        //comment========================================
        int x = 0, y = 0;
        bool c = false;
        public void creatComment()
        {
            SplitContainer s1 = new SplitContainer();
            x = y = 0;
            var q = db.Comments.Where(n => n.ProductID == pID && n.CommentParentID == 0).OrderByDescending(x => x.CommentID)
                .Select(n => new { n.CommentID }).ToList();
            for (int i = 0; i < q.Count; i++)
            {
                CoControl co = new CoControl(q[i].CommentID, pID, memberID);
                co.BackColor = c ? Color.Moccasin : Color.BurlyWood;
                co.Location = new Point(20, (y++ * co.Height + 5));
                panel1.Controls.Add(co);
                creatReComment(q[i].CommentID);
                c = !c;
            }
        }

        public void creatReComment(int paID)
        {
            var qc = db.Comments.AsEnumerable().Where(n => n.CommentParentID == paID).OrderByDescending(n => n.CommentID).Select(n => new { n.CommentID }).ToList();
            var qp = db.Comments.Where(n => n.CommentParentID == paID).OrderByDescending(n => n.CommentID).Select(n => new { n.CommentParentID }).ToList();
            x++;
            for (int i = 0; i < qc.Count; i++)
            {
                CoReControl cr = new CoReControl(qc[i].CommentID, pID, (int)qp[i].CommentParentID, memberID);
                cr.BackColor = c ? Color.Moccasin : Color.BurlyWood;
                cr.Location = new Point(20 + x * 10, (y++ * cr.Height + 5));
                panel1.Controls.Add(cr);
                cr.txtSend.Visible = cr.btnSend.Visible = cr.btnCancel.Visible = false;
                creatReComment(qc[i].CommentID);
            }
            x--;
        }

        private void btnCom_Click(object sender, EventArgs e)
        {
            var q = db.OrderDetails.AsEnumerable().Where(x => x.Order.MemberID == memberID && x.ProductID == pID).Select(x => new { x.OrderID }).Last();
            if (txtComment.Text == "")
            {
                MessageBox.Show("請輸入留言內容");
                return;
            }

            db.Comments.Add(new Comment { ProductID = pID, MemberID = memberID, OrderID = q.OrderID, CommentParentID = 0, CommentDescription = txtComment.Text, Star = cbbStar.SelectedIndex + 1 });
            db.SaveChanges();
            btnCom.Visible = txtComment.Visible = cbbStar.Visible = false;
            clearPanel();
            creatComment();
        }

        private void btnMyLike_Click(object sender, EventArgs e)
        {

            if (memberID == 0)
            {
                MessageBox.Show("請先登入會員");
            }
            else
            {
                bool qh = db.MyLikes.Any(x => x.MemberID == memberID && x.ProductID == pID);
                if (qh)
                {
                    MessageBox.Show("已在您的收藏中");
                }
                else
                {
                    var q = new MyLike { MemberID = memberID, ProductID = pID };
                    db.MyLikes.Add(q);
                    db.SaveChanges();
                    MessageBox.Show("成功加入了收藏");
                }

            }
        }

        private void Productdetail_Load(object sender, EventArgs e)
        {
            Random rng = new Random(Guid.NewGuid().GetHashCode());

            if (db.Products.Where(x => x.ProductID == pID).Any(x => x.CategoryID != 1))
            {
                this.label3.Visible = false;
                return;
            }

            var r1 = db.Products.Where(p => p.ProductID == pID).Select(x => new { x.Coffee.RoastingID }).ToList();
            var qr1 = db.Coffees.AsEnumerable().Where(p => p.RoastingID == r1[0].RoastingID && p.ProductID != pID).OrderByDescending(x => rng.Next()).Select(p => p.ProductID).Take(1).ToList();

            PDcontrol recommend1 = new PDcontrol(qr1[0], memberID);

            recommend1.Location = new Point(950, 100);
            recommend1.Size = new Size(194, 190);
            recommend1.button2.Visible = false;
            recommend1.button1.Visible = false;
            Controls.Add(recommend1);

            var r2 = db.Products.Where(p => p.ProductID == pID).Select(x => new { x.Coffee.ProcessID }).ToList();
            var qr2 = db.Coffees.AsEnumerable().Where(p => p.ProcessID == r2[0].ProcessID && p.ProductID != pID && p.ProductID != qr1[0]).OrderByDescending(x => rng.Next()).Select(p => p.ProductID).Take(1).ToList();

            PDcontrol recommend2 = new PDcontrol(qr2[0], memberID);

            recommend2.Location = new Point(950, 315);
            recommend2.Size = new Size(194, 190);
            recommend2.button2.Visible = false;
            recommend2.button1.Visible = false;
            Controls.Add(recommend2);

            var r3 = db.Products.Where(p => p.ProductID == pID).Select(x => new { x.Coffee.Country.ContinentID }).ToList();
            var qr3 = db.Coffees.AsEnumerable().Where(p => p.Country.Continent.ContinentID == r3[0].ContinentID && p.ProductID != pID && p.ProductID != qr1[0] && p.ProductID != qr2[0]).OrderByDescending(x => rng.Next()).Select(p => p.ProductID).Take(1).ToList();

            PDcontrol recommend3 = new PDcontrol(qr3[0], memberID);

            recommend3.Location = new Point(950, 530);
            recommend3.Size = new Size(194, 190);
            recommend3.button2.Visible = false;
            recommend3.button1.Visible = false;
            Controls.Add(recommend3);
        }

        public void clearPanel()
        {
            panel1.Controls.Clear();
        }
    }
}
