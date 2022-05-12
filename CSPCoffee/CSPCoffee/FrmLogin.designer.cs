
namespace CSPCoffee
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.tabMem = new System.Windows.Forms.TabControl();
            this.tabPLogin = new System.Windows.Forms.TabPage();
            this.linlabForget = new System.Windows.Forms.LinkLabel();
            this.btnLogin = new System.Windows.Forms.Button();
            this.pboxEye = new System.Windows.Forms.PictureBox();
            this.txtPW = new System.Windows.Forms.TextBox();
            this.txtAccount = new System.Windows.Forms.TextBox();
            this.labLogErr = new System.Windows.Forms.Label();
            this.tabPCreate = new System.Windows.Forms.TabPage();
            this.labBirth = new System.Windows.Forms.Label();
            this.labBirthErr = new System.Windows.Forms.Label();
            this.labAdressErr = new System.Windows.Forms.Label();
            this.labNameErr = new System.Windows.Forms.Label();
            this.labPWAgain = new System.Windows.Forms.Label();
            this.labPWStren = new System.Windows.Forms.Label();
            this.labEmailErr = new System.Windows.Forms.Label();
            this.labPhoneErr = new System.Windows.Forms.Label();
            this.txtAdress = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPWAgain = new System.Windows.Forms.TextBox();
            this.txtPWStren = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.btnCreate = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.timerEye = new System.Windows.Forms.Timer(this.components);
            this.tabMem.SuspendLayout();
            this.tabPLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxEye)).BeginInit();
            this.tabPCreate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabMem
            // 
            this.tabMem.Controls.Add(this.tabPLogin);
            this.tabMem.Controls.Add(this.tabPCreate);
            this.tabMem.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabMem.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tabMem.ItemSize = new System.Drawing.Size(250, 40);
            this.tabMem.Location = new System.Drawing.Point(700, 45);
            this.tabMem.Margin = new System.Windows.Forms.Padding(10);
            this.tabMem.Multiline = true;
            this.tabMem.Name = "tabMem";
            this.tabMem.Padding = new System.Drawing.Point(6, 2);
            this.tabMem.SelectedIndex = 0;
            this.tabMem.Size = new System.Drawing.Size(505, 770);
            this.tabMem.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabMem.TabIndex = 0;
            this.tabMem.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabMem_Selecting);
            // 
            // tabPLogin
            // 
            this.tabPLogin.Controls.Add(this.linlabForget);
            this.tabPLogin.Controls.Add(this.btnLogin);
            this.tabPLogin.Controls.Add(this.pboxEye);
            this.tabPLogin.Controls.Add(this.txtPW);
            this.tabPLogin.Controls.Add(this.txtAccount);
            this.tabPLogin.Controls.Add(this.labLogErr);
            this.tabPLogin.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabPLogin.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tabPLogin.Location = new System.Drawing.Point(4, 44);
            this.tabPLogin.Name = "tabPLogin";
            this.tabPLogin.Padding = new System.Windows.Forms.Padding(3);
            this.tabPLogin.Size = new System.Drawing.Size(497, 722);
            this.tabPLogin.TabIndex = 0;
            this.tabPLogin.Text = "會員登入";
            this.tabPLogin.UseVisualStyleBackColor = true;
            // 
            // linlabForget
            // 
            this.linlabForget.AutoSize = true;
            this.linlabForget.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.linlabForget.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linlabForget.Location = new System.Drawing.Point(319, 228);
            this.linlabForget.Name = "linlabForget";
            this.linlabForget.Size = new System.Drawing.Size(73, 17);
            this.linlabForget.TabIndex = 5;
            this.linlabForget.TabStop = true;
            this.linlabForget.Text = "忘記密碼？";
            this.linlabForget.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linlabForget_LinkClicked);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.SystemColors.Control;
            this.btnLogin.Location = new System.Drawing.Point(193, 291);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(127, 53);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "登入";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // pboxEye
            // 
            this.pboxEye.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pboxEye.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pboxEye.Image = ((System.Drawing.Image)(resources.GetObject("pboxEye.Image")));
            this.pboxEye.Location = new System.Drawing.Point(366, 191);
            this.pboxEye.Name = "pboxEye";
            this.pboxEye.Size = new System.Drawing.Size(24, 24);
            this.pboxEye.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboxEye.TabIndex = 1;
            this.pboxEye.TabStop = false;
            this.pboxEye.Click += new System.EventHandler(this.pboxEye_Click);
            // 
            // txtPW
            // 
            this.txtPW.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPW.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPW.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtPW.Location = new System.Drawing.Point(112, 190);
            this.txtPW.Name = "txtPW";
            this.txtPW.Size = new System.Drawing.Size(280, 26);
            this.txtPW.TabIndex = 3;
            this.txtPW.Text = "0966666666";
            this.txtPW.Enter += new System.EventHandler(this.txtPW_Enter);
            this.txtPW.Leave += new System.EventHandler(this.txtPW_Leave);
            // 
            // txtAccount
            // 
            this.txtAccount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAccount.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtAccount.Location = new System.Drawing.Point(112, 129);
            this.txtAccount.Name = "txtAccount";
            this.txtAccount.Size = new System.Drawing.Size(280, 26);
            this.txtAccount.TabIndex = 2;
            this.txtAccount.Text = "0966666666";
            this.txtAccount.Enter += new System.EventHandler(this.txtAccount_Enter);
            this.txtAccount.Leave += new System.EventHandler(this.txtAccount_Leave);
            // 
            // labLogErr
            // 
            this.labLogErr.AutoSize = true;
            this.labLogErr.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labLogErr.ForeColor = System.Drawing.Color.Crimson;
            this.labLogErr.Location = new System.Drawing.Point(108, 227);
            this.labLogErr.Name = "labLogErr";
            this.labLogErr.Size = new System.Drawing.Size(162, 18);
            this.labLogErr.TabIndex = 1;
            this.labLogErr.Text = "請輸入正確的帳號或密碼";
            // 
            // tabPCreate
            // 
            this.tabPCreate.Controls.Add(this.labBirth);
            this.tabPCreate.Controls.Add(this.labBirthErr);
            this.tabPCreate.Controls.Add(this.labAdressErr);
            this.tabPCreate.Controls.Add(this.labNameErr);
            this.tabPCreate.Controls.Add(this.labPWAgain);
            this.tabPCreate.Controls.Add(this.labPWStren);
            this.tabPCreate.Controls.Add(this.labEmailErr);
            this.tabPCreate.Controls.Add(this.labPhoneErr);
            this.tabPCreate.Controls.Add(this.txtAdress);
            this.tabPCreate.Controls.Add(this.txtName);
            this.tabPCreate.Controls.Add(this.txtPWAgain);
            this.tabPCreate.Controls.Add(this.txtPWStren);
            this.tabPCreate.Controls.Add(this.txtEmail);
            this.tabPCreate.Controls.Add(this.txtPhone);
            this.tabPCreate.Controls.Add(this.splitContainer2);
            this.tabPCreate.Location = new System.Drawing.Point(4, 44);
            this.tabPCreate.Name = "tabPCreate";
            this.tabPCreate.Padding = new System.Windows.Forms.Padding(3);
            this.tabPCreate.Size = new System.Drawing.Size(497, 722);
            this.tabPCreate.TabIndex = 1;
            this.tabPCreate.Text = "註冊會員";
            this.tabPCreate.UseVisualStyleBackColor = true;
            // 
            // labBirth
            // 
            this.labBirth.BackColor = System.Drawing.SystemColors.Window;
            this.labBirth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labBirth.ForeColor = System.Drawing.Color.Silver;
            this.labBirth.Location = new System.Drawing.Point(68, 419);
            this.labBirth.Name = "labBirth";
            this.labBirth.Size = new System.Drawing.Size(350, 26);
            this.labBirth.TabIndex = 2;
            this.labBirth.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labBirth.Click += new System.EventHandler(this.labBirth_Click);
            // 
            // labBirthErr
            // 
            this.labBirthErr.AutoSize = true;
            this.labBirthErr.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labBirthErr.ForeColor = System.Drawing.Color.Crimson;
            this.labBirthErr.Location = new System.Drawing.Point(64, 453);
            this.labBirthErr.Name = "labBirthErr";
            this.labBirthErr.Size = new System.Drawing.Size(92, 18);
            this.labBirthErr.TabIndex = 19;
            this.labBirthErr.Text = "生日不得為空";
            // 
            // labAdressErr
            // 
            this.labAdressErr.AutoSize = true;
            this.labAdressErr.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labAdressErr.ForeColor = System.Drawing.Color.Crimson;
            this.labAdressErr.Location = new System.Drawing.Point(64, 389);
            this.labAdressErr.Name = "labAdressErr";
            this.labAdressErr.Size = new System.Drawing.Size(92, 18);
            this.labAdressErr.TabIndex = 18;
            this.labAdressErr.Text = "住址不得為空";
            // 
            // labNameErr
            // 
            this.labNameErr.AutoSize = true;
            this.labNameErr.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labNameErr.ForeColor = System.Drawing.Color.Crimson;
            this.labNameErr.Location = new System.Drawing.Point(64, 325);
            this.labNameErr.Name = "labNameErr";
            this.labNameErr.Size = new System.Drawing.Size(92, 18);
            this.labNameErr.TabIndex = 17;
            this.labNameErr.Text = "姓名不得為空";
            // 
            // labPWAgain
            // 
            this.labPWAgain.AutoSize = true;
            this.labPWAgain.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labPWAgain.ForeColor = System.Drawing.Color.Crimson;
            this.labPWAgain.Location = new System.Drawing.Point(64, 261);
            this.labPWAgain.Name = "labPWAgain";
            this.labPWAgain.Size = new System.Drawing.Size(64, 18);
            this.labPWAgain.TabIndex = 16;
            this.labPWAgain.Text = "密碼不符";
            // 
            // labPWStren
            // 
            this.labPWStren.AutoSize = true;
            this.labPWStren.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labPWStren.ForeColor = System.Drawing.Color.Crimson;
            this.labPWStren.Location = new System.Drawing.Point(64, 197);
            this.labPWStren.Name = "labPWStren";
            this.labPWStren.Size = new System.Drawing.Size(36, 18);
            this.labPWStren.TabIndex = 15;
            this.labPWStren.Text = "強弱";
            // 
            // labEmailErr
            // 
            this.labEmailErr.AutoSize = true;
            this.labEmailErr.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labEmailErr.ForeColor = System.Drawing.Color.Crimson;
            this.labEmailErr.Location = new System.Drawing.Point(64, 133);
            this.labEmailErr.Name = "labEmailErr";
            this.labEmailErr.Size = new System.Drawing.Size(120, 18);
            this.labEmailErr.TabIndex = 14;
            this.labEmailErr.Text = "電子信箱不得為空";
            // 
            // labPhoneErr
            // 
            this.labPhoneErr.AutoSize = true;
            this.labPhoneErr.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labPhoneErr.ForeColor = System.Drawing.Color.Crimson;
            this.labPhoneErr.Location = new System.Drawing.Point(64, 69);
            this.labPhoneErr.Name = "labPhoneErr";
            this.labPhoneErr.Size = new System.Drawing.Size(120, 18);
            this.labPhoneErr.TabIndex = 13;
            this.labPhoneErr.Text = "手機號碼不得為空";
            // 
            // txtAdress
            // 
            this.txtAdress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAdress.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtAdress.Location = new System.Drawing.Point(68, 355);
            this.txtAdress.Name = "txtAdress";
            this.txtAdress.Size = new System.Drawing.Size(350, 26);
            this.txtAdress.TabIndex = 8;
            this.txtAdress.Enter += new System.EventHandler(this.txtAdress_Enter);
            this.txtAdress.Leave += new System.EventHandler(this.txtAdress_Leave);
            // 
            // txtName
            // 
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtName.Location = new System.Drawing.Point(68, 291);
            this.txtName.MaxLength = 50;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(350, 26);
            this.txtName.TabIndex = 7;
            this.txtName.Enter += new System.EventHandler(this.txtName_Enter);
            this.txtName.Leave += new System.EventHandler(this.txtName_Leave);
            // 
            // txtPWAgain
            // 
            this.txtPWAgain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPWAgain.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPWAgain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtPWAgain.Location = new System.Drawing.Point(68, 227);
            this.txtPWAgain.MaxLength = 50;
            this.txtPWAgain.Name = "txtPWAgain";
            this.txtPWAgain.Size = new System.Drawing.Size(350, 26);
            this.txtPWAgain.TabIndex = 6;
            this.txtPWAgain.Enter += new System.EventHandler(this.txtPWAgain_Enter);
            this.txtPWAgain.Leave += new System.EventHandler(this.txtPWAgain_Leave);
            // 
            // txtPWStren
            // 
            this.txtPWStren.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPWStren.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPWStren.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtPWStren.Location = new System.Drawing.Point(68, 163);
            this.txtPWStren.MaxLength = 50;
            this.txtPWStren.Name = "txtPWStren";
            this.txtPWStren.Size = new System.Drawing.Size(350, 26);
            this.txtPWStren.TabIndex = 5;
            this.txtPWStren.TextChanged += new System.EventHandler(this.txtPWStren_TextChanged);
            this.txtPWStren.Enter += new System.EventHandler(this.txtPWStren_Enter);
            this.txtPWStren.Leave += new System.EventHandler(this.txtPWStren_Leave);
            // 
            // txtEmail
            // 
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtEmail.Location = new System.Drawing.Point(68, 99);
            this.txtEmail.MaxLength = 50;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(350, 26);
            this.txtEmail.TabIndex = 4;
            this.txtEmail.Enter += new System.EventHandler(this.txtEmail_Enter);
            this.txtEmail.Leave += new System.EventHandler(this.txtEmail_Leave);
            // 
            // txtPhone
            // 
            this.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPhone.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtPhone.Location = new System.Drawing.Point(68, 35);
            this.txtPhone.MaxLength = 10;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(350, 26);
            this.txtPhone.TabIndex = 3;
            this.txtPhone.Enter += new System.EventHandler(this.txtPhone_Enter);
            this.txtPhone.Leave += new System.EventHandler(this.txtPhone_Leave);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Location = new System.Drawing.Point(109, 451);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.monthCalendar1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.btnCreate);
            this.splitContainer2.Size = new System.Drawing.Size(328, 245);
            this.splitContainer2.SplitterDistance = 167;
            this.splitContainer2.TabIndex = 2;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(56, 3);
            this.monthCalendar1.MaxDate = new System.DateTime(2022, 5, 9, 0, 0, 0, 0);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 2;
            this.monthCalendar1.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateSelected);
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.SystemColors.Control;
            this.btnCreate.Location = new System.Drawing.Point(56, 8);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(127, 53);
            this.btnCreate.TabIndex = 11;
            this.btnCreate.Text = "註冊";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabMem);
            this.splitContainer1.Size = new System.Drawing.Size(1904, 1041);
            this.splitContainer1.SplitterDistance = 113;
            this.splitContainer1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(876, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 69);
            this.label1.TabIndex = 0;
            this.label1.Text = "Logol";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timerEye
            // 
            this.timerEye.Interval = 1000;
            this.timerEye.Tick += new System.EventHandler(this.timerEye_Tick);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmLogin";
            this.Text = "FrmLogin";
            this.tabMem.ResumeLayout(false);
            this.tabPLogin.ResumeLayout(false);
            this.tabPLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxEye)).EndInit();
            this.tabPCreate.ResumeLayout(false);
            this.tabPCreate.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabMem;
        private System.Windows.Forms.TabPage tabPCreate;
        private System.Windows.Forms.TabPage tabPLogin;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox txtAccount;
        private System.Windows.Forms.TextBox txtPW;
        private System.Windows.Forms.PictureBox pboxEye;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label labLogErr;
        private System.Windows.Forms.Timer timerEye;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtAdress;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPWAgain;
        private System.Windows.Forms.TextBox txtPWStren;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label labPhoneErr;
        private System.Windows.Forms.Label labBirthErr;
        private System.Windows.Forms.Label labAdressErr;
        private System.Windows.Forms.Label labNameErr;
        private System.Windows.Forms.Label labPWAgain;
        private System.Windows.Forms.Label labPWStren;
        private System.Windows.Forms.Label labEmailErr;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Label labBirth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linlabForget;
    }
}