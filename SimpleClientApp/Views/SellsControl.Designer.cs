namespace SimpleClientApp.Views
{
    partial class SellsControl
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
            DevExpress.XtraPivotGrid.DataSourceColumnBinding dataSourceColumnBinding1 = new DevExpress.XtraPivotGrid.DataSourceColumnBinding();
            DevExpress.XtraPivotGrid.DataSourceColumnBinding dataSourceColumnBinding2 = new DevExpress.XtraPivotGrid.DataSourceColumnBinding();
            DevExpress.XtraPivotGrid.DataSourceColumnBinding dataSourceColumnBinding3 = new DevExpress.XtraPivotGrid.DataSourceColumnBinding();
            DevExpress.XtraPivotGrid.DataSourceColumnBinding dataSourceColumnBinding4 = new DevExpress.XtraPivotGrid.DataSourceColumnBinding();
            DevExpress.XtraPivotGrid.DataSourceColumnBinding dataSourceColumnBinding5 = new DevExpress.XtraPivotGrid.DataSourceColumnBinding();
            DevExpress.XtraPivotGrid.DataSourceColumnBinding dataSourceColumnBinding6 = new DevExpress.XtraPivotGrid.DataSourceColumnBinding();
            this.sellsPivotGridControl = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.sellsSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idPivotGridField = new DevExpress.XtraPivotGrid.PivotGridField();
            this.custumerPivotGridField = new DevExpress.XtraPivotGrid.PivotGridField();
            this.goodsPivotGridField = new DevExpress.XtraPivotGrid.PivotGridField();
            this.datePivotGridField = new DevExpress.XtraPivotGrid.PivotGridField();
            this.quantityPivotGridField = new DevExpress.XtraPivotGrid.PivotGridField();
            this.totalPivotGridField = new DevExpress.XtraPivotGrid.PivotGridField();
            this.sellsMvvmContext = new DevExpress.Utils.MVVM.MVVMContext(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.sellsPivotGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellsSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellsMvvmContext)).BeginInit();
            this.SuspendLayout();
            // 
            // sellsPivotGridControl
            // 
            this.sellsPivotGridControl.DataSource = this.sellsSetBindingSource;
            this.sellsPivotGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sellsPivotGridControl.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.idPivotGridField,
            this.custumerPivotGridField,
            this.goodsPivotGridField,
            this.datePivotGridField,
            this.quantityPivotGridField,
            this.totalPivotGridField});
            this.sellsPivotGridControl.Location = new System.Drawing.Point(0, 0);
            this.sellsPivotGridControl.Name = "sellsPivotGridControl";
            this.sellsPivotGridControl.OptionsData.DataProcessingEngine = DevExpress.XtraPivotGrid.PivotDataProcessingEngine.Optimized;
            this.sellsPivotGridControl.Size = new System.Drawing.Size(868, 414);
            this.sellsPivotGridControl.TabIndex = 0;
            // 
            // sellsSetBindingSource
            // 
            this.sellsSetBindingSource.DataSource = typeof(SimpleClientApp.DataModels.Sells);
            // 
            // idPivotGridField
            // 
            this.idPivotGridField.AreaIndex = 0;
            this.idPivotGridField.Caption = "Id";
            dataSourceColumnBinding1.ColumnName = "Id";
            this.idPivotGridField.DataBinding = dataSourceColumnBinding1;
            this.idPivotGridField.Name = "idPivotGridField";
            this.idPivotGridField.Visible = false;
            // 
            // custumerPivotGridField
            // 
            this.custumerPivotGridField.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.custumerPivotGridField.AreaIndex = 0;
            this.custumerPivotGridField.Caption = "Покупатель";
            dataSourceColumnBinding2.ColumnName = "CustomersID";
            this.custumerPivotGridField.DataBinding = dataSourceColumnBinding2;
            this.custumerPivotGridField.Name = "custumerPivotGridField";
            // 
            // goodsPivotGridField
            // 
            this.goodsPivotGridField.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.goodsPivotGridField.AreaIndex = 1;
            this.goodsPivotGridField.Caption = "Товар";
            dataSourceColumnBinding3.ColumnName = "GoodsID";
            this.goodsPivotGridField.DataBinding = dataSourceColumnBinding3;
            this.goodsPivotGridField.Name = "goodsPivotGridField";
            // 
            // datePivotGridField
            // 
            this.datePivotGridField.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.datePivotGridField.AreaIndex = 0;
            this.datePivotGridField.Caption = "Дата";
            dataSourceColumnBinding4.ColumnName = "Date";
            this.datePivotGridField.DataBinding = dataSourceColumnBinding4;
            this.datePivotGridField.Name = "datePivotGridField";
            // 
            // quantityPivotGridField
            // 
            this.quantityPivotGridField.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.quantityPivotGridField.AreaIndex = 0;
            this.quantityPivotGridField.Caption = "Количество";
            dataSourceColumnBinding5.ColumnName = "Quantity";
            this.quantityPivotGridField.DataBinding = dataSourceColumnBinding5;
            this.quantityPivotGridField.Name = "quantityPivotGridField";
            // 
            // totalPivotGridField
            // 
            this.totalPivotGridField.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.totalPivotGridField.AreaIndex = 1;
            this.totalPivotGridField.Caption = "Сумма";
            dataSourceColumnBinding6.ColumnName = "Total";
            this.totalPivotGridField.DataBinding = dataSourceColumnBinding6;
            this.totalPivotGridField.Name = "totalPivotGridField";
            // 
            // sellsMvvmContext
            // 
            this.sellsMvvmContext.ContainerControl = this;
            this.sellsMvvmContext.ViewModelType = typeof(SimpleClientApp.ViewModels.SellsControlViewModel);
            // 
            // SellsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.sellsPivotGridControl);
            this.Name = "SellsControl";
            this.Size = new System.Drawing.Size(868, 414);
            ((System.ComponentModel.ISupportInitialize)(this.sellsPivotGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellsSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellsMvvmContext)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraPivotGrid.PivotGridControl sellsPivotGridControl;
        private System.Windows.Forms.BindingSource sellsSetBindingSource;
        private DevExpress.XtraPivotGrid.PivotGridField idPivotGridField;
        private DevExpress.XtraPivotGrid.PivotGridField custumerPivotGridField;
        private DevExpress.XtraPivotGrid.PivotGridField goodsPivotGridField;
        private DevExpress.XtraPivotGrid.PivotGridField datePivotGridField;
        private DevExpress.XtraPivotGrid.PivotGridField quantityPivotGridField;
        private DevExpress.XtraPivotGrid.PivotGridField totalPivotGridField;
        private DevExpress.Utils.MVVM.MVVMContext sellsMvvmContext;
    }
}
