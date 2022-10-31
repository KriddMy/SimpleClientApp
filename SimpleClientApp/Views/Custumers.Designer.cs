namespace SimpleClientApplication.UserControls
{
    partial class Custumers
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
            this.windowsUIButtonPanel1 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.custumersGridControl = new DevExpress.XtraGrid.GridControl();
            this.customersGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colФИО = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colКонтактныеданные = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colОбщаясуммауслуг = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.custumersGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // windowsUIButtonPanel1
            // 
            this.windowsUIButtonPanel1.Buttons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {
            new DevExpress.XtraBars.Docking2010.WindowsUIButton(),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton()});
            this.windowsUIButtonPanel1.Location = new System.Drawing.Point(616, 0);
            this.windowsUIButtonPanel1.Name = "windowsUIButtonPanel1";
            this.windowsUIButtonPanel1.Size = new System.Drawing.Size(8, 8);
            this.windowsUIButtonPanel1.TabIndex = 1;
            this.windowsUIButtonPanel1.Text = "windowsUIButtonPanel1";
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(1044, 17);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(8, 9);
            this.simpleButton2.TabIndex = 3;
            this.simpleButton2.Text = "simpleButton2";
            // 
            // custumersGridControl
            // 
            this.custumersGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.custumersGridControl.Location = new System.Drawing.Point(0, 0);
            this.custumersGridControl.MainView = this.customersGridView;
            this.custumersGridControl.Name = "custumersGridControl";
            this.custumersGridControl.Size = new System.Drawing.Size(1301, 612);
            this.custumersGridControl.TabIndex = 4;
            this.custumersGridControl.UseEmbeddedNavigator = true;
            this.custumersGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.customersGridView});
            // 
            // customersGridView
            // 
            this.customersGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colФИО,
            this.colКонтактныеданные,
            this.colОбщаясуммауслуг});
            this.customersGridView.GridControl = this.custumersGridControl;
            this.customersGridView.Name = "customersGridView";
            this.customersGridView.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditFormInplace;
            this.customersGridView.OptionsEditForm.EditFormColumnCount = 2;
            this.customersGridView.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.customersGridView_InitNewRow);
            this.customersGridView.RowDeleted += new DevExpress.Data.RowDeletedEventHandler(this.customersGridView_RowDeleted);
            this.customersGridView.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.customersGridView_RowUpdated);
            // 
            // colФИО
            // 
            this.colФИО.FieldName = "ФИО";
            this.colФИО.Name = "colФИО";
            this.colФИО.Visible = true;
            this.colФИО.VisibleIndex = 0;
            // 
            // colКонтактныеданные
            // 
            this.colКонтактныеданные.FieldName = "Контактные данные";
            this.colКонтактныеданные.Name = "colКонтактныеданные";
            this.colКонтактныеданные.Visible = true;
            this.colКонтактныеданные.VisibleIndex = 1;
            // 
            // colОбщаясуммауслуг
            // 
            this.colОбщаясуммауслуг.FieldName = "Общая сумма услуг";
            this.colОбщаясуммауслуг.Name = "colОбщаясуммауслуг";
            this.colОбщаясуммауслуг.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.False;
            this.colОбщаясуммауслуг.Visible = true;
            this.colОбщаясуммауслуг.VisibleIndex = 2;
            // 
            // Custumers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.custumersGridControl);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.windowsUIButtonPanel1);
            this.Name = "Custumers";
            this.Size = new System.Drawing.Size(1301, 612);
            ((System.ComponentModel.ISupportInitialize)(this.custumersGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel windowsUIButtonPanel1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraGrid.GridControl custumersGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView customersGridView;
        private DevExpress.XtraGrid.Columns.GridColumn colФИО;
        private DevExpress.XtraGrid.Columns.GridColumn colКонтактныеданные;
        private DevExpress.XtraGrid.Columns.GridColumn colОбщаясуммауслуг;
    }
}
