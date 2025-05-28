using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GPSFrancisco
{
    public partial class frmGerenciarVoluntarios : Form
    {
        const int MF_BYCOMMAND = 0X400;
        [DllImport("user32")]
        static extern int RemoveMenu(IntPtr hMenu, int nPosition, int wFlags);
        [DllImport("user32")]
        static extern IntPtr GetSystemMenu(IntPtr hWnd, bool bRevert);
        [DllImport("user32")]
        static extern int GetMenuItemCount(IntPtr hWnd);

        public frmGerenciarVoluntarios()
        {
            InitializeComponent();

            carregaAtribuicoes();
        }
        private void frmGerenciarVoluntarios_Load(object sender, EventArgs e)
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



// buscando atribuições para carregar na combo

        public void carregaAtribuicoes()
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "select * from tbAtribuicoes order by nome;";
            comm.CommandType = CommandType.Text;            

            comm.Connection = Conexao.obterConexao();

            MySqlDataReader DR;

            DR = comm.ExecuteReader();          
           
            while (DR.Read())
            {
                cbbAtribuicoes.Items.Add(DR.GetString(1));
            }

            Conexao.fecharConexao();                            
        }

        private int cadastrarVoluntarios(string nome, string email, string telCel, string endereco, string numero, string cep, string bairro, string cidade, string estado, DateTime data, DateTime hora, int status)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "insert into tbVoluntarios(nome,email,telCel,endereco,numero,cep,bairro,cidade,estado,codAtr,data,hora,status)values(@nome,@email,@telCel,@endereco,@numero,@cep,@bairro,@cidade,@estado,@codAtr,@data,@hora,@status);";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.Add("@nome", MySqlDbType.VarChar, 100).Value = nome;
            comm.Parameters.Add("@email", MySqlDbType.VarChar, 100).Value = email;
            comm.Parameters.Add("@telCel", MySqlDbType.VarChar, 15).Value = telCel;
            comm.Parameters.Add("@endereco", MySqlDbType.VarChar, 100).Value = endereco;
            comm.Parameters.Add("@numero", MySqlDbType.VarChar, 5).Value = numero;
            comm.Parameters.Add("@cep", MySqlDbType.VarChar, 9).Value = cep;
            comm.Parameters.Add("@bairro", MySqlDbType.VarChar, 100).Value = bairro;
            comm.Parameters.Add("@cidade", MySqlDbType.VarChar, 100).Value = cidade;
            comm.Parameters.Add("@estado", MySqlDbType.VarChar, 2).Value = estado;
            comm.Parameters.Add("@codAtr", MySqlDbType.Int32).Value = codigoAtribuicao;
            comm.Parameters.Add("@data", MySqlDbType.Date, 100).Value = data;
            comm.Parameters.Add("@hora", MySqlDbType.Time, 100).Value = hora;
            comm.Parameters.Add("@status", MySqlDbType.Bit, 100).Value = status;


            comm.Connection = Conexao.obterConexao();         
                      

            int resp = comm.ExecuteNonQuery();

            Conexao.fecharConexao();

            return resp;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            cadastrarVoluntarios(txtNome.Text, txtEmail.Text, mskTelefone.Text, txtEndereco.Text, txtNumero.Text, mskCep.Text, txtBairro.Text, txtCidade.Text, cbbEstado.Text, dtpData.Value, dtpHora.Value, ckbStatus.Checked.GetHashCode());
        }


        public int buscaCodigoAtribuicoes(string nome)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "select codAtr from tbatribuicoes where nome = @nome;";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.Add("@nome", MySqlDbType.VarChar, 100).Value = nome;

            comm.Connection = Conexao.obterConexao();

            MySqlDataReader DR;

            DR = comm.ExecuteReader();

            DR.Read();

            int codAtr = DR.GetInt32(0);         
      
            Conexao.fecharConexao();

            return codAtr;
        }

        int codigoAtribuicao;

        private void cbbAtribuicoes_SelectedIndexChanged(object sender, EventArgs e)
        {
          codigoAtribuicao = buscaCodigoAtribuicoes(cbbAtribuicoes.SelectedItem.ToString());
            txtCodigo.Text = codigoAtribuicao.ToString();
        }

       
    }

   
}
