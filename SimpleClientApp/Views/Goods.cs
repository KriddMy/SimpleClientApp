using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleClientApplication.UserControls
{
    public partial class Goods : DevExpress.XtraEditors.XtraUserControl
    {
        public Goods()
        {
            InitializeComponent();

            Text = "Товары";
            Name = "GoodsUserControl";
            Tag = "goods";
        }
    }
}
