using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleClientApplication.UserControls
{
    public partial class Custumers : DevExpress.XtraEditors.XtraUserControl
    {
        public Custumers()
        {
            InitializeComponent();

            Text = "Клиенты";
            Name = "Custumers";
            Tag = "cust";
        }

        private void customersGridView_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            GridView view = sender as GridView;

            view.SetRowCellValue(e.RowHandle, view.Columns[2], 0);
        }

        private void customersGridView_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            
        }

        private void customersGridView_RowDeleted(object sender, DevExpress.Data.RowDeletedEventArgs e)
        {
            
        }
    }
}
