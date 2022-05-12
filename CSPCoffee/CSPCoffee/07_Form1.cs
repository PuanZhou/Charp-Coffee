using CSPCoffee.Properties;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSPCoffee
{
    public partial class Form1 : Form
    {
        CoffeeEntities1 db = new CoffeeEntities1();
        public HashSet<int> cList = new HashSet<int>();
        public List<int> List = new List<int>();
        public int memberID = 0;
        public Form1()
        {
            InitializeComponent();
            CreatBanner();
            LoadTreeNode();
            SujectTxt();
            
        }

        //Banner==========================================
        PDcontrol[] pds = new PDcontrol[6];
        bool mouseDrog = false;
        int curX, dX;
        Random rd = new Random();
        public void disBanner()
        {
            foreach (PDcontrol item in pds)
            {
                item.Dispose();
            }
        }
        public void CreatBanner()
        {
            var q1 = db.Products.OrderByDescending(x => x.Stock).Take(5).Select(x => x.ProductID);
            var q2 = db.OrderDetails.OrderBy(x => x.Order.OrderDate).Take(5).Select(x => x.ProductID);
            var q = q1.AsEnumerable().Concat(q2).Distinct().OrderBy(x => rd.Next()).Take(pds.Length).ToArray();
            for (int i = 0; i < pds.Length; i++)
            {
                pds[i] = new PDcontrol(q[i], memberID);
                pds[i].Location = new Point(97 + i * 198, 20);
                pds[i].MouseDown += (object sender, MouseEventArgs e) => { mouseDrog = true; curX = e.X; };
                pds[i].MouseUp += (object sender, MouseEventArgs e) => { mouseDrog = false; curX = dX = 0; };
                pds[i].MouseEnter += (object sender, EventArgs e) => timer1.Enabled = false;
                pds[i].MouseLeave += (object sender, EventArgs e) => timer1.Enabled = true;
                pds[i].MouseMove += bannerMM;
                pds[i].button1.Visible = pds[i].button2.Visible = false;
                pds[i].Size = new Size(194, 190);
                splitContainer1.Panel1.Controls.Add(pds[i]);
            }
            label5.Location = new Point(0, pds[0].Location.Y - 1);
            label6.Location = new Point(1462, pds[0].Location.Y - 1);
            label5.Size = new Size(412, pds[0].Height + 1);
            label6.Size = new Size(467, pds[0].Height + 1);

        }
        private void bannerMM(object sender, MouseEventArgs e)
        {
            if (mouseDrog)
            {
                dX = e.X - curX;
                CheckPicX();
            }
            foreach (int n in cList)
            {
                List.Add(n);
            }
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = 100;
            foreach (PDcontrol pic in pds)
            {
                pic.Location = new Point(pic.Location.X - 2, pic.Location.Y);
                CheckPicX();
            }
        }

        private void CheckPicX()
        {
            foreach (PDcontrol pic in pds)
            {
                pic.Location = new Point(pic.Location.X + dX, pic.Location.Y);
                if (pic.Location.X + pic.Width <= label5.Location.X + label5.Width)
                {
                    pic.Location = new Point(pic.Location.X + pds.Length * (pic.Width+5), pic.Location.Y);
                }
                if (pic.Location.X > label6.Location.X)
                {
                    pic.Location = new Point(pic.Location.X - pds.Length * (pic.Width+5), pic.Location.Y);
                }
            }
        }
        //TreeView=============================================
        private void LoadTreeNode()
        {
            var qc = db.Coffees.Select(n => new {
                cnN = n.Country.Continent.ContinentName,
                coN = n.Country.CountryName,
                roN = n.Roasting.RoastingName,
                prN = n.Process.ProcessName,
                paN = n.Package.PackageName,
                cfN = n.CoffeeName,
                rfF = n.RainForest,
            });
            var qp = db.Products.Where(c => c.CategoryID != 1).Select(n => new
            {
                cID = n.CategoryID,
                cgN = n.Category.CategoriesName,
                pdN = n.ProductName
            });


            //TreeNode node0 = treeView1.Nodes.Add($"雨林樹娃咖啡({qc.Select(n => n.rfF).Distinct().Count()})");
            ////foreach (string t1 in qc.Where(x => x.rfF).Select(n => n.cfN).Distinct())
            ////{
            ////    TreeNode node1 = node0.Nodes.Add($"{t1}({qc.Where(c => c.cfN == t1).Count()})");
            ////    node1.Name = t1;
            ////}
            TreeNode node0 = treeView1.Nodes.Add($"原產地({qc.Select(n => n.cnN).Distinct().Count()}大洲)");
            foreach (string t1 in qc.Select(s => s.cnN).Distinct())
            {
                TreeNode node1 = node0.Nodes.Add($"{t1}({qc.Where(n => n.cnN == t1).Select(n => n.coN).Distinct().Count()}國家)");
                node1.Name = t1;
                foreach (string t2 in qc.Where(s => s.cnN == t1).Select(n => n.coN).Distinct())
                {
                    TreeNode node2 = node1.Nodes.Add($"{t2}({qc.Where(n => n.coN == t2).Select(n => n.coN).Distinct().Count()}種咖啡)");
                    node2.Name = t2;
                    //foreach (string t3 in qc.Where(s => s.coN == t2).Select(n => n.cfN).Distinct())
                    //{
                    //    TreeNode node3 = node2.Nodes.Add(t3);
                    //    node3.Name = t3;
                    //}
                }
            }
            node0 = treeView1.Nodes.Add($"焙度({qc.Select(n => n.roN).Distinct().Count()}種焙度)");
            foreach (string t1 in qc.Select(s => s.roN).Distinct())
            {
                TreeNode node1 = node0.Nodes.Add($"{t1}({qc.Where(c => c.roN == t1).Count()}種咖啡)");
                node1.Name = t1;
                //foreach (string t2 in qc.Where(s => s.roN == t1).Select(n => n.cfN))
                //{
                //    TreeNode node2 = node1.Nodes.Add(t2);
                //    node2.Name = t2;
                //}
            }
            node0 = treeView1.Nodes.Add($"處理法({qc.Select(n => n.prN).Distinct().Count()}種處理法)"); ;
            foreach (string t1 in qc.Select(s => s.prN).Distinct())
            {
                TreeNode node1 = node0.Nodes.Add($"{t1}({qc.Where(c => c.prN == t1).Count()}種咖啡)");
                node1.Name = t1;
                //foreach (string t2 in qc.Where(s => s.prN == t1).Select(n => n.cfN))
                //{
                //    TreeNode node2 = node1.Nodes.Add(t2);
                //    node2.Name = t2;
                //}
            }
            node0 = treeView1.Nodes.Add($"包裝({qc.Select(n => n.paN).Distinct().Count()}種包裝)");
            foreach (string t1 in qc.Select(s => s.paN).Distinct())
            {
                TreeNode node1 = node0.Nodes.Add($"{t1}({qc.Where(c => c.paN == t1).Count()}種咖啡)");
                node1.Name = t1;
                //foreach (string t2 in qc.Where(s => s.paN == t1).Select(n => n.cfN))
                //{
                //    TreeNode node2 = node1.Nodes.Add(t2);
                //    node2.Name = t2;
                //}
            }
            node0 = treeView1.Nodes.Add($"咖啡周邊商品({qp.Select(n => n.cgN).Count()}類)");
            foreach (string t1 in qp.Select(s => s.cgN).Distinct())
            {
                TreeNode node1 = node0.Nodes.Add($"{t1}({qp.Where(c => c.cgN == t1).Count()}個產品)");
                node1.Name = t1;
                //foreach (string t2 in qp.Where(s => s.cgN == t1).Select(n => n.pdN))
                //{
                //    TreeNode node2 = node1.Nodes.Add(t2);
                //    node2.Name = t2;
                //}
            }
        }
        private void btnRain_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            var qr = db.Coffees.Where(x => x.RainForest).Select(s => new { pID = s.ProductID }).ToList();
            PDcontrol[] pdc = new PDcontrol[qr.Count];
            for (int i = 0; i < qr.Count; i++)
            {
                pdc[i] = new PDcontrol(qr[i].pID, memberID);
                flowLayoutPanel1.Controls.Add(pdc[i]);
            }
        }

        PDcontrol[] pdc;
        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            TreeNode node = e.Node;
            flowLayoutPanel1.Controls.Clear();

            var qc = db.Products.Select(n => new {rfN = n.Coffee.RainForest,cnN = n.Coffee.Country.Continent.ContinentName
                ,coN = n.Coffee.Country.CountryName,roN = n.Coffee.Roasting.RoastingName,prN = n.Coffee.Process.ProcessName
                ,paN = n.Coffee.Package.PackageName,cfN = n.Coffee.CoffeeName,cgN = n.Category.CategoriesName,pID = n.ProductID
            }).Where(c => (c.cnN == node.Name || c.coN == node.Name || c.roN == node.Name ||
                c.prN == node.Name || c.paN == node.Name || c.cfN == node.Name || c.cgN == node.Name)).Select(c => new { c.pID }).ToList();

            pdc = new PDcontrol[qc.Count];
            for (int i = 0; i < qc.Count; i++)
            {
                pdc[i] = new PDcontrol(qc[i].pID, memberID);

                
                    if (List.Count != 0 && List.Contains(qc[i].pID) )
                    {
                        pdc[i].button2.Text = "取消比較";
                        pdc[i].button1.Visible = true;
                    }
                    else
                    {
                        pdc[i].button2.Text = "加入比較";
                        pdc[i].button1.Visible = false;
                    }
                flowLayoutPanel1.Controls.Add(pdc[i]);
            }
        }
        bool flagCollapseA = true;
        bool flagCollapseC = true;
        bool flagCollapseO = true;

        private void btnCollapse_Click(object sender, EventArgs e)
        {
            if (flagCollapseA)
            {
                treeView1.ExpandAll();
                treeView1.SelectedNode = treeView1.Nodes[0];
                btnCollapse.Text = "全部收闔";
                flagCollapseC = flagCollapseO = false;
                btnCoCollapse.Text = "產地收闔";
                btnOthCollapse.Text = "其它收闔";
            }
            else
            {
                treeView1.CollapseAll();
                btnCollapse.Text = "全部展開";
                flagCollapseC = flagCollapseO = true;
                btnCoCollapse.Text = "產地展開";
                btnOthCollapse.Text = "其它展開";
            }
            flagCollapseA = !flagCollapseA;
        }
        private void btnCoCollapse_Click(object sender, EventArgs e)
        {
            if (flagCollapseC)
            {
                treeView1.Nodes[0].ExpandAll();
                treeView1.SelectedNode = treeView1.Nodes[0];
                btnCoCollapse.Text = "產地收闔";
            }
            else
            {
                treeView1.Nodes[0].Collapse();
                btnCoCollapse.Text = "產地展開";
            }
            flagCollapseC = !flagCollapseC;
            if (!flagCollapseC && !flagCollapseO)
            {
                flagCollapseA = false;
                btnCollapse.Text = "全部收闔";
            }
        }
        private void btnOthCollapse_Click(object sender, EventArgs e)
        {
            if (flagCollapseO)
            {
                for (int i = 1; i < treeView1.Nodes.Count; i++)
                {
                    treeView1.Nodes[i].ExpandAll();
                }
                treeView1.SelectedNode = treeView1.Nodes[1];
                btnOthCollapse.Text = "其它收闔";
            }
            else
            {
                for (int i = 1; i < treeView1.Nodes.Count; i++)
                {
                    treeView1.Nodes[i].Collapse();
                }
                btnOthCollapse.Text = "其它展開";
            }
            flagCollapseO = !flagCollapseO;
            if (!flagCollapseC && !flagCollapseO)
            {
                flagCollapseA = false;
                btnCollapse.Text = "全部收闔";
            }
            else if (flagCollapseC && flagCollapseO)
            {
                flagCollapseA = true;
                btnCollapse.Text = "全部展開";
            }
        }

        //TextBox Auto Complete=============================================
        private void SujectTxt()
        {
            AutoCompleteStringCollection strings = new AutoCompleteStringCollection();
            strings.AddRange(db.Categories.Select(x => x.CategoriesName).ToArray());
            strings.AddRange(db.Coffees.Select(x => x.CoffeeName).ToArray());
            strings.AddRange(db.Coffees.Select(x => x.CoffeeName).ToArray());
            strings.AddRange(db.Continents.Select(x => x.ContinentName).ToArray());
            strings.AddRange(db.Countries.Select(x => x.CountryName).ToArray());
            strings.AddRange(db.Packages.Select(x => x.PackageName).ToArray());
            strings.AddRange(db.Processes.Select(x => x.ProcessName).ToArray());
            strings.AddRange(db.Products.Select(x => x.ProductName).ToArray());
            strings.AddRange(db.Roastings.Select(x => x.RoastingName).ToArray());
            txtSearch.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtSearch.AutoCompleteCustomSource = strings;
            txtSearch.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
        }

        private void timer3Enable()
        {
            if (txtSearch.Text != "") return;
            timer2.Enabled = false;
            timer3.Enabled = true;
        }
        private void timer2Enable()
        {
            timer2.Enabled = true;
            timer3.Enabled = false;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (txtSearch.Width <= 310)
            {
                txtSearch.Width += 60;
                txtSearch.Location = new Point(txtSearch.Location.X - 60, txtSearch.Location.Y);
            }
            else
                timer2.Enabled = false;
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (txtSearch.Width >= 40)
            {
                txtSearch.Width -= 60;
                txtSearch.Location = new Point(txtSearch.Location.X + 60, txtSearch.Location.Y);
            }
            else
                timer3.Enabled = false;
        }
        private void picSearch_MouseEnter(object sender, EventArgs e)
        {
            timer2Enable();
        }
        private void txtSearch_MouseEnter(object sender, EventArgs e)
        {
            timer2Enable();
        }
        private void picSearch_MouseLeave(object sender, EventArgs e)
        {
            timer3Enable();
        }

        private void txtSearch_MouseLeave(object sender, EventArgs e)
        {
            timer3Enable();
        }

        private void picSearch_Click(object sender, EventArgs e)
        {
            searchItem();
        }


        private void searchItem()
        {
            flowLayoutPanel1.Controls.Clear();

            var qp = db.Products.AsEnumerable().Select(n => new { poN = n.ProductName, caN = n.Category.CategoriesName, pID = n.ProductID })
                .Where(c => fuzzy(c.poN) || fuzzy(c.caN)).Select(c => new { c.pID });

            var qc = db.Coffees.AsEnumerable().Select(n => new {
                cnN = n.Country.Continent.ContinentName
                ,
                coN = n.Country.CountryName,
                roN = n.Roasting.RoastingName
                ,
                prN = n.Process.ProcessName,
                paN = n.Package.PackageName
                ,
                cfN = n.CoffeeName,
                pID = n.ProductID
            }).Where(c => fuzzy(c.cnN) || fuzzy(c.coN) || fuzzy(c.roN) || fuzzy(c.prN) || fuzzy(c.paN) || fuzzy(c.cfN))
            .Select(c => new { c.pID });

            var q = qc.Concat(qp).Distinct().ToList();

            PDcontrol[] pdc = new PDcontrol[q.Count()];
            for (int i = 0; i < q.Count(); i++)
            {
                pdc[i] = new PDcontrol(q[i].pID, memberID);
                flowLayoutPanel1.Controls.Add(pdc[i]);
            }
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) searchItem();
        }
        public bool fuzzy(string item)
        {
            if (item.Contains(txtSearch.Text)) return true;
            return false;
        }

        //Online Service================================================
        private void lblOLService_Click(object sender, EventArgs e)
        {
            if (memberID == 0)
            {
                MessageBox.Show("請先登入會員");
                return;
            }
            FrmOLService f = new FrmOLService(memberID);
            f.Show();
        }
        public void noButton()
        {
            foreach (PDcontrol item in pds)
            {
                item.button1.Visible = false;
            }

            if (pdc is null) return;

            foreach (PDcontrol item in pdc)
            {
                item.button1.Visible = false;
            }
            //BecomeVisable();
        }

        private void btnCart_Click(object sender, EventArgs e)
        {
            if (memberID == 0)
            {
                MessageBox.Show("請先登入會員");
                return;
            }

            new Car1
            {

                memID = memberID
            }.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {//關於我
            this.flowLayoutPanel1.Controls.Clear();
            //關於我圖1
            var q = from n in db.IntroducePhotos
                    where n.IntroducePhotosID == 24
                    select new
                    {
                        picture = n.IntroducePhoto1
                    };
            foreach (var item in q)
            {
                Photo_Big PB = new Photo_Big();
                byte[] bytes = (byte[])item.picture;
                System.IO.MemoryStream ms = new System.IO.MemoryStream(bytes);
                PB.FlagPhoto = Image.FromStream(ms);
                this.flowLayoutPanel1.Controls.Add(PB);
            }
            //關於我文1
            Box_small BS = new Box_small();
            var q1 = from n in db.Introduces
                     where n.IntroducesID == 12
                     select n.Description;
            BS.FlagIntroduce = q1.ToList()[0];
            this.flowLayoutPanel1.Controls.Add(BS);
            //關於我圖2
            var q2 = from n in db.IntroducePhotos
                     where n.IntroducePhotosID == 25
                     select new
                     {
                         picture = n.IntroducePhoto1
                     };
            foreach (var item in q2)
            {
                Photo_Big PB = new Photo_Big();
                byte[] bytes = (byte[])item.picture;
                System.IO.MemoryStream ms = new System.IO.MemoryStream(bytes);
                PB.FlagPhoto = Image.FromStream(ms);
                this.flowLayoutPanel1.Controls.Add(PB);
            }
            //關於我文2
            Box_small BS2 = new Box_small();
            var q3 = from n in db.Introduces
                     where n.IntroducesID == 13
                     select n.Description;
            BS2.FlagIntroduce = q3.ToList()[0];
            this.flowLayoutPanel1.Controls.Add(BS2);

        }

        private void label2_Click(object sender, EventArgs e)
        {//最新消息
            this.flowLayoutPanel1.Controls.Clear();
            var q = from n in db.News
                    where n.NewsOverTime.Value > DateTime.Now && n.NewsStartTime < DateTime.Now
                    orderby n.NewsStartTime descending
                    select new
                    {
                        開始時間 = n.NewsStartTime,
                        活動內容 = n.NewsDescription
                    };

            foreach (var item in q.Take(5))
            {
                NewsControl NC = new NewsControl();
                NC.TimeStart = item.開始時間.Value;
                NC.News = item.活動內容;
                this.flowLayoutPanel1.Controls.Add(NC);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            //相關文章
            this.flowLayoutPanel1.Controls.Clear();
            var q = from n in db.Introduces
                    where n.IntroducesName != null
                    orderby n.IntroducesID
                    select new
                    {
                        intros = n.IntroducesName,
                        introsphoto = n.IntroducePhotos,
                        introID = n.IntroducesID
                    };
            foreach (var item in q)
            {

                var q2 = from n in db.IntroducePhotos
                         where n.IntroduceID == item.introID
                         select n.IntroducePhoto1;
                byte[] bts = q2.ToList()[1];
                System.IO.MemoryStream ms = new System.IO.MemoryStream(bts);

                IntroduceUsControl IUC = new IntroduceUsControl();

                IUC.IntroduceImage = Image.FromStream(ms);

                IUC.IntroduceMessage = item.intros;
                this.flowLayoutPanel1.Controls.Add(IUC);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {//樹蛙雨林聯盟
            this.flowLayoutPanel1.Controls.Clear();
            //雨林圖1
            var q = from n in db.IntroducePhotos
                    where n.IntroducePhotosID == 4
                    select new
                    {
                        picture = n.IntroducePhoto1
                    };
            foreach (var item in q)
            {
                Photo_Big FPC = new Photo_Big();
                //Photo_Square FPC = new Photo_Square();
                byte[] bytes = (byte[])item.picture;
                System.IO.MemoryStream ms = new System.IO.MemoryStream(bytes);
                //FPC.FlagPhotoS = Image.FromStream(ms);
                FPC.FlagPhoto = Image.FromStream(ms);
                this.flowLayoutPanel1.Controls.Add(FPC);
            }
            //介紹文1
            Box_small FC = new Box_small();
            var q1 = from n in db.Introduces
                     where n.IntroducesID == 1
                     select n.Description;
            FC.FlagIntroduce = q1.ToList()[0];
            this.flowLayoutPanel1.Controls.Add(FC);
            //雨林圖2
            var q2 = from n in db.IntroducePhotos
                     where n.IntroducePhotosID == 5
                     select new
                     {
                         picture = n.IntroducePhoto1
                     };
            foreach (var item in q2)
            {
                Photo_Big FPC = new Photo_Big();
                byte[] bytes = (byte[])item.picture;
                System.IO.MemoryStream ms = new System.IO.MemoryStream(bytes);
                FPC.FlagPhoto = Image.FromStream(ms);
                this.flowLayoutPanel1.Controls.Add(FPC);
            }
            //介紹文2
            Box_small FC1 = new Box_small();
            var q3 = from n in db.Introduces
                     where n.IntroducesID == 2
                     select n.Description;
            FC1.FlagIntroduce = q3.ToList()[0];
            this.flowLayoutPanel1.Controls.Add(FC1);
            //雨林圖3
            var q4 = from n in db.IntroducePhotos
                     where n.IntroducePhotosID == 6
                     select new
                     {
                         picture = n.IntroducePhoto1
                     };
            foreach (var item in q4)
            {
                Photo_Big FPC = new Photo_Big();
                byte[] bytes = (byte[])item.picture;
                System.IO.MemoryStream ms = new System.IO.MemoryStream(bytes);
                FPC.FlagPhoto = Image.FromStream(ms);
                this.flowLayoutPanel1.Controls.Add(FPC);
            }
            //介紹文3
            Box_small FC3 = new Box_small();
            var q5 = from n in db.Introduces
                     where n.IntroducesID == 3
                     select n.Description;
            FC3.FlagIntroduce = q5.ToList()[0];
            this.flowLayoutPanel1.Controls.Add(FC3);
            //雨林圖4
            var q6 = from n in db.IntroducePhotos
                     where n.IntroducePhotosID == 7
                     select new
                     {
                         picture = n.IntroducePhoto1
                     };
            foreach (var item in q6)
            {
                Photo_Big FPC = new Photo_Big();
                byte[] bytes = (byte[])item.picture;
                System.IO.MemoryStream ms = new System.IO.MemoryStream(bytes);
                FPC.FlagPhoto = Image.FromStream(ms);
                this.flowLayoutPanel1.Controls.Add(FPC);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {//星座按鈕
            this.flowLayoutPanel1.Controls.Clear();
            ConstellationTital CT = new ConstellationTital();
            this.flowLayoutPanel1.Controls.Add(CT);
            var q1 = from n in db.Constellations
                     select new
                     {
                         recommendID = n.ConstellationID,
                         recommendcoffee = n.ConstellationName,
                         recommenddescription = n.ConstellationDescription,
                         recommendPhoto = n.ConstellationPhoto
                     };
            foreach (var item in q1)
            {
                ConstellationUSControl CUSC = new ConstellationUSControl(memberID);
                FormConstellation FC = new FormConstellation(memberID);
                CUSC.Tag = item.recommendID;
                CUSC.ConstellationName = item.recommendcoffee;
                byte[] bytes = (byte[])item.recommendPhoto;
                System.IO.MemoryStream ms = new System.IO.MemoryStream(bytes);
                CUSC.ConstellationImage = Image.FromStream(ms);
                CUSC.Click += CUSC_Click; ;
                this.flowLayoutPanel1.Controls.Add(CUSC);

            }
        }

        private void CUSC_Click(object sender, EventArgs e)
        {
            ConstellationUSControl CUSC = sender as ConstellationUSControl;
            FormConstellation f = new FormConstellation(memberID);

            var q = from n in db.Constellations
                    where n.ConstellationID == (int)CUSC.Tag
                    select n.ConstellationDescription;
        }

        private void linLabMemCen_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (this.memberID != 0)
            {
                FrmMemCenter fmc = new FrmMemCenter();
                fmc.Show();
            }

        }

        private void btnMem_Click(object sender, EventArgs e)
        {
            if (this.memberID == 0)
            {
                FrmLogin flog = new FrmLogin();
                flog.ShowDialog();
            }
            else 
            {
                this.memberID = 0;

                btnMem.BackgroundImage = Resources._3580168;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.memberID != 0)
            {
                FrmMemCenter fmc = new FrmMemCenter();
                fmc.Show();
            }
            else
            {
                DialogResult dr = MessageBox.Show("請先登入會員", "會員中心", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (dr == DialogResult.OK)
                    return;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var q = this.db.CouponDetails.Any(x => x.MemberID == memberID);

            if (q)
            {
                MessageBox.Show("您已領取過優惠券");
                return;
            }

            if (memberID == 0)
            {
                DialogResult result = MessageBox.Show("登入成為會員完成問卷後可以獲得優惠券，是否要前往登入或註冊?", "尚未登入", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    FrmLogin login = new FrmLogin();
                    login.Show();
                }
                else
                {
                    QuestionnaireFrm questionnaire = new QuestionnaireFrm();
                    questionnaire.ShowDialog();
                }
            }
            else
            {
                QuestionnaireFrm questionnaire = new QuestionnaireFrm();
                questionnaire.ShowDialog();
            }
        }

        public void cancelCompare()
        {


            foreach (PDcontrol item in pds)
            {
                item.button2.Text = "加入比較";
            }

            if (pdc is null)
            {
                return;
            }

            foreach (PDcontrol item in pdc)
            {
                item.button2.Text = "加入比較";
            }

        }

    }
}
