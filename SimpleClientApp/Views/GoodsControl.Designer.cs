namespace SimpleClientApp.Views
{
    partial class GoodsControl
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
            this.goodsGridControl = new DevExpress.XtraGrid.GridControl();
            this.goodsSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.goodsGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.goodsMvvmContext = new DevExpress.Utils.MVVM.MVVMContext(this.components);
            this.mvvmContext1 = new DevExpress.Utils.MVVM.MVVMContext(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.goodsGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodsSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodsMvvmContext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext1)).BeginInit();
            this.SuspendLayout();
            // 
            // goodsGridControl
            // 
            this.goodsGridControl.DataSource = this.goodsSetBindingSource;
            this.goodsGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.goodsGridControl.Location = new System.Drawing.Point(0, 0);
            this.goodsGridControl.MainView = this.goodsGridView;
            this.goodsGridControl.Name = "goodsGridControl";
            this.goodsGridControl.Size = new System.Drawing.Size(956, 484);
            this.goodsGridControl.TabIndex = 0;
            this.goodsGridControl.UseEmbeddedNavigator = true;
            this.goodsGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.goodsGridView});
            // 
            // goodsSetBindingSource
            // 
            this.goodsSetBindingSource.DataSource = typeof(SimpleClientApp.DataModels.Goods);
            // 
            // goodsGridView
            // 
            this.goodsGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colName,
            this.colPrice});
            this.goodsGridView.GridControl = this.goodsGridControl;
            this.goodsGridView.Name = "goodsGridView";
            this.goodsGridView.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditFormInplace;
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            // 
            // colName
            // 
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 0;
            // 
            // colPrice
            // 
            this.colPrice.FieldName = "Price";
            this.colPrice.Name = "colPrice";
            this.colPrice.Visible = true;
            this.colPrice.VisibleIndex = 1;
            // 
            // goodsMvvmContext
            // 
            this.goodsMvvmContext.ContainerControl = this;
            this.goodsMvvmContext.ViewModelType = typeof(SimpleClientApp.ViewModels.GoodsControlViewModel);
            // 
            // mvvmContext1
            // 
            this.mvvmContext1.ContainerControl = this;
            // 
            // GoodsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.goodsGridControl);
            this.Name = "GoodsControl";
            this.Size = new System.Drawing.Size(956, 484);
            ((System.ComponentModel.ISupportInitialize)(this.goodsGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodsSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodsMvvmContext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl goodsGridControl;
        private System.Windows.Forms.BindingSource goodsSetBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView goodsGridView;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colPrice;
        private DevExpress.Utils.MVVM.MVVMContext goodsMvvmContext;
        private DevExpress.Utils.MVVM.MVVMContext mvvmContext1;
    }
}
