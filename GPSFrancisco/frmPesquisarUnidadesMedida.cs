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
    public partial class frmPesquisarUnidadesMedida : Form
    {
        public frmPesquisarUnidadesMedida()
        {
            InitializeComponent();
        }
        private void ltbPesquisarUnidade_SelectedIndexChanged(object sender, EventArgs e)
        {
            string descricao = ltbPesquisarUnidade.SelectedItem.ToString();            

            frmUnidades abrir = new frmUnidades(descricao); 
            abrir.ShowDialog();
            this.Hide();
        }

        private void btnPesquisarUnidade_Click(object sender, EventArgs e)
        {
            if (!rdbCodigoUnidade.Checked && !rdbNomeUnidade.Checked)
            {
                MessageBox.Show("Favor selecionar um item", "Mensagem do sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1);
            }
            else if (txtDescricaoUnidade.Text.Equals(""))
            {
                MessageBox.Show("Favor inserir uma descrição", "Mensagem do sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1);
                txtDescricaoUnidade.Focus();
            }
            else
            {
                if (rdbCodigoUnidade.Checked)
                {
                    try
                    {
                        buscarUnidadesPorCodigo(Convert.ToInt32(txtDescricaoUnidade.Text));
                    }
                    catch (Exception) 
                    {
                        MessageBox.Show("Favor inserir apenas números!", "Mensagem do sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1);
                        txtDescricaoUnidade.Focus();
                    }
                }
                if (rdbNomeUnidade.Checked)
                {
                    buscarUnidadesPorNome(txtDescricaoUnidade.Text);
                }                
            }           
        }

        private void buscarUnidadesPorCodigo(int codUnid)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = $"SELECT * FROM tbUnidades WHERE codUnid = {@codUnid};";
            comm.CommandType = CommandType.Text;
        
            comm.Connection = Conexao.obterConexao();

            MySqlDataReader DR;
            DR = comm.ExecuteReader();
            DR.Read();

            ltbPesquisarUnidade.Items.Clear();
            ltbPesquisarUnidade.Items.Add(DR.GetString(1));

            Conexao.fecharConexao();

        }

        private void buscarUnidadesPorNome(string descricao)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = $"SELECT * FROM tbUnidades WHERE descricao LIKE '%{descricao}%';";
            comm.CommandType = CommandType.Text;

            comm.Connection = Conexao.obterConexao();

            MySqlDataReader DR;
            DR = comm.ExecuteReader();

            ltbPesquisarUnidade.Items.Clear();

            while (DR.Read())
            {
                ltbPesquisarUnidade.Items.Add(DR.GetString(1));
            }

            Conexao.fecharConexao();

        }







    }
}
