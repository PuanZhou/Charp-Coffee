using CSPCoffee;
using InsertNews;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminClient
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnMembers_Click(object sender, EventArgs e)
        {
            this.splitContainer1.Panel2.Controls.Clear();
            Members f = new Members();
            f.TopLevel = false;
            f.Visible = true;
            this.splitContainer1.Panel2.Controls.Add(f);
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            this.splitContainer1.Panel2.Controls.Clear();
            Orders f = new Orders();
            f.TopLevel = false;
            f.Visible = true;
            this.splitContainer1.Panel2.Controls.Add(f);
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            this.splitContainer1.Panel2.Controls.Clear();
            Products f = new Products();
            f.TopLevel = false;
            f.Visible = true;
            this.splitContainer1.Panel2.Controls.Add(f);
        }

        private void btnBlackList_Click(object sender, EventArgs e)
        {
            this.splitContainer1.Panel2.Controls.Clear();
            BlackList f = new BlackList();
            f.TopLevel = false;
            f.Visible = true;
            this.splitContainer1.Panel2.Controls.Add(f);
        }

        private void btnChart_Click(object sender, EventArgs e)
        {
            this.splitContainer1.Panel2.Controls.Clear();
            Chart f = new Chart();
            f.TopLevel = false;
            f.Visible = true;
            this.splitContainer1.Panel2.Controls.Add(f);
        }
        
        private void btnNews_Click(object sender, EventArgs e)
        {
            this.splitContainer1.Panel2.Controls.Clear();
            Form1 f = new Form1();
            f.TopLevel = false;
            f.Visible = true;
            this.splitContainer1.Panel2.Controls.Add(f);
        }

        private void btnQuestionnaire_Click(object sender, EventArgs e)
        {
            this.splitContainer1.Panel2.Controls.Clear();
            SurveyFrm surveyFrm = new SurveyFrm();
            surveyFrm.TopLevel = false;
            surveyFrm.Visible = true;
            this.splitContainer1.Panel2.Controls.Add(surveyFrm);
        }
    }
}
