namespace SimpleClientApp
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ribbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.skinRibbonGalleryBarItem = new DevExpress.XtraBars.SkinRibbonGalleryBarItem();
            this.goodsBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.customersBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.skinDropDownButtonItem = new DevExpress.XtraBars.SkinDropDownButtonItem();
            this.skinPaletteRibbonGalleryBarItem = new DevExpress.XtraBars.SkinPaletteRibbonGalleryBarItem();
            this.sellsBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.newSellBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.reportInfobarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.selllsRibbonPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.viewRibbonPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.dockManager = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.dockPanel = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.accordionControl = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.mainAccordionGroup = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.goodsAccordionControlElement = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.customersAccordionControlElement = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.sellsAccordionControlElement = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.tabbedView = new DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView(this.components);
            this.documentManager = new DevExpress.XtraBars.Docking2010.DocumentManager(this.components);
            this.MainFormMvvmContext = new DevExpress.Utils.MVVM.MVVMContext(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager)).BeginInit();
            this.dockPanel.SuspendLayout();
            this.dockPanel_Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainFormMvvmContext)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl
            // 
            this.ribbonControl.ExpandCollapseItem.Id = 0;
            this.ribbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl.ExpandCollapseItem,
            this.ribbonControl.SearchEditItem,
            this.skinRibbonGalleryBarItem,
            this.goodsBarButtonItem,
            this.customersBarButtonItem,
            this.skinDropDownButtonItem,
            this.skinPaletteRibbonGalleryBarItem,
            this.sellsBarButtonItem,
            this.newSellBarButtonItem,
            this.reportInfobarButtonItem});
            this.ribbonControl.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl.MaxItemId = 51;
            this.ribbonControl.MdiMergeStyle = DevExpress.XtraBars.Ribbon.RibbonMdiMergeStyle.Always;
            this.ribbonControl.Name = "ribbonControl";
            this.ribbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.selllsRibbonPage,
            this.viewRibbonPage});
            this.ribbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.ribbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl.Size = new System.Drawing.Size(790, 158);
            this.ribbonControl.StatusBar = this.ribbonStatusBar;
            this.ribbonControl.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // skinRibbonGalleryBarItem
            // 
            this.skinRibbonGalleryBarItem.Id = 14;
            this.skinRibbonGalleryBarItem.Name = "skinRibbonGalleryBarItem";
            // 
            // goodsBarButtonItem
            // 
            this.goodsBarButtonItem.Caption = "Товары";
            this.goodsBarButtonItem.Id = 46;
            this.goodsBarButtonItem.Name = "goodsBarButtonItem";
            // 
            // customersBarButtonItem
            // 
            this.customersBarButtonItem.Caption = "Клиенты";
            this.customersBarButtonItem.Id = 47;
            this.customersBarButtonItem.Name = "customersBarButtonItem";
            // 
            // skinDropDownButtonItem
            // 
            this.skinDropDownButtonItem.Id = 46;
            this.skinDropDownButtonItem.Name = "skinDropDownButtonItem";
            // 
            // skinPaletteRibbonGalleryBarItem
            // 
            this.skinPaletteRibbonGalleryBarItem.Caption = "$newskinpalettename$";
            this.skinPaletteRibbonGalleryBarItem.Id = 47;
            this.skinPaletteRibbonGalleryBarItem.Name = "skinPaletteRibbonGalleryBarItem";
            // 
            // sellsBarButtonItem
            // 
            this.sellsBarButtonItem.Caption = "Продажи";
            this.sellsBarButtonItem.Id = 48;
            this.sellsBarButtonItem.Name = "sellsBarButtonItem";
            // 
            // newSellBarButtonItem
            // 
            this.newSellBarButtonItem.Caption = "Новая Продажа";
            this.newSellBarButtonItem.Id = 49;
            this.newSellBarButtonItem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("newSellBarButtonItem.ImageOptions.Image")));
            this.newSellBarButtonItem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("newSellBarButtonItem.ImageOptions.LargeImage")));
            this.newSellBarButtonItem.Name = "newSellBarButtonItem";
            // 
            // reportInfobarButtonItem
            // 
            this.reportInfobarButtonItem.Caption = "Отчет по покупателю";
            this.reportInfobarButtonItem.Id = 50;
            this.reportInfobarButtonItem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("reportInfobarButtonItem.ImageOptions.Image")));
            this.reportInfobarButtonItem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("reportInfobarButtonItem.ImageOptions.LargeImage")));
            this.reportInfobarButtonItem.Name = "reportInfobarButtonItem";
            // 
            // selllsRibbonPage
            // 
            this.selllsRibbonPage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.selllsRibbonPage.Name = "selllsRibbonPage";
            this.selllsRibbonPage.Text = "Продажи";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.newSellBarButtonItem);
            this.ribbonPageGroup1.ItemLinks.Add(this.reportInfobarButtonItem);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Формы";
            // 
            // viewRibbonPage
            // 
            this.viewRibbonPage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup});
            this.viewRibbonPage.Name = "viewRibbonPage";
            this.viewRibbonPage.Text = "Вид";
            // 
            // ribbonPageGroup
            // 
            this.ribbonPageGroup.AllowTextClipping = false;
            this.ribbonPageGroup.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonPageGroup.ItemLinks.Add(this.skinDropDownButtonItem);
            this.ribbonPageGroup.ItemLinks.Add(this.skinPaletteRibbonGalleryBarItem);
            this.ribbonPageGroup.Name = "ribbonPageGroup";
            this.ribbonPageGroup.Text = "Интерфейс";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 575);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbonControl;
            this.ribbonStatusBar.Size = new System.Drawing.Size(790, 24);
            // 
            // dockManager
            // 
            this.dockManager.Form = this;
            this.dockManager.RootPanels.AddRange(new DevExpress.XtraBars.Docking.DockPanel[] {
            this.dockPanel});
            this.dockManager.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "DevExpress.XtraBars.StandaloneBarDockControl",
            "System.Windows.Forms.StatusBar",
            "System.Windows.Forms.MenuStrip",
            "System.Windows.Forms.StatusStrip",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl",
            "DevExpress.XtraBars.Navigation.OfficeNavigationBar",
            "DevExpress.XtraBars.Navigation.TileNavPane"});
            // 
            // dockPanel
            // 
            this.dockPanel.Controls.Add(this.dockPanel_Container);
            this.dockPanel.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left;
            this.dockPanel.ID = new System.Guid("a045df26-1503-4d9a-99c1-a531310af22b");
            this.dockPanel.Location = new System.Drawing.Point(0, 158);
            this.dockPanel.Name = "dockPanel";
            this.dockPanel.Options.AllowFloating = false;
            this.dockPanel.Options.FloatOnDblClick = false;
            this.dockPanel.OriginalSize = new System.Drawing.Size(200, 200);
            this.dockPanel.Size = new System.Drawing.Size(200, 417);
            this.dockPanel.Text = "Навигация";
            // 
            // dockPanel_Container
            // 
            this.dockPanel_Container.Controls.Add(this.accordionControl);
            this.dockPanel_Container.Location = new System.Drawing.Point(3, 26);
            this.dockPanel_Container.Name = "dockPanel_Container";
            this.dockPanel_Container.Size = new System.Drawing.Size(193, 388);
            this.dockPanel_Container.TabIndex = 0;
            // 
            // accordionControl
            // 
            this.accordionControl.AllowItemSelection = true;
            this.accordionControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.accordionControl.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.mainAccordionGroup});
            this.accordionControl.Location = new System.Drawing.Point(0, 0);
            this.accordionControl.Name = "accordionControl";
            this.accordionControl.Size = new System.Drawing.Size(193, 388);
            this.accordionControl.TabIndex = 0;
            // 
            // mainAccordionGroup
            // 
            this.mainAccordionGroup.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.goodsAccordionControlElement,
            this.customersAccordionControlElement,
            this.sellsAccordionControlElement});
            this.mainAccordionGroup.Expanded = true;
            this.mainAccordionGroup.HeaderVisible = false;
            this.mainAccordionGroup.Name = "mainAccordionGroup";
            this.mainAccordionGroup.Text = "mainGroup";
            // 
            // goodsAccordionControlElement
            // 
            this.goodsAccordionControlElement.Name = "goodsAccordionControlElement";
            this.goodsAccordionControlElement.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.goodsAccordionControlElement.Text = "Товары";
            // 
            // customersAccordionControlElement
            // 
            this.customersAccordionControlElement.Name = "customersAccordionControlElement";
            this.customersAccordionControlElement.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.customersAccordionControlElement.Text = "Клиенты";
            // 
            // sellsAccordionControlElement
            // 
            this.sellsAccordionControlElement.Name = "sellsAccordionControlElement";
            this.sellsAccordionControlElement.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.sellsAccordionControlElement.Text = "Продажи";
            // 
            // tabbedView
            // 
            this.tabbedView.DocumentProperties.AllowFloat = false;
            this.tabbedView.DocumentProperties.AllowFloatOnDoubleClick = false;
            // 
            // documentManager
            // 
            this.documentManager.ContainerControl = this;
            this.documentManager.RibbonAndBarsMergeStyle = DevExpress.XtraBars.Docking2010.Views.RibbonAndBarsMergeStyle.Always;
            this.documentManager.View = this.tabbedView;
            this.documentManager.ViewCollection.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseView[] {
            this.tabbedView});
            // 
            // MainFormMvvmContext
            // 
            this.MainFormMvvmContext.ContainerControl = this;
            this.MainFormMvvmContext.ViewModelType = typeof(SimpleClientApp.ViewModels.MainFormViewModel);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 599);
            this.Controls.Add(this.dockPanel);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbonControl);
            this.Name = "MainForm";
            this.Ribbon = this.ribbonControl;
            this.StatusBar = this.ribbonStatusBar;
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager)).EndInit();
            this.dockPanel.ResumeLayout(false);
            this.dockPanel_Container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainFormMvvmContext)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl;
        private DevExpress.XtraBars.Ribbon.RibbonPage viewRibbonPage;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.SkinRibbonGalleryBarItem skinRibbonGalleryBarItem;
        private DevExpress.XtraBars.Docking.DockManager dockManager;
        private DevExpress.XtraBars.Docking.DockPanel dockPanel;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel_Container;
        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl;
        private DevExpress.XtraBars.BarButtonItem goodsBarButtonItem;
        private DevExpress.XtraBars.BarButtonItem customersBarButtonItem;
        private DevExpress.XtraBars.Navigation.AccordionControlElement goodsAccordionControlElement;
        private DevExpress.XtraBars.Navigation.AccordionControlElement customersAccordionControlElement;
        private DevExpress.XtraBars.Navigation.AccordionControlElement mainAccordionGroup;
        private DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView tabbedView;
        private DevExpress.XtraBars.Docking2010.DocumentManager documentManager;
        private DevExpress.XtraBars.SkinDropDownButtonItem skinDropDownButtonItem;
        private DevExpress.XtraBars.SkinPaletteRibbonGalleryBarItem skinPaletteRibbonGalleryBarItem;
        private DevExpress.XtraBars.BarButtonItem sellsBarButtonItem;
        private DevExpress.XtraBars.Navigation.AccordionControlElement sellsAccordionControlElement;
        private DevExpress.XtraBars.BarButtonItem newSellBarButtonItem;
        private DevExpress.XtraBars.BarButtonItem reportInfobarButtonItem;
        private DevExpress.XtraBars.Ribbon.RibbonPage selllsRibbonPage;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.Utils.MVVM.MVVMContext MainFormMvvmContext;
    }
}