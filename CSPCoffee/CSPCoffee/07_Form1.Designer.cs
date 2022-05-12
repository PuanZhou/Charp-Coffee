
namespace CSPCoffee
{
    partial class Form1
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

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblOLService = new System.Windows.Forms.Label();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picSearch = new System.Windows.Forms.PictureBox();
            this.btnCart = new System.Windows.Forms.Button();
            this.btnMem = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnRain = new System.Windows.Forms.Button();
            this.btnOthCollapse = new System.Windows.Forms.Button();
            this.btnCoCollapse = new System.Windows.Forms.Button();
            this.btnCollapse = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(1832, 194);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(10, 29);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            this.txtSearch.MouseEnter += new System.EventHandler(this.txtSearch_MouseEnter);
            this.txtSearch.MouseLeave += new System.EventHandler(this.txtSearch_MouseLeave);
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.button2);
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox1);
            this.splitContainer1.Panel1.Controls.Add(this.picSearch);
            this.splitContainer1.Panel1.Controls.Add(this.txtSearch);
            this.splitContainer1.Panel1.Controls.Add(this.btnCart);
            this.splitContainer1.Panel1.Controls.Add(this.btnMem);
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1904, 1041);
            this.splitContainer1.SplitterDistance = 351;
            this.splitContainer1.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(1102, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(440, 274);
            this.label6.TabIndex = 9;
            this.label6.Text = "  ";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(-1, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(541, 274);
            this.label5.TabIndex = 8;
            this.label5.Text = "  ";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Tan;
            this.tableLayoutPanel1.ColumnCount = 8;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.100946F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.97266F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblOLService, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.button3, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.button1, 7, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 285);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1902, 64);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(383, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 64);
            this.label1.TabIndex = 0;
            this.label1.Text = "關於我";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(573, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 64);
            this.label2.TabIndex = 1;
            this.label2.Text = "最新消息";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(763, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 64);
            this.label3.TabIndex = 2;
            this.label3.Text = "相關文章";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(953, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(184, 64);
            this.label4.TabIndex = 3;
            this.label4.Text = "雨林樹蛙聯盟";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblOLService
            // 
            this.lblOLService.AutoSize = true;
            this.lblOLService.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblOLService.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblOLService.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOLService.Location = new System.Drawing.Point(1143, 0);
            this.lblOLService.Name = "lblOLService";
            this.lblOLService.Size = new System.Drawing.Size(184, 64);
            this.lblOLService.TabIndex = 4;
            this.lblOLService.Text = "線上客服";
            this.lblOLService.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblOLService.Click += new System.EventHandler(this.lblOLService_Click);
            // 
            // splitContainer2
            // 
            this.splitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.btnRain);
            this.splitContainer2.Panel1.Controls.Add(this.btnOthCollapse);
            this.splitContainer2.Panel1.Controls.Add(this.btnCoCollapse);
            this.splitContainer2.Panel1.Controls.Add(this.btnCollapse);
            this.splitContainer2.Panel1.Controls.Add(this.treeView1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.flowLayoutPanel1);
            this.splitContainer2.Size = new System.Drawing.Size(1902, 684);
            this.splitContainer2.SplitterDistance = 287;
            this.splitContainer2.TabIndex = 0;
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.Color.Moccasin;
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.treeView1.Location = new System.Drawing.Point(0, 55);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(283, 625);
            this.treeView1.TabIndex = 0;
            this.treeView1.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseClick);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1607, 680);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 10;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = global::CSPCoffee.Properties.Resources.pngwing_com__1_;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PapayaWhip;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(1803, 11);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(41, 34);
            this.button2.TabIndex = 13;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(2, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(395, 205);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // picSearch
            // 
            this.picSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picSearch.Image = ((System.Drawing.Image)(resources.GetObject("picSearch.Image")));
            this.picSearch.Location = new System.Drawing.Point(1844, 194);
            this.picSearch.Name = "picSearch";
            this.picSearch.Size = new System.Drawing.Size(38, 29);
            this.picSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSearch.TabIndex = 7;
            this.picSearch.TabStop = false;
            this.picSearch.Click += new System.EventHandler(this.picSearch_Click);
            this.picSearch.MouseEnter += new System.EventHandler(this.picSearch_MouseEnter);
            this.picSearch.MouseLeave += new System.EventHandler(this.picSearch_MouseLeave);
            // 
            // btnCart
            // 
            this.btnCart.BackColor = System.Drawing.Color.Transparent;
            this.btnCart.BackgroundImage = global::CSPCoffee.Properties.Resources.pngwing_com__2_;
            this.btnCart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCart.FlatAppearance.BorderSize = 0;
            this.btnCart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PapayaWhip;
            this.btnCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCart.Location = new System.Drawing.Point(1756, 11);
            this.btnCart.Name = "btnCart";
            this.btnCart.Size = new System.Drawing.Size(41, 34);
            this.btnCart.TabIndex = 2;
            this.btnCart.UseVisualStyleBackColor = false;
            this.btnCart.Click += new System.EventHandler(this.btnCart_Click);
            // 
            // btnMem
            // 
            this.btnMem.BackColor = System.Drawing.Color.Transparent;
            this.btnMem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMem.BackgroundImage")));
            this.btnMem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMem.FlatAppearance.BorderSize = 0;
            this.btnMem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PapayaWhip;
            this.btnMem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMem.Location = new System.Drawing.Point(1850, 11);
            this.btnMem.Name = "btnMem";
            this.btnMem.Size = new System.Drawing.Size(35, 34);
            this.btnMem.TabIndex = 1;
            this.btnMem.UseVisualStyleBackColor = false;
            this.btnMem.Click += new System.EventHandler(this.btnMem_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.BackgroundImage = global::CSPCoffee.Properties.Resources.survey;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(1333, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(60, 58);
            this.button3.TabIndex = 14;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(1410, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 58);
            this.button1.TabIndex = 10;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnRain
            // 
            this.btnRain.BackColor = System.Drawing.Color.Moccasin;
            this.btnRain.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRain.BackgroundImage")));
            this.btnRain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRain.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRain.FlatAppearance.BorderSize = 0;
            this.btnRain.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PapayaWhip;
            this.btnRain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRain.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnRain.ForeColor = System.Drawing.Color.Black;
            this.btnRain.Location = new System.Drawing.Point(209, 1);
            this.btnRain.Name = "btnRain";
            this.btnRain.Size = new System.Drawing.Size(73, 39);
            this.btnRain.TabIndex = 6;
            this.btnRain.Text = "雨林樹蛙";
            this.btnRain.UseVisualStyleBackColor = false;
            this.btnRain.Click += new System.EventHandler(this.btnRain_Click);
            // 
            // btnOthCollapse
            // 
            this.btnOthCollapse.BackColor = System.Drawing.Color.Transparent;
            this.btnOthCollapse.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOthCollapse.BackgroundImage")));
            this.btnOthCollapse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOthCollapse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOthCollapse.FlatAppearance.BorderSize = 0;
            this.btnOthCollapse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PapayaWhip;
            this.btnOthCollapse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOthCollapse.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnOthCollapse.ForeColor = System.Drawing.Color.Black;
            this.btnOthCollapse.Location = new System.Drawing.Point(141, 1);
            this.btnOthCollapse.Name = "btnOthCollapse";
            this.btnOthCollapse.Size = new System.Drawing.Size(66, 39);
            this.btnOthCollapse.TabIndex = 5;
            this.btnOthCollapse.Text = "其它展開";
            this.btnOthCollapse.UseVisualStyleBackColor = false;
            this.btnOthCollapse.Click += new System.EventHandler(this.btnOthCollapse_Click);
            // 
            // btnCoCollapse
            // 
            this.btnCoCollapse.BackColor = System.Drawing.Color.Transparent;
            this.btnCoCollapse.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCoCollapse.BackgroundImage")));
            this.btnCoCollapse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCoCollapse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCoCollapse.FlatAppearance.BorderSize = 0;
            this.btnCoCollapse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PapayaWhip;
            this.btnCoCollapse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCoCollapse.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCoCollapse.ForeColor = System.Drawing.Color.Black;
            this.btnCoCollapse.Location = new System.Drawing.Point(73, 1);
            this.btnCoCollapse.Name = "btnCoCollapse";
            this.btnCoCollapse.Size = new System.Drawing.Size(66, 39);
            this.btnCoCollapse.TabIndex = 4;
            this.btnCoCollapse.Text = "產地展開";
            this.btnCoCollapse.UseVisualStyleBackColor = false;
            this.btnCoCollapse.Click += new System.EventHandler(this.btnCoCollapse_Click);
            // 
            // btnCollapse
            // 
            this.btnCollapse.BackColor = System.Drawing.Color.Transparent;
            this.btnCollapse.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCollapse.BackgroundImage")));
            this.btnCollapse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCollapse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCollapse.FlatAppearance.BorderSize = 0;
            this.btnCollapse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PapayaWhip;
            this.btnCollapse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCollapse.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCollapse.ForeColor = System.Drawing.Color.Black;
            this.btnCollapse.Location = new System.Drawing.Point(3, 1);
            this.btnCollapse.Name = "btnCollapse";
            this.btnCollapse.Size = new System.Drawing.Size(66, 39);
            this.btnCollapse.TabIndex = 3;
            this.btnCollapse.Text = "全部展開";
            this.btnCollapse.UseVisualStyleBackColor = false;
            this.btnCollapse.Click += new System.EventHandler(this.btnCollapse_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSearch)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnCart;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblOLService;
        private System.Windows.Forms.Button btnCollapse;
        private System.Windows.Forms.Button btnOthCollapse;
        private System.Windows.Forms.Button btnCoCollapse;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox picSearch;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.Button btnMem;
        private System.Windows.Forms.Button btnRain;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PrintDialog printDialog1;
        public System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

