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

namespace PiotrLazarowicz
{
    public partial class AddReservation : DevExpress.XtraEditors.XtraUserControl
    {
        public AddReservation()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                using (Model1 model = new Model1())
                {
                    int lastId = model.Reservation.Max(x => x.ID);
                    int newId = lastId + 1;

                    Reservation reservation = new Reservation();
                    reservation.ID = newId;
                    reservation.FirstName = textEdit1.Text;
                    reservation.LastName = textEdit2.Text;
                    reservation.Time = dateEdit1.DateTime;

                    model.Reservation.Add(reservation);
                    model.SaveChanges();
                }

                XtraMessageBox.Show("Klient został dodany prawidłowo");

            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
                
            }
      
        }
    }
}
