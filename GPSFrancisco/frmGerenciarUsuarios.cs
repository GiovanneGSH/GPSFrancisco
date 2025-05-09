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

        private void habilitarCamposCadastrar()
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
               habilitarCamposCadastrar();
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
                    MessageBox.Show("Cadastrado com sucesso!", "Mensagem do sistema.", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);

                    habilitarCamposCadastrar();
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
    }
}
