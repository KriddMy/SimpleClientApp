using DevExpress.XtraBars;
using DevExpress.XtraBars.Docking2010.Views;
using DevExpress.XtraBars.Navigation;
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

namespace SimpleClientApp
{
    public partial class MainForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public MainForm()
        {
            InitializeComponent();

            //mvvm
            MainFormMvvmContext.ViewModelType = typeof(MainFormViewModel);
            var fluent = MainFormMvvmContext.OfType<MainFormViewModel>();
            fluent.ViewModel.TabbedView = tabbedView;
            fluent.ViewModel.AccordionControl = accordionControl;
            fluent.ViewModel.AccordionElements = mainAccordionGroup;

            fluent.WithEvent<SelectedElementChangedEventArgs>(accordionControl, "SelectedElementChanged").EventToCommand(
                x => x.SelectedNavigationElementChanged(null),
                new Func<SelectedElementChangedEventArgs, object>((args) => args));
            fluent.WithEvent<DocumentCancelEventArgs>(tabbedView, "DocumentClosing").EventToCommand(
                x => x.DocumentClosing(null),
                new Func<DocumentCancelEventArgs, object>((args) => args));
            fluent.BindCommand(newSellBarButtonItem, x => x.AddNewSellButtonClick());
            fluent.BindCommand(reportInfobarButtonItem, x => x.ReportButtonClick());    

            //view
            dockPanel.Options.ShowCloseButton = false;
        }
    }
}