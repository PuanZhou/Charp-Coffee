using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace AdminClient
{
    public partial class Members : Form
    {
        public Members()
        {
            InitializeComponent();
        }

        private void membersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.membersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.coffeeDataSet);            
        }

        CoffeeEntities dbContext = new CoffeeEntities();

        private void Members_Load(object sender, EventArgs e)
        {
            this.membersTableAdapter.Fill(this.coffeeDataSet.Members);
            UpdateValidCode();

            AutoCompleteStringCollection strings = new AutoCompleteStringCollection();

            strings.AddRange(this.dbContext.Members.Select(x => x.MemberPhone).ToArray());
            this.txtSearch.AutoCompleteSource = AutoCompleteSource.CustomSource;
            this.txtSearch.AutoCompleteCustomSource = strings;
            this.txtSearch.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!(txtSearch.Text.Trim() == ""))
            {
                string memberPhone = txtSearch.Text;
                this.membersTableAdapter.FillByMemberPhone(this.coffeeDataSet.Members, memberPhone);

                if (membersDataGridView.Rows.Count == 0)
                {
                    MessageBox.Show("查無此號");
                    this.membersTableAdapter.Fill(this.coffeeDataSet.Members);
                    this.txtSearch.Clear();
                    this.txtSearch.Select();
                }
            }
            else
            {
                this.membersTableAdapter.Fill(this.coffeeDataSet.Members);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //string validCode = this.txtValidCode.Text;

            //char[] chars1 = validCode.ToCharArray();
            //char[] chars2 = strValidCode.ToCharArray();
            //int alphabet = 0;
            //int number = 0;

            //if (String.IsNullOrEmpty(validCode) != true)
            //{
            //    for (int i = 0; i < strValidCode.Length; i++)
            //    {
            //        if((chars1[i] >= 'a'&& chars1[i] <= 'z') || (chars1[i] >= 'A' && chars1[i] <= 'Z'))
            //        {
            //            if(chars1[i] == chars2[i])
            //            {
            //                alphabet++;
            //            }
            //        }
            //        else
            //        {
            //            if (chars1[i] == chars2[i])
            //            {
            //                number++;
            //            }
            //        }
            //    }

            //    int CodeCount = alphabet + number;
            //    if(CodeCount == strValidCode.Length)
            //    {
            //        try
            //        {
            //            if (MessageBox.Show("確認刪除、修改資料 ?", "提醒", MessageBoxButtons.OKCancel) == DialogResult.OK)
            //            {
            //                this.Validate();
            //                this.membersBindingSource.EndEdit();
            //                this.tableAdapterManager.UpdateAll(this.coffeeDataSet);
            //                MessageBox.Show("修改資料完成!");
            //                UpdateValidCode();
            //                txtValidCode.Text = "";
            //            }
            //        }
            //        catch (Exception ex)
            //        {
            //            MessageBox.Show(ex.Message);
            //        }
            //}

            //    else
            //    {
            //        MessageBox.Show("驗證碼錯誤", "提醒", MessageBoxButtons.OK);
            //        UpdateValidCode();
            //        txtValidCode.Text = "";
            //        txtValidCode.Focus();
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("驗證碼不能為空", "提醒", MessageBoxButtons.OK);
            //    UpdateValidCode();
            //    txtValidCode.Text = "";
            //    txtValidCode.Focus();
            //}

            string validCode = this.txtValidCode.Text.Trim();
            if (String.IsNullOrEmpty(validCode) != true)
            {
                if (validCode.ToLower() == strValidCode.ToLower())
                {
                    try
                    {
                        if (MessageBox.Show("確認刪除、修改資料 ?", "提醒", MessageBoxButtons.OKCancel) == DialogResult.OK)
                        {
                            this.Validate();
                            this.membersBindingSource.EndEdit();
                            this.tableAdapterManager.UpdateAll(this.coffeeDataSet);
                            MessageBox.Show("修改資料完成!");
                            UpdateValidCode();
                            txtValidCode.Text = "";
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("驗證碼錯誤", "提醒", MessageBoxButtons.OK);
                    UpdateValidCode();
                    txtValidCode.Text = "";
                    txtValidCode.Focus();
                }
            }
            else
            {
                MessageBox.Show("驗證碼不能為空", "提醒", MessageBoxButtons.OK);
                UpdateValidCode();
                txtValidCode.Text = "";
                txtValidCode.Focus();
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            DialogResult result = this.openFileDialogPhoto.ShowDialog();

            if (result == DialogResult.OK)
            {
                this.memberPhotoPictureBox.Image = Image.FromFile(this.openFileDialogPhoto.FileName);
            }
        }

        private void btnClearPhoto_Click(object sender, EventArgs e)
        {
            this.memberPhotoPictureBox.Image = null;
        }

        private const int ValidCodeLength = 4;
        private string strValidCode = "";

        private void UpdateValidCode()
        {
            strValidCode = 驗證碼.CreateRandomCode(ValidCodeLength);
            if (strValidCode == "")
                return;
            驗證碼.CreatImage(strValidCode, pictureBoxValidCode);
        }

        private void labChangeValidCode_Click(object sender, EventArgs e)
        {
            UpdateValidCode();
        }
    }
}
