using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace GPSFrancisco
{
    public partial class frmPesquisaProduto : Form
    {
        public frmPesquisaProduto()
        {
            InitializeComponent();
        }

        private void ltbPesquisarProduto_SelectedIndexChanged(object sender, EventArgs e)
        {
            string codigoBarras = ltbPesquisarProduto.SelectedItem.ToString();

            frmGerenciarProdutos abrir = new frmGerenciarProdutos(codigoBarras);
            abrir.Show();
            this.Hide();
        }

        private void btnPesquisarProduto_Click(object sender, EventArgs e)
        {
            if (rdbCodigoProduto.Checked.Equals(false) && rdbNomeProduto.Checked.Equals(false))
            {
                MessageBox.Show("Favor selecionar um item",
                    "Mensagem do sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1);
            }
            else if (txtDescricaoProduto.Text.Equals(""))
            {
                MessageBox.Show("Favor inserir um valor",
                    "Mensagem do sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1);
                txtDescricaoProduto.Focus();
            }
            else
            {
                if (rdbCodigoProduto.Checked)
                {
                    buscaProdutosPorCodigoBarras(txtDescricaoProduto.Text);
                }
                if (rdbNomeProduto.Checked)
                {
                    buscaProdutosDescricao(txtDescricaoProduto.Text);
                }
            }
        }

        public void buscaProdutosPorCodigoBarras(string codProdBarras)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "SELECT * FROM tbProdutos WHERE codBarras = @codBarras;";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.Add("@codBarras", MySqlDbType.VarChar, 255).Value = codProdBarras;
            comm.Connection = Conexao.obterConexao();

            MySqlDataReader DR;
            DR = comm.ExecuteReader();
            DR.Read();

            ltbPesquisarProduto.Items.Clear();

            ltbPesquisarProduto.Items.Add(DR.GetString(0));

            Conexao.fecharConexao();

        }

        public void buscaProdutosDescricao(string descricao)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = $"SELECT * FROM tbProdutos WHERE descricao LIKE '%{descricao}%';";

            comm.CommandType = CommandType.Text;

            comm.Connection = Conexao.obterConexao();

            MySqlDataReader DR;
            DR = comm.ExecuteReader();

            ltbPesquisarProduto.Items.Clear();

            while (DR.Read())
            {
                ltbPesquisarProduto.Items.Add(DR.GetString(1));
            }

            Conexao.fecharConexao();

        }
    }
}
