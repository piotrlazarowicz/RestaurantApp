using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Export;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Base;
using System.Runtime.Remoting.Contexts;
using DevExpress.XtraGrid.Columns;
using DevExpress.ClipboardSource.SpreadsheetML;
using DevExpress.Data.Async;
using DevExpress.ExpressApp;
using DevExpress.Utils.Menu;
using DevExpress.XtraBars;
using DevExpress.XtraGrid.Views.Layout.Modes;
using DevExpress.Utils.Menu;
using DevExpress.XtraBars.Docking2010.Views.WindowsUI;
using DevExpress.Internal.WinApi.Windows.UI.Notifications;
using DevExpress.Utils.CommonDialogs.Internal;
using DialogResult = System.Windows.Forms.DialogResult;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using DevExpress.Utils;

namespace PiotrLazarowicz
{
    public partial class GridUserControl : DevExpress.XtraEditors.XtraUserControl
    {
        public GridUserControl()
        {

            InitializeComponent();
            GridColumn column = gridView1.Columns["Time"]; 
            column.DisplayFormat.FormatType = FormatType.DateTime;
            column.DisplayFormat.FormatString = "yyyy-MM-dd HH:mm:ss";
            Model1 dbset = new Model1();
          

     
            reservationTableAdapter1.Fill(restaurationAppDataSet1.Reservation);
            gridView1.RefreshData();
        }


  

        private void gridView1_InitNewRow(object sender, InitNewRowEventArgs e)
        {
            gridView1.AddNewRow();
        }

     

        private void gridControl1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var selected = gridView1.GetSelectedRows();
        }

        private void gridView1_RowClick(object sender, RowClickEventArgs e)
        {
            int idHandle = gridView1.FocusedRowHandle;
            var selectedRow = gridView1.GetDataRow(idHandle);
            var result = XtraMessageBox.Show("Czy chcesz usunąć wiersz?", "Potwierdzenie", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                if (selectedRow != null)
                {
                    int deleteId = (int)selectedRow["ID"];
                    Model1 model = new Model1();
                    using (model)
                    {
                        var itemToRemove = model.Reservation.FirstOrDefault(x => x.ID == deleteId);
                        if (itemToRemove != null)
                        {
                            model.Reservation.Remove(itemToRemove);
                            model.SaveChanges();
                        }
                    }
                    gridView1.DeleteRow(idHandle);
                }
            }
         
        }

        //private void gridView1_DoubleClick(object sender, EventArgs e)
        //{

        //}
    }


}

