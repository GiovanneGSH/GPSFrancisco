namespace GPSFrancisco
{
    partial class frmCarregandoFotoBD
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCarregandoFotoBD));
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtBuscaFotos = new System.Windows.Forms.TextBox();
            this.pctFotos = new System.Windows.Forms.PictureBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnInserirFotos = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnSalvarFotos = new System.Windows.Forms.Button();
            this.ofdInserirFotos = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pctFotos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(365, 18);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(51, 20);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(207, 50);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(361, 26);
            this.txtNome.TabIndex = 1;
            // 
            // txtBuscaFotos
            // 
            this.txtBuscaFotos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscaFotos.Location = new System.Drawing.Point(150, 345);
            this.txtBuscaFotos.Name = "txtBuscaFotos";
            this.txtBuscaFotos.Size = new System.Drawing.Size(490, 26);
            this.txtBuscaFotos.TabIndex = 2;
            // 
            // pctFotos
            // 
            this.pctFotos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pctFotos.Location = new System.Drawing.Point(216, 82);
            this.pctFotos.Name = "pctFotos";
            this.pctFotos.Size = new System.Drawing.Size(343, 257);
            this.pctFotos.TabIndex = 3;
            this.pctFotos.TabStop = false;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.Location = new System.Drawing.Point(522, 393);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(118, 42);
            this.btnPesquisar.TabIndex = 6;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnInserirFotos
            // 
            this.btnInserirFotos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInserirFotos.Location = new System.Drawing.Point(150, 393);
            this.btnInserirFotos.Name = "btnInserirFotos";
            this.btnInserirFotos.Size = new System.Drawing.Size(118, 42);
            this.btnInserirFotos.TabIndex = 3;
            this.btnInserirFotos.Text = "Inserir Fotos";
            this.btnInserirFotos.UseVisualStyleBackColor = true;
            this.btnInserirFotos.Click += new System.EventHandler(this.btnInserirFotos_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(398, 393);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(118, 42);
            this.btnLimpar.TabIndex = 5;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(669, 449);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(118, 42);
            this.btnSair.TabIndex = 7;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnSalvarFotos
            // 
            this.btnSalvarFotos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvarFotos.Location = new System.Drawing.Point(274, 393);
            this.btnSalvarFotos.Name = "btnSalvarFotos";
            this.btnSalvarFotos.Size = new System.Drawing.Size(118, 42);
            this.btnSalvarFotos.TabIndex = 4;
            this.btnSalvarFotos.Text = "Salvar Fotos";
            this.btnSalvarFotos.UseVisualStyleBackColor = true;
            this.btnSalvarFotos.Click += new System.EventHandler(this.btnSalvarFotos_Click);
            // 
            // ofdInserirFotos
            // 
            this.ofdInserirFotos.FileName = "openFileDialog1";
            // 
            // frmCarregandoFotoBD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 503);
            this.Controls.Add(this.btnSalvarFotos);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnInserirFotos);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.pctFotos);
            this.Controls.Add(this.txtBuscaFotos);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmCarregandoFotoBD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Carregando fotos banco de dados";
            ((System.ComponentModel.ISupportInitialize)(this.pctFotos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtBuscaFotos;
        private System.Windows.Forms.PictureBox pctFotos;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnInserirFotos;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnSalvarFotos;
        private System.Windows.Forms.OpenFileDialog ofdInserirFotos;
    }
}