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
// importando a API de buscar CEP
using MosaicoSolutions.ViaCep;
using System.IO;

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

            desabilitarCamposNovo();


        }

        //Criando método construtor com parametros
        public frmGerenciarVoluntarios(string nome)
        {
            InitializeComponent();

            carregaAtribuicoes();

            desabilitarCamposNovo();

            txtNome.Text = nome;

            carregaVoluntariosPorNome(txtNome.Text);

            habilitarCamposAlterar();

        }


        public void desabilitarCamposNovo()
        {
            txtCodigo.Enabled = false;
            txtNome.Enabled = false;
            txtEmail.Enabled = false;
            txtEndereco.Enabled = false;
            txtBairro.Enabled = false;
            txtCidade.Enabled = false;
            txtNumero.Enabled = false;
            txtComplemento.Enabled = false;
            mskTelefone.Enabled = false;
            mskCep.Enabled = false;
            cbbAtribuicoes.Enabled = false;
            cbbEstado.Enabled = false;
            dtpData.Enabled = false;
            dtpHora.Enabled = false;
            btnAlterar.Enabled = false;
            btnCadastrar.Enabled = false;
            btnExcluir.Enabled = false;
            btnLimpar.Enabled = false;
            btnCarregar.Enabled = false;
            txtNome.Focus();
        }

        public void habilitarCamposNovo()
        {
            txtCodigo.Enabled = false;
            txtNome.Enabled = true;
            txtEmail.Enabled = true;
            txtEndereco.Enabled = true;
            txtBairro.Enabled = true;
            txtCidade.Enabled = true;
            txtNumero.Enabled = true;
            txtComplemento.Enabled = true;
            mskTelefone.Enabled = true;
            mskCep.Enabled = true;
            cbbAtribuicoes.Enabled = true;
            cbbEstado.Enabled = true;
            dtpData.Enabled = true;
            dtpHora.Enabled = true;
            btnCadastrar.Enabled = true;
            btnExcluir.Enabled = true;
            btnLimpar.Enabled = true;
            btnCarregar.Enabled = true;
            txtNome.Focus();
        }

        public void habilitarCamposAlterar()
        {
            txtCodigo.Enabled = false;
            txtNome.Enabled = true;
            txtEmail.Enabled = true;
            txtEndereco.Enabled = true;
            txtBairro.Enabled = true;
            txtCidade.Enabled = true;
            txtNumero.Enabled = true;
            txtComplemento.Enabled = true;
            mskTelefone.Enabled = true;
            mskCep.Enabled = true;
            cbbAtribuicoes.Enabled = true;
            cbbEstado.Enabled = true;
            dtpData.Enabled = true;
            dtpHora.Enabled = true;
            btnCadastrar.Enabled = false;
            btnExcluir.Enabled = true;
            btnLimpar.Enabled = true;
            btnNovo.Enabled = false;
            btnAlterar.Enabled = true;
            btnCarregar.Enabled = true;
            txtNome.Focus();
        }

        public void limparCampos()
        {
            txtCodigo.Clear();
            txtNome.Clear();
            txtEmail.Clear();
            txtEndereco.Clear();
            txtBairro.Clear();
            txtCidade.Clear();
            txtNumero.Clear();
            txtComplemento.Clear();
            mskTelefone.Clear();
            mskCep.Clear();
            cbbAtribuicoes.Text = "";
            cbbEstado.Text = "";
            dtpData.Value = DateTime.Now;
            dtpHora.Value = DateTime.Now;
            btnCadastrar.Enabled = false;
            btnExcluir.Enabled = false;
            btnAlterar.Enabled = false;
            btnLimpar.Enabled = true;
            txtNome.Focus();
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

        


        private int cadastrarVoluntarios(string nome, string email, string telCel, string endereco, string numero, string cep, string bairro, string cidade, string estado, DateTime data, DateTime hora, int status, long foto)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "insert into tbVoluntarios(nome,email,telCel,endereco,numero,cep,bairro,cidade,estado,codAtr,data,hora,status,foto)values(@nome,@email,@telCel,@endereco,@numero,@cep,@bairro,@cidade,@estado,@codAtr,@data,@hora,@status,@foto);";
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
            comm.Parameters.Add("@data", MySqlDbType.DateTime).Value = data;


            //--------Converte o dtp.Hora para o formato hora--------

            //DateTime horaSelecionada = dtpHora.Value;

            //TimeSpan apenasHora = horaSelecionada.TimeOfDay;
            /*--------------------------------------------------*/


            comm.Parameters.Add("@hora", MySqlDbType.DateTime).Value = hora;
            comm.Parameters.Add("@status", MySqlDbType.Bit, 100).Value = status;

            comm.Parameters.Add("@foto", MySqlDbType.LongBlob).Value = foto;


            comm.Connection = Conexao.obterConexao();


            int resp = comm.ExecuteNonQuery();

            Conexao.fecharConexao();

            return resp;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {

            //verificando se os campos foram preenchidos 

            if (txtNome.Text.Equals("") || txtEmail.Text.Equals("") || mskTelefone.Text.Equals("(  )    -") || txtEndereco.Text.Equals("") || txtBairro.Text.Equals("") || txtNumero.Text.Equals("") || mskCep.Text.Equals("     -") || txtCidade.Text.Equals("") || cbbEstado.Text.Equals("") || cbbAtribuicoes.Text.Equals("") || ckbStatus.Checked == false)
            {
                MessageBox.Show("Favor preencher os campos!", "Mensagem do sistema",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error,
                MessageBoxDefaultButton.Button1);

                txtNome.Focus();

            }
            else if (mskTelefone.Text.Length < 13)
            {
                MessageBox.Show("Favor preencher o campo Número!", "Mensagem do sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button1);

                mskTelefone.Focus();

            }
            else if (mskCep.Text.Length < 9)
            {
                MessageBox.Show("Favor preencher o campo CEP!", "Mensagem do sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button1);

                mskCep.Focus();
            }
            else if (pcbFoto.Image.Equals(null)) //Organizar estrutura de decisão
            {
                MessageBox.Show("Favor carregar uma foto", "Mensagem do sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button1);                
            }
            else
            {
                cadastrarVoluntarios(txtNome.Text, txtEmail.Text, mskTelefone.Text, txtEndereco.Text, txtNumero.Text, mskCep.Text, txtBairro.Text, txtCidade.Text, cbbEstado.Text, dtpData.Value, dtpHora.Value, ckbStatus.Checked.GetHashCode(), salvarFotos().LongLength);
                MessageBox.Show("Cadastrado com sucesso!", "Mensagem do sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1);
                limparCampos();
                pcbFoto.Image = null;
                desabilitarCamposNovo();
            }


            //cadastrarVoluntarios(txtNome.Text, txtEmail.Text, mskTelefone.Text, txtEndereco.Text, txtNumero.Text, mskCep.Text, txtBairro.Text, txtCidade.Text, cbbEstado.Text, dtpData.Value, dtpHora.Value, ckbStatus.Checked.GetHashCode());
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

        private void btnNovo_Click(object sender, EventArgs e)
        {
            habilitarCamposNovo();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparCampos();
            desabilitarCamposNovo();
        }



        //criando o método busca cep
        public void buscaCEP(string cep)
        {

            var viaCEPService = ViaCepService.Default();
            try
            {
                var endereco = viaCEPService.ObterEndereco(cep);

                txtEndereco.Text = endereco.Logradouro.ToString();
                txtCidade.Text = endereco.Localidade.ToString();
                txtBairro.Text = endereco.Bairro.ToString();
                cbbEstado.Text = endereco.UF.ToString();
            }

            catch (Exception)
            {
                MessageBox.Show("Favor inserir um CEP válido", "Mensagem do sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1);

                mskCep.Text = "";
                mskCep.Focus();
            }

        }

        public void carregaVoluntariosPorNome(string nome)
        {
            bool status = false;

            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "select * from tbVoluntarios where nome = @nome;";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();

            comm.Parameters.Add("@nome", MySqlDbType.VarChar, 100).Value = nome;


            comm.Connection = Conexao.obterConexao();

            MySqlDataReader DR;
            DR = comm.ExecuteReader();
            DR.Read();

            //Checando o campo status

            if (DR.GetInt32(13).Equals(1))
            {
                status = true;
            }
            if (DR.GetInt32(13).Equals(0))
            {
                status = false;
            }

            //Trazendo os dados para o formulário:

            txtCodigo.Text = Convert.ToString(DR.GetInt32(0));
            txtNome.Text = DR.GetString(1);
            txtEmail.Text = DR.GetString(2);
            mskTelefone.Text = DR.GetString(3);
            txtEndereco.Text = DR.GetString(4);
            txtNumero.Text = DR.GetString(5);
            mskCep.Text = DR.GetString(6);
            txtBairro.Text = DR.GetString(7);
            txtCidade.Text = DR.GetString(8);
            cbbEstado.Text = DR.GetString(9);

            //cbbAtribuicoes.Text = Convert.ToString(DR.GetInt32(10));

            //cbbAtribuicoes.Text = Convert.ToString(DR.GetInt32(10));

            //cbbAtribuicoes.SelectedItem = (DR.GetInt32(10));

            dtpData.Value = DR.GetDateTime(11);
            dtpHora.Value = DR.GetDateTime(12);
            ckbStatus.Checked = status;

            Conexao.fecharConexao();

        }

        private void mskCep_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buscaCEP(mskCep.Text);
                txtNumero.Focus();
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            frmPesquisarVoluntarios abrir = new frmPesquisarVoluntarios();
            abrir.Show();
            this.Hide();
        }

        string enderecoFoto;

        private void btnCarregar_Click(object sender, EventArgs e)
        {
            ////pcbFoto.Image = Image.FromFile("");

            //ofdCarregar.ShowDialog();
            //string path = ofdCarregar.FileName;
            //pcbFoto.Image = Image.FromFile(path);

            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "JPG Files(*.jpg)|*jpg|PNG Files(*.png)|*png|AllFiles(*.*)|*.*";

            if (dialog.ShowDialog().Equals(DialogResult.OK))
            {
                string foto = dialog.FileName.ToString();
                enderecoFoto = foto;
                pcbFoto.ImageLocation = foto;
                txtNome.Focus();
            }
        }

        public byte[] salvarFotos()
        {
            byte[] imagem_byte = null;

            FileStream fs = new FileStream(enderecoFoto, FileMode.Open, FileAccess.Read);

            BinaryReader br = new BinaryReader(fs);

            imagem_byte = br.ReadBytes((int)fs.Length);


            return imagem_byte;

        }
    }

}
