namespace CSPCoffee
{
    partial class FrmOLService
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
            this.components = new System.ComponentModel.Container();
            this.txtQuest = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.labForD1 = new System.Windows.Forms.Label();
            this.labForD2 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timerforQuest = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtQuest
            // 
            this.txtQuest.Location = new System.Drawing.Point(30, 29);
            this.txtQuest.Name = "txtQuest";
            this.txtQuest.Size = new System.Drawing.Size(381, 22);
            this.txtQuest.TabIndex = 0;
            this.txtQuest.TextChanged += new System.EventHandler(this.txtQuest_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Moccasin;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(38, 127);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(462, 114);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.Visible = false;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.Color.Moccasin;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(38, 284);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(462, 114);
            this.dataGridView2.TabIndex = 5;
            this.dataGridView2.Visible = false;
            // 
            // labForD1
            // 
            this.labForD1.AutoSize = true;
            this.labForD1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labForD1.Location = new System.Drawing.Point(34, 104);
            this.labForD1.Name = "labForD1";
            this.labForD1.Size = new System.Drawing.Size(69, 20);
            this.labForD1.TabIndex = 6;
            this.labForD1.Text = "nothing";
            this.labForD1.Visible = false;
            // 
            // labForD2
            // 
            this.labForD2.AutoSize = true;
            this.labForD2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labForD2.Location = new System.Drawing.Point(34, 261);
            this.labForD2.Name = "labForD2";
            this.labForD2.Size = new System.Drawing.Size(69, 20);
            this.labForD2.TabIndex = 7;
            this.labForD2.Text = "nothing";
            this.labForD2.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "請輸入您的問題";
            // 
            // timerforQuest
            // 
            this.timerforQuest.Interval = 2000;
            this.timerforQuest.Tick += new System.EventHandler(this.timerforQuest_Tick_1);
            // 
            // FrmOLService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(548, 534);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labForD2);
            this.Controls.Add(this.labForD1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtQuest);
            this.Name = "FrmOLService";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OLService";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtQuest;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label labForD1;
        private System.Windows.Forms.Label labForD2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timerforQuest;
    }
}