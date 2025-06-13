using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GPSFrancisco
{
    public partial class frmCalendario : Form
    {
        public frmCalendario()
        {
            InitializeComponent();
        }

        private void cldCalendario_DateChanged(object sender, DateRangeEventArgs e)
        {
            txtCalendario.Text = "Início:  " +
            e.Start.ToShortDateString() + " - Fim: " + e.End.ToShortDateString();

            lblData.Text = "Início:  " +
            e.Start.ToShortDateString() + " - Fim: " + e.End.ToShortDateString();
        }

        private void cldCalendario_DateSelected(object sender, DateRangeEventArgs e)
        {
            txtCalendario.Text = "Início: " +
            e.Start.ToShortDateString() + " - Fim: " + e.End.ToShortDateString();
        }

        private void btnCarregaData_Click(object sender, EventArgs e)
        {

            DateTime dtNow = new DateTime(2025, 06, 09, 09, 45, 10);

            DateTime dtUtcNow = new DateTime(2025, 06, 09);


            DateTime dataAtual = new DateTime();

            int dia = dataAtual.Day;
            int mes = dataAtual.Month;
            int ano = dataAtual.Year;

            dataAtual.TimeOfDay.Add(dataAtual.TimeOfDay);


            MessageBox.Show("Hora Atual: " + dtNow + " Hora Local: " + dtUtcNow);
            
        }
    }
}
