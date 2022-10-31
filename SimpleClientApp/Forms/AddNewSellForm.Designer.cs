namespace SimpleClientApp
{
    partial class AddNewSellForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.sellsGridControl = new DevExpress.XtraGrid.GridControl();
            this.sellModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sellsGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colProductName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.goodsRepositoryItemLookUpEdit = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.goodsSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sellDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.addProductButton = new DevExpress.XtraEditors.SimpleButton();
            this.saveSellButton = new DevExpress.XtraEditors.SimpleButton();
            this.customersGridLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.customersSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.Клиент = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.Дата = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.AddNewSellFormMvvmContext = new DevExpress.Utils.MVVM.MVVMContext(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sellsGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodsRepositoryItemLookUpEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodsSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersGridLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Клиент)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Дата)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddNewSellFormMvvmContext)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.sellsGridControl);
            this.layoutControl1.Controls.Add(this.sellDateEdit);
            this.layoutControl1.Controls.Add(this.addProductButton);
            this.layoutControl1.Controls.Add(this.saveSellButton);
            this.layoutControl1.Controls.Add(this.customersGridLookUpEdit);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(774, 187, 650, 400);
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(338, 268);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // sellsGridControl
            // 
            this.sellsGridControl.DataSource = this.sellModelBindingSource;
            this.sellsGridControl.Location = new System.Drawing.Point(12, 62);
            this.sellsGridControl.MainView = this.sellsGridView;
            this.sellsGridControl.Name = "sellsGridControl";
            this.sellsGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.goodsRepositoryItemLookUpEdit});
            this.sellsGridControl.Size = new System.Drawing.Size(314, 168);
            this.sellsGridControl.TabIndex = 8;
            this.sellsGridControl.UseEmbeddedNavigator = true;
            this.sellsGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.sellsGridView});
            // 
            // sellModelBindingSource
            // 
            this.sellModelBindingSource.DataSource = typeof(SimpleClientApp.Models.AddNewSellsListModel);
            // 
            // sellsGridView
            // 
            this.sellsGridView.AutoFillColumn = this.colProductName;
            this.sellsGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colProductName,
            this.colQuantity});
            this.sellsGridView.GridControl = this.sellsGridControl;
            this.sellsGridView.Name = "sellsGridView";
            this.sellsGridView.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditForm;
            this.sellsGridView.OptionsEditForm.PopupEditFormWidth = 400;
            this.sellsGridView.OptionsNavigation.AutoFocusNewRow = true;
            this.sellsGridView.OptionsView.ShowGroupPanel = false;
            this.sellsGridView.OptionsView.ShowIndicator = false;
            // 
            // colProductName
            // 
            this.colProductName.Caption = "Название";
            this.colProductName.ColumnEdit = this.goodsRepositoryItemLookUpEdit;
            this.colProductName.FieldName = "ProductName";
            this.colProductName.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText;
            this.colProductName.Name = "colProductName";
            this.colProductName.Visible = true;
            this.colProductName.VisibleIndex = 0;
            // 
            // goodsRepositoryItemLookUpEdit
            // 
            this.goodsRepositoryItemLookUpEdit.AutoHeight = false;
            this.goodsRepositoryItemLookUpEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.goodsRepositoryItemLookUpEdit.DataSource = this.goodsSetBindingSource;
            this.goodsRepositoryItemLookUpEdit.DisplayMember = "Name";
            this.goodsRepositoryItemLookUpEdit.Name = "goodsRepositoryItemLookUpEdit";
            this.goodsRepositoryItemLookUpEdit.ValueMember = "Id";
            // 
            // goodsSetBindingSource
            // 
            this.goodsSetBindingSource.DataSource = typeof(SimpleClientApp.DataModels.Goods);
            // 
            // colQuantity
            // 
            this.colQuantity.Caption = "Количество";
            this.colQuantity.FieldName = "Quantity";
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.Visible = true;
            this.colQuantity.VisibleIndex = 1;
            // 
            // sellDateEdit
            // 
            this.sellDateEdit.EditValue = null;
            this.sellDateEdit.Location = new System.Drawing.Point(220, 12);
            this.sellDateEdit.Name = "sellDateEdit";
            this.sellDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.sellDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.sellDateEdit.Size = new System.Drawing.Size(106, 20);
            this.sellDateEdit.StyleController = this.layoutControl1;
            this.sellDateEdit.TabIndex = 7;
            // 
            // addProductButton
            // 
            this.addProductButton.Location = new System.Drawing.Point(12, 36);
            this.addProductButton.Name = "addProductButton";
            this.addProductButton.Size = new System.Drawing.Size(314, 22);
            this.addProductButton.StyleController = this.layoutControl1;
            this.addProductButton.TabIndex = 5;
            this.addProductButton.Text = "Добавить товар";
            this.addProductButton.Click += new System.EventHandler(this.addProductButton_Click);
            // 
            // saveSellButton
            // 
            this.saveSellButton.Location = new System.Drawing.Point(12, 234);
            this.saveSellButton.Name = "saveSellButton";
            this.saveSellButton.Size = new System.Drawing.Size(314, 22);
            this.saveSellButton.StyleController = this.layoutControl1;
            this.saveSellButton.TabIndex = 4;
            this.saveSellButton.Text = "Добавить продажу";
            // 
            // customersGridLookUpEdit
            // 
            this.customersGridLookUpEdit.EditValue = -1;
            this.customersGridLookUpEdit.Location = new System.Drawing.Point(61, 12);
            this.customersGridLookUpEdit.Name = "customersGridLookUpEdit";
            this.customersGridLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.customersGridLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Id", "Id", 19, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Имя", 36, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Contacts", "Контакты", 52, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Sells", "Sells", 30, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.customersGridLookUpEdit.Properties.DataSource = this.customersSetBindingSource;
            this.customersGridLookUpEdit.Properties.DisplayMember = "Name";
            this.customersGridLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.customersGridLookUpEdit.Properties.ValueMember = "Id";
            this.customersGridLookUpEdit.Size = new System.Drawing.Size(106, 20);
            this.customersGridLookUpEdit.StyleController = this.layoutControl1;
            this.customersGridLookUpEdit.TabIndex = 1;
            // 
            // customersSetBindingSource
            // 
            this.customersSetBindingSource.DataSource = typeof(SimpleClientApp.DataModels.Customers);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.Клиент,
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.Дата,
            this.layoutControlItem3});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(338, 268);
            this.Root.TextVisible = false;
            // 
            // Клиент
            // 
            this.Клиент.Control = this.customersGridLookUpEdit;
            this.Клиент.Location = new System.Drawing.Point(0, 0);
            this.Клиент.Name = "Клиент";
            this.Клиент.Size = new System.Drawing.Size(159, 24);
            this.Клиент.TextSize = new System.Drawing.Size(37, 13);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.saveSellButton;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 222);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(318, 26);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.addProductButton;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(318, 26);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // Дата
            // 
            this.Дата.Control = this.sellDateEdit;
            this.Дата.Location = new System.Drawing.Point(159, 0);
            this.Дата.Name = "Дата";
            this.Дата.Size = new System.Drawing.Size(159, 24);
            this.Дата.TextSize = new System.Drawing.Size(37, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.sellsGridControl;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 50);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(318, 172);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // AddNewSellFormMvvmContext
            // 
            this.AddNewSellFormMvvmContext.ContainerControl = this;
            // 
            // AddNewSellForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 268);
            this.Controls.Add(this.layoutControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "AddNewSellForm";
            this.Text = "Добавить продажу";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sellsGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodsRepositoryItemLookUpEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodsSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersGridLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Клиент)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Дата)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddNewSellFormMvvmContext)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem Клиент;
        private System.Windows.Forms.BindingSource customersSetBindingSource;
        private DevExpress.XtraEditors.SimpleButton saveSellButton;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.LookUpEdit customersGridLookUpEdit;
        private DevExpress.XtraEditors.SimpleButton addProductButton;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private System.Windows.Forms.BindingSource goodsSetBindingSource;
        private DevExpress.XtraEditors.DateEdit sellDateEdit;
        private DevExpress.XtraLayout.LayoutControlItem Дата;
        private DevExpress.Utils.MVVM.MVVMContext AddNewSellFormMvvmContext;
        private System.Windows.Forms.BindingSource sellModelBindingSource;
        private DevExpress.XtraGrid.GridControl sellsGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView sellsGridView;
        private DevExpress.XtraGrid.Columns.GridColumn colProductName;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantity;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit goodsRepositoryItemLookUpEdit;
    }
}