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
using DevExpress.XtraPivotGrid;

namespace SimpleClientApp.Views
{
    public partial class SellsControl : DevExpress.XtraEditors.XtraUserControl
    {
        public SellsControl()
        {
            InitializeComponent();

            Text = "Продажи";
            Name = "Sells";

            //mvvm
            sellsMvvmContext.ViewModelType = typeof(SellsControlViewModel);
            var fluent = sellsMvvmContext.OfType<SellsControlViewModel>();
            fluent.SetBinding(sellsSetBindingSource, s => s.DataSource, x => x.DbHelper.SellsDbSet.Local);
            fluent.WithEvent<PivotFieldDisplayTextEventArgs>(sellsPivotGridControl, "FieldValueDisplayText").EventToCommand(x => x.DisplayFuildText(null),
                new Func<PivotFieldDisplayTextEventArgs, object>((args) => args));

            fluent.SetTrigger(x => x.ReloadDataTriggerFlag, (val) => sellsPivotGridControl.RefreshData());
        }
    }
}
