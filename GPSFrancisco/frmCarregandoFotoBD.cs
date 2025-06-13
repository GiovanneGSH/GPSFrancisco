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
using System.IO;

namespace GPSFrancisco
{
    public partial class frmCarregandoFotoBD : Form
    {
        public frmCarregandoFotoBD()
        {
            InitializeComponent();
        }

        private void btnInserirFotos_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "JPG Files(*.jpg)|*jpg|PNG Files(*.png)|*png|AllFiles(*.*)|*.*";

            if (dialog.ShowDialog().Equals(DialogResult.OK))
            {
                string foto = dialog.FileName.ToString();
                txtBuscaFotos.Text = foto;
                pctFotos.ImageLocation = foto;
            }
        }

        private void btnSalvarFotos_Click(object sender, EventArgs e)
        {

            if (!pctFotos.Equals(null))
            {
                
                byte [] imagem_byte = null;

                FileStream fs = new FileStream (this.txtBuscaFotos.Text, FileMode.Open, FileAccess.Read);

                BinaryReader br = new BinaryReader (fs);

                imagem_byte = br.ReadBytes((int)fs.Length);


                MySqlCommand comm = new MySqlCommand();
                comm.CommandText = "insert into tbfotos(nome,campo_imagem)values(@nome,@campo_imagem);";
                comm.CommandType = CommandType.Text;

                comm.Parameters.Clear();

                comm.Parameters.Add("@campo_imagem", MySqlDbType.LongBlob).Value = imagem_byte;
                comm.Parameters.Add("@nome", MySqlDbType.VarChar, 100).Value = txtNome.Text;


                comm.Connection = Conexao.obterConexao();

               
                int resp = comm.ExecuteNonQuery();

                MessageBox.Show("Foto salva no banco de dados!" + resp);
                

                Conexao.fecharConexao();

            }
            else
            {
                MessageBox.Show("Favor inserir um texto ou uma imagem", "Mensagem do sistema", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1);
            }



        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
