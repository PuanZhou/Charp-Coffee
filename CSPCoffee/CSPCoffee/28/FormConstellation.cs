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
    public partial class FormConstellation : Form
    {
        int memberID = 0;
        public FormConstellation(int mID)
        {
            InitializeComponent();
            memberID = mID;
        }
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        Form1 f1;
        internal string ConsName;
        //中鍵
        private void button1_Click(object sender, EventArgs e)
        {
            f1 = (Form1)Application.OpenForms["Form1"];
            f1.flowLayoutPanel1.Controls.Clear();
            CoffeeEntities1 db = new CoffeeEntities1();
            var q = (from n in db.Constellations
                     where n.ConstellationName == ConsName
                     select n.ConstellationProductID).ToList();

            foreach (var item in q)
            {
                PDcontrol PD = new PDcontrol(item.Value, memberID);
                f1.flowLayoutPanel1.Controls.Add(PD);
            }

            this.Close();
        }
        //左鍵
        private void button2_Click(object sender, EventArgs e)
        {
            CoffeeEntities1 db = new CoffeeEntities1();
            var q = from n in db.Constellations
                    where n.ConstellationName == ConsName
                    select new
                    {
                        Forward = n.ConstellationID - 1
                    };
            foreach (var item in q)
            {
                if (item.Forward == 0)
                {
                    return;
                }
                else
                {
                    var q1 = from n1 in db.Constellations
                             where n1.ConstellationID == item.Forward
                             select new
                             {
                                 n1.ConstellationDescription,
                                 n1.ConstellationName
                             };
                    this.textBox1.Text = q1.ToList()[0].ConstellationDescription;
                    this.ConsName = q1.ToList()[0].ConstellationName;
                }
            }
        }
        //右鍵
        private void button3_Click(object sender, EventArgs e)
        {
            CoffeeEntities1 db = new CoffeeEntities1();
            var q = from n in db.Constellations
                    where n.ConstellationName == ConsName
                    select new
                    {
                        Next = n.ConstellationID + 1
                    };
            foreach (var item in q)
            {
                if (item.Next == 13)
                {
                    return;
                }
                else
                {
                    var q1 = from n1 in db.Constellations
                             where n1.ConstellationID == item.Next
                             select new
                             {
                                 n1.ConstellationDescription,
                                 n1.ConstellationName
                             };
                    this.textBox1.Text = q1.ToList()[0].ConstellationDescription;
                    this.ConsName = q1.ToList()[0].ConstellationName;
                }
            }
        }
    }
}
