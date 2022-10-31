using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.POCO;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Docking2010.Views;
using DevExpress.XtraBars.Docking2010.Views.Tabbed;
using DevExpress.XtraBars.Navigation;
using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;

namespace SimpleClientApp.ViewModels
{
    [POCOViewModel]
    public class MainFormViewModel
    {
        Dictionary<string, XtraUserControl> NavigationTabs = new Dictionary<string, XtraUserControl>();

        public virtual TabbedView TabbedView { get; set; }
        public virtual AccordionControl AccordionControl { get; set; }
        public virtual AccordionControlElement AccordionElements { get; set; }

        public MainFormViewModel()
        {
            NavigationTabs.Add("customersAccordionControlElement", new Views.CustomersControl());
            NavigationTabs.Add("goodsAccordionControlElement", new Views.GoodsControl());
            NavigationTabs.Add("sellsAccordionControlElement", new Views.SellsControl());
        }

        public void SelectedNavigationElementChanged(SelectedElementChangedEventArgs e)
        {
            if (e.Element == null) return;

            XtraUserControl userControl = null;
            NavigationTabs.TryGetValue((string)e.Element.Name, out userControl);

            if (userControl.IsDisposed)
            {
                if(e.Element == AccordionElements.Elements[0])
                {
                    userControl = new Views.GoodsControl();
                    NavigationTabs["goodsAccordionControlElement"] = userControl;
                }
                else if(e.Element == AccordionElements.Elements[1])
                {
                    userControl = new Views.CustomersControl();
                    NavigationTabs["customersAccordionControlElement"] = userControl;
                }
                else if (e.Element == AccordionElements.Elements[2])
                {
                    userControl = new Views.SellsControl();
                    NavigationTabs["sellsAccordionControlElement"] = userControl;
                }

                
            }

            if (userControl == null) return;

            TabbedView.AddDocument(userControl);
            TabbedView.ActivateDocument(userControl);
        }

        public void DocumentClosing(DocumentCancelEventArgs e)
        {
            if (TabbedView.Documents.Count == 1)
            {
                AccordionControl.SelectedElement = null;
                return;
            }

            int index = TabbedView.Documents.IndexOf(e.Document);
            index = index == 0 ? index + 1 : index + 1;

            var control = TabbedView.Documents[index].Control;
            if(control.GetType() == typeof(Views.GoodsControl))
                AccordionControl.SelectedElement = AccordionElements.Elements[0];
            else if(control.GetType() == typeof(Views.CustomersControl))
                AccordionControl.SelectedElement = AccordionElements.Elements[1];
            else if (control.GetType() == typeof(Views.SellsControl))
                AccordionControl.SelectedElement = AccordionElements.Elements[2];
        }

        public void AddNewSellButtonClick()
        {
            AddNewSellForm sellForm = new AddNewSellForm();
            sellForm.ShowDialog();
        }

        public void ReportButtonClick()
        {
            Reports.CustomerReport report = new Reports.CustomerReport();
            ReportPrintTool printTool = new ReportPrintTool(report);
            printTool.ShowRibbonPreview();
        }

    }
}