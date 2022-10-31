using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.POCO;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using SimpleClientApp.DataModels;
using SimpleClientApp.Models;
using SimpleClientApp.Servises;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;

namespace SimpleClientApp.ViewModels
{
    [POCOViewModel]
    public class AddNewSellViewModel
    {
        public virtual BindingList<AddNewSellsListModel> Sells { get; set; } = new BindingList<AddNewSellsListModel>();

        public virtual int CustomersListEditValue { get; set; } = -1;

        public virtual DateTime DateTime { get; set; } = DateTime.UtcNow;

        [ServiceProperty]
        public virtual IDbHelperInterface DbHelper {  get { throw new System.NotImplementedException(); } }

        [ServiceProperty(SearchMode = ServiceSearchMode.PreferParents)]
        protected virtual IMessageBoxService MessageBoxService { get { throw new System.NotImplementedException(); } }

        [ServiceProperty]
        protected virtual ICurrentWindowService CurrentWindowService { get { throw new System.NotImplementedException(); } }

        public void SaveButton()
        {
            if (CustomersListEditValue == -1)
            {
                MessageBoxService.ShowMessage("Выберите клиента", "Пустое обязательное поле");
            }
            else if (Sells.Count == 0)
            {
                MessageBoxService.ShowMessage("Список товаров пуст", "Пустое обязательное поле");
            }
            else
            {
                foreach (AddNewSellsListModel sellModel in Sells)
                {
                    Sells sell = new Sells();
                    sell.CustomersID = CustomersListEditValue;
                    sell.Date = DateTime;
                    sell.GoodsID = Int32.Parse(sellModel.ProductName);
                    sell.Quantity = sellModel.Quantity;
                    sell.Total = DbHelper.GoodsDbSet.Find(sell.GoodsID).Price * sell.Quantity;
                    DbHelper.SellsDbSet.Add(sell);

                    var customer = DbHelper.CustomersDbSet.Find(sell.CustomersID);
                    customer.Sells += sell.Total;

                    DbHelper.SaveChanges();
                }
                CurrentWindowService.Close();
            }
        }

        public void SellsListRowUpdated(RowObjectEventArgs e)
        {
            AddNewSellsListModel current = e.Row as AddNewSellsListModel;

            foreach (AddNewSellsListModel sell in Sells)
            {
                if (sell.ProductName == current.ProductName && sell != current)
                {
                    sell.Quantity = sell.Quantity + current.Quantity;
                    Sells.Remove(current);
                    return;
                }
            }
        }

        public void RowValueValidation(ValidateRowEventArgs e)
        {
            var sell = e.Row as AddNewSellsListModel;
            if(sell.ProductName == null || sell.Quantity <= 0)
            {
                e.Valid = false;
            }
        }

        public void EditorValueValidation(BaseContainerValidateEditorEventArgs e)
        {
            EditFormValidateEditorEventArgs args = e as EditFormValidateEditorEventArgs;
            if (args == null) return;
            if (e.Value == null)
            {
                e.ErrorText = "Незаполненное значение";
                e.Valid = false;
                return;
            }
            else if (args.Column.ColumnHandle == 1 && (int)e.Value <= 0)
            {
                e.ErrorText = "Количество товара не может быть меньше или равно нулю";
                e.Valid = false;
                return;
            }
        }
    }
}