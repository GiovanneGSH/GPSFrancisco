using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using MySql.Data.MySqlClient;
using ZstdSharp.Unsafe;

namespace GPSFrancisco
{
    public partial class frmAtribuicoes : Form
    {
        const int MF_BYCOMMAND = 0X400;
        [DllImport("user32")]
        static extern int RemoveMenu(IntPtr hMenu, int nPosition, int wFlags);
        [DllImport("user32")]
        static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
        [DllImport("user32")]
        static extern int GetMenuItemCount(IntPtr hWnd);

        public frmAtribuicoes()
        {
            InitializeComponent();
            desabilitarCampos();
        }

        private void limparCampos()
        {
            txtCodigo.Clear();
            txtNome.Clear();
        }

        private void desabilitarCampos()
        {
            txtCodigo.Enabled = false;
            txtNome.Enabled = false;
            btnCadastrar.Enabled = false;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnLimpar.Enabled = false;
        }

        private void desabilitarCamposNovo()
        {
            txtCodigo.Enabled = false;
            txtNome.Enabled = false;
            btnNovo.Enabled = true;
            btnCadastrar.Enabled = false;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnLimpar.Enabled = false;
        }

        private void habilitarCamposAtribuicoes()
        {
            txtCodigo.Enabled = false;
            txtNome.Enabled = true;
            btnCadastrar.Enabled = true;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnLimpar.Enabled = true;
            btnPesquisar.Enabled = true;
            txtNome.Focus();
        }


        private void habilitarCampos()
        {
            txtCodigo.Enabled = false;
            txtNome.Enabled = true;
            btnCadastrar.Enabled = true;
            btnAlterar.Enabled = true;
            btnExcluir.Enabled = true;
            btnLimpar.Enabled = true;
        }

        private void habilitarCamposNovo()
        {
            txtCodigo.Enabled = false;
            txtNome.Enabled = true;
            btnNovo.Enabled = false;
            btnCadastrar.Enabled = true;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnLimpar.Enabled = true;
            btnPesquisar.Enabled = true;
        }


        private void frmAtribuicoes_Load(object sender, EventArgs e)
        {
            IntPtr hMenu = GetSystemMenu(this.Handle, false);
            int MenuCount = GetMenuItemCount(hMenu) - 1;
            RemoveMenu(hMenu, MenuCount, MF_BYCOMMAND);
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal abrir = new frmMenuPrincipal();
            abrir.Show();
            this.Hide();
        }

        //Criando o método cadastrar atribuições

        public int cadastrarAtribuicoes(string nome)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "insert into tbAtribuicoes(nome)values(@nome);";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.Add("@nome", MySqlDbType.VarChar, 100).Value = nome;

            comm.Connection = Conexao.obterConexao();           

            int resp = comm.ExecuteNonQuery();

            Conexao.fecharConexao();

            return resp;

        }

        //Criando o método alterar atribuições

        public int alterarAtribuicoes(int codigo, string nome)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "update tbAtribuicoes set nome = @nome where codAtr = ;" + codigo;
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.Add("@nome", MySqlDbType.VarChar, 100).Value = nome;

            comm.Connection = Conexao.obterConexao();

            int resp = comm.ExecuteNonQuery();

            Conexao.fecharConexao();

            return resp;

        }

        //Criando o método excluir atribuições

        public int excluirAtribuicoes(int codigo)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "delete from tbAtribuicoes where codAtr = @codAtr;";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.Add("@codAtr", MySqlDbType.VarChar, 100).Value = codigo;

            comm.Connection = Conexao.obterConexao();

            int resp = comm.ExecuteNonQuery();

            Conexao.fecharConexao();

            return resp;

        }


        private void btnNovo_Click(object sender, EventArgs e)
        {
            habilitarCamposNovo();
            txtNome.Focus();

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {

            if (txtNome.Text.Equals(""))
            {
                MessageBox.Show("Favor inserir valores", "Mensagem do sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1);
                limparCampos();
                txtNome.Focus();
            }
            else
            {
                if (cadastrarAtribuicoes(txtNome.Text).Equals(1))
                {
                    MessageBox.Show("Atribuição cadastrada com sucesso!", "Mensagem do sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1);
                }
                limparCampos();
                desabilitarCamposNovo();
            }

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            //alterarAtribuicoes();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseja excluir a atribuição?.", "Mensagem do sistema",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2
                );
            if (result.Equals(DialogResult.Yes))
            {
                if (excluirAtribuicoes(Convert.ToInt32(txtCodigo.Text)).Equals(1))
                {
                
                    MessageBox.Show("Atribuição excluída com sucesso.", "Mensagem do sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1
                );
                    limparCampos();
                    desabilitarCampos();
                    btnNovo.Enabled = true;

                }
                else
                {
                    MessageBox.Show("Erro ao excluir.", "Mensagem do sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1);
                }
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparCampos();
            habilitarCamposAtribuicoes();

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            frmPesquisarAtribuicao abrir = new frmPesquisarAtribuicao();
            abrir.Show();
            this.Hide();
        }
    }
}
