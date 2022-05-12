using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace AdminClient
{
    public partial class Orders : Form
    {
        public Orders()
        {
            InitializeComponent();
            LoadDataToDataGridView();
            CreateYearToComboBox();
            CreateMonthToComboBox();
            CreateStateToComboBox();
        }

        CoffeeEntities dbContext = new CoffeeEntities();

        private void LoadDataToDataGridView()
        {   
            DataClear();
            this.dataGridViewOrders.DataSource = this.dbContext.Orders.AsEnumerable()
                .Select(o => new
                {
                    o.OrderID,
                    o.Member.MemberName,
                    o.OrderDate,
                    OrderState = o.OrderState.OrderState1,
                    Payment = o.Payment.Payment1,
                    o.OrderAddress,
                    CouponName = CouponNameCheck(o.CouponID),
                    OriginalPrice = $"{(o.OrderDetails.Sum(x=>x.Product.Price*x.Quantity) >= 1200 ? o.OrderDetails.Sum(x => x.Product.Price * x.Quantity) : o.OrderDetails.Sum(x => x.Product.Price * x.Quantity) + 80):c0}",
                    TotalAmount = $"{(o.OrderDetails.Sum(x => x.Product.Price * x.Quantity) >= 1200 ? o.OrderDetails.Sum(x => x.Product.Price * x.Quantity) : o.OrderDetails.Sum(x => x.Product.Price * x.Quantity) + 80) - CouponMoneyCheck(o.CouponID):c0}"
                }).ToList();            
        }
      
        private void CreateYearToComboBox()
        {
            this.cbxYear.DataSource = this.dbContext.Orders
                .Select(s => s.OrderDate.Year).Distinct().ToList();
        }

        private void CreateMonthToComboBox()
        {
            this.cbxMonth.Items.Add("/");
            for (int i = 1; i <= 12; i++)
            {
                this.cbxMonth.Items.Add(i);
            }
        }

        private void CreateStateToComboBox()
        {
            this.cbxOrderState.DataSource = this.dbContext.OrderStates
                .Select(s => s.OrderState1).ToList();
            this.cbxReviseState.DataSource = this.dbContext.OrderStates
               .Select(s => s.OrderState1).ToList();
        }

        private void DataClear()
        {            
            this.dataGridViewOrders.DataSource = null;
        }

        private decimal CouponMoneyCheck(int? CouponID)
        {
            if (CouponID is null) return 0;
            else
            {
                var qc = dbContext.Coupons.Where(x => x.CouponID == CouponID).Select(x => x.Money).ToList();
                return qc[0];
            }
        }

        private string CouponNameCheck(int? CouponID)
        {
            string nullname = " ";
            if (CouponID == null)
                return nullname;
            else
            {
                var qs = dbContext.Coupons.Where(x => x.CouponID == CouponID).Select(s => s.CouponName).ToList();
                return qs[0];
            }
        }

        private void ShowData()
        {
            int orderID = (int)this.dataGridViewOrders.CurrentRow.Cells[0].Value;

            this.dataGridViewOrderDetails.DataSource = null;
            this.dataGridViewOrderDetails.DataSource = this.dbContext.OrderDetails
                .Where(od => od.OrderID == orderID)
                .Select(s => new { s.OrderID, s.ProductID, ProductName = s.Product.ProductName, s.Quantity }).ToList();
            CurrentRow = this.dataGridViewOrders.CurrentRow.Index;
        }

        private void ResetComboxReviseStateSelectIndex()
        {
            this.cbxReviseState.SelectedIndex = 0;
        }

        private void btnSearchOrderDate_Click(object sender, EventArgs e)
        {
            DataClear();
            int selectedYear = Int32.Parse(this.cbxYear.Text);
            int selectedMonth = this.cbxMonth.SelectedIndex;

            if (this.cbxMonth.Text == "/")
            {
                this.dataGridViewOrders.DataSource = this.dbContext.Orders.AsEnumerable()
                                        .Where(o => o.OrderDate.Year == selectedYear).Select(o => new
                                        {
                                            o.OrderID,
                                            o.Member.MemberName,
                                            o.OrderDate,
                                            OrderState = o.OrderState.OrderState1,
                                            Payment = o.Payment.Payment1,
                                            o.OrderAddress,
                                            CouponName = CouponNameCheck(o.CouponID),
                                            OriginalPrice = $"{(o.OrderDetails.Sum(x => x.Product.Price * x.Quantity) >= 1200 ? o.OrderDetails.Sum(x => x.Product.Price * x.Quantity) : o.OrderDetails.Sum(x => x.Product.Price * x.Quantity) + 80):c0}",
                                            TotalAmount = $"{(o.OrderDetails.Sum(x => x.Product.Price * x.Quantity) >= 1200 ? o.OrderDetails.Sum(x => x.Product.Price * x.Quantity) : o.OrderDetails.Sum(x => x.Product.Price * x.Quantity) + 80) - CouponMoneyCheck(o.CouponID):c0}"
                                        }).ToList();
            }
            else
            {
                this.dataGridViewOrders.DataSource = this.dbContext.Orders.AsEnumerable()
                    .Where(o => o.OrderDate.Year == selectedYear && o.OrderDate.Month == selectedMonth).Select(o => new
                {
                    o.OrderID,
                    o.Member.MemberName,
                    o.OrderDate,
                    OrderState = o.OrderState.OrderState1,
                    Payment = o.Payment.Payment1,
                    o.OrderAddress,
                        CouponName = CouponNameCheck(o.CouponID),
                        OriginalPrice = $"{(o.OrderDetails.Sum(x => x.Product.Price * x.Quantity) >= 1200 ? o.OrderDetails.Sum(x => x.Product.Price * x.Quantity) : o.OrderDetails.Sum(x => x.Product.Price * x.Quantity) + 80):c0}",
                        TotalAmount = $"{(o.OrderDetails.Sum(x => x.Product.Price * x.Quantity) >= 1200 ? o.OrderDetails.Sum(x => x.Product.Price * x.Quantity) : o.OrderDetails.Sum(x => x.Product.Price * x.Quantity) + 80) - CouponMoneyCheck(o.CouponID):c0}"
                    }).ToList();
            }            
        }

        private void btnSearchOrderState_Click(object sender, EventArgs e)
        {
            DataClear();
            string states = this.cbxOrderState.Text;

            this.dataGridViewOrders.DataSource = this.dbContext.Orders.AsEnumerable()
                .Where(o => o.OrderState.OrderState1 == states).Select(o => new
            {
                o.OrderID,
                o.Member.MemberName,
                o.OrderDate,
                OrderState = o.OrderState.OrderState1,
                Payment = o.Payment.Payment1,
                o.OrderAddress,
                CouponName = CouponNameCheck(o.CouponID),
                    OriginalPrice = $"{(o.OrderDetails.Sum(x => x.Product.Price * x.Quantity) >= 1200 ? o.OrderDetails.Sum(x => x.Product.Price * x.Quantity) : o.OrderDetails.Sum(x => x.Product.Price * x.Quantity) + 80):c0}",
                    TotalAmount = $"{(o.OrderDetails.Sum(x => x.Product.Price * x.Quantity) >= 1200 ? o.OrderDetails.Sum(x => x.Product.Price * x.Quantity) : o.OrderDetails.Sum(x => x.Product.Price * x.Quantity) + 80) - CouponMoneyCheck(o.CouponID):c0}"
                }).ToList();            
        }

        private void btnRevise_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("確認修改此筆訂單狀態 ?", "提醒", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    int CurrentRowOrderID = (int)this.dataGridViewOrders.CurrentRow.Cells[0].Value;

                    var q = this.dbContext.Orders.FirstOrDefault(o => o.OrderID == CurrentRowOrderID);
                    var id = this.dbContext.OrderStates
                        .Where(os => os.OrderState1 == cbxReviseState.Text)
                        .Select(s => s.OrderStateID).ToList();

                    q.OrderStateID = id[0];

                    MessageBox.Show("修改成功");
                    this.dbContext.SaveChanges();
                    LoadDataToDataGridView();
                    int rowCount = this.dataGridViewOrders.Rows.Count;
                    this.dataGridViewOrders.CurrentCell = this.dataGridViewOrders.Rows[CurrentRow].Cells[0];
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            ResetComboxReviseStateSelectIndex();
        }

        private void btnSearchOrderID_Click(object sender, EventArgs e)
        {
            try
            {                
                int OrderID = Int32.Parse(this.txtSearchOrderID.Text);
                this.dataGridViewOrders.DataSource = this.dbContext.Orders.AsEnumerable()
                    .Where(o => o.OrderID == OrderID).Select(o => new
                    {
                        o.OrderID,
                        o.Member.MemberName,
                        o.OrderDate,
                        OrderState = o.OrderState.OrderState1,
                        Payment = o.Payment.Payment1,
                        o.OrderAddress,
                        CouponName = CouponNameCheck(o.CouponID),
                        OriginalPrice = $"{(o.OrderDetails.Sum(x => x.Product.Price * x.Quantity) >= 1200 ? o.OrderDetails.Sum(x => x.Product.Price * x.Quantity) : o.OrderDetails.Sum(x => x.Product.Price * x.Quantity) + 80):c0}",
                        TotalAmount = $"{(o.OrderDetails.Sum(x => x.Product.Price * x.Quantity) >= 1200 ? o.OrderDetails.Sum(x => x.Product.Price * x.Quantity) : o.OrderDetails.Sum(x => x.Product.Price * x.Quantity) + 80) - CouponMoneyCheck(o.CouponID):c0}"
                    }).ToList();

                if (this.dataGridViewOrders.Rows.Count == 0)
                {
                    MessageBox.Show("查無此訂單編號","提醒", MessageBoxButtons.OK);
                    this.txtSearchOrderID.Select();
                    LoadDataToDataGridView();
                    this.dataGridViewOrderDetails.DataSource = null;
                }

                this.txtSearchOrderID.Clear();
            }
            catch
            {
                MessageBox.Show("請確認訂單編號正確無誤","提醒", MessageBoxButtons.OK);
                return;
            }           
        }

        private void btnSelectAllOrders_Click(object sender, EventArgs e)
        {
            LoadDataToDataGridView();
            this.dataGridViewOrderDetails.DataSource = null;
        }

        int CurrentRow;
        private void dataGridViewOrders_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ShowData();
            this.pictureBoxProduct.Image = null;
        }

        private void btnDeleteCancelledOrders_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("確認刪除所有筆已取消訂單 ?", "提醒", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    var q = this.dbContext.Orders.Where(o => o.OrderState.OrderState1 == "已取消").ToList();


                    for (int i = 0; i < q.Count; i++)
                    {
                        int orderID = q[i].OrderID;
                        var orderDetails = this.dbContext.OrderDetails.Where(o => o.OrderID == orderID).ToList();

                        for (int j = 0; j < orderDetails.Count; j++)
                        {
                            int productID = orderDetails[j].ProductID;
                            int quantity = orderDetails[j].Quantity;

                            var product = this.dbContext.Products.FirstOrDefault(p => p.ProductID == productID);
                            product.Stock = product.Stock + quantity;

                            this.dbContext.OrderDetails.Remove(orderDetails[j]);
                        }

                        this.dbContext.Orders.Remove(q[i]);
                    }                    
                                        
                    this.dbContext.SaveChanges();
                    LoadDataToDataGridView();
                    this.dataGridViewOrderDetails.DataSource = null;
                    MessageBox.Show("刪除成功");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            ResetComboxReviseStateSelectIndex();
        }

        private void dataGridViewOrderDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int productID = (int)this.dataGridViewOrderDetails.CurrentRow.Cells[1].Value;

            var q = this.dbContext.PhotoDetails.AsEnumerable().Where(p => p.ProductID == productID).Select(s => new { s.ProductID, s.Photo.Photo1 }).ToList();
            if (q.Count == 0)
            {
                pictureBoxProduct.Image = null;
            }
            else
            {
                pictureBoxProduct.Image = q[0].Photo1 == null ? null : Image.FromStream(new MemoryStream(q[0].Photo1));
            }
            
        }  
    }
}
