using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using DevExpress.XtraGrid;
using DevExpress.XtraPrinting.Native;

namespace PiotrLazarowicz
{
    public partial class Form1 : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
            this.FormBorderStyle = FormBorderStyle.FixedSingle; // Ustawienie stałego rozmiaru okna
            this.MaximizeBox = false; // Wyłączenie maksymalizacji
            this.MinimizeBox = false; // Wyłączenie minimalizacji
        }
        /// <summary>
        /// Metoda odpowiadająca za załadowanie danych okna startowego
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            fluentDesignFormContainer1.Controls.Clear(); 
            HelloWindow Hello = new HelloWindow();
            Hello.Dock = DockStyle.Fill;
            fluentDesignFormContainer1.Controls.Add(Hello);
        }


        /// <summary>
        /// Metoda odpowiadająca za rezerwację stolika
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void accordionControlElement3_Click(object sender, EventArgs e)
        {
            fluentDesignFormContainer1.Controls.Clear(); 
            AddReservation addReservationForm = new AddReservation();
            addReservationForm.Dock = DockStyle.Fill;
            fluentDesignFormContainer1.Controls.Add(addReservationForm);
        }
        /// <summary>
        /// Metoda odpowiadająca za wyświetlenie aktualnych rezerwacji 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void accordionControlElement4_Click(object sender, EventArgs e)
        {
            fluentDesignFormContainer1.Controls.Clear(); 
            GridUserControl gridUserControlForm = new GridUserControl();
            gridUserControlForm.Dock = DockStyle.Fill;
            fluentDesignFormContainer1.Controls.Add(gridUserControlForm);
        }

    }
}
