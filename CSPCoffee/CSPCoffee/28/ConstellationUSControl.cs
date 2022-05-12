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
    public partial class ConstellationUSControl : UserControl
    {
        int mID = 0;
        public ConstellationUSControl(int memberID)
        {
            InitializeComponent();
            mID = memberID;
        }

        public string ConstellationName
        {
            get
            {
                return label1.Text;
            }
            set
            {
                label1.Text = value;
            }
        }
        public Image ConstellationImage
        {
            get
            {
                return pictureBox1.BackgroundImage;
            }
            set
            {
                pictureBox1.BackgroundImage = value;
            }
        }
        
        //按鈕
        private void button1_Click(object sender, EventArgs e)
        {
            CoffeeEntities1 db = new CoffeeEntities1();
            FormConstellation f = new FormConstellation(mID);
            var q = from n in db.Constellations
                     where n.ConstellationName == this.label1.Text
                     select n.ConstellationDescription;

            f.ConsName = this.label1.Text;
            f.textBox1.Text =q.ToList()[0];
            f.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            CoffeeEntities1 db = new CoffeeEntities1();
            FormConstellation f = new FormConstellation(mID);
            var q = from n in db.Constellations
                    where n.ConstellationName == this.label1.Text
                    select n.ConstellationDescription;

            f.ConsName = this.label1.Text;
            f.textBox1.Text = q.ToList()[0];
            f.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            CoffeeEntities1 db = new CoffeeEntities1();
            FormConstellation f = new FormConstellation(mID);
            var q = from n in db.Constellations
                    where n.ConstellationName == this.label1.Text
                    select n.ConstellationDescription;

            f.ConsName = this.label1.Text;
            f.textBox1.Text = q.ToList()[0];
            f.ShowDialog();
        }
    }
}
