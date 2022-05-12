using AdminClient;
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
    public partial class SurveyFrm : Form
    {
        public SurveyFrm()
        {
            InitializeComponent();
        }

        CoffeeEntities db = new CoffeeEntities();

        private void SurveyFrm_Load(object sender, EventArgs e)
        {
            this.SurveyNameCombobox.Text = "請選擇問卷";
            this.QuestNameCombo.Text = "請選擇問題";
        }

        private void SurveyNameCombobox_Click(object sender, EventArgs e)
        {
            var q = this.db.QuestionTables.Select(x => x.QuestionTableName).ToList();

            this.SurveyNameCombobox.DataSource = q;
        }

        private void QuestNameCombo_Click(object sender, EventArgs e)
        {
            if (this.SurveyNameCombobox.Text == "請選擇問卷")
            {
                MessageBox.Show("請選擇一份問卷");
            }
        }


        private void SurveyNameCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.QuestNameCombo.Items.Clear();

            var qT = this.db.QuestionTables.Select(x => x.QuestionTableName).ToList();

            if (this.SurveyNameCombobox.Text == qT[0])
            {
                var q = this.db.QuestionTableDetails.Select(x => x.Q1).ToList();
                this.QuestNameCombo.Items.Add(q[0]);

                q = this.db.QuestionTableDetails.Select(x => x.Q2).ToList();
                this.QuestNameCombo.Items.Add(q[0]);

                q = this.db.QuestionTableDetails.Select(x => x.Q3).ToList();
                this.QuestNameCombo.Items.Add(q[0]);

                q = this.db.QuestionTableDetails.Select(x => x.Q4).ToList();
                this.QuestNameCombo.Items.Add(q[0]);

                q = this.db.QuestionTableDetails.Select(x => x.Q5).ToList();
                this.QuestNameCombo.Items.Add(q[0]);

                q = this.db.QuestionTableDetails.Select(x => x.Q6).ToList();
                this.QuestNameCombo.Items.Add(q[0]);

                q = this.db.QuestionTableDetails.Select(x => x.Q7).ToList();
                this.QuestNameCombo.Items.Add(q[0]);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var qT = this.db.QuestionTables.Select(x => x.QuestionTableName).ToList();
            var q = this.db.QuestionTableDetails.ToList();

            if (this.SurveyNameCombobox.Text == qT[0] && this.QuestNameCombo.Text ==q[0].Q1)
            {
                QT1Q1();
            }
            else if(this.SurveyNameCombobox.Text == qT[0] && this.QuestNameCombo.Text == q[0].Q2)
            {
                QT1Q2();
            }
            else if (this.SurveyNameCombobox.Text == qT[0] && this.QuestNameCombo.Text == q[0].Q3)
            {
                QT1Q3();
            }
            else if (this.SurveyNameCombobox.Text == qT[0] && this.QuestNameCombo.Text == q[0].Q4)
            {
                QT1Q4();
            }
            else if(this.SurveyNameCombobox.Text == qT[0] && this.QuestNameCombo.Text == q[0].Q5)
            {
                QT1Q5();
            }
            else if(this.SurveyNameCombobox.Text == qT[0] && this.QuestNameCombo.Text == q[0].Q6)
            {
                QT1Q6();
            }
            else if(this.SurveyNameCombobox.Text == qT[0] && this.QuestNameCombo.Text == q[0].Q7)
            {
                QT1Q7();
            }
        }

        private void QT1Q7()
        {
            var x = from q in this.db.AnswerTableDetails.AsEnumerable()
                    group q by QT1A7(q.Q7) into g
                    select new
                    {
                        回答 = g.Key,
                        總計 = g.Count(),
                    };

            this.dataGridView1.DataSource = x.ToList();
            this.chartSurvey.DataSource = x;
            this.chartSurvey.Series[0].XValueMember = "回答";
            this.chartSurvey.Series[0].YValueMembers = "總計";
            this.chartSurvey.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
        }

        private object QT1A7(string q7)
        {
            var q = this.db.QuestionTableDetails.ToList();

            if (q7 == q[0].A7_1)
            {
                return q[0].A7_1;
            }
            else if (q7 == q[0].A7_2)
            {
                return q[0].A7_2;
            }
            else if (q7 == q[0].A7_3)
            {
                return q[0].A7_3;
            }
            else if (q7 == q[0].A7_4)
            {
                return q[0].A7_4;
            }
            else
            {
                return q[0].A7_5;
            }
        }

        private void QT1Q6()
        {
            var x = from q in this.db.AnswerTableDetails.AsEnumerable()
                    group q by QT1A6(q.Q6) into g
                    select new
                    {
                        回答 = g.Key,
                        總計 = g.Count(),
                    };

            this.dataGridView1.DataSource = x.ToList();
            this.chartSurvey.DataSource = x;
            this.chartSurvey.Series[0].XValueMember = "回答";
            this.chartSurvey.Series[0].YValueMembers = "總計";
            this.chartSurvey.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
        }

        private object QT1A6(string q6)
        {
            var q = this.db.QuestionTableDetails.ToList();

            if (q6 == q[0].A6_1)
            {
                return q[0].A6_1;
            }
            else if (q6 == q[0].A6_2)
            {
                return q[0].A6_2;
            }
            else if (q6 == q[0].A6_3)
            {
                return q[0].A6_3;
            }
            else if (q6 == q[0].A6_4)
            {
                return q[0].A6_4;
            }
            else
            {
                return q[0].A6_5;
            }
        }

        private void QT1Q5()
        {

            var x = from q in this.db.AnswerTableDetails.AsEnumerable()
                    group q by QT1A5(q.Q5) into g
                    select new
                    {
                        回答 = g.Key,
                        總計 = g.Count(),
                    };

            this.dataGridView1.DataSource = x.ToList();
            this.chartSurvey.DataSource = x;
            this.chartSurvey.Series[0].XValueMember = "回答";
            this.chartSurvey.Series[0].YValueMembers = "總計";
            this.chartSurvey.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
        }

        private object QT1A5(string q5)
        {
            var q = this.db.QuestionTableDetails.ToList();

            if (q5 == q[0].A5_1)
            {
                return q[0].A5_1;
            }
            else if (q5 == q[0].A5_2)
            {
                return q[0].A5_2;
            }
            else if (q5 == q[0].A5_3)
            {
                return q[0].A5_3;
            }
            else
            {
                return q[0].A5_4;
            }
        }

        private void QT1Q4()
        {
            var x = from q in this.db.AnswerTableDetails.AsEnumerable()
                    group q by QT1A4(q.Q4) into g
                    select new
                    {
                        回答 = g.Key,
                        總計 = g.Count(),
                    };

            this.dataGridView1.DataSource = x.ToList();
            this.chartSurvey.DataSource = x;
            this.chartSurvey.Series[0].XValueMember = "回答";
            this.chartSurvey.Series[0].YValueMembers = "總計";
            this.chartSurvey.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
        }

        private object QT1A4(string q4)
        {
            var q = this.db.QuestionTableDetails.ToList();

            if (q4 == q[0].A4_1)
            {
                return q[0].A4_1;
            }
            else if (q4 == q[0].A4_2)
            {
                return q[0].A4_2;
            }
            else if (q4 == q[0].A4_3)
            {
                return q[0].A4_3;
            }
            else
            {
                return q[0].A4_4;
            }
        }

        private void QT1Q3()
        {
            var x = from q in this.db.AnswerTableDetails.AsEnumerable()
                    group q by QT1A3(q.Q4) into g
                    select new
                    {
                        回答 = g.Key,
                        總計 = g.Count(),
                    };

            this.dataGridView1.DataSource = x.ToList();
            this.chartSurvey.DataSource = x;
            this.chartSurvey.Series[0].XValueMember = "回答";
            this.chartSurvey.Series[0].YValueMembers = "總計";
            this.chartSurvey.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
        }

        private object QT1A3(string q3)
        {
            var q = this.db.QuestionTableDetails.ToList();

            if (q3 == q[0].A3_1)
            {
                return q[0].A3_1;
            }
            else if (q3 == q[0].A3_2)
            {
                return q[0].A3_2;
            }
            else if (q3 == q[0].A3_3)
            {
                return q[0].A3_3;
            }
            else if (q3 == q[0].A3_4)
            {
                return q[0].A3_4;
            }
           else if (q3 == q[0].A3_5)
            {
                return q[0].A3_5;
            }
            else if(q3 == q[0].A3_6)
            {
                return q[0].A3_6;
            }
            else
            {
                return q[0].A3_7;
            }
        }

        private void QT1Q2()
        {
            var x = from q in this.db.AnswerTableDetails.AsEnumerable()
                    group q by QT1A2(q.Q2) into g
                    select new
                    {
                        回答 = g.Key,
                        總計 = g.Count(),
                    };

            this.dataGridView1.DataSource = x.ToList();
            this.chartSurvey.DataSource = x;
            this.chartSurvey.Series[0].XValueMember = "回答";
            this.chartSurvey.Series[0].YValueMembers = "總計";
            this.chartSurvey.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
        }

        private object QT1A2(string q2)
        {
            var q = this.db.QuestionTableDetails.ToList();

            if (q2 == q[0].A2_1)
            {
                return q[0].A2_1;
            }
            else if (q2 == q[0].A2_2)
            {
                return q[0].A2_2;
            }
            else if (q2 == q[0].A2_3)
            {
                return q[0].A2_3;
            }
            else if (q2 == q[0].A2_4)
            {
                return q[0].A2_4;
            }
            else
            {
                return q[0].A2_5;
            }
        }

        private void QT1Q1()
        {
            var x = from q in this.db.AnswerTableDetails.AsEnumerable()
                    group q by QT1A1(q.Q1) into g
                    select new
                    {
                        回答 = g.Key,
                        總計 = g.Count(),
                    };

            this.dataGridView1.DataSource = x.ToList();
            this.chartSurvey.DataSource = x;
            this.chartSurvey.Series[0].XValueMember = "回答";
            this.chartSurvey.Series[0].YValueMembers = "總計";
            this.chartSurvey.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
        }
        private object QT1A1(string q1)
        {
            var q = this.db.QuestionTableDetails.ToList();

            if (q1 == q[0].A1_1)
            {
                return q[0].A1_1;
            }
            else if (q1 == q[0].A1_2)
            {
                return q[0].A1_2;
            }
            else if (q1 == q[0].A1_3)
            {
                return q[0].A1_3;
            }
            else if (q1 == q[0].A1_4)
            {
                return q[0].A1_4;
            }
            else 
            {
                return q[0].A1_5;
            }

        }
    }
}
