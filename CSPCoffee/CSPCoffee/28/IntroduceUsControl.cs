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
    public partial class IntroduceUsControl : UserControl
    {
        public IntroduceUsControl()
        {
            InitializeComponent();
        }

        public string IntroduceMessage
        {
            get
            {
                return textBox1.Text;
            }
            set
            {
                textBox1.Text = value;
            }
        }
        public Image IntroduceImage
        {
            get
            {
                return pictureBox1.Image;
            }
            set
            {
                pictureBox1.Image = value;
            }
        }
        public string IntroduceLinklabel
        {
            get
            {
                return linkLabel1.Text;
            }
            set
            {
                linkLabel1.Text = value;
            }
        }
        CoffeeEntities1 db = new CoffeeEntities1();
        Form1 f1;
        //詳細閱讀
        private void linkLabel1_Click(object sender, EventArgs e)
        {
            f1 = (Form1)Application.OpenForms["Form1"];
            f1.flowLayoutPanel1.Controls.Clear();
            var q = (from n in db.IntroducePhotos
                    where n.Introduce.IntroducesName == this.textBox1.Text
                    select new
                    {
                        Article = n.Introduce.Description,
                        Picture = n.IntroducePhoto1
                    }).Take(1);
            foreach (var item in q)
            {
                Photo_Big FPC = new Photo_Big();
                byte[] bytes = (byte[])item.Picture;
                System.IO.MemoryStream ms = new System.IO.MemoryStream(bytes);
                FPC.FlagPhoto = Image.FromStream(ms);
                f1.flowLayoutPanel1.Controls.Add(FPC);
                Box_Big IUC = new Box_Big();
                IUC.ReadIntroduse = item.Article;
                f1.flowLayoutPanel1.Controls.Add(IUC);

            }
        }
    }
}
