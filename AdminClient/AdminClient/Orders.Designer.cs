
namespace AdminClient
{
    partial class Orders
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewOrders = new System.Windows.Forms.DataGridView();
            this.labTitle = new System.Windows.Forms.Label();
            this.grpSearch = new System.Windows.Forms.GroupBox();
            this.btnDeleteCancelledOrders = new System.Windows.Forms.Button();
            this.btnSelectAllOrders = new System.Windows.Forms.Button();
            this.btnSearchOrderID = new System.Windows.Forms.Button();
            this.txtSearchOrderID = new System.Windows.Forms.TextBox();
            this.labSearchOrderID = new System.Windows.Forms.Label();
            this.btnRevise = new System.Windows.Forms.Button();
            this.cbxReviseState = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearchOrderState = new System.Windows.Forms.Button();
            this.cbxOrderState = new System.Windows.Forms.ComboBox();
            this.labOrderState = new System.Windows.Forms.Label();
            this.labDate = new System.Windows.Forms.Label();
            this.btnSearchOrderDate = new System.Windows.Forms.Button();
            this.labMonth = new System.Windows.Forms.Label();
            this.cbxMonth = new System.Windows.Forms.ComboBox();
            this.labYear = new System.Windows.Forms.Label();
            this.cbxYear = new System.Windows.Forms.ComboBox();
            this.grpOrderDetails = new System.Windows.Forms.GroupBox();
            this.dataGridViewOrderDetails = new System.Windows.Forms.DataGridView();
            this.pictureBoxProduct = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).BeginInit();
            this.grpSearch.SuspendLayout();
            this.grpOrderDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrderDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProduct)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewOrders
            // 
            this.dataGridViewOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Tan;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewOrders.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Linen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.BurlyWood;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewOrders.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewOrders.Location = new System.Drawing.Point(6, 110);
            this.dataGridViewOrders.Name = "dataGridViewOrders";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Linen;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Tan;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewOrders.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewOrders.RowTemplate.Height = 40;
            this.dataGridViewOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewOrders.Size = new System.Drawing.Size(787, 449);
            this.dataGridViewOrders.TabIndex = 0;
            this.dataGridViewOrders.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewOrders_CellClick);
            // 
            // labTitle
            // 
            this.labTitle.AutoSize = true;
            this.labTitle.Font = new System.Drawing.Font("微軟正黑體", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labTitle.Location = new System.Drawing.Point(885, 9);
            this.labTitle.Name = "labTitle";
            this.labTitle.Size = new System.Drawing.Size(133, 37);
            this.labTitle.TabIndex = 23;
            this.labTitle.Text = "訂單管理";
            // 
            // grpSearch
            // 
            this.grpSearch.Controls.Add(this.btnDeleteCancelledOrders);
            this.grpSearch.Controls.Add(this.btnSelectAllOrders);
            this.grpSearch.Controls.Add(this.btnSearchOrderID);
            this.grpSearch.Controls.Add(this.txtSearchOrderID);
            this.grpSearch.Controls.Add(this.labSearchOrderID);
            this.grpSearch.Controls.Add(this.btnRevise);
            this.grpSearch.Controls.Add(this.cbxReviseState);
            this.grpSearch.Controls.Add(this.label1);
            this.grpSearch.Controls.Add(this.btnSearchOrderState);
            this.grpSearch.Controls.Add(this.cbxOrderState);
            this.grpSearch.Controls.Add(this.labOrderState);
            this.grpSearch.Controls.Add(this.labDate);
            this.grpSearch.Controls.Add(this.btnSearchOrderDate);
            this.grpSearch.Controls.Add(this.labMonth);
            this.grpSearch.Controls.Add(this.cbxMonth);
            this.grpSearch.Controls.Add(this.labYear);
            this.grpSearch.Controls.Add(this.cbxYear);
            this.grpSearch.Controls.Add(this.dataGridViewOrders);
            this.grpSearch.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.grpSearch.Location = new System.Drawing.Point(33, 49);
            this.grpSearch.Name = "grpSearch";
            this.grpSearch.Size = new System.Drawing.Size(821, 602);
            this.grpSearch.TabIndex = 24;
            this.grpSearch.TabStop = false;
            this.grpSearch.Text = "查詢訂單";
            // 
            // btnDeleteCancelledOrders
            // 
            this.btnDeleteCancelledOrders.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteCancelledOrders.Location = new System.Drawing.Point(86, 567);
            this.btnDeleteCancelledOrders.Name = "btnDeleteCancelledOrders";
            this.btnDeleteCancelledOrders.Size = new System.Drawing.Size(149, 29);
            this.btnDeleteCancelledOrders.TabIndex = 18;
            this.btnDeleteCancelledOrders.Text = "清除已取消訂單";
            this.btnDeleteCancelledOrders.UseVisualStyleBackColor = true;
            this.btnDeleteCancelledOrders.Click += new System.EventHandler(this.btnDeleteCancelledOrders_Click);
            // 
            // btnSelectAllOrders
            // 
            this.btnSelectAllOrders.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSelectAllOrders.Location = new System.Drawing.Point(645, 28);
            this.btnSelectAllOrders.Name = "btnSelectAllOrders";
            this.btnSelectAllOrders.Size = new System.Drawing.Size(147, 29);
            this.btnSelectAllOrders.TabIndex = 17;
            this.btnSelectAllOrders.Text = "所有訂單";
            this.btnSelectAllOrders.UseVisualStyleBackColor = true;
            this.btnSelectAllOrders.Click += new System.EventHandler(this.btnSelectAllOrders_Click);
            // 
            // btnSearchOrderID
            // 
            this.btnSearchOrderID.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchOrderID.Location = new System.Drawing.Point(227, 37);
            this.btnSearchOrderID.Name = "btnSearchOrderID";
            this.btnSearchOrderID.Size = new System.Drawing.Size(99, 29);
            this.btnSearchOrderID.TabIndex = 16;
            this.btnSearchOrderID.Text = "查詢";
            this.btnSearchOrderID.UseVisualStyleBackColor = true;
            this.btnSearchOrderID.Click += new System.EventHandler(this.btnSearchOrderID_Click);
            // 
            // txtSearchOrderID
            // 
            this.txtSearchOrderID.Location = new System.Drawing.Point(126, 38);
            this.txtSearchOrderID.Name = "txtSearchOrderID";
            this.txtSearchOrderID.Size = new System.Drawing.Size(91, 29);
            this.txtSearchOrderID.TabIndex = 15;
            // 
            // labSearchOrderID
            // 
            this.labSearchOrderID.AutoSize = true;
            this.labSearchOrderID.Location = new System.Drawing.Point(39, 41);
            this.labSearchOrderID.Name = "labSearchOrderID";
            this.labSearchOrderID.Size = new System.Drawing.Size(81, 20);
            this.labSearchOrderID.TabIndex = 14;
            this.labSearchOrderID.Text = "訂單編號 :";
            // 
            // btnRevise
            // 
            this.btnRevise.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRevise.Location = new System.Drawing.Point(693, 567);
            this.btnRevise.Name = "btnRevise";
            this.btnRevise.Size = new System.Drawing.Size(99, 29);
            this.btnRevise.TabIndex = 12;
            this.btnRevise.Text = "確認修改";
            this.btnRevise.UseVisualStyleBackColor = true;
            this.btnRevise.Click += new System.EventHandler(this.btnRevise_Click);
            // 
            // cbxReviseState
            // 
            this.cbxReviseState.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbxReviseState.FormattingEnabled = true;
            this.cbxReviseState.Location = new System.Drawing.Point(596, 570);
            this.cbxReviseState.Name = "cbxReviseState";
            this.cbxReviseState.Size = new System.Drawing.Size(91, 25);
            this.cbxReviseState.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(461, 571);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "修改訂單狀態為 :";
            // 
            // btnSearchOrderState
            // 
            this.btnSearchOrderState.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchOrderState.Location = new System.Drawing.Point(694, 77);
            this.btnSearchOrderState.Name = "btnSearchOrderState";
            this.btnSearchOrderState.Size = new System.Drawing.Size(99, 29);
            this.btnSearchOrderState.TabIndex = 9;
            this.btnSearchOrderState.Text = "查詢";
            this.btnSearchOrderState.UseVisualStyleBackColor = true;
            this.btnSearchOrderState.Click += new System.EventHandler(this.btnSearchOrderState_Click);
            // 
            // cbxOrderState
            // 
            this.cbxOrderState.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbxOrderState.FormattingEnabled = true;
            this.cbxOrderState.Location = new System.Drawing.Point(597, 81);
            this.cbxOrderState.Name = "cbxOrderState";
            this.cbxOrderState.Size = new System.Drawing.Size(91, 25);
            this.cbxOrderState.TabIndex = 8;
            // 
            // labOrderState
            // 
            this.labOrderState.AutoSize = true;
            this.labOrderState.Location = new System.Drawing.Point(490, 82);
            this.labOrderState.Name = "labOrderState";
            this.labOrderState.Size = new System.Drawing.Size(101, 20);
            this.labOrderState.TabIndex = 7;
            this.labOrderState.Text = "依訂單狀態 : ";
            // 
            // labDate
            // 
            this.labDate.AutoSize = true;
            this.labDate.Location = new System.Drawing.Point(7, 81);
            this.labDate.Name = "labDate";
            this.labDate.Size = new System.Drawing.Size(113, 20);
            this.labDate.TabIndex = 6;
            this.labDate.Text = "選擇查詢日期 :";
            // 
            // btnSearchOrderDate
            // 
            this.btnSearchOrderDate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchOrderDate.Location = new System.Drawing.Point(382, 77);
            this.btnSearchOrderDate.Name = "btnSearchOrderDate";
            this.btnSearchOrderDate.Size = new System.Drawing.Size(99, 29);
            this.btnSearchOrderDate.TabIndex = 5;
            this.btnSearchOrderDate.Text = "查詢";
            this.btnSearchOrderDate.UseVisualStyleBackColor = true;
            this.btnSearchOrderDate.Click += new System.EventHandler(this.btnSearchOrderDate_Click);
            // 
            // labMonth
            // 
            this.labMonth.AutoSize = true;
            this.labMonth.Location = new System.Drawing.Point(351, 84);
            this.labMonth.Name = "labMonth";
            this.labMonth.Size = new System.Drawing.Size(25, 20);
            this.labMonth.TabIndex = 4;
            this.labMonth.Text = "月";
            // 
            // cbxMonth
            // 
            this.cbxMonth.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxMonth.FormattingEnabled = true;
            this.cbxMonth.Location = new System.Drawing.Point(254, 82);
            this.cbxMonth.Name = "cbxMonth";
            this.cbxMonth.Size = new System.Drawing.Size(91, 23);
            this.cbxMonth.TabIndex = 3;
            this.cbxMonth.Text = "/";
            // 
            // labYear
            // 
            this.labYear.AutoSize = true;
            this.labYear.Location = new System.Drawing.Point(223, 84);
            this.labYear.Name = "labYear";
            this.labYear.Size = new System.Drawing.Size(25, 20);
            this.labYear.TabIndex = 2;
            this.labYear.Text = "年";
            // 
            // cbxYear
            // 
            this.cbxYear.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxYear.FormattingEnabled = true;
            this.cbxYear.Location = new System.Drawing.Point(126, 82);
            this.cbxYear.Name = "cbxYear";
            this.cbxYear.Size = new System.Drawing.Size(91, 23);
            this.cbxYear.TabIndex = 1;
            // 
            // grpOrderDetails
            // 
            this.grpOrderDetails.Controls.Add(this.dataGridViewOrderDetails);
            this.grpOrderDetails.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.grpOrderDetails.Location = new System.Drawing.Point(860, 115);
            this.grpOrderDetails.Name = "grpOrderDetails";
            this.grpOrderDetails.Size = new System.Drawing.Size(495, 505);
            this.grpOrderDetails.TabIndex = 25;
            this.grpOrderDetails.TabStop = false;
            this.grpOrderDetails.Text = "訂單明細";
            // 
            // dataGridViewOrderDetails
            // 
            this.dataGridViewOrderDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Tan;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewOrderDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewOrderDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Linen;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.BurlyWood;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewOrderDetails.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewOrderDetails.Location = new System.Drawing.Point(12, 44);
            this.dataGridViewOrderDetails.Name = "dataGridViewOrderDetails";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Linen;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Tan;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewOrderDetails.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewOrderDetails.RowTemplate.Height = 40;
            this.dataGridViewOrderDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewOrderDetails.Size = new System.Drawing.Size(483, 449);
            this.dataGridViewOrderDetails.TabIndex = 1;
            this.dataGridViewOrderDetails.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewOrderDetails_CellClick);
            // 
            // pictureBoxProduct
            // 
            this.pictureBoxProduct.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxProduct.Location = new System.Drawing.Point(6, 44);
            this.pictureBoxProduct.Name = "pictureBoxProduct";
            this.pictureBoxProduct.Size = new System.Drawing.Size(373, 384);
            this.pictureBoxProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxProduct.TabIndex = 26;
            this.pictureBoxProduct.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBoxProduct);
            this.groupBox1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.Location = new System.Drawing.Point(1361, 115);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(385, 434);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "產品圖片";
            // 
            // Orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(1888, 702);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpOrderDetails);
            this.Controls.Add(this.grpSearch);
            this.Controls.Add(this.labTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Orders";
            this.Text = "Orders";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders)).EndInit();
            this.grpSearch.ResumeLayout(false);
            this.grpSearch.PerformLayout();
            this.grpOrderDetails.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrderDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProduct)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewOrders;
        private System.Windows.Forms.Label labTitle;
        private System.Windows.Forms.GroupBox grpSearch;
        private System.Windows.Forms.Label labMonth;
        private System.Windows.Forms.ComboBox cbxMonth;
        private System.Windows.Forms.Label labYear;
        private System.Windows.Forms.ComboBox cbxYear;
        private System.Windows.Forms.Button btnSearchOrderState;
        private System.Windows.Forms.ComboBox cbxOrderState;
        private System.Windows.Forms.Label labOrderState;
        private System.Windows.Forms.Label labDate;
        private System.Windows.Forms.Button btnSearchOrderDate;
        private System.Windows.Forms.Button btnRevise;
        private System.Windows.Forms.ComboBox cbxReviseState;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labSearchOrderID;
        private System.Windows.Forms.Button btnSearchOrderID;
        private System.Windows.Forms.TextBox txtSearchOrderID;
        private System.Windows.Forms.Button btnSelectAllOrders;
        private System.Windows.Forms.GroupBox grpOrderDetails;
        private System.Windows.Forms.DataGridView dataGridViewOrderDetails;
        private System.Windows.Forms.Button btnDeleteCancelledOrders;
        private System.Windows.Forms.PictureBox pictureBoxProduct;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}