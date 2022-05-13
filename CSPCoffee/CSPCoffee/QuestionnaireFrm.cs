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
    public partial class QuestionnaireFrm : Form
    {
        CoffeeEntities1 db = new CoffeeEntities1();
        public QuestionnaireFrm()
        {
            InitializeComponent();
        }

        Form1 f1 = (Form1)Application.OpenForms["Form1"];

        private void QuestionnaireFrm_Load(object sender, EventArgs e)
        {
         
            var a = this.db.QuestionTableDetails.Select(q => q.Q1).ToList();
            
            label1.Text = $"1.{a[0]}";

            a = this.db.QuestionTableDetails.Select(q => q.A1_1).ToList();

            comboBox1.Items.Add(a[0]);

            a = this.db.QuestionTableDetails.Select(q => q.A1_2).ToList();

            comboBox1.Items.Add(a[0]);

            a = this.db.QuestionTableDetails.Select(q => q.A1_3).ToList();

            comboBox1.Items.Add(a[0]);

            a = this.db.QuestionTableDetails.Select(q => q.A1_4).ToList();

            comboBox1.Items.Add(a[0]);

            a = this.db.QuestionTableDetails.Select(q => q.Q2).ToList();

            label2.Text = $"2.{a[0]}";

            a = this.db.QuestionTableDetails.Select(q => q.A2_1).ToList();

            comboBox2.Items.Add(a[0]);

            a = this.db.QuestionTableDetails.Select(q => q.A2_2).ToList();

            comboBox2.Items.Add(a[0]);

            a = this.db.QuestionTableDetails.Select(q => q.A2_3).ToList();

            comboBox2.Items.Add(a[0]);

            a = this.db.QuestionTableDetails.Select(q => q.A2_4).ToList();

            comboBox2.Items.Add(a[0]);

            a = this.db.QuestionTableDetails.Select(q => q.A2_5).ToList();

            comboBox2.Items.Add(a[0]);

            a = this.db.QuestionTableDetails.Select(q => q.Q3).ToList();

            label3.Text = $"3.{a[0]}";

            a = this.db.QuestionTableDetails.Select(q => q.A3_1).ToList();

            comboBox3.Items.Add(a[0]);

            a = this.db.QuestionTableDetails.Select(q => q.A3_2).ToList();

            comboBox3.Items.Add(a[0]);

            a = this.db.QuestionTableDetails.Select(q => q.A3_3).ToList();

            comboBox3.Items.Add(a[0]);


            a = this.db.QuestionTableDetails.Select(q => q.A3_4).ToList();

            comboBox3.Items.Add(a[0]);


            a = this.db.QuestionTableDetails.Select(q => q.A3_5).ToList();

            comboBox3.Items.Add(a[0]);


            a = this.db.QuestionTableDetails.Select(q => q.A3_6).ToList();

            comboBox3.Items.Add(a[0]);

            a = this.db.QuestionTableDetails.Select(q => q.A3_7).ToList();

            comboBox3.Items.Add(a[0]);

            a = this.db.QuestionTableDetails.Select(q => q.Q4).ToList();

            label4.Text = $"4.{a[0]}";

            a = this.db.QuestionTableDetails.Select(q => q.A4_1).ToList();

            comboBox4.Items.Add(a[0]);

            a = this.db.QuestionTableDetails.Select(q => q.A4_2).ToList();

            comboBox4.Items.Add(a[0]);

            a = this.db.QuestionTableDetails.Select(q => q.A4_3).ToList();

            comboBox4.Items.Add(a[0]);

            a = this.db.QuestionTableDetails.Select(q => q.A4_4).ToList();

            comboBox4.Items.Add(a[0]);

            a = this.db.QuestionTableDetails.Select(q => q.Q5).ToList();

            label5.Text = $"5.{a[0]}";

            a = this.db.QuestionTableDetails.Select(q => q.A5_1).ToList();

            comboBox5.Items.Add(a[0]);

            a = this.db.QuestionTableDetails.Select(q => q.A5_2).ToList();

            comboBox5.Items.Add(a[0]);

            a = this.db.QuestionTableDetails.Select(q => q.A5_3).ToList();

            comboBox5.Items.Add(a[0]);

            a = this.db.QuestionTableDetails.Select(q => q.A5_4).ToList();

            comboBox5.Items.Add(a[0]);

            a = this.db.QuestionTableDetails.Select(q => q.Q6).ToList();

            label6.Text = $"6.{a[0]}";

            a = this.db.QuestionTableDetails.Select(q => q.A6_1).ToList();

            comboBox6.Items.Add(a[0]);

            a = this.db.QuestionTableDetails.Select(q => q.A6_2).ToList();

            comboBox6.Items.Add(a[0]);


            a = this.db.QuestionTableDetails.Select(q => q.A6_3).ToList();

            comboBox6.Items.Add(a[0]);


            a = this.db.QuestionTableDetails.Select(q => q.A6_4).ToList();

            comboBox6.Items.Add(a[0]);


            a = this.db.QuestionTableDetails.Select(q => q.A6_5).ToList();

            comboBox6.Items.Add(a[0]);

            a = this.db.QuestionTableDetails.Select(q => q.Q7).ToList();

            label7.Text = $"7.{a[0]}";

            a = this.db.QuestionTableDetails.Select(q => q.A7_1).ToList();

            comboBox7.Items.Add(a[0]);

            a = this.db.QuestionTableDetails.Select(q => q.A7_2).ToList();

            comboBox7.Items.Add(a[0]);


            a = this.db.QuestionTableDetails.Select(q => q.A7_3).ToList();

            comboBox7.Items.Add(a[0]);


            a = this.db.QuestionTableDetails.Select(q => q.A7_4).ToList();

            comboBox7.Items.Add(a[0]);


            a = this.db.QuestionTableDetails.Select(q => q.A7_5).ToList();

            comboBox7.Items.Add(a[0]);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(this.comboBox1.Text == string.Empty)
            {
                MessageBox.Show("第一題尚未選擇");
            }
            else if(this.comboBox2.Text == string.Empty)
            {
                MessageBox.Show("第二題尚未選擇");
            }
            else if (this.comboBox3.Text == string.Empty)
            {
                MessageBox.Show("第三題尚未選擇");
            }
            else if (this.comboBox4.Text == string.Empty)
            {
                MessageBox.Show("第四題尚未選擇");
            }
            else if (this.comboBox5.Text == string.Empty)
            {
                MessageBox.Show("第五題尚未選擇");
            }
            else if (this.comboBox6.Text == string.Empty)
            {
                MessageBox.Show("第六題尚未選擇");
            }
            else if (this.comboBox7.Text == string.Empty)
            {
                MessageBox.Show("第七題尚未選擇");
            }
            else
            {
                AnswerTableDetail answer = new AnswerTableDetail
                {
                    QuestionTableDetailsID=1,
                    Q1 = this.comboBox1.Text,
                    Q2 = this.comboBox2.Text,
                    Q3 = this.comboBox3.Text,
                    Q4 = this.comboBox4.Text,
                    Q5 = this.comboBox5.Text,
                    Q6 = this.comboBox6.Text,
                    Q7 = this.comboBox7.Text
                };

                if (f1.memberID != 0)
                {
                    var q = this.db.CouponDetails.Any(x => x.MemberID == f1.memberID && x.CouponID == 3);

                    if (q)
                    {
                        MessageBox.Show("您已領取過優惠券");
                        this.Close();
                        return;
                    }
                    else
                    {
                        CouponDetail coupon = new CouponDetail
                        {
                            CouponID = 3,
                            MemberID = f1.memberID
                        };

                        this.db.CouponDetails.Add(coupon);
                        MessageBox.Show("問卷已送出感謝您的填寫!! 已經優惠券發放給您");
                    }
                }
                else
                {
                    MessageBox.Show("問卷已送出感謝您的填寫!!");
                }

                this.db.AnswerTableDetails.Add(answer);

                this.db.SaveChanges();

                

                this.Close();
            }
        }
    }
}
