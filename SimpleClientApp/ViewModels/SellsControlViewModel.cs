using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.POCO;
using DevExpress.XtraPivotGrid;
using SimpleClientApp.Servises;
using System;
namespace SimpleClientApp.ViewModels
{
    [POCOViewModel]
    public class SellsControlViewModel
    {
        public virtual bool ReloadDataTriggerFlag { get; set; }
        
        public SellsControlViewModel()
        {
            DbHelper.SellsDbSet.Local.CollectionChanged += DbHelper_OnSellsDataModelChanged;
        }
        
        ~SellsControlViewModel()
        {
            //DbHelper.SellsDbSet.Local.CollectionChanged -= DbHelper_OnSellsDataModelChanged;
        }

        private void DbHelper_OnSellsDataModelChanged(object sender, EventArgs e)
        {
            ReloadDataTriggerFlag = !ReloadDataTriggerFlag;
        }

        [ServiceProperty]
        public virtual IDbHelperInterface DbHelper
        {
            get { throw new System.NotImplementedException(); }
        }

        public void DisplayFuildText(PivotFieldDisplayTextEventArgs e)
        {
            if (e == null || e.Field == null)
                return;

            if (e.Field.Name == "custumerPivotGridField")
            {
                //меняем Id покупателя на его имя
                string customerName = DbHelper.CustomersDbSet.Find((int)e.Value).Name;
                e.DisplayText = customerName == null ? "Неизвестный покупатель" : customerName;
            }
            else if (e.Field.Name == "goodsPivotGridField")

            {
                //меняем Id товара на его название
                string goodsName = DbHelper.GoodsDbSet.Find((int)e.Value).Name;
                e.DisplayText = goodsName == null ? "Неизвестный товар" : goodsName;
            }
        }
    }
}