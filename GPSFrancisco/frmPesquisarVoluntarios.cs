using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// importando MYSQL para utilizar no formulário

using MySql.Data.MySqlClient;

namespace GPSFrancisco
{
    public partial class frmPesquisarVoluntarios : Form
    {
        public frmPesquisarVoluntarios()
        {
            InitializeComponent();
        }

        private void ltbPesquisarVoluntario_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nome = ltbPesquisarVoluntario.SelectedItem.ToString();

            frmGerenciarVoluntarios abrir = new frmGerenciarVoluntarios(nome);
            abrir.Show();
            this.Hide();
        }

        public void habilitarCampos()
        {
            txtNomeVoluntario.Enabled = true;
            ltbPesquisarVoluntario.Enabled = true;
            btnLimparNome.Enabled = true;
            btnPesquisarVoluntario.Enabled = true;
            txtNomeVoluntario.Focus();
        }


        private void btnPesquisarVoluntario_Click(object sender, EventArgs e)
        {
            if (!rdbCodigoVoluntario.Checked && !rdbNomeVoluntario.Checked)
            {
                MessageBox.Show("Favor selecionar um item", "Mensagem do sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1);             
            }            
            else if (txtNomeVoluntario.Text.Equals(""))
            {
                MessageBox.Show("Favor inserir uma descrição", "Mensagem do sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1);
                txtNomeVoluntario.Focus();
            }
            else
            {
                if (rdbCodigoVoluntario.Checked)
                {
                   buscarVoluntariosPorCodigo(Convert.ToInt32(txtNomeVoluntario.Text));
                }
                if (rdbNomeVoluntario.Checked)
                {
                    buscarVoluntariosPorNome(txtNomeVoluntario.Text);                    
                }

                //ltbPesquisarVoluntario.Items.Add(txtNomeVoluntario.Text);
            }
        }

        //Busca Voluntários por código na tabela no banco de dados 

        private void buscarVoluntariosPorCodigo(int codVol)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "SELECT * FROM tbvoluntarios WHERE @codVol = @codVol;";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.Add("@codVol", MySqlDbType.Int32).Value = codVol;

            comm.Connection = Conexao.obterConexao();

            MySqlDataReader DR;
            DR = comm.ExecuteReader();
            DR.Read();

            ltbPesquisarVoluntario.Items.Clear();
            ltbPesquisarVoluntario.Items.Add(DR.GetInt32(0));

            Conexao.fecharConexao();

        }

        //Busca Voluntários por código na tabela no banco de dados 

        private void buscarVoluntariosPorNome(string nome)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "SELECT * FROM tbVoluntarios WHERE nome LIKE '%"+nome+"%';"; 
            comm.CommandType = CommandType.Text;           

            comm.Connection = Conexao.obterConexao();

            MySqlDataReader DR;
            DR = comm.ExecuteReader();            

            ltbPesquisarVoluntario.Items.Clear();

            while (DR.Read())
            {
                ltbPesquisarVoluntario.Items.Add(DR.GetString(1));
            }                       

            Conexao.fecharConexao();

        }

        private void rdbCodigoVoluntario_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbCodigoVoluntario.Checked)
            {
                habilitarCampos();
            }
        }

        private void rdbNomeVoluntario_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbNomeVoluntario.Checked)
            {
                habilitarCampos();
                txtNomeVoluntario.Focus();
            }
        }

        //criando método de habilitar campos

        public void limparCampos()
        {
            txtNomeVoluntario.Clear();
            ltbPesquisarVoluntario.Items.Clear();
            rdbCodigoVoluntario.Checked = false;
            rdbNomeVoluntario.Checked = false;
            txtNomeVoluntario.Focus();
        }

        private void btnLimparNome_Click(object sender, EventArgs e)
        {
            limparCampos();
        }
    }
}
