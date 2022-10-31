namespace SimpleClientApp.Views
{
    partial class CustomersControl
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
            this.customersGridControl = new DevExpress.XtraGrid.GridControl();
            this.customersSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customersGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colContacts = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSells = new DevExpress.XtraGrid.Columns.GridColumn();
            this.customerMvvmContext = new DevExpress.Utils.MVVM.MVVMContext(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.customersGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerMvvmContext)).BeginInit();
            this.SuspendLayout();
            // 
            // customersGridControl
            // 
            this.customersGridControl.DataSource = this.customersSetBindingSource;
            this.customersGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customersGridControl.Location = new System.Drawing.Point(0, 0);
            this.customersGridControl.MainView = this.customersGridView;
            this.customersGridControl.Name = "customersGridControl";
            this.customersGridControl.Size = new System.Drawing.Size(1042, 553);
            this.customersGridControl.TabIndex = 0;
            this.customersGridControl.UseEmbeddedNavigator = true;
            this.customersGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.customersGridView});
            // 
            // customersSetBindingSource
            // 
            this.customersSetBindingSource.DataSource = typeof(SimpleClientApp.DataModels.Customers);
            // 
            // customersGridView
            // 
            this.customersGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colName,
            this.colContacts,
            this.colSells});
            this.customersGridView.GridControl = this.customersGridControl;
            this.customersGridView.Name = "customersGridView";
            this.customersGridView.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditFormInplace;
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
            // colContacts
            // 
            this.colContacts.FieldName = "Contacts";
            this.colContacts.Name = "colContacts";
            this.colContacts.Visible = true;
            this.colContacts.VisibleIndex = 1;
            // 
            // colSells
            // 
            this.colSells.FieldName = "Sells";
            this.colSells.Name = "colSells";
            this.colSells.OptionsColumn.AllowEdit = false;
            this.colSells.OptionsColumn.ReadOnly = true;
            this.colSells.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.False;
            this.colSells.Visible = true;
            this.colSells.VisibleIndex = 2;
            // 
            // customerMvvmContext
            // 
            this.customerMvvmContext.ContainerControl = this;
            this.customerMvvmContext.ViewModelType = typeof(SimpleClientApp.ViewModels.CustomersControlViewModel);
            // 
            // CustomersControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.customersGridControl);
            this.Name = "CustomersControl";
            this.Size = new System.Drawing.Size(1042, 553);
            ((System.ComponentModel.ISupportInitialize)(this.customersGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerMvvmContext)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl customersGridControl;
        private System.Windows.Forms.BindingSource customersSetBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView customersGridView;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colContacts;
        private DevExpress.XtraGrid.Columns.GridColumn colSells;
        private DevExpress.Utils.MVVM.MVVMContext customerMvvmContext;
    }
}
