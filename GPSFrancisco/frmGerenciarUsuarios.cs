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
            comm.CommandText = "select nome from tbusuarios order by nome asc;";
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

        private void cbbUsuariosCadastrados_Click(object sender, EventArgs e)
        {
            cbbUsuariosCadastrados.Items.Clear();
            buscarUsuariosCadastrados();
        }

        //metódo alterar usuário

        private void alterarUsuario(string usuario, string senha)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "update tbUsuarios set nome='@nome',senha='@senha' where codUsu = @codUsu;";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();

            comm.Parameters.Add("@nome", MySqlDbType.VarChar, 50).Value = usuario;
            comm.Parameters.Add("@senha", MySqlDbType.VarChar, 12).Value = senha;

            comm.Connection = Conexao.obterConexao();

            Conexao.fecharConexao();

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
    }
}
