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
    public partial class BlackList : Form
    {
        public BlackList()
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

        private void BlackList_Load(object sender, EventArgs e)
        {            
            this.membersTableAdapter.Fill(this.coffeeDataSet.Members);
            AutoCompleteStringCollection strings = new AutoCompleteStringCollection();

            strings.AddRange(this.dbContext.Members.Select(x => x.MemberPhone).ToArray());
            this.txtSearch.AutoCompleteSource = AutoCompleteSource.CustomSource;
            this.txtSearch.AutoCompleteCustomSource = strings;
            this.txtSearch.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("確認修改資料 ?", "提醒", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    this.Validate();
                    this.membersBindingSource.EndEdit();
                    this.tableAdapterManager.UpdateAll(this.coffeeDataSet);
                    MessageBox.Show("修改資料完成!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
    }
}
