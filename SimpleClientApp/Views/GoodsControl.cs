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
using System.Data.Entity;
using SimpleClientApp.ViewModels;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.Data;

namespace SimpleClientApp.Views
{
    public partial class GoodsControl : DevExpress.XtraEditors.XtraUserControl
    {
        public GoodsControl()
        {
            InitializeComponent();

            Text = "Товары";
            Name = "Goods";

            //mvvm
            goodsMvvmContext.ViewModelType = typeof(GoodsControlViewModel);
            var fluent = goodsMvvmContext.OfType<GoodsControlViewModel>();

            fluent.SetBinding(goodsSetBindingSource, s => s.DataSource, x => x.DbHelper.GoodsDbSet.Local);
            fluent.WithEvent<RowObjectEventArgs>(goodsGridView, "RowUpdated").EventToCommand(x => x.TableUpdated(null),
                new Func<RowObjectEventArgs, object>((args) => args));
            fluent.WithEvent<RowDeletedEventArgs>(goodsGridView, "RowDeleted").EventToCommand(x => x.TableDeleted(null),
                new Func<RowDeletedEventArgs, object>((args) => args));
        }
    }
}
