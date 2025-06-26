using MosaicoSolutions.ViaCep.Modelos;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GPSFrancisco
{
    public partial class frmUnidades : Form
    {
        public frmUnidades()
        {
            InitializeComponent();
            desabilitarCampos();
        }

        public frmUnidades(string descricao)
        {
            InitializeComponent();
            desabilitarCampos();
            txtDescricao.Text = descricao;
            pesquisarPorNome(txtDescricao.Text);
        }

        public void desabilitarCampos()
        {
            txtCodigo.Enabled = false;
            txtDescricao.Enabled = false;
            txtUnidade.Enabled = false;

            btnCadastrar.Enabled = false;
            btnExcluir.Enabled = false;
            btnAlterar.Enabled = false;
            btnLimpar.Enabled = false;            
        }


        public void habilitarCamposNovo()
        {
            txtCodigo.Enabled = false;
            txtDescricao.Enabled = true;
            txtUnidade.Enabled = true;

            btnNovo.Enabled = false;

            btnCadastrar.Enabled = true;
            btnExcluir.Enabled = false;
            btnAlterar.Enabled = false;
            btnLimpar.Enabled = false;

            txtDescricao.Focus();   
        }
        public void limparCampos()
        {
            txtCodigo.Clear();
            txtDescricao.Clear();
            txtUnidade.Clear();

            btnNovo.Enabled = true;

            btnCadastrar.Enabled = false;
            btnExcluir.Enabled = false;
            btnAlterar.Enabled = false;
            btnLimpar.Enabled = false;
        }



        private void btnNovo_Click(object sender, EventArgs e)
        {
            habilitarCamposNovo();          
        }

       

            //cadastrando unidades

        public int cadastrarUnidades(string descricao, string unidade)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "INSERT INTO tbUnidades(descricao,unidade)VALUES(@descricao,@unidade);";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.Add("@descricao",MySqlDbType.VarChar,50).Value = descricao;
            comm.Parameters.Add("@unidade",MySqlDbType.VarChar,2).Value = unidade;


            comm.Connection = Conexao.obterConexao();


            int resp = comm.ExecuteNonQuery();

            Conexao.fecharConexao();

            return resp;
        }

        public int alterarUnidades(string descricao, string unidade, int codUnid)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "UPDATE SET tbUnidades descricao=@descricao, unidade=@unidade WHERE codUnid=@codUnid;";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.Add("@descricao", MySqlDbType.VarChar, 50).Value = descricao;
            comm.Parameters.Add("@unidade", MySqlDbType.VarChar, 2).Value = unidade;
            comm.Parameters.Add("@codUnid", MySqlDbType.Int32).Value = codUnid;



            comm.Connection = Conexao.obterConexao();


            int resp = comm.ExecuteNonQuery();

            Conexao.fecharConexao();

            return resp;
        }

        public void pesquisarPorNome(string descricao)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = $"SELECT * FROM tbUnidades WHERE descricao LIKE '%{descricao}%';";
            comm.CommandType = CommandType.Text;                  

            comm.Connection = Conexao.obterConexao();

            MySqlDataReader DR;

            DR = comm.ExecuteReader();
            DR.Read();

            txtCodigo.Text = Convert.ToString(DR.GetInt32(0));
            txtDescricao.Text = Convert.ToString(DR.GetString(1));
            txtUnidade.Text = Convert.ToString(DR.GetString(2));

            Conexao.fecharConexao();

            
        }


        public int excluirUnidades(int codUnid)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "DELETE FROM tbUnidades WHERE codUnid=@codUnid;";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.Add("@codUnid", MySqlDbType.Int32).Value = codUnid;            


            comm.Connection = Conexao.obterConexao();


            int resp = comm.ExecuteNonQuery();

            Conexao.fecharConexao();

            return resp;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txtDescricao.Text.Equals("") || txtUnidade.Text.Equals(""))
            {
                MessageBox.Show("Favor inserir valores", "Mensagem do sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1);
            }
            else
            {
                int resp = cadastrarUnidades(txtDescricao.Text, txtUnidade.Text);

                if (resp.Equals(1))
                {
                    MessageBox.Show("Cadastrado com sucesso!", "Mensagem do sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1);
                    desabilitarCampos();
                    limparCampos();
                    btnNovo.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Erro ao Cadastrar!", "Mensagem do sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1);

                    limparCampos();
                    txtDescricao.Focus();
                }
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmGerenciarProdutos abrir = new frmGerenciarProdutos();
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
