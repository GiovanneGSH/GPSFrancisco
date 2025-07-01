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
using GenCode128;
using QRCoder;
using System.IO;

namespace GPSFrancisco
{
    public partial class frmGerenciarProdutos : Form
    {
        public frmGerenciarProdutos()
        {
            InitializeComponent();
            buscarUnidadesMedida();
            desabilitarCampos();
        }

        public frmGerenciarProdutos(string descricao)
        {
            InitializeComponent();
            buscarUnidadesMedida();
            desabilitarCampos();
            txtDescricao.Text = descricao;
            carregaProdutosPorDescricao(txtDescricao.Text);
        }

        public void desabilitarCampos()
        {
            txtCodigo.Enabled = false;
            txtDescricao.Enabled = false;
            txtLote.Enabled = false;
            txtQuantidade.Enabled = false;

            pcbCodigoDeBarras.Image = null;
            pcbFoto.Image = null;

            cbbUnidade.Enabled = false;

            dtpDataEntrada.Enabled = false;
            dtpValidade.Enabled = false;
            dtpHora.Enabled = false;

            btnNovo.Enabled = true;
            btnInserir.Enabled = false;
            btnExcluir.Enabled = false;
            btnCadastrar.Enabled = false;
            btnAlterar.Enabled = false;
            btnLimpar.Enabled = false;
        }

        public void habilitarCamposAlterar()
        {
            txtCodigo.Enabled = true;
            txtDescricao.Enabled = true;
            txtLote.Enabled = true;
            txtQuantidade.Enabled = true;

            //pctCodigoBarras.Image = null;
            //pcbFotoProduto.Image = null;

            cbbUnidade.Enabled = true;

            dtpDataEntrada.Enabled = true;
            dtpValidade.Enabled = true;
            dtpHora.Enabled = true;

            btnAlterar.Enabled = true;
            btnExcluir.Enabled = true;
            btnNovo.Enabled = false;
            btnInserir.Enabled = true;

            btnCadastrar.Enabled = false;

            txtCodigo.Focus();

            btnInserir.Text = "Alterar";

        }

        public void habilitarCampos()
        {
            txtCodigo.Enabled = true;
            txtDescricao.Enabled = true;
            txtLote.Enabled = true;
            txtQuantidade.Enabled = true;

           pcbCodigoDeBarras.Image = null;
           pcbFoto.Image = null;

            cbbUnidade.Enabled = true;

            dtpDataEntrada.Enabled = true;
            dtpValidade.Enabled = true;
            dtpHora.Enabled = true;

            btnAlterar.Enabled = false;
            btnExcluir.Enabled = false;
            btnNovo.Enabled = false;
            btnInserir.Enabled = true;

            btnCadastrar.Enabled = true;

            txtCodigo.Focus();

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal abrir = new frmMenuPrincipal();
            abrir.Show();
            this.Hide();
        }

        private void frmGerenciarProdutos_Load(object sender, EventArgs e)
        {

        }

        //buscar unidades

        public void buscarUnidadesMedida()
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "SELECT * FROM tbUnidades ORDER BY unidade;";
            comm.CommandType = CommandType.Text;            

            comm.Connection = Conexao.obterConexao();

            MySqlDataReader DR;

            DR = comm.ExecuteReader();

            while (DR.Read()) 
            {
                cbbUnidade.Items.Add(DR.GetString(2));
            }


            Conexao.fecharConexao();            
        }

