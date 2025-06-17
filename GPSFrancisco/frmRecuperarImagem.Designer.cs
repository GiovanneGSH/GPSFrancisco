namespace GPSFrancisco
{
    partial class frmRecuperarImagem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRecuperarImagem));
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.dgvListaImagens = new System.Windows.Forms.DataGridView();
            this.pctFotos = new System.Windows.Forms.PictureBox();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaImagens)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctFotos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(269, 386);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(85, 39);
            this.btnVoltar.TabIndex = 0;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(269, 341);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(85, 39);
            this.btnSalvar.TabIndex = 1;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Location = new System.Drawing.Point(269, 296);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(85, 39);
            this.btnExcluir.TabIndex = 2;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // dgvListaImagens
            // 
            this.dgvListaImagens.AllowUserToAddRows = false;
            this.dgvListaImagens.AllowUserToDeleteRows = false;
            this.dgvListaImagens.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListaImagens.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvListaImagens.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvListaImagens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaImagens.ColumnHeadersVisible = false;
            this.dgvListaImagens.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nome,
            this.codigo});
            this.dgvListaImagens.Location = new System.Drawing.Point(12, 288);
            this.dgvListaImagens.Margin = new System.Windows.Forms.Padding(2);
            this.dgvListaImagens.MultiSelect = false;
            this.dgvListaImagens.Name = "dgvListaImagens";
            this.dgvListaImagens.ReadOnly = true;
            this.dgvListaImagens.RowHeadersVisible = false;
            this.dgvListaImagens.RowHeadersWidth = 62;
            this.dgvListaImagens.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListaImagens.Size = new System.Drawing.Size(242, 150);
            this.dgvListaImagens.TabIndex = 5;
            this.dgvListaImagens.SelectionChanged += new System.EventHandler(this.dgvListaImagens_SelectionChanged);
            // 
            // pctFotos
            // 
            this.pctFotos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pctFotos.Location = new System.Drawing.Point(12, 12);
            this.pctFotos.Name = "pctFotos";
            this.pctFotos.Size = new System.Drawing.Size(338, 271);
            this.pctFotos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctFotos.TabIndex = 6;
            this.pctFotos.TabStop = false;
            // 
            // nome
            // 
            this.nome.HeaderText = "Nome";
            this.nome.MinimumWidth = 8;
            this.nome.Name = "nome";
            this.nome.ReadOnly = true;
            // 
            // codigo
            // 
            this.codigo.HeaderText = "Codigo";
            this.codigo.MinimumWidth = 8;
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            this.codigo.Visible = false;
            // 
            // frmRecuperarImagem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 450);
            this.Controls.Add(this.pctFotos);
            this.Controls.Add(this.dgvListaImagens);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnVoltar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmRecuperarImagem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recuperar Imagem";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaImagens)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctFotos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.DataGridView dgvListaImagens;
        private System.Windows.Forms.PictureBox pctFotos;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
    }
}