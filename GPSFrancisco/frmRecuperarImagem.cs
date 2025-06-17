using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MySql.Data.MySqlClient;


namespace GPSFrancisco
{
    public partial class frmRecuperarImagem : Form
    {
        public frmRecuperarImagem()
        {
            InitializeComponent();
            carregaImagens();
        }

        public void carregaImagens()
        {
            MySqlCommand comm = new MySqlCommand();
            string sql = "select * from tbfotos;";
            MySqlDataAdapter DA = new MySqlDataAdapter(sql, Conexao.obterConexao());
            DataTable dt = new DataTable();
            if (DA.Fill(dt) < 1)
            {
                MessageBox.Show("Sem registros no banco de dados");
            }
            else
            {
                foreach (DataRow dr in dt.Rows)
                {

                    dgvListaImagens.Rows.Add(dr.ItemArray);

                }
                DA.Dispose();

            }
            Conexao.fecharConexao();
                

        }

        private void dgvListaImagens_SelectionChanged(object sender, EventArgs e)
        {
            string nome = dgvListaImagens.SelectedRows[0].Cells[0].Value.ToString();

            MySqlCommand comm = new MySqlCommand();
            string sql = $"select * from tbfotos where codfotos like {nome};";
            MySqlDataAdapter DA = new MySqlDataAdapter(sql, Conexao.obterConexao());
            DataTable dt = new DataTable(); 
            DA.Fill(dt);
            byte[] image = (byte[])dt.Rows[0][2];
            
            MemoryStream ms = new MemoryStream(image); //importar System.IO

            pctFotos.Image = Image.FromStream(ms);

            Conexao.fecharConexao();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmCarregandoFotoBD abrir = new frmCarregandoFotoBD();
            abrir.Show();
            this.Hide();
        }
    }
}