        public void carregaProdutosPorDescricao(string descricao)
        {

            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "SELECT codBarras, prod.descricao, quantidade, lote, dataEntr, horaEntr, validade, fotoProd, unidade from tbProdutos as prod INNER JOIN tbUnidades as uni on prod.codUnid = uni.codUnid WHERE prod.descricao = @prod.descricao;";
            comm.CommandType = CommandType.Text;
            comm.Parameters.Clear();
            comm.Parameters.Add("@prod.descricao", MySqlDbType.VarChar, 100).Value = descricao;


            comm.Connection = Conexao.obterConexao();

            MySqlDataReader DR;
            DR = comm.ExecuteReader();
            DR.Read();

            txtCodigo.Text = DR.GetString(0);
            txtDescricao.Text = DR.GetString(1);
            txtQuantidade.Text = Convert.ToString(DR.GetInt32(2));
            txtLote.Text = DR.GetString(3);
            dtpDataEntrada.Value = DR.GetDateTime(4);
            dtpHora.Value = DR.GetDateTime(5);
            dtpValidade.Value = DR.GetDateTime(6);

            byte[] imageData = (byte[])DR.GetValue(7);
            MemoryStream ms = new MemoryStream(imageData);
            pcbFoto.Image = Image.FromStream(ms);

            cbbUnidade.Text = DR.GetString(8);

            Conexao.fecharConexao();

            habilitarCamposAlterar();

        }

        private void btnUnidade_Click(object sender, EventArgs e)
        {
            frmUnidades abrir = new frmUnidades();
            abrir.Show();
            this.Hide();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            frmPesquisarProdutos abrir = new frmPesquisarProdutos();
            abrir.Show();
            this.Hide();
        }

        private void txtCodigo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter))
            {
                Image imgCodigoBarras =
                    Code128Rendering.
                    MakeBarcodeImage
                    (txtCodigo.Text, 2, true);
                pcbCodigoDeBarras.Image = imgCodigoBarras;
            }
        }
        
        int codigoUnidade;

        public int cadastrarProdutos(string codBarra, string descricao,
            int quantidade, string lote,
            int codigoUnidade, DateTime dataEntrada,
            DateTime horaEntrada, DateTime validade, byte[] fotoProd)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "INSERT INTO tbProdutos(codBarras,descricao,quantidade,lote,dataEntr,horaEntr,validade,codUnid,fotoProd)VALUES(@codBarras,@descricao,@quantidade,@lote,@dataEntr,@horaEntr,@validade,@codUnid,@fotoProd);";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();

            comm.Parameters.Add("@codBarras", MySqlDbType.VarChar, 255).Value = codBarra;
            comm.Parameters.Add("@descricao", MySqlDbType.VarChar, 100).Value = descricao;
            comm.Parameters.Add("@quantidade", MySqlDbType.Int32).Value = quantidade;
            comm.Parameters.Add("@lote", MySqlDbType.VarChar, 10).Value = lote;
            comm.Parameters.Add("@dataEntr", MySqlDbType.DateTime).Value = dataEntrada;
            comm.Parameters.Add("@horaEntr", MySqlDbType.DateTime).Value = horaEntrada;
            comm.Parameters.Add("@validade", MySqlDbType.DateTime).Value = validade;
            comm.Parameters.Add("@codUnid", MySqlDbType.Int32).Value = codigoUnidade;
            comm.Parameters.Add("@fotoProd", MySqlDbType.LongBlob).Value = fotoProd;


            comm.Connection = Conexao.obterConexao();

            int resp = comm.ExecuteNonQuery();

            return resp;
        }

        //alterar produtos
        public int alterarProdutos(int codBarra, string descricao,
            int quantidade, string lote,
            int codigoUnidade, DateTime dataEntrada,
            DateTime horaEntrada, DateTime validade)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "UPDATE tbProdutos SET codBarras = @codBarras,descricao=@descricao,quantidade=@quantidade,lote=@lote,dataEntr=@dataEntr,horaEntr=@horaEntr,validade=@validade,codUnid=@codUnid WHERE codBarras = @codBarras;";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();

            comm.Parameters.Add("@codBarras", MySqlDbType.Int32).Value = codBarra;
            comm.Parameters.Add("@descricao", MySqlDbType.VarChar, 100).Value = descricao;
            comm.Parameters.Add("@quantidade", MySqlDbType.Int32).Value = quantidade;
            comm.Parameters.Add("@lote", MySqlDbType.VarChar, 10).Value = lote;
            comm.Parameters.Add("@dataEntr", MySqlDbType.DateTime).Value = dataEntrada;
            comm.Parameters.Add("@horaEntr", MySqlDbType.DateTime).Value = horaEntrada;
            comm.Parameters.Add("@validade", MySqlDbType.DateTime).Value = validade;
            comm.Parameters.Add("@codUnid", MySqlDbType.Int32).Value = codigoUnidade;

            comm.Connection = Conexao.obterConexao();

            int resp = comm.ExecuteNonQuery();

            return resp;
        }

        public int excluirProdutos(int codBarra)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "DELETE FROM tbProdutos where codBarra = @codBarra;";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();

            comm.Parameters.Add("@codBarras", MySqlDbType.Int32).Value = codBarra;

            comm.Connection = Conexao.obterConexao();

            int resp = comm.ExecuteNonQuery();

            return resp;
        }

        string enderecoFoto;

        private void btnInserir_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "JPG Files(*.jpg)|*.jpg|" +
                "PNG Files(*.png)|*.png|AllFiles(*.*) | *.*";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string foto = dialog.FileName.ToString();
                enderecoFoto = foto;
                pcbFoto.ImageLocation = foto;

            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (cadastrarProdutos(txtCodigo.Text, txtDescricao.Text, Convert.ToInt32(txtQuantidade.Text), txtLote.Text, codigoUnidade, dtpDataEntrada.Value, dtpHora.Value, dtpValidade.Value, salvarFotos()).Equals(1))
            {
                MessageBox.Show("Cadastrado com sucesso.",
                    "Messagem do sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1);
                limparCamposAlterar();
                desabilitarCampos();

            }
            else
            {
                MessageBox.Show("Erro ao cadastrar.",
                    "Messagem do sistema",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1);
            }
        }

        public byte[] salvarFotos()
        {
            byte[] imagem_byte = null;

            FileStream fs = new FileStream(enderecoFoto,
                FileMode.Open, FileAccess.Read);

            BinaryReader br = new BinaryReader(fs);

            imagem_byte = br.ReadBytes((int)fs.Length);

            return imagem_byte;
        }

        private void cbbUnidade_SelectedIndexChanged(object sender, EventArgs e)
        {
            codigoUnidade = buscaCodigoUnidades(cbbUnidade.SelectedItem.ToString());
        }

        //buscando código da atribuição carregada na combo
        public int buscaCodigoUnidades(string unidade)
        {
            MySqlCommand comm = new MySqlCommand();
            comm.CommandText = "SELECT codUnid FROM tbunidades WHERE unidade = @unidade;";
            comm.CommandType = CommandType.Text;

            comm.Parameters.Clear();
            comm.Parameters.Add("@unidade", MySqlDbType.VarChar, 100).Value = unidade;

            comm.Connection = Conexao.obterConexao();
            MySqlDataReader DR;
            DR = comm.ExecuteReader();
            DR.Read();
            int codUnidade = DR.GetInt32(0);
            Conexao.fecharConexao();

            return codUnidade;
        }

        public void limparCamposAlterar()
        {
            txtCodigo.Clear();
            txtDescricao.Clear();
            txtLote.Clear();
            txtQuantidade.Clear();

            pcbCodigoDeBarras.Image = null;
            pcbFoto.Image = null;

            cbbUnidade.Text = "";

            dtpDataEntrada.Value = DateTime.Now;
            dtpValidade.Value = DateTime.Now;
            dtpHora.Value = DateTime.Now;

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            habilitarCampos();
        }

        public void limparCamposGeral()
        {
            txtCodigo.Clear();
            txtDescricao.Clear();
            txtLote.Clear();
            txtQuantidade.Clear();

            pcbCodigoDeBarras.Image = null;
            pcbFoto.Image = null;

            cbbUnidade.Text = "";

            dtpDataEntrada.Value = DateTime.Now;
            dtpValidade.Value = DateTime.Now;
            dtpHora.Value = DateTime.Now;

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparCamposGeral();
            desabilitarCampos();
        }
    }
}
