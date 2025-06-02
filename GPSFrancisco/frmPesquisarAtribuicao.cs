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
    public partial class frmPesquisarAtribuicao : Form
    {
        public frmPesquisarAtribuicao()
        {
            InitializeComponent();
        }

        private void ltbPesquisarAtribuicao_SelectedIndexChanged(object sender, EventArgs e)
        {
            string item = ltbPesquisarAtribuicao.SelectedItem.ToString();
        }
    }
}
