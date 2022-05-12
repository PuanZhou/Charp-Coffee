namespace CSPCoffee
{
    partial class FrmComment
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
            this.cbbProID = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnReply = new System.Windows.Forms.Button();
            this.labName = new System.Windows.Forms.Label();
            this.labDate = new System.Windows.Forms.Label();
            this.labRank = new System.Windows.Forms.Label();
            this.labCom = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbbProID
            // 
            this.cbbProID.FormattingEnabled = true;
            this.cbbProID.Location = new System.Drawing.Point(603, 39);
            this.cbbProID.Name = "cbbProID";
            this.cbbProID.Size = new System.Drawing.Size(121, 20);
            this.cbbProID.TabIndex = 1;
            this.cbbProID.SelectedIndexChanged += new System.EventHandler(this.cbbProID_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(601, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "測試用：請選產品名";
            // 
            // btnReply
            // 
            this.btnReply.Location = new System.Drawing.Point(57, 153);
            this.btnReply.Name = "btnReply";
            this.btnReply.Size = new System.Drawing.Size(75, 23);
            this.btnReply.TabIndex = 6;
            this.btnReply.Text = "回覆";
            this.btnReply.UseVisualStyleBackColor = true;
            this.btnReply.Click += new System.EventHandler(this.btnReply_Click);
            // 
            // labName
            // 
            this.labName.AutoSize = true;
            this.labName.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labName.Location = new System.Drawing.Point(57, 13);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(55, 20);
            this.labName.TabIndex = 8;
            this.labName.Text = "Name";
            // 
            // labDate
            // 
            this.labDate.AutoSize = true;
            this.labDate.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labDate.Location = new System.Drawing.Point(57, 39);
            this.labDate.Name = "labDate";
            this.labDate.Size = new System.Drawing.Size(45, 20);
            this.labDate.TabIndex = 9;
            this.labDate.Text = "Date";
            // 
            // labRank
            // 
            this.labRank.AutoSize = true;
            this.labRank.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labRank.Location = new System.Drawing.Point(348, 39);
            this.labRank.Name = "labRank";
            this.labRank.Size = new System.Drawing.Size(47, 20);
            this.labRank.TabIndex = 10;
            this.labRank.Text = "Rank";
            // 
            // labCom
            // 
            this.labCom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labCom.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labCom.Location = new System.Drawing.Point(57, 59);
            this.labCom.Name = "labCom";
            this.labCom.Size = new System.Drawing.Size(419, 91);
            this.labCom.TabIndex = 11;
            this.labCom.Text = "Comment";
            // 
            // FrmComment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(756, 692);
            this.Controls.Add(this.labCom);
            this.Controls.Add(this.labRank);
            this.Controls.Add(this.labDate);
            this.Controls.Add(this.labName);
            this.Controls.Add(this.btnReply);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbbProID);
            this.Name = "FrmComment";
            this.Text = "FrmComment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbbProID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnReply;
        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.Label labDate;
        private System.Windows.Forms.Label labRank;
        private System.Windows.Forms.Label labCom;
    }
}