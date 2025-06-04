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

namespace GPSFrancisco
{
    public partial class frmGerenciarUsuarios : Form
    {
        const int MF_BYCOMMAND = 0X400;
        [DllImport("user32")]
        static extern int RemoveMenu(IntPtr hMenu, int nPosition, int wFlags);
        [DllImport("user32")]
        static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
        [DllImport("user32")]
        static extern int GetMenuItemCount(IntPtr hWnd);

        public frmGerenciarUsuarios()
        {
            InitializeComponent();
            desabilitarCampos();
        }

        public frmGerenciarUsuarios(string nome)
        {
            InitializeComponent();
            desabilitarCampos();

            txtUsuario.Text = nome;

            buscaUsuarioExistente(nome);

            habilitarCamposUsuarioExistente();

        }

        private void desabilitarCampos()
        {
            txtUsuario.Enabled = false;
            txtSenha.Enabled = false;
            txtValidaSenha.Enabled = false;
            btnCadastrar.Enabled = false;
            btnExcluir.Enabled = false;
            btnLimpar.Enabled = false;
            btnAlterar.Enabled = false;

        }

        private void habilitarCampos()
        {
            txtUsuario.Enabled = true;
            txtSenha.Enabled = true;
            txtValidaSenha.Enabled = true;
            btnCadastrar.Enabled = true;
            btnExcluir.Enabled = false;
            btnLimpar.Enabled = true;
            btnAlterar.Enabled = false;
            btnNovo.Enabled = false;
            txtUsuario.Focus();

        }

        private void habilitarCamposUsuarioExistente()
        {
            txtUsuario.Enabled = true;
            txtSenha.Enabled = true;
            txtValidaSenha.Enabled = true;
            btnCadastrar.Enabled = false;
            btnExcluir.Enabled = true;
            btnLimpar.Enabled = true;
            btnAlterar.Enabled = true;
            btnNovo.Enabled = false;
            txtUsuario.Focus();
        }

        private void desabilitarCamposCadastrar()
        {
            txtUsuario.Enabled = false;
            txtSenha.Enabled = false;
            txtValidaSenha.Enabled = false;
            btnCadastrar.Enabled = false;
            btnExcluir.Enabled = false;
            btnLimpar.Enabled = true;
            btnAlterar.Enabled = false;
            btnNovo.Enabled = true;  
            txtUsuario.Clear();
            txtSenha.Clear();
            txtValidaSenha.Clear();           
        }
               


        private void frmGerenciarUsuarios_Load(object sender, EventArgs e)
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

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparCampos();
        }
        //Método para limpar campos
        private void limparCampos()
        {
            txtCodigo.Clear();
            txtUsuario.Clear();
            txtSenha.Clear();
            txtValidaSenha.Clear();
            txtUsuario.Focus();
            btnCheck.Visible = false;
            btnErro.Visible = false;
            txtSenha.Enabled = true;
        }        

        private void btnNovo_Click(object sender, EventArgs e)
        {
            habilitarCampos();            
        }           
       
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text.Equals("") || txtSenha.Text.Equals("") || txtValidaSenha.Text.Equals(""))
            {
                MessageBox.Show("Por favor inserir valores!", "Mensagem do sistema.", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
               desabilitarCamposCadastrar();
            }
            else
            {                               

               if (txtSenha.Text.Length < 12 || txtValidaSenha.Text.Length < 12)
                    {
                        MessageBox.Show("Sua senha tem que ter 12 caracteres", "Mensagem do sistema.", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    }
                    
                else
                       
                if (txtSenha.Text.Equals(txtValidaSenha.Text))
                {

                    if (cadastrarUsuario(txtUsuario.Text, txtSenha.Text).Equals(1))
                    {
                        MessageBox.Show("Cadastrado com sucesso!", "Mensagem do sistema.", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                        desabilitarCamposCadastrar();                        
                    }
                    else
                    {
                        MessageBox.Show("Erro ao cadastrar!", "Mensagem do sistema.", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                        desabilitarCamposCadastrar();
                    }


                }
                else
                    MessageBox.Show("A senha não é igual!", "Mensagem do sistema.", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    txtSenha.Clear() ;
                    txtValidaSenha.Clear();
                    txtSenha.Focus();                
            }
        }

        int contador = 0;

        private void txtValidaSenha_TextChanged(object sender, EventArgs e)
        {
            if (txtSenha.Text.Equals(txtValidaSenha.Text) && txtValidaSenha.Text.Length.Equals(12))
            {
                btnCheck.Visible = true;
                btnErro.Visible = false;
            }
            else
            {
                btnCheck.Visible = false;
            }
            if (!txtValidaSenha.Text.Equals(txtSenha.Text) && txtValidaSenha.Text.Length.Equals(12))
            {
                btnErro.Visible = true;
                contador++;
            }
            if (contador > 0)
            {
                btnErro.Visible = true;
                txtValidaSenha.Clear();
                txtValidaSenha.Focus();
                txtSenha.Enabled = false;
                contador = 0;
            }           

        }

        //Criando métodos CRUD

        //Método cadastrar usuário

        public int cadastrarUsuario(string nome, string senha)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "insert into tbUsuarios(nome,senha)values(@nome,@senha);";
            comm.CommandType = CommandType.Text;
            
            comm.Parameters.Clear();
            comm.Parameters.Add("@nome",MySqlDbType.VarChar,50).Value = nome;
            comm.Parameters.Add("@senha",MySqlDbType.VarChar,12).Value = senha;

            comm.Connection = Conexao.obterConexao();
                        
            int resp = comm.ExecuteNonQuery();

            Conexao.fecharConexao();

            return resp;
        }

        //Método Buscar Usuários Cadastrados

        public void buscarUsuariosCadastrados()
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "SELECT nome FROM tbusuarios ORDER BY nome ASC;";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();

            comm.Connection = Conexao.obterConexao();

            MySqlDataReader DR;
            DR = comm.ExecuteReader();

            while (DR.Read()) {

                cbbUsuariosCadastrados.Items.Add(DR.GetString(0));

            }          

            Conexao.fecharConexao();

        }

        //metódo busca usuário existente

        public void buscaUsuarioExistente(string usuario)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "select * from tbUsuarios where nome = @nome;";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.Add("@nome", MySqlDbType.VarChar, 50).Value = usuario;

            comm.Connection = Conexao.obterConexao();
            MySqlDataReader DR;
            DR = comm.ExecuteReader();
            DR.Read();

            txtCodigo.Text = Convert.ToString(DR.GetInt32(0));
            txtUsuario.Text = DR.GetString(1);
            txtSenha.Text = DR.GetString(2);

            Conexao.fecharConexao();

        }


        private void cbbUsuariosCadastrados_Click(object sender, EventArgs e)
        {
            cbbUsuariosCadastrados.Items.Clear();
            buscarUsuariosCadastrados();
        }

        //metódo alterar usuário

        private int alterarUsuario(string usuario, string senha, int codUsu)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "update tbUsuarios set nome = @nome, senha = @senha where codUsu = " + codUsu;
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();

            comm.Parameters.Add("@nome", MySqlDbType.VarChar, 50).Value = usuario;
            comm.Parameters.Add("@senha", MySqlDbType.VarChar, 12).Value = senha;

            comm.Connection = Conexao.obterConexao();

            int resp = comm.ExecuteNonQuery();

            Conexao.fecharConexao();

            return resp;

        }

        public void buscaUsuarioCodigo()
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "select * from tbUsuarios where codUsu = 1;";
            comm.CommandType = CommandType.Text;

            comm.Connection = Conexao.obterConexao();

            MySqlDataReader DR;
            DR = comm.ExecuteReader();
            DR.Read();

            txtCodigo.Text = DR.GetString(0);
            txtUsuario.Text = DR.GetString(1);
            txtSenha.Text = DR.GetString(2);
                        
            Conexao.fecharConexao();
        }

        public int excluirUsuario(int codUsu)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "delete from tbUsuarios where codUsu = @codUsu;";
            comm.CommandType = CommandType.Text;            

            comm.Parameters.Clear();

            comm.Parameters.Add("@codUsu", MySqlDbType.Int32).Value = codUsu;

            comm.Connection = Conexao.obterConexao();

            int resp = comm.ExecuteNonQuery();

            Conexao.fecharConexao();

            desabilitarCampos();
            limparCampos();

            return resp;
            
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            frmPesquisarUsuarios abrir = new frmPesquisarUsuarios();
            abrir.Show();
            this.Hide();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
           if(alterarUsuario(txtUsuario.Text, txtSenha.Text, Convert.ToInt32(txtCodigo.Text)).Equals(1)){

                MessageBox.Show("Usuário alterado com sucesso.", "Mensagem do sistema",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1);
                desabilitarCampos();
                limparCampos();
            }
            else
            {
                MessageBox.Show("Erro ao alterar", "Mensagem do sistema",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error,
                MessageBoxDefaultButton.Button1);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult resp = MessageBox.Show("Deseja excluir?", "Mensagem do sistema",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2
                );

            if (resp == DialogResult.Yes)
            {

                if (excluirUsuario(Convert.ToInt32(txtCodigo.Text)).Equals(1))
                {
                    MessageBox.Show("Usuário excluído com sucesso.", "Mensagem do sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1);                    
                }
                else
                {
                    MessageBox.Show("Erro ao excluir.", "Mensagem do sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1);
                }
            }
            else
            {
                //se o botão for NO.
            }
        }
    }
}
