
namespace AdminClient
{
    partial class Products
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
            this.labTitle = new System.Windows.Forms.Label();
            this.grpProducts = new System.Windows.Forms.GroupBox();
            this.dataGridViewProducts = new System.Windows.Forms.DataGridView();
            this.grpProductsCRUD = new System.Windows.Forms.GroupBox();
            this.cbxCategoryName = new System.Windows.Forms.ComboBox();
            this.btnClearPic = new System.Windows.Forms.Button();
            this.flowLayoutPanelProductsPhoto = new System.Windows.Forms.FlowLayoutPanel();
            this.btnClearDescription = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnRevise = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.txtStar = new System.Windows.Forms.TextBox();
            this.checkboxTakeDown = new System.Windows.Forms.CheckBox();
            this.txtClickCount = new System.Windows.Forms.TextBox();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.txtProductID = new System.Windows.Forms.TextBox();
            this.labStar = new System.Windows.Forms.Label();
            this.labTakeDown = new System.Windows.Forms.Label();
            this.labClickCount = new System.Windows.Forms.Label();
            this.labStock = new System.Windows.Forms.Label();
            this.labDescription = new System.Windows.Forms.Label();
            this.labUnitPrice = new System.Windows.Forms.Label();
            this.labCategoryName = new System.Windows.Forms.Label();
            this.labProductName = new System.Windows.Forms.Label();
            this.labProductID = new System.Windows.Forms.Label();
            this.labCountryName = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbxCountry = new System.Windows.Forms.ComboBox();
            this.checkboxRainForest = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxPackage = new System.Windows.Forms.ComboBox();
            this.cbxProcess = new System.Windows.Forms.ComboBox();
            this.cbxRoasting = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labProcess = new System.Windows.Forms.Label();
            this.labRoasting = new System.Windows.Forms.Label();
            this.grpProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).BeginInit();
            this.grpProductsCRUD.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labTitle
            // 
            this.labTitle.AutoSize = true;
            this.labTitle.Font = new System.Drawing.Font("微軟正黑體", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labTitle.Location = new System.Drawing.Point(885, 9);
            this.labTitle.Name = "labTitle";
            this.labTitle.Size = new System.Drawing.Size(133, 37);
            this.labTitle.TabIndex = 23;
            this.labTitle.Text = "產品管理";
            // 
            // grpProducts
            // 
            this.grpProducts.Controls.Add(this.dataGridViewProducts);
            this.grpProducts.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.grpProducts.Location = new System.Drawing.Point(892, 90);
            this.grpProducts.Name = "grpProducts";
            this.grpProducts.Size = new System.Drawing.Size(968, 561);
            this.grpProducts.TabIndex = 24;
            this.grpProducts.TabStop = false;
            this.grpProducts.Text = "產品總覽";
            // 
            // dataGridViewProducts
            // 
            this.dataGridViewProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Linen;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.BurlyWood;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewProducts.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewProducts.Location = new System.Drawing.Point(6, 28);
            this.dataGridViewProducts.Name = "dataGridViewProducts";
            this.dataGridViewProducts.RowTemplate.Height = 40;
            this.dataGridViewProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewProducts.Size = new System.Drawing.Size(956, 527);
            this.dataGridViewProducts.TabIndex = 0;
            this.dataGridViewProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProducts_CellClick);
            // 
            // grpProductsCRUD
            // 
            this.grpProductsCRUD.Controls.Add(this.cbxCategoryName);
            this.grpProductsCRUD.Controls.Add(this.btnClearPic);
            this.grpProductsCRUD.Controls.Add(this.flowLayoutPanelProductsPhoto);
            this.grpProductsCRUD.Controls.Add(this.btnClearDescription);
            this.grpProductsCRUD.Controls.Add(this.btnDelete);
            this.grpProductsCRUD.Controls.Add(this.btnRevise);
            this.grpProductsCRUD.Controls.Add(this.btnInsert);
            this.grpProductsCRUD.Controls.Add(this.txtStar);
            this.grpProductsCRUD.Controls.Add(this.checkboxTakeDown);
            this.grpProductsCRUD.Controls.Add(this.txtClickCount);
            this.grpProductsCRUD.Controls.Add(this.txtStock);
            this.grpProductsCRUD.Controls.Add(this.txtDescription);
            this.grpProductsCRUD.Controls.Add(this.txtUnitPrice);
            this.grpProductsCRUD.Controls.Add(this.txtProductName);
            this.grpProductsCRUD.Controls.Add(this.txtProductID);
            this.grpProductsCRUD.Controls.Add(this.labStar);
            this.grpProductsCRUD.Controls.Add(this.labTakeDown);
            this.grpProductsCRUD.Controls.Add(this.labClickCount);
            this.grpProductsCRUD.Controls.Add(this.labStock);
            this.grpProductsCRUD.Controls.Add(this.labDescription);
            this.grpProductsCRUD.Controls.Add(this.labUnitPrice);
            this.grpProductsCRUD.Controls.Add(this.labCategoryName);
            this.grpProductsCRUD.Controls.Add(this.labProductName);
            this.grpProductsCRUD.Controls.Add(this.labProductID);
            this.grpProductsCRUD.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.grpProductsCRUD.Location = new System.Drawing.Point(13, 12);
            this.grpProductsCRUD.Name = "grpProductsCRUD";
            this.grpProductsCRUD.Size = new System.Drawing.Size(874, 555);
            this.grpProductsCRUD.TabIndex = 25;
            this.grpProductsCRUD.TabStop = false;
            this.grpProductsCRUD.Text = "產品新增修改                    ";
            // 
            // cbxCategoryName
            // 
            this.cbxCategoryName.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbxCategoryName.FormattingEnabled = true;
            this.cbxCategoryName.Location = new System.Drawing.Point(134, 178);
            this.cbxCategoryName.Name = "cbxCategoryName";
            this.cbxCategoryName.Size = new System.Drawing.Size(157, 28);
            this.cbxCategoryName.TabIndex = 26;
            // 
            // btnClearPic
            // 
            this.btnClearPic.Location = new System.Drawing.Point(775, 523);
            this.btnClearPic.Name = "btnClearPic";
            this.btnClearPic.Size = new System.Drawing.Size(93, 26);
            this.btnClearPic.TabIndex = 25;
            this.btnClearPic.Text = "清除";
            this.btnClearPic.UseVisualStyleBackColor = true;
            this.btnClearPic.Click += new System.EventHandler(this.btnClearPic_Click);
            // 
            // flowLayoutPanelProductsPhoto
            // 
            this.flowLayoutPanelProductsPhoto.AutoScroll = true;
            this.flowLayoutPanelProductsPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanelProductsPhoto.Location = new System.Drawing.Point(419, 246);
            this.flowLayoutPanelProductsPhoto.Name = "flowLayoutPanelProductsPhoto";
            this.flowLayoutPanelProductsPhoto.Size = new System.Drawing.Size(454, 271);
            this.flowLayoutPanelProductsPhoto.TabIndex = 24;
            // 
            // btnClearDescription
            // 
            this.btnClearDescription.Location = new System.Drawing.Point(293, 491);
            this.btnClearDescription.Name = "btnClearDescription";
            this.btnClearDescription.Size = new System.Drawing.Size(93, 26);
            this.btnClearDescription.TabIndex = 23;
            this.btnClearDescription.Text = "清除";
            this.btnClearDescription.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(729, 148);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(121, 33);
            this.btnDelete.TabIndex = 22;
            this.btnDelete.Text = "刪除產品";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnRevise
            // 
            this.btnRevise.Location = new System.Drawing.Point(729, 103);
            this.btnRevise.Name = "btnRevise";
            this.btnRevise.Size = new System.Drawing.Size(121, 33);
            this.btnRevise.TabIndex = 21;
            this.btnRevise.Text = "修改";
            this.btnRevise.UseVisualStyleBackColor = true;
            this.btnRevise.Click += new System.EventHandler(this.btnRevise_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(729, 58);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(121, 33);
            this.btnInsert.TabIndex = 20;
            this.btnInsert.Text = "新增產品";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // txtStar
            // 
            this.txtStar.Location = new System.Drawing.Point(508, 195);
            this.txtStar.Name = "txtStar";
            this.txtStar.Size = new System.Drawing.Size(86, 29);
            this.txtStar.TabIndex = 17;
            // 
            // checkboxTakeDown
            // 
            this.checkboxTakeDown.AutoSize = true;
            this.checkboxTakeDown.Location = new System.Drawing.Point(519, 158);
            this.checkboxTakeDown.Name = "checkboxTakeDown";
            this.checkboxTakeDown.Size = new System.Drawing.Size(15, 14);
            this.checkboxTakeDown.TabIndex = 16;
            this.checkboxTakeDown.UseVisualStyleBackColor = true;
            // 
            // txtClickCount
            // 
            this.txtClickCount.Location = new System.Drawing.Point(540, 106);
            this.txtClickCount.Name = "txtClickCount";
            this.txtClickCount.Size = new System.Drawing.Size(86, 29);
            this.txtClickCount.TabIndex = 15;
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(508, 62);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(86, 29);
            this.txtStock.TabIndex = 14;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(134, 299);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(252, 186);
            this.txtDescription.TabIndex = 13;
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Location = new System.Drawing.Point(134, 236);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(86, 29);
            this.txtUnitPrice.TabIndex = 12;
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(134, 120);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(157, 29);
            this.txtProductName.TabIndex = 10;
            // 
            // txtProductID
            // 
            this.txtProductID.Location = new System.Drawing.Point(134, 62);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.ReadOnly = true;
            this.txtProductID.Size = new System.Drawing.Size(86, 29);
            this.txtProductID.TabIndex = 9;
            this.txtProductID.TextChanged += new System.EventHandler(this.txtProductID_TextChanged);
            // 
            // labStar
            // 
            this.labStar.AutoSize = true;
            this.labStar.Location = new System.Drawing.Point(421, 198);
            this.labStar.Name = "labStar";
            this.labStar.Size = new System.Drawing.Size(81, 20);
            this.labStar.TabIndex = 8;
            this.labStar.Text = "產品評分 :";
            // 
            // labTakeDown
            // 
            this.labTakeDown.AutoSize = true;
            this.labTakeDown.Location = new System.Drawing.Point(421, 154);
            this.labTakeDown.Name = "labTakeDown";
            this.labTakeDown.Size = new System.Drawing.Size(81, 20);
            this.labTakeDown.TabIndex = 7;
            this.labTakeDown.Text = "是否下架 :";
            // 
            // labClickCount
            // 
            this.labClickCount.AutoSize = true;
            this.labClickCount.Location = new System.Drawing.Point(421, 109);
            this.labClickCount.Name = "labClickCount";
            this.labClickCount.Size = new System.Drawing.Size(113, 20);
            this.labClickCount.TabIndex = 6;
            this.labClickCount.Text = "產品點擊次數 :";
            // 
            // labStock
            // 
            this.labStock.AutoSize = true;
            this.labStock.Location = new System.Drawing.Point(421, 65);
            this.labStock.Name = "labStock";
            this.labStock.Size = new System.Drawing.Size(49, 20);
            this.labStock.TabIndex = 5;
            this.labStock.Text = "庫存 :";
            // 
            // labDescription
            // 
            this.labDescription.AutoSize = true;
            this.labDescription.Location = new System.Drawing.Point(47, 297);
            this.labDescription.Name = "labDescription";
            this.labDescription.Size = new System.Drawing.Size(81, 20);
            this.labDescription.TabIndex = 4;
            this.labDescription.Text = "產品描述 :";
            // 
            // labUnitPrice
            // 
            this.labUnitPrice.AutoSize = true;
            this.labUnitPrice.Location = new System.Drawing.Point(47, 239);
            this.labUnitPrice.Name = "labUnitPrice";
            this.labUnitPrice.Size = new System.Drawing.Size(81, 20);
            this.labUnitPrice.TabIndex = 3;
            this.labUnitPrice.Text = "產品單價 :";
            // 
            // labCategoryName
            // 
            this.labCategoryName.AutoSize = true;
            this.labCategoryName.Location = new System.Drawing.Point(47, 181);
            this.labCategoryName.Name = "labCategoryName";
            this.labCategoryName.Size = new System.Drawing.Size(81, 20);
            this.labCategoryName.TabIndex = 2;
            this.labCategoryName.Text = "類別名稱 :";
            // 
            // labProductName
            // 
            this.labProductName.AutoSize = true;
            this.labProductName.Location = new System.Drawing.Point(47, 123);
            this.labProductName.Name = "labProductName";
            this.labProductName.Size = new System.Drawing.Size(81, 20);
            this.labProductName.TabIndex = 1;
            this.labProductName.Text = "產品名稱 :";
            // 
            // labProductID
            // 
            this.labProductID.AutoSize = true;
            this.labProductID.Location = new System.Drawing.Point(47, 65);
            this.labProductID.Name = "labProductID";
            this.labProductID.Size = new System.Drawing.Size(66, 20);
            this.labProductID.TabIndex = 0;
            this.labProductID.Text = "產品 ID:";
            // 
            // labCountryName
            // 
            this.labCountryName.AutoSize = true;
            this.labCountryName.Location = new System.Drawing.Point(46, 35);
            this.labCountryName.Name = "labCountryName";
            this.labCountryName.Size = new System.Drawing.Size(81, 20);
            this.labCountryName.TabIndex = 18;
            this.labCountryName.Text = "產品國家 :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbxCountry);
            this.groupBox1.Controls.Add(this.checkboxRainForest);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbxPackage);
            this.groupBox1.Controls.Add(this.cbxProcess);
            this.groupBox1.Controls.Add(this.cbxRoasting);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.labProcess);
            this.groupBox1.Controls.Add(this.labRoasting);
            this.groupBox1.Controls.Add(this.labCountryName);
            this.groupBox1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.Location = new System.Drawing.Point(12, 573);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(872, 166);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "新增咖啡細項";
            // 
            // cbxCountry
            // 
            this.cbxCountry.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbxCountry.FormattingEnabled = true;
            this.cbxCountry.Location = new System.Drawing.Point(133, 32);
            this.cbxCountry.Name = "cbxCountry";
            this.cbxCountry.Size = new System.Drawing.Size(157, 28);
            this.cbxCountry.TabIndex = 32;
            // 
            // checkboxRainForest
            // 
            this.checkboxRainForest.AutoSize = true;
            this.checkboxRainForest.Location = new System.Drawing.Point(713, 39);
            this.checkboxRainForest.Name = "checkboxRainForest";
            this.checkboxRainForest.Size = new System.Drawing.Size(15, 14);
            this.checkboxRainForest.TabIndex = 31;
            this.checkboxRainForest.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(615, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 30;
            this.label2.Text = "樹蛙聯盟 :";
            // 
            // cbxPackage
            // 
            this.cbxPackage.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbxPackage.FormattingEnabled = true;
            this.cbxPackage.Location = new System.Drawing.Point(424, 74);
            this.cbxPackage.Name = "cbxPackage";
            this.cbxPackage.Size = new System.Drawing.Size(157, 28);
            this.cbxPackage.TabIndex = 29;
            // 
            // cbxProcess
            // 
            this.cbxProcess.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbxProcess.FormattingEnabled = true;
            this.cbxProcess.Location = new System.Drawing.Point(424, 32);
            this.cbxProcess.Name = "cbxProcess";
            this.cbxProcess.Size = new System.Drawing.Size(157, 28);
            this.cbxProcess.TabIndex = 28;
            // 
            // cbxRoasting
            // 
            this.cbxRoasting.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cbxRoasting.FormattingEnabled = true;
            this.cbxRoasting.Location = new System.Drawing.Point(133, 74);
            this.cbxRoasting.Name = "cbxRoasting";
            this.cbxRoasting.Size = new System.Drawing.Size(157, 28);
            this.cbxRoasting.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(336, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 23;
            this.label1.Text = "包裝方式 :";
            // 
            // labProcess
            // 
            this.labProcess.AutoSize = true;
            this.labProcess.Location = new System.Drawing.Point(336, 35);
            this.labProcess.Name = "labProcess";
            this.labProcess.Size = new System.Drawing.Size(65, 20);
            this.labProcess.TabIndex = 21;
            this.labProcess.Text = "處理法 :";
            // 
            // labRoasting
            // 
            this.labRoasting.AutoSize = true;
            this.labRoasting.Location = new System.Drawing.Point(46, 77);
            this.labRoasting.Name = "labRoasting";
            this.labRoasting.Size = new System.Drawing.Size(49, 20);
            this.labRoasting.TabIndex = 1;
            this.labRoasting.Text = "焙度 :";
            // 
            // Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(1888, 788);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpProductsCRUD);
            this.Controls.Add(this.grpProducts);
            this.Controls.Add(this.labTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Products";
            this.Text = "Products";
            this.grpProducts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).EndInit();
            this.grpProductsCRUD.ResumeLayout(false);
            this.grpProductsCRUD.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labTitle;
        private System.Windows.Forms.GroupBox grpProducts;
        private System.Windows.Forms.DataGridView dataGridViewProducts;
        private System.Windows.Forms.GroupBox grpProductsCRUD;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.TextBox txtProductID;
        private System.Windows.Forms.Label labStar;
        private System.Windows.Forms.Label labTakeDown;
        private System.Windows.Forms.Label labClickCount;
        private System.Windows.Forms.Label labStock;
        private System.Windows.Forms.Label labDescription;
        private System.Windows.Forms.Label labUnitPrice;
        private System.Windows.Forms.Label labCategoryName;
        private System.Windows.Forms.Label labProductName;
        private System.Windows.Forms.Label labProductID;
        private System.Windows.Forms.TextBox txtStar;
        private System.Windows.Forms.CheckBox checkboxTakeDown;
        private System.Windows.Forms.TextBox txtClickCount;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label labCountryName;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelProductsPhoto;
        private System.Windows.Forms.Button btnClearDescription;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnRevise;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnClearPic;
        private System.Windows.Forms.ComboBox cbxCategoryName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labRoasting;
        private System.Windows.Forms.CheckBox checkboxRainForest;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxPackage;
        private System.Windows.Forms.ComboBox cbxProcess;
        private System.Windows.Forms.ComboBox cbxRoasting;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labProcess;
        private System.Windows.Forms.ComboBox cbxCountry;
    }
}