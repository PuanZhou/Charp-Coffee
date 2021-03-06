
namespace CSPCoffee
{
    partial class CoReControl
    {
        /// <summary> 
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 元件設計工具產生的程式碼

        /// <summary> 
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.labName = new System.Windows.Forms.Label();
            this.labCom = new System.Windows.Forms.Label();
            this.btnReply = new System.Windows.Forms.Button();
            this.txtSend = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labName
            // 
            this.labName.AutoSize = true;
            this.labName.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labName.Location = new System.Drawing.Point(3, 5);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(55, 20);
            this.labName.TabIndex = 9;
            this.labName.Text = "Name";
            // 
            // labCom
            // 
            this.labCom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labCom.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labCom.Location = new System.Drawing.Point(3, 30);
            this.labCom.Name = "labCom";
            this.labCom.Size = new System.Drawing.Size(521, 62);
            this.labCom.TabIndex = 15;
            this.labCom.Text = "Comment";
            // 
            // btnReply
            // 
            this.btnReply.Location = new System.Drawing.Point(3, 97);
            this.btnReply.Name = "btnReply";
            this.btnReply.Size = new System.Drawing.Size(133, 23);
            this.btnReply.TabIndex = 12;
            this.btnReply.Text = "對這則留言發表意見";
            this.btnReply.UseVisualStyleBackColor = true;
            this.btnReply.Click += new System.EventHandler(this.btnReply_Click);
            // 
            // txtSend
            // 
            this.txtSend.Location = new System.Drawing.Point(3, 98);
            this.txtSend.Name = "txtSend";
            this.txtSend.Size = new System.Drawing.Size(419, 22);
            this.txtSend.TabIndex = 16;
            this.txtSend.Visible = false;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(424, 96);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(49, 24);
            this.btnSend.TabIndex = 17;
            this.btnSend.Text = "送出";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Visible = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(475, 96);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(49, 24);
            this.btnCancel.TabIndex = 18;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // CoReControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtSend);
            this.Controls.Add(this.labCom);
            this.Controls.Add(this.btnReply);
            this.Controls.Add(this.labName);
            this.Name = "CoReControl";
            this.Size = new System.Drawing.Size(531, 125);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.Label labCom;
        private System.Windows.Forms.Button btnReply;
        public System.Windows.Forms.TextBox txtSend;
        public System.Windows.Forms.Button btnSend;
        public System.Windows.Forms.Button btnCancel;
    }
}
