using MySql.Data.MySqlClient;
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
    public partial class frmGerenciarProdutos : Form
    {
        public frmGerenciarProdutos()
        {
            InitializeComponent();
            buscarUnidadesMedida();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal abrir = new frmMenuPrincipal();
            abrir.Show();
            this.Hide();
        }

        private void frmGerenciarProdutos_Load(object sender, EventArgs e)
        {

        }

        //buscar unidades

        public void buscarUnidadesMedida()
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "SELECT * FROM tbUnidades ORDER BY unidade;";
            comm.CommandType = CommandType.Text;            

            comm.Connection = Conexao.obterConexao();

            MySqlDataReader DR;

            DR = comm.ExecuteReader();

            while (DR.Read()) 
            {
                cbbUnidade.Items.Add(DR.GetString(2));
            }


            Conexao.fecharConexao();            
        }

        private void btnUnidade_Click(object sender, EventArgs e)
        {
            frmUnidades abrir = new frmUnidades();
            abrir.Show();
            this.Hide();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            frmPesquisarUnidadesMedida abrir = new frmPesquisarUnidadesMedida();
            abrir.Show();
            this.Hide();
        }
    }
}
