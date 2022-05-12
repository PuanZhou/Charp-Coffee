using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSPCoffee
{
    public partial class CouponControl1 : UserControl
    {
        public CouponControl1()
        {
            InitializeComponent();
        }

        public override Size MinimumSize
        {
            get
            {//拉到Form.cs時不讓人設定最小
                return new Size(341, 188);
            }
            set
            {
            }
        }
        public override Size MaximumSize
        {
            get
            {//拉到Form.cs時不讓人設定最小
                return new Size(341, 188);
            }
            set
            {
            }
        }

        #region labtext
        public string TextCouName
        {
            get
            {
                return labCouName.Text;
            }
            set
            {
                labCouName.Text = value;
            }
        }

        public string TextLabCon
        {
            get
            {
                return labCon.Text;
            }
            set
            {
                labCon.Text = value;
            }
        }

        public string TextLabMoney
        {
            get
            {
                return labMoney.Text;
            }
            set
            {
                labMoney.Text = value;
            }
        }

        public string TextLabStart
        {
            get
            {
                return labStart.Text;
            }
            set
            {
                labStart.Text = value;
            }
        }

        public string TextLabEnd
        {
            get
            {
                return labEnd.Text;
            }
            set
            {
                labEnd.Text = value;
            }
        }

        #endregion labtext
    }
}
