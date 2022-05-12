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
    public partial class CompareFrm : Form
    {
        //CoffeeEntities db = new CoffeeEntities();
        public CompareFrm()
        {
            InitializeComponent();

            Deactivate += (object sender, EventArgs e) => this.Close();
        }

        private Image ConvertToImage(byte[] photobytes)
        {
            Image photo = null;

            using (MemoryStream ms = new MemoryStream(photobytes))
            {
                return photo = Image.FromStream(ms);
            }

        }
        CoffeeEntities1 db = new CoffeeEntities1();

        Form1 f1 = (Form1)Application.OpenForms["Form1"];

        private void CompareFrm_Load(object sender, EventArgs e)
        {
            if (f1.List.Count == 1)
            {
                //圖片
                var photo = this.db.PhotoDetails.AsEnumerable().Where(x => x.ProductID == f1.List[0]).Select(x => x.Photo.Photo1).ToList();
                this.pictureBox1.Image = ConvertToImage(photo[0]);

                //產品名稱
                var q = this.db.Products.AsEnumerable().Where(p => p.ProductID == f1.List[0]).ToList();

                this.label9.Text = q[0].ProductName;

                // 產地名稱;
                this.label10.Text = q[0].Country.Continent.ContinentName;

                //國家

                this.label11.Text = q[0].Country.CountryName;

                // 烘焙程度
                this.label12.Text = q[0].Coffee.Roasting.RoastingName;

                //處理法

                this.label13.Text = q[0].Coffee.Process.ProcessName;

                //包裝

                this.label14.Text = q[0].Coffee.Package.PackageName;

                //風味

                this.label15.Text = q[0].Description;

                //單價
                this.label16.Text = $"{q[0].Price:c0}";
            }
            else if (f1.List.Count == 2)
            {
                //圖片
                var photo = this.db.PhotoDetails.AsEnumerable().Where(x => x.ProductID == f1.List[0]).Select(x => x.Photo.Photo1).ToList();
                this.pictureBox1.Image = ConvertToImage(photo[0]);

                //產品名稱
                var q = this.db.Products.AsEnumerable().Where(p => p.ProductID == f1.List[0]).ToList();

                this.label9.Text = q[0].ProductName;

                // 產地名稱;
                this.label10.Text = q[0].Country.Continent.ContinentName;

                //國家

                this.label11.Text = q[0].Country.CountryName;

                // 烘焙程度
                this.label12.Text = q[0].Coffee.Roasting.RoastingName;

                //處理法

                this.label13.Text = q[0].Coffee.Process.ProcessName;

                //包裝

                this.label14.Text = q[0].Coffee.Package.PackageName;

                //風味

                this.label15.Text = q[0].Description;

                //單價
                this.label16.Text = $"{q[0].Price:c0}";

                //=========================================

                //圖片
                photo = this.db.PhotoDetails.AsEnumerable().Where(x => x.ProductID == f1.List[1]).Select(x => x.Photo.Photo1).ToList();
                this.pictureBox2.Image = ConvertToImage(photo[0]);

                //產品名稱
                q = this.db.Products.AsEnumerable().Where(p => p.ProductID == f1.List[1]).ToList();

                this.label17.Text = q[0].ProductName;

                // 產地名稱;
                this.label18.Text = q[0].Country.Continent.ContinentName;

                //國家

                this.label19.Text = q[0].Country.CountryName;

                // 烘焙程度
                this.label20.Text = q[0].Coffee.Roasting.RoastingName;

                //處理法

                this.label21.Text = q[0].Coffee.Process.ProcessName;

                //包裝

                this.label22.Text = q[0].Coffee.Package.PackageName;

                //風味

                this.label23.Text = q[0].Description;

                //單價
                this.label24.Text = $"{q[0].Price:c0}";
            }
            else if (f1.List.Count == 3)
            {
                //圖片
                var photo = this.db.PhotoDetails.AsEnumerable().Where(x => x.ProductID == f1.List[0]).Select(x => x.Photo.Photo1).ToList();
                this.pictureBox1.Image = ConvertToImage(photo[0]);

                //產品名稱
                var q = this.db.Products.AsEnumerable().Where(p => p.ProductID == f1.List[0]).ToList();

                this.label9.Text = q[0].ProductName;

                // 產地名稱;
                this.label10.Text = q[0].Country.Continent.ContinentName;

                //國家

                this.label11.Text = q[0].Country.CountryName;

                // 烘焙程度
                this.label12.Text = q[0].Coffee.Roasting.RoastingName;

                //處理法

                this.label13.Text = q[0].Coffee.Process.ProcessName;

                //包裝

                this.label14.Text = q[0].Coffee.Package.PackageName;

                //風味

                this.label15.Text = q[0].Description;

                //單價
                this.label16.Text = $"{q[0].Price:c0}";

                //=========================================

                //圖片
                photo = this.db.PhotoDetails.AsEnumerable().Where(x => x.ProductID == f1.List[1]).Select(x => x.Photo.Photo1).ToList();
                this.pictureBox2.Image = ConvertToImage(photo[0]);

                //產品名稱
                q = this.db.Products.AsEnumerable().Where(p => p.ProductID == f1.List[1]).ToList();

                this.label17.Text = q[0].ProductName;

                // 產地名稱;
                this.label18.Text = q[0].Country.Continent.ContinentName;

                //國家

                this.label19.Text = q[0].Country.CountryName;

                // 烘焙程度
                this.label20.Text = q[0].Coffee.Roasting.RoastingName;

                //處理法

                this.label21.Text = q[0].Coffee.Process.ProcessName;

                //包裝

                this.label22.Text = q[0].Coffee.Package.PackageName;

                //風味

                this.label23.Text = q[0].Description;

                //單價
                this.label24.Text = $"{q[0].Price:c0}";

                //=========================================

                //圖片
                photo = this.db.PhotoDetails.AsEnumerable().Where(x => x.ProductID == f1.List[2]).Select(x => x.Photo.Photo1).ToList();
                this.pictureBox3.Image = ConvertToImage(photo[0]);

                //產品名稱
                q = this.db.Products.AsEnumerable().Where(p => p.ProductID == f1.List[2]).ToList();

                this.label25.Text = q[0].ProductName;

                // 產地名稱;
                this.label26.Text = q[0].Country.Continent.ContinentName;

                //國家

                this.label27.Text = q[0].Country.CountryName;

                // 烘焙程度
                this.label28.Text = q[0].Coffee.Roasting.RoastingName;

                //處理法

                this.label29.Text = q[0].Coffee.Process.ProcessName;

                //包裝

                this.label30.Text = q[0].Coffee.Package.PackageName;

                //風味

                this.label31.Text = q[0].Description;

                //單價
                this.label32.Text = $"{q[0].Price:c0}";
            }
            f1.cList.Clear();
            f1.List.Clear();

        }

        private void CompareFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            f1.cancelCompare();
        }
    }
}
