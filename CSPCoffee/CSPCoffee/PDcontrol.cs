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
    public delegate void TheButtonClick1(PDcontrol source);
    public partial class PDcontrol : UserControl
    {
        CoffeeEntities1 db = new CoffeeEntities1();
        public event TheButtonClick1 theClick = null;
        int PDid;
        int memID = 0;
        Form1 f1;

        //public PDcontrol(int productID)
        //{

        //    InitializeComponent();
        //    PDid = productID;

        //    noCoffeeNoButton();


        //    //產品名稱
        //    var name = db.Products.AsEnumerable().Where(p => p.ProductID == productID).ToArray();
        //    label1.Text = name[0].ProductName.ToString();
        //    //label1.Click += PDcontrol_Click;
        //    //產品價格
        //    string pric = $"{name[0].Price:c0}元";
        //    label2.Text = pric;
        //    //label2.Click += PDcontrol_Click;
        //    //產品類別
        //    var Catergory = db.Products.AsEnumerable().Where(p => p.ProductID == productID).Select(p => p.Category.CategoriesName).ToArray();
        //    string ctg = $"{Catergory[0]}";
        //    label3.Text = ctg;
        //    /*label3.Click += PDcontrol_Click*/
        //    ;
        //    //產品圖片
        //    var photo = db.PhotoDetails.AsEnumerable().Where(p => p.ProductID == productID).Select(p => new { p.ProductID, p.Photo.Photo1 }).ToList();
        //    byte[] bytes = photo[0].Photo1;
        //    MemoryStream ms = new MemoryStream(bytes);
        //    pictureBox1.Image = Image.FromStream(ms);
        //    //pictureBox1.Click += PDcontrol_Click;
        //}
        public PDcontrol(int productID, int mID)
        {

            InitializeComponent();
            PDid = productID;
            memID = mID;
            noCoffeeNoButton();


            //產品名稱
            var name = db.Products.AsEnumerable().Where(p => p.ProductID == productID).ToArray();
            label1.Text = name[0].ProductName.ToString();
            //label1.Click += PDcontrol_Click;
            //產品價格
            string pric = $"{name[0].Price:c0}元";
            label2.Text = pric;
            //label2.Click += PDcontrol_Click;
            //產品類別
            var Catergory = db.Products.AsEnumerable().Where(p => p.ProductID == productID).Select(p => p.Category.CategoriesName).ToArray();
            string ctg = $"{Catergory[0]}";
            label3.Text = ctg;
            /*label3.Click += PDcontrol_Click*/
            if (db.Products.Any(x => x.ProductID == productID && x.CategoryID == 1))
            {
                var Package = db.Coffees.AsEnumerable().Where(p => p.ProductID == productID).Select(p => p.Package.PackageName).ToArray();
                string pkg = $"{Package[0]}";
                label4.Text = pkg;
            }
            else
            {
                label4.Text = "";
            }




            //產品圖片
            var photo = db.PhotoDetails.AsEnumerable().Where(p => p.ProductID == productID).Select(p => new { p.ProductID, p.Photo.Photo1 }).ToList();
            byte[] bytes = photo[0].Photo1;
            MemoryStream ms = new MemoryStream(bytes);
            pictureBox1.Image = Image.FromStream(ms);
            //pictureBox1.Click += PDcontrol_Click;
        }

        CompareFrm compare;
        private void button1_Click(object sender, EventArgs e)
        {
            f1 = (Form1)Application.OpenForms["Form1"];
            compare = new CompareFrm();
            compare.Show();
            f1.noButton();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            f1 = (Form1)Application.OpenForms["Form1"];

            if (f1.List.Count >= 3 && f1.List.Contains(PDid))
            {
                f1.List.Remove(PDid);
                this.button2.Text = "加入比較";
                button1.Visible = false;
            }
            else if(f1.List.Count >= 3)
            {
                MessageBox.Show("已加入三樣商品");
                return;
            }
           else if (f1.List.Contains(PDid) == false)
            {
                f1.List.Add(PDid);
                this.button2.Text = "取消比較";
                button1.Visible = true;
            }
            else if(f1.List.Contains(PDid) == true)
            {
                f1.List.Remove(PDid);
                this.button2.Text = "加入比較";
                button1.Visible = false;
            }


        }
        private void noCoffeeNoButton()
        {
            if (db.Products.Where(x => x.ProductID == PDid).Any(x => x.CategoryID != 1))
            {
                button1.Visible = button2.Visible = false;
            }
        }
        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            Object product = (Object)sender;
            Productdetail pd = new Productdetail(PDid, memID);
            pd.Location = new Point(300, 300);
            pd.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (theClick != null)
            {
                theClick(this);
            }
            ////theClick += oadCar;

            //if (memID == 0)
            //{
            //    MessageBox.Show("請先登入會員");
            //}
            //else
            //{
            //    var q = new ShoppingCarDetail { MemberID = memID, ProductsID = PDid, Quantity = 1 };
            //    db.ShoppingCarDetails.Add(q);
            //    db.SaveChanges();
            //}
        }
    }
}
