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
    public partial class Chart : Form
    {
        public Chart()
        {
            InitializeComponent();            
        }

        CoffeeEntities dbContext = new CoffeeEntities();

        string[] question1 = { "銷售最好的商品", "銷售最不好的商品", "庫存最多的商品", "最多人收藏的商品", "消費者點擊數最高的商品","每月商品總銷售額(僅列出有銷售額月份)" };
        string[] question2 = { "5", "10", "15", "20" };
        string[] question3 = { "月銷售成長率" };
        private void LoadQuestionToComboxQuestionOne()
        {
            cbxQuestionOne.DataSource = question1;
        }

        private void LoadQuestionToComboxQuestionTwo()
        {
            cbxQuestionTwo.DataSource = question3;
        }

        private void LoadQuestionToComboxQuestionTake()
        {
            cbxQuestionTake.DataSource = question2;
        }

        private void cbxQuestionOne_Click(object sender, EventArgs e)
        {
            LoadQuestionToComboxQuestionOne();
        }

        private void cbxQuestionTwo_Click(object sender, EventArgs e)
        {
            LoadQuestionToComboxQuestionTwo();
            this.btnShowLine.Enabled = true;
        }

        private void cbxQuestionTake_Click(object sender, EventArgs e)
        {
            LoadQuestionToComboxQuestionTake();
            this.btnShowChart.Enabled = true;
        }

        private decimal GrowthRate(decimal q1, decimal q2)
        {
            decimal result = (q1 - q2) / q2 * 100;
            return result;
        }

        private void btnShowChart_Click(object sender, EventArgs e)
        {
            int index = this.cbxQuestionOne.SelectedIndex;
            
            switch (index)
            {
                case 0:
                    int take = Int32.Parse(this.cbxQuestionTake.Text);
                    var q  = this.dbContext.OrderDetails
                        .Select(s => new { ProductName = s.Product.ProductName, s.Quantity })
                        .GroupBy(g => g.ProductName)
                        .Select(s => new { ProductName = s.Key, Quantity = s.Sum(x => x.Quantity) })
                        .OrderByDescending(o=>o.Quantity).Take(take).ToList();

                    this.chart1.DataSource = null;
                    this.chart1.DataSource = q;
                    this.chart1.Series[0].Name = $"{question1[index]}(單位:個)";
                    this.chart1.Series[0].XValueMember = "ProductName";
                    this.chart1.Series[0].YValueMembers = "Quantity";
                    this.chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
                    break;
                case 1:
                    take = Int32.Parse(this.cbxQuestionTake.Text);
                    var qu = this.dbContext.OrderDetails
                        .Select(s => new { ProductName = s.Product.ProductName, s.Quantity })
                        .GroupBy(g => g.ProductName)
                        .Select(s => new { ProductName = s.Key, Quantity = s.Sum(x => x.Quantity) })
                        .OrderBy(o => o.Quantity).Take(take).ToList();

                    this.chart1.DataSource = null;
                    this.chart1.DataSource = qu;
                    this.chart1.Series[0].Name = $"{question1[index]}(單位:個)";
                    this.chart1.Series[0].XValueMember = "ProductName";
                    this.chart1.Series[0].YValueMembers = "Quantity";
                    this.chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
                    break;
                case 2:
                    take = Int32.Parse(this.cbxQuestionTake.Text);
                    var que = this.dbContext.Products.OrderByDescending(o => o.Stock).Take(take).ToList();

                    this.chart1.DataSource = null;
                    this.chart1.DataSource = que;
                    this.chart1.Series[0].Name = $"{question1[index]}(單位:個)";
                    this.chart1.Series[0].XValueMember = "ProductName";
                    this.chart1.Series[0].YValueMembers = "Stock";
                    this.chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
                    break;
                case 3:
                    take = Int32.Parse(this.cbxQuestionTake.Text);
                    var quer = this.dbContext.MyLikes.AsEnumerable()
                        .GroupBy(g => g.Product.ProductName)
                        .Select(s => new {ProductName = s.Key, Count = s.Count() }).Take(take).ToList();

                    this.chart1.DataSource = null;
                    this.chart1.DataSource = quer;
                    this.chart1.Series[0].Name = $"{question1[index]}(單位:次數)";
                    this.chart1.Series[0].XValueMember = "ProductName";
                    this.chart1.Series[0].YValueMembers = "Count";
                    this.chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
                    break;
                case 4:
                    take = Int32.Parse(this.cbxQuestionTake.Text);
                    var query = this.dbContext.Products.AsEnumerable().OrderByDescending(o => o.ClickCount).Take(take).ToList();

                    this.chart1.DataSource = null;
                    this.chart1.DataSource = query;
                    this.chart1.Series[0].Name = $"{question1[index]}(單位:次數)";
                    this.chart1.Series[0].XValueMember = "ProductName";
                    this.chart1.Series[0].YValueMembers = "ClickCount";
                    this.chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
                    break;

                case 5:                   
                    var amount = this.dbContext.OrderDetails.AsEnumerable().Select(s => new { s.Product.ProductName, s.Order.OrderDate.Month, amount = (int)(s.Product.Price * s.Quantity) })
                        .GroupBy(g=>g.Month).Select(s=>new {Month = s.Key,Amount = $"{s.Sum(x=>x.amount):c0}" }).ToList();

                    this.chart1.DataSource = null;
                    this.chart1.DataSource = amount;
                    this.chart1.Series[0].Name = $"{question1[index]} (單位:元)";
                    this.chart1.Series[0].XValueMember = "Month";
                    this.chart1.Series[0].YValueMembers = "Amount";
                    this.chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
                    break;
            }
        }

        private void cbxQuestionOne_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cbxQuestionOne.SelectedIndex == 5)
            {
                this.cbxQuestionTake.Enabled = false;
                this.btnShowChart.Enabled = true;
            }
            else
            {
                this.cbxQuestionTake.Enabled = true;
            }
        }

        private void btmShowLine_Click(object sender, EventArgs e)
        {
            int index = this.cbxQuestionTwo.SelectedIndex;

            switch (index)
            {
                case 0:
                    var amount = this.dbContext.OrderDetails.AsEnumerable().Select(s => new { s.Product.ProductName, s.Order.OrderDate.Month, amount = (int)(s.Product.Price * s.Quantity) })
                       .GroupBy(g => g.Month).Select(s => new { Month = s.Key, Amount = s.Sum(x => x.amount) }).OrderBy(o=>o.Month);
                    var zip = amount.Skip(1).Zip(amount.Take(amount.Count() - 1), (amountFront, amountBack) => new { Month = amountFront.Month, GrowthRate = GrowthRate(amountFront.Amount, amountBack.Amount) }).ToList();
                                        
                    this.chart2.DataSource = null;
                    this.chart2.DataSource = zip;
                    this.chart2.Series[0].Name = "月銷售額成長率(單位%)";
                    this.chart2.Series[0].XValueMember = "Month";                    
                    this.chart2.Series[0].YValueMembers = "GrowthRate";
                    this.chart2.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
                    break;
            }
        }
    }    
}
