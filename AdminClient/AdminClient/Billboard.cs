using AdminClient;
using AdminClient.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InsertNews
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.dataGridView1.DataSource = this.db.News.ToList();
            this.monthCalendar1.MinDate = DateTime.Now;
        }
        CoffeeEntities db = new CoffeeEntities();
        private void button1_Click(object sender, EventArgs e)
        {
            DateTime Start = this.monthCalendar1.SelectionStart.Date;
            DateTime End = this.monthCalendar2.SelectionStart.Date;
            News news = new News { NewsID = int.Parse(this.textBox1.Text), NewsDescription = this.textBox2.Text, NewsStartTime = Start, NewsOverTime = End };
            this.db.News.Add(news);
            this.db.SaveChanges();
            this.dataGridView1.DataSource = null;
            this.dataGridView1.DataSource = this.db.News.ToList();
        }



        private void button3_Click(object sender, EventArgs e)
        {
            int num = int.Parse(this.textBox1.Text);
            var q = (from n in this.db.News
                     where n.NewsID == num
                     select n).FirstOrDefault();
            if (q == null)
            {
                return;
            }
            this.db.News.Remove(q);
            this.db.SaveChanges();
            this.dataGridView1.DataSource = null;
            this.dataGridView1.DataSource = this.db.News.ToList();
        }


        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            this.monthCalendar2.MinDate = this.monthCalendar1.SelectionStart;
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControlNews.SelectedIndex == 0)
            {
                this.dataGridView1.DataSource = this.db.News.ToList();
            }
            else if (tabControlNews.SelectedIndex == 1)
            {
                this.dataGridView2.DataSource = this.db.Introduces.Where(n => n.IntroducesName != null).ToList();
            }
            else if (tabControlNews.SelectedIndex == 2)
            {
                this.dataGridView3.DataSource = this.db.IntroducePhotos.Where(n => n.IntroduceID > 3).ToList();

            }

        }

        private void button4_Click(object sender, EventArgs e)
        {

            Introduce introduce = new Introduce { IntroducesID = int.Parse(this.textBox3.Text), IntroducesName = this.textBox5.Text, Description = this.textBox4.Text };
            this.db.Introduces.Add(introduce);
            this.db.SaveChanges();
            this.dataGridView2.DataSource = null;
            this.dataGridView2.DataSource = this.db.Introduces.Where(n => n.IntroducesName != null).ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int num = int.Parse(this.textBox3.Text);
            var q = (from n in this.db.Introduces
                     where n.IntroducesID == num
                     select n).FirstOrDefault();
            if (q == null)
            {
                return;
            }
            this.db.Introduces.Remove(q);
            this.db.SaveChanges();
            this.dataGridView2.DataSource = null;
            this.dataGridView2.DataSource = this.db.Introduces.Where(n => n.IntroducesName != null).ToList();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (int.TryParse(this.textBox6.Text, out int x))
            {
                bool q = db.Introduces.Any(n => n.IntroducesID == x && x > 3);
                if (q)
                {
                    MemoryStream ms = new MemoryStream();
                    this.pictureBox1.Image.Save(ms, ImageFormat.Jpeg);
                    byte[] bytes = ms.GetBuffer();
                    IntroducePhoto introducePhoto = new IntroducePhoto { IntroducePhotosID = int.Parse(this.textBox7.Text), IntroduceID = int.Parse(this.textBox6.Text), IntroducePhoto1 = bytes };
                    this.db.IntroducePhotos.Add(introducePhoto);
                    this.db.SaveChanges();
                    this.dataGridView3.DataSource = null;
                    this.dataGridView3.DataSource = this.db.IntroducePhotos.Where(n => n.IntroduceID > 3).ToList();
                }
                else
                {
                    return;
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int num = int.Parse(this.textBox7.Text);
            var q = (from n in this.db.IntroducePhotos
                     where n.IntroducePhotosID == num
                     select n).FirstOrDefault();
            if (q == null)
            {
                return;
            }
            this.db.IntroducePhotos.Remove(q);
            this.db.SaveChanges();
            this.dataGridView3.DataSource = null;
            this.dataGridView3.DataSource = this.db.IntroducePhotos.Where(n => n.IntroduceID > 3).ToList();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.Filter=
            "All Images Files (*.png;*.jpeg;*.gif;*.jpg;*.bmp;*.tiff;*.tif)|*.png;*.jpeg;*.gif;*.jpg;*.bmp;*.tiff;*.tif" +
            "|PNG Portable Network Graphics (*.png)|*.png" +
            "|JPEG File Interchange Format (*.jpg *.jpeg *jfif)|*.jpg;*.jpeg;*.jfif" +
            "|BMP Windows Bitmap (*.bmp)|*.bmp" +
            "|TIF Tagged Imaged File Format (*.tif *.tiff)|*.tif;*.tiff" +
            "|GIF Graphics Interchange Format (*.gif)|*.gif";

            if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                this.pictureBox1.Image = Image.FromFile(this.openFileDialog1.FileName);
            }
        }

        private void tabControlNews_DrawItem(object sender, DrawItemEventArgs e)
        {
            Rectangle rectangle = tabControlNews.ClientRectangle;

            //標題框背景圖片
            Image backImage = Resources.vector_grunge_stained_background;

            //標籤文字對齊
            StringFormat stringFormat = new StringFormat();
            stringFormat.LineAlignment = StringAlignment.Center;
            stringFormat.Alignment = StringAlignment.Center;

            //標籤文字顏色，字型大小
            SolidBrush brush = new SolidBrush(Color.Moccasin);
            SolidBrush fontBrush = new SolidBrush(Color.Black);
            Font font = new Font("Consolas", 9F, FontStyle.Bold);

            //標題框建立背景
            e.Graphics.DrawImage(backImage, 0, 0, tabControlNews.Width, tabControlNews.Height);

            for (int i = 0; i < tabControlNews.TabPages.Count; i++)
            {
                //抓取工作區域
                Rectangle tabRectangle = tabControlNews.GetTabRect(i);

                //標籤建立背景顏色
                e.Graphics.FillRectangle(brush, tabRectangle);

                //標籤建立
                e.Graphics.DrawString(this.tabControlNews.TabPages[i].Text, font, fontBrush, tabRectangle, stringFormat);
            }
        }
    }
}
