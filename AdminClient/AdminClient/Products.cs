using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminClient
{
    public partial class Products : Form
    {
        public Products()
        {
            InitializeComponent();
            LoadDataToDataGridView();
            FlowLayOutPanel();
            LoadCategoryToComboBoxCategory();
            LoadPackageToComboBoxPackage();
            LoadRoastingToComboBoxRoasting();
            LoadProcessToComboBoxProcess();
            LoadCountryToComboBoxCountry();
        }

        CoffeeEntities dbContext = new CoffeeEntities();

        private void LoadDataToDataGridView()
        {
            DataClear();
            this.dataGridViewProducts.DataSource = this.dbContext.Products
                .Select(s => new
                {
                    s.ProductID,
                    s.ProductName,
                    s.CategoryID,
                    s.CountryID,
                    s.Price,
                    s.Description,
                    s.Stock,
                    s.ClickCount,
                    s.TakeDown,
                    s.Star
                }).ToList();
        }

        private void DataClear()
        {
            this.dataGridViewProducts.DataSource = null;
            this.flowLayoutPanelProductsPhoto.Controls.Clear();
        }

        private void ControlsDataClear()
        {            
            this.txtProductName.Text = "";
            this.cbxCountry.Text = "";
            this.txtClickCount.Text = "";
            this.txtDescription.Text = "";
            this.txtStar.Text = "";
            this.txtStock.Text = "";
            this.txtUnitPrice.Text = "";
            this.checkboxTakeDown.Checked = false;
            this.checkboxRainForest.Checked = false;
            this.cbxCategoryName.Text = "";
            this.cbxPackage.Text = "";
            this.cbxProcess.Text = "";
            this.cbxRoasting.Text = "";
        }


        private void LoadCategoryToComboBoxCategory()
        {
            var q = this.dbContext.Categories.ToList();
            for (int i = 0; i < q.Count; i++)
            {
                this.cbxCategoryName.Items.Add($"{q[i].CategoriesName }");
            }
        }

        private void LoadRoastingToComboBoxRoasting()
        {
            var q = this.dbContext.Roastings.ToList();
            for (int i = 0; i < q.Count; i++)
            {
                this.cbxRoasting.Items.Add($"{q[i].RoastingName}");
            }
        }

        private void LoadProcessToComboBoxProcess()
        {
            var q = this.dbContext.Processes.ToList();
            for (int i = 0; i < q.Count; i++)
            {
                this.cbxProcess.Items.Add($"{q[i].ProcessName}");
            }
        }

        private void LoadPackageToComboBoxPackage()
        {
            var q = this.dbContext.Packages.ToList();
            for (int i = 0; i < q.Count; i++)
            {
                this.cbxPackage.Items.Add($"{q[i].PackageName}");
            }
        }

        private void LoadCountryToComboBoxCountry()
        {
            var q = this.dbContext.Countries.ToList();
            for (int i = 0; i < q.Count; i++)
            {
                this.cbxCountry.Items.Add($"{q[i].CountryName}");
            }

            AutoCompleteStringCollection strings = new AutoCompleteStringCollection(); 

            strings.AddRange(this.dbContext.Countries.Select(x => x.CountryName).ToArray());
            this.cbxCountry.AutoCompleteSource = AutoCompleteSource.CustomSource;
            this.cbxCountry.AutoCompleteCustomSource = strings;
            this.cbxCountry.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
        }

        private void ShowData()
        {
            int categoryID = (int)this.dataGridViewProducts.CurrentRow.Cells[2].Value;
            int productID = (int)this.dataGridViewProducts.CurrentRow.Cells[0].Value;
            int countryID = (this.dataGridViewProducts.CurrentRow.Cells[3].Value) == null ? 1 : (int)this.dataGridViewProducts.CurrentRow.Cells[3].Value;
            int stock = (this.dataGridViewProducts.CurrentRow.Cells[7].Value) == null ? 0 : (int)this.dataGridViewProducts.CurrentRow.Cells[7].Value;
            int star = (this.dataGridViewProducts.CurrentRow.Cells[9].Value) == null ? 0 : (int)this.dataGridViewProducts.CurrentRow.Cells[9].Value;
            int unitPrice = (int)((decimal)this.dataGridViewProducts.CurrentRow.Cells[4].Value);
            var categoryName = this.dbContext.Categories.Where(c => c.CategoryID == categoryID).ToList();
            var countryName = this.dbContext.Countries.Where(c => c.CountryID == countryID).ToList();


            this.txtProductID.Text = this.dataGridViewProducts.CurrentRow.Cells[0].Value.ToString();
            this.txtProductName.Text = this.dataGridViewProducts.CurrentRow.Cells[1].Value.ToString();
            this.cbxCategoryName.Text = categoryName[0].CategoriesName;
            this.txtUnitPrice.Text = unitPrice.ToString();
            this.txtDescription.Text = this.dataGridViewProducts.CurrentRow.Cells[5].Value.ToString();
            this.txtStock.Text = this.dataGridViewProducts.CurrentRow.Cells[6].Value.ToString();
            this.txtClickCount.Text = stock.ToString();
            this.checkboxTakeDown.Checked = (bool)this.dataGridViewProducts.CurrentRow.Cells[8].Value;
            this.txtStar.Text = star.ToString();
            CurrentRow = this.dataGridViewProducts.CurrentRow.Index;

            if (this.cbxCategoryName.Text == "咖啡")
            {
                string roasting = this.dbContext.Coffees.Where(c => c.ProductID == productID).ToList()[0].Roasting.RoastingName.ToString();
                string process = this.dbContext.Coffees.Where(c => c.ProductID == productID).ToList()[0].Process.ProcessName.ToString();
                string package = this.dbContext.Coffees.Where(c => c.ProductID == productID).ToList()[0].Package.PackageName.ToString();
                bool rainForest = this.dbContext.Coffees.Where(c => c.ProductID == productID).ToList()[0].RainForest;

                this.cbxCountry.Text = countryName[0].CountryName;
                this.cbxRoasting.Text = roasting;
                this.cbxProcess.Text = process;
                this.cbxPackage.Text = package;
                this.checkboxRainForest.Checked = rainForest;
            }
            else
            {
                this.cbxCountry.Text = "";
                this.cbxRoasting.Text = "";
                this.cbxProcess.Text = "";
                this.cbxPackage.Text = "";
                this.checkboxRainForest.Checked = false;
            }
        }
        private void ShowPictures()
        {
            int productID = Int32.Parse(this.txtProductID.Text);
            this.flowLayoutPanelProductsPhoto.Controls.Clear();
            var q = this.dbContext.PhotoDetails.Where(p => p.ProductID == productID).Select(s => s.Photo).ToList();
            int photoCount = this.dbContext.PhotoDetails.Where(p => p.ProductID == productID).Count();

            for (int i = 0; i < photoCount; i++)
            {
                PictureBox pic = new PictureBox();
                pic.Image = Image.FromStream(new MemoryStream(q[i].Photo1));
                pic.SizeMode = PictureBoxSizeMode.StretchImage;
                pic.Width = 150;
                pic.Height = 150;
                pic.BorderStyle = BorderStyle.FixedSingle;
                pic.MouseEnter += Pic_MouseEnter;
                pic.MouseLeave += Pic_MouseLeave;
                pic.Padding = new Padding(2, 2, 2, 2);
                flowLayoutPanelProductsPhoto.Controls.Add(pic);
            }
        }

        int CurrentRow;
        private void dataGridViewProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ShowData();
        }

        private void FlowLayOutPanel()
        {
            flowLayoutPanelProductsPhoto.AllowDrop = true;
            flowLayoutPanelProductsPhoto.DragEnter += FlowLayoutPanelProductsPhoto_DragEnter;
            flowLayoutPanelProductsPhoto.DragDrop += FlowLayoutPanelProductsPhoto_DragDrop;
        }

        private void FlowLayoutPanelProductsPhoto_DragDrop(object sender, DragEventArgs e)
        {
            int productID = (int)this.dataGridViewProducts.CurrentRow.Cells[0].Value;
            string[] file = (string[])e.Data.GetData(DataFormats.FileDrop);
            for (int i = 0; i < file.Length; i++)
            {
                PictureBox pic = new PictureBox();
                pic.Image = Image.FromFile(file[i]);
                pic.SizeMode = PictureBoxSizeMode.StretchImage;
                pic.Width = 150;
                pic.Height = 150;
                pic.BorderStyle = BorderStyle.FixedSingle;
                pic.MouseEnter += Pic_MouseEnter;
                pic.MouseLeave += Pic_MouseLeave;
                pic.Padding = new Padding(2, 2, 2, 2);
                flowLayoutPanelProductsPhoto.Controls.Add(pic);

                MemoryStream ms = new MemoryStream();
                pic.Image.Save(ms, ImageFormat.Jpeg);
                byte[] bytes = ms.GetBuffer();
                Photo photo = new Photo { Photo1 = bytes };
                this.dbContext.Photos.Add(photo);
                this.dbContext.SaveChanges();

                int photoID = this.dbContext.Photos.ToList().Last().PhotoID;
                PhotoDetail photoDetail = new PhotoDetail { ProductID = productID, PhotoID = photoID };
                this.dbContext.PhotoDetails.Add(photoDetail);
            }

            this.dbContext.SaveChanges();
        }

        private void FlowLayoutPanelProductsPhoto_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void Pic_MouseLeave(object sender, EventArgs e)
        {
            ((PictureBox)sender).BackColor = Color.Transparent;
        }

        private void Pic_MouseEnter(object sender, EventArgs e)
        {
            ((PictureBox)sender).BackColor = Color.BurlyWood;
        }

     
        private void txtProductID_TextChanged(object sender, EventArgs e)
        {
            ShowPictures();
        }

        private void btnClearPic_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("確認移除所有圖片 ?", "提醒", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                List<int> photoIDList = new List<int>();

                int productID = Int32.Parse(this.txtProductID.Text);
                var photo = this.dbContext.PhotoDetails.Where(p => p.ProductID == productID);
                for (int i = 0; i < photo.ToList().Count; i++)

                {
                    var q = this.dbContext.Photos.AsEnumerable().Where(p => p.PhotoID == photo.ToList()[i].PhotoID).ToList();
                    this.dbContext.Photos.Remove(q[i]);
                }

                for (int i = 0; i < photo.ToList().Count; i++)
                {
                    this.dbContext.PhotoDetails.Remove(photo.ToList()[i]);
                }
                this.dbContext.SaveChanges();
                LoadDataToDataGridView();                
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.cbxCategoryName.Text == "咖啡")
                {
                    var categoryID = this.dbContext.Categories.Where(c => c.CategoriesName == this.cbxCategoryName.Text).ToList();
                    var countryID = this.dbContext.Countries.Where(c => c.CountryName == this.cbxCountry.Text).ToList();
                    var roastingID = this.dbContext.Roastings.Where(r => r.RoastingName == this.cbxRoasting.Text).ToList();
                    var processID = this.dbContext.Processes.Where(p => p.ProcessName == this.cbxProcess.Text).ToList();
                    var packageID = this.dbContext.Packages.Where(p => p.PackageName == this.cbxPackage.Text).ToList();
                    decimal price = Decimal.Parse(this.txtUnitPrice.Text);
                    int stock = Int32.Parse(this.txtStock.Text);

                    Product product = new Product { ProductName = this.txtProductName.Text, CategoryID = categoryID[0].CategoryID, CountryID = countryID[0].CountryID, Price = price, Description = this.txtDescription.Text, Stock = stock, TakeDown = checkboxTakeDown.Checked };
                    this.dbContext.Products.Add(product);
                    this.dbContext.SaveChanges();

                    var productID = this.dbContext.Products.AsEnumerable().Last().ProductID;

                    Coffee coffee = new Coffee { ProductID = productID, CoffeeName = this.txtProductName.Text, CountryID = countryID[0].CountryID, RoastingID = roastingID[0].RoastingID, ProcessID = processID[0].ProcessID, PackageID = packageID[0].PackageID, RainForest = checkboxRainForest.Checked };
                    this.dbContext.Coffees.Add(coffee);
                    this.dbContext.SaveChanges();
                    LoadDataToDataGridView();
                    ControlsDataClear();
                }
                else
                {
                    var categoryID = this.dbContext.Categories.Where(c => c.CategoriesName == this.cbxCategoryName.Text).ToList();
                    decimal price = Decimal.Parse(this.txtUnitPrice.Text);
                    int stock = Int32.Parse(this.txtStock.Text);

                    Product product = new Product { ProductName = this.txtProductName.Text, CategoryID = categoryID[0].CategoryID, Price = price, Description = this.txtDescription.Text, Stock = stock, TakeDown = checkboxTakeDown.Checked };
                    this.dbContext.Products.Add(product);
                    this.dbContext.SaveChanges();
                    LoadDataToDataGridView();
                    ControlsDataClear();
                }

                int rowsCount = this.dataGridViewProducts.Rows.Count;
                this.dataGridViewProducts.CurrentCell = this.dataGridViewProducts.Rows[rowsCount - 1].Cells[0];
                ShowData();
                ShowPictures();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRevise_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("確認修改商品資料 ?", "提醒", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    int productID = (int)this.dataGridViewProducts.CurrentRow.Cells[0].Value;
                    var categoryID = this.dbContext.Categories.Where(c => c.CategoriesName == this.cbxCategoryName.Text).ToList();
                    var countryID = this.dbContext.Countries.Where(c => c.CountryName == this.cbxCountry.Text).ToList();
                    var roastingID = this.dbContext.Roastings.Where(r => r.RoastingName == this.cbxRoasting.Text).ToList();
                    var processID = this.dbContext.Processes.Where(p => p.ProcessName == this.cbxProcess.Text).ToList();
                    var packageID = this.dbContext.Packages.Where(p => p.PackageName == this.cbxPackage.Text).ToList();

                    if (this.cbxCategoryName.Text == "咖啡")
                    {
                        var product = this.dbContext.Products.FirstOrDefault(p => p.ProductID == productID);
                        product.ProductName = this.txtProductName.Text;
                        product.CategoryID = categoryID[0].CategoryID;
                        product.Price = Int32.Parse(this.txtUnitPrice.Text);
                        product.Description = this.txtDescription.Text;
                        product.Stock = Int32.Parse(this.txtStock.Text);
                        product.TakeDown = this.checkboxTakeDown.Checked;
                        this.dbContext.SaveChanges();

                        var coffee = this.dbContext.Coffees.FirstOrDefault(c => c.ProductID == productID);
                        coffee.CoffeeName = this.txtProductName.Text;
                        coffee.CountryID = countryID[0].CountryID;
                        coffee.RoastingID = roastingID[0].RoastingID;
                        coffee.ProcessID = processID[0].ProcessID;
                        coffee.PackageID = packageID[0].PackageID;
                        coffee.RainForest = this.checkboxRainForest.Checked;
                    }
                    else
                    {
                        var product = this.dbContext.Products.FirstOrDefault(p => p.ProductID == productID);
                        product.ProductName = this.txtProductName.Text;
                        product.CategoryID = categoryID[0].CategoryID;
                        product.Price = Int32.Parse(this.txtUnitPrice.Text);
                        product.Description = this.txtDescription.Text;
                        product.Stock = Int32.Parse(this.txtStock.Text);
                        product.TakeDown = this.checkboxTakeDown.Checked;                                            
                    }
                   
                    this.dbContext.SaveChanges();
                    MessageBox.Show("修改成功");
                    LoadDataToDataGridView();
                    ControlsDataClear();

                    int rowsCount = this.dataGridViewProducts.Rows.Count;
                    this.dataGridViewProducts.CurrentCell = this.dataGridViewProducts.Rows[CurrentRow].Cells[0];
                    ShowData();
                    ShowPictures();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int productID = Int32.Parse(this.txtProductID.Text);

                if (MessageBox.Show("確認刪除此商品 ?", "提醒", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    if (this.cbxCategoryName.Text == "咖啡")
                    {                        
                        var q = this.dbContext.Coffees.Where(c => c.ProductID == productID).FirstOrDefault();
                        this.dbContext.Coffees.Remove(q);
                        var qu = this.dbContext.Products.Where(p => p.ProductID == productID).FirstOrDefault();
                        this.dbContext.Products.Remove(qu);                        
                    }
                    else
                    {                        
                        var qu = this.dbContext.Products.Where(p => p.ProductID == productID).FirstOrDefault();
                        this.dbContext.Products.Remove(qu);
                    }

                    this.dbContext.SaveChanges();
                    LoadDataToDataGridView();
                    ControlsDataClear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
