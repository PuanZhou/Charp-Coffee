
namespace CSPCoffee
{
    partial class CouponControl1
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
            this.spC1 = new System.Windows.Forms.SplitContainer();
            this.tLayPMoney = new System.Windows.Forms.TableLayoutPanel();
            this.labMoney = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labCon = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.spC2 = new System.Windows.Forms.SplitContainer();
            this.labCouName = new System.Windows.Forms.Label();
            this.tLayPTime = new System.Windows.Forms.TableLayoutPanel();
            this.labto = new System.Windows.Forms.Label();
            this.labEnd = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labStart = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.spC1)).BeginInit();
            this.spC1.Panel1.SuspendLayout();
            this.spC1.Panel2.SuspendLayout();
            this.spC1.SuspendLayout();
            this.tLayPMoney.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spC2)).BeginInit();
            this.spC2.Panel1.SuspendLayout();
            this.spC2.Panel2.SuspendLayout();
            this.spC2.SuspendLayout();
            this.tLayPTime.SuspendLayout();
            this.SuspendLayout();
            // 
            // spC1
            // 
            this.spC1.BackColor = System.Drawing.Color.White;
            this.spC1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spC1.IsSplitterFixed = true;
            this.spC1.Location = new System.Drawing.Point(0, 0);
            this.spC1.Name = "spC1";
            this.spC1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // spC1.Panel1
            // 
            this.spC1.Panel1.Controls.Add(this.tLayPMoney);
            // 
            // spC1.Panel2
            // 
            this.spC1.Panel2.Controls.Add(this.spC2);
            this.spC1.Size = new System.Drawing.Size(341, 188);
            this.spC1.SplitterDistance = 49;
            this.spC1.TabIndex = 0;
            // 
            // tLayPMoney
            // 
            this.tLayPMoney.BackColor = System.Drawing.Color.Peru;
            this.tLayPMoney.ColumnCount = 4;
            this.tLayPMoney.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.63636F));
            this.tLayPMoney.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.36364F));
            this.tLayPMoney.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.64F));
            this.tLayPMoney.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.36F));
            this.tLayPMoney.Controls.Add(this.labMoney, 3, 0);
            this.tLayPMoney.Controls.Add(this.label3, 2, 0);
            this.tLayPMoney.Controls.Add(this.labCon, 1, 0);
            this.tLayPMoney.Controls.Add(this.label1, 0, 0);
            this.tLayPMoney.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tLayPMoney.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tLayPMoney.Location = new System.Drawing.Point(0, 0);
            this.tLayPMoney.Name = "tLayPMoney";
            this.tLayPMoney.RowCount = 1;
            this.tLayPMoney.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tLayPMoney.Size = new System.Drawing.Size(341, 49);
            this.tLayPMoney.TabIndex = 1;
            // 
            // labMoney
            // 
            this.labMoney.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labMoney.Location = new System.Drawing.Point(219, 0);
            this.labMoney.Name = "labMoney";
            this.labMoney.Size = new System.Drawing.Size(119, 49);
            this.labMoney.TabIndex = 3;
            this.labMoney.Text = "label4";
            this.labMoney.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(173, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 49);
            this.label3.TabIndex = 2;
            this.label3.Text = "送";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labCon
            // 
            this.labCon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labCon.Location = new System.Drawing.Point(49, 0);
            this.labCon.Name = "labCon";
            this.labCon.Size = new System.Drawing.Size(118, 49);
            this.labCon.TabIndex = 1;
            this.labCon.Text = "label2";
            this.labCon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 49);
            this.label1.TabIndex = 0;
            this.label1.Text = "滿";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // spC2
            // 
            this.spC2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spC2.IsSplitterFixed = true;
            this.spC2.Location = new System.Drawing.Point(0, 0);
            this.spC2.Name = "spC2";
            this.spC2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // spC2.Panel1
            // 
            this.spC2.Panel1.Controls.Add(this.labCouName);
            // 
            // spC2.Panel2
            // 
            this.spC2.Panel2.Controls.Add(this.tLayPTime);
            this.spC2.Size = new System.Drawing.Size(341, 135);
            this.spC2.SplitterDistance = 80;
            this.spC2.TabIndex = 0;
            // 
            // labCouName
            // 
            this.labCouName.BackColor = System.Drawing.Color.Pink;
            this.labCouName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labCouName.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labCouName.Location = new System.Drawing.Point(0, 0);
            this.labCouName.Name = "labCouName";
            this.labCouName.Size = new System.Drawing.Size(341, 80);
            this.labCouName.TabIndex = 0;
            this.labCouName.Text = "母親節";
            this.labCouName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tLayPTime
            // 
            this.tLayPTime.BackColor = System.Drawing.Color.Peru;
            this.tLayPTime.ColumnCount = 4;
            this.tLayPTime.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tLayPTime.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tLayPTime.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tLayPTime.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tLayPTime.Controls.Add(this.labto, 0, 0);
            this.tLayPTime.Controls.Add(this.labEnd, 0, 0);
            this.tLayPTime.Controls.Add(this.label6, 0, 0);
            this.tLayPTime.Controls.Add(this.labStart, 0, 0);
            this.tLayPTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tLayPTime.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tLayPTime.Location = new System.Drawing.Point(0, 0);
            this.tLayPTime.Name = "tLayPTime";
            this.tLayPTime.RowCount = 1;
            this.tLayPTime.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tLayPTime.Size = new System.Drawing.Size(341, 51);
            this.tLayPTime.TabIndex = 0;
            // 
            // labto
            // 
            this.labto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labto.Location = new System.Drawing.Point(173, 0);
            this.labto.Name = "labto";
            this.labto.Size = new System.Drawing.Size(62, 51);
            this.labto.TabIndex = 4;
            this.labto.Text = "~";
            this.labto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labEnd
            // 
            this.labEnd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labEnd.Location = new System.Drawing.Point(241, 0);
            this.labEnd.Name = "labEnd";
            this.labEnd.Size = new System.Drawing.Size(97, 51);
            this.labEnd.TabIndex = 3;
            this.labEnd.Text = "label7";
            this.labEnd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 51);
            this.label6.TabIndex = 2;
            this.label6.Text = "期限：";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labStart
            // 
            this.labStart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labStart.Location = new System.Drawing.Point(71, 0);
            this.labStart.Name = "labStart";
            this.labStart.Size = new System.Drawing.Size(96, 51);
            this.labStart.TabIndex = 1;
            this.labStart.Text = "label5";
            this.labStart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CouponControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.spC1);
            this.Name = "CouponControl1";
            this.Size = new System.Drawing.Size(341, 188);
            this.spC1.Panel1.ResumeLayout(false);
            this.spC1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spC1)).EndInit();
            this.spC1.ResumeLayout(false);
            this.tLayPMoney.ResumeLayout(false);
            this.spC2.Panel1.ResumeLayout(false);
            this.spC2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spC2)).EndInit();
            this.spC2.ResumeLayout(false);
            this.tLayPTime.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer spC1;
        private System.Windows.Forms.TableLayoutPanel tLayPMoney;
        private System.Windows.Forms.SplitContainer spC2;
        private System.Windows.Forms.Label labCouName;
        private System.Windows.Forms.TableLayoutPanel tLayPTime;
        private System.Windows.Forms.Label labMoney;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labCon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labto;
        private System.Windows.Forms.Label labEnd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labStart;
    }
}
