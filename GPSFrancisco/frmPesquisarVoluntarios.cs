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
    public partial class frmPesquisarVoluntarios : Form
    {
        public frmPesquisarVoluntarios()
        {
            InitializeComponent();
        }

        private void ltbPesquisarVoluntario_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nome = ltbPesquisarVoluntario.SelectedItem.ToString();

            frmGerenciarVoluntarios abrir = new frmGerenciarVoluntarios(nome);
            abrir.Show();
            this.Hide();
        }

        private void btnPesquisarVoluntario_Click(object sender, EventArgs e)
        {
            ltbPesquisarVoluntario.Items.Add(txtNomeVoluntario.Text);
        }
    }
}
