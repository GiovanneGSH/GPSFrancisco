using Org.BouncyCastle.Bcpg.OpenPgp;
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
using K4os.Compression.LZ4.Streams.Frames;

namespace GPSFrancisco
{
    public partial class frmPesquisarUsuarios : Form
    {
        public frmPesquisarUsuarios()
        {
            InitializeComponent();           

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (rdbCodigo.Checked || rdbNome.Checked)
            {

                if (rdbCodigo.Checked && !txtDescricao.Text.Equals(""))
                {
                    try
                    {
                        pesquisarPorCodigo(Convert.ToInt32(txtDescricao.Text));
                        txtDescricao.Focus();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Favor inserir somente números inteiros");
                        txtDescricao.Clear();
                        txtDescricao.Focus();
                    }

                }
                else if (rdbNome.Checked && !txtDescricao.Text.Equals(""))
                {
                    pesquisarPorNome(txtDescricao.Text);
                    txtDescricao.Focus();
                }
                else
                {
                    MessageBox.Show("Favor inserir uma código ou nome");
                    txtDescricao.Focus();
                }
            }
            else
            {
                MessageBox.Show("Favor selecionar um método de pesquisa.");
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparCampos();
        }

        public void limparCampos()
        {
            txtDescricao.Clear();
            ltbPesquisar.Items.Clear();
            rdbNome.Checked = false;
            rdbCodigo.Checked = false;
            txtDescricao.Focus();
        }

        //pesquisar por codigo

        public void pesquisarPorCodigo(int codUsu)
        {

            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "select * from tbUsuarios where codUsu = @codUsu;";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();

            comm.Parameters.Add("@codUsu",MySqlDbType.Int32).Value = codUsu;

            comm.Connection = Conexao.obterConexao();                       

            MySqlDataReader DR;
            DR = comm.ExecuteReader();

            DR.Read();

            ltbPesquisar.Items.Clear();

            ltbPesquisar.Items.Add(DR.GetString(1));

            Conexao.fecharConexao();                       

        }
        

        public void pesquisarPorNome(string usuarios)
        {

            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "select * from tbUsuarios where nome like '%" + usuarios + "%';"; 
            comm.CommandType = CommandType.Text;

            comm.Connection = Conexao.obterConexao();

            MySqlDataReader DR;
            DR = comm.ExecuteReader();
            while (DR.Read())
            {
                ltbPesquisar.Items.Clear();

                ltbPesquisar.Items.Add(DR.GetString(1));
            }

            Conexao.fecharConexao();

        }

        private void rdbCodigo_CheckedChanged(object sender, EventArgs e)
        {
            txtDescricao.Focus();
        }

        private void rdbNome_CheckedChanged(object sender, EventArgs e)
        {
            txtDescricao.Focus();
        }

        private void ltbPesquisar_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nome = ltbPesquisar.SelectedItem.ToString();

            frmGerenciarUsuarios abrir = new frmGerenciarUsuarios(nome);
            abrir.Show();
            this.Hide();

        }
    }
}
