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
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraEditors.Repository;
using SimpleClientApp.DataModels;
using SimpleClientApp.ViewModels;
using DevExpress.XtraGrid.Views.Base;
using SimpleClientApp.Models;
using DevExpress.XtraEditors.Controls;

namespace SimpleClientApp
{
    public partial class AddNewSellForm : DevExpress.XtraEditors.XtraForm
    {
        public AddNewSellForm()
        {
            InitializeComponent();

            //sellDateEdit.DateTime = DateTime.UtcNow;

            //mvvm
            AddNewSellFormMvvmContext.ViewModelType = typeof(AddNewSellViewModel);
            var fluent = AddNewSellFormMvvmContext.OfType<AddNewSellViewModel>();

            fluent.SetBinding(goodsSetBindingSource, s => s.DataSource, x => x.DbHelper.GoodsDbSet.Local);
            fluent.SetBinding(customersSetBindingSource, s => s.DataSource, x => x.DbHelper.CustomersDbSet.Local);
            fluent.SetBinding(sellModelBindingSource, s => s.DataSource, x => x.Sells);
            fluent.SetBinding(customersGridLookUpEdit, s => s.EditValue, x => x.CustomersListEditValue);
            fluent.SetBinding(sellDateEdit, s => s.DateTime, x => x.DateTime);

            fluent.WithEvent<RowObjectEventArgs>(sellsGridView, "RowUpdated").EventToCommand(x => x.SellsListRowUpdated(null),
                new Func<RowObjectEventArgs, object>((args) => args));

            fluent.WithEvent<BaseContainerValidateEditorEventArgs>(sellsGridView, "ValidatingEditor").EventToCommand(x => x.EditorValueValidation(null),
                new Func<BaseContainerValidateEditorEventArgs, object>((args) => args));

            fluent.WithEvent<ValidateRowEventArgs>(sellsGridView, "ValidateRow").EventToCommand(x => x.RowValueValidation(null),
                new Func<ValidateRowEventArgs, object>((args) => args));

            fluent.BindCommand(saveSellButton, x => x.SaveButton());
        }

        private void addProductButton_Click(object sender, EventArgs e)
        {
            sellsGridView.AddNewRow();
            sellsGridView.ShowEditor();
        }
    }
}