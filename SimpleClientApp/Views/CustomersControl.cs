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
using SimpleClientApp.DataModels;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.Data;

namespace SimpleClientApp.Views
{
    public partial class CustomersControl : DevExpress.XtraEditors.XtraUserControl
    {
        public CustomersControl()
        {
            InitializeComponent();

            Text = "Клиенты";
            Name = "Custumers";

            //mvvm
            customerMvvmContext.ViewModelType = typeof(CustomersControlViewModel);
            var fluent = customerMvvmContext.OfType<CustomersControlViewModel>();
            fluent.SetBinding(customersSetBindingSource, s => s.DataSource, x => x.DbHelper.CustomersDbSet.Local);
            fluent.WithEvent<RowObjectEventArgs>(customersGridView, "RowUpdated").EventToCommand(x => x.TableUpdated(null), new Func<RowObjectEventArgs, object>((args) => args));
            fluent.WithEvent<RowDeletedEventArgs>(customersGridView, "RowDeleted").EventToCommand(x => x.TableDeleted(null), new Func<RowDeletedEventArgs, object>((args) => args));

            fluent.SetTrigger(x => x.ReloadCustomerDataTriggerFlag, (val) => customersGridView.RefreshData());
        }
    }
}
