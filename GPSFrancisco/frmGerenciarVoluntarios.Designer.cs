namespace GPSFrancisco
{
    partial class frmGerenciarVoluntarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGerenciarVoluntarios));
            this.pnlCrud = new System.Windows.Forms.Panel();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.gpbInformacoesUsuarios = new System.Windows.Forms.GroupBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.lblBairro = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.lblCidade = new System.Windows.Forms.Label();
            this.lblCep = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.cbbEstado = new System.Windows.Forms.ComboBox();
            this.mskTelefone = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.gpbInformacoesDoDirigente = new System.Windows.Forms.GroupBox();
            this.lblAtribuições = new System.Windows.Forms.Label();
            this.cbbAtribuições = new System.Windows.Forms.ComboBox();
            this.lblData = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.dtpHora = new System.Windows.Forms.DateTimePicker();
            this.ckbStatus = new System.Windows.Forms.CheckBox();
            this.pcbFoto = new System.Windows.Forms.PictureBox();
            this.pnlCrud.SuspendLayout();
            this.gpbInformacoesUsuarios.SuspendLayout();
            this.gpbInformacoesDoDirigente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlCrud
            // 
            this.pnlCrud.Controls.Add(this.btnVoltar);
            this.pnlCrud.Controls.Add(this.btnExcluir);
            this.pnlCrud.Controls.Add(this.btnLimpar);
            this.pnlCrud.Controls.Add(this.btnAlterar);
            this.pnlCrud.Controls.Add(this.btnCadastrar);
            this.pnlCrud.Controls.Add(this.btnPesquisar);
            this.pnlCrud.Controls.Add(this.btnNovo);
            this.pnlCrud.Location = new System.Drawing.Point(7, 378);
            this.pnlCrud.Name = "pnlCrud";
            this.pnlCrud.Size = new System.Drawing.Size(730, 206);
            this.pnlCrud.TabIndex = 6;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Image = ((System.Drawing.Image)(resources.GetObject("btnVoltar.Image")));
            this.btnVoltar.Location = new System.Drawing.Point(602, 155);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(125, 48);
            this.btnVoltar.TabIndex = 20;
            this.btnVoltar.Text = "&Voltar";
            this.btnVoltar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
            this.btnExcluir.Location = new System.Drawing.Point(541, 26);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(125, 48);
            this.btnExcluir.TabIndex = 17;
            this.btnExcluir.Text = "&Excluir";
            this.btnExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpar.Image")));
            this.btnLimpar.Location = new System.Drawing.Point(391, 102);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(125, 48);
            this.btnLimpar.TabIndex = 19;
            this.btnLimpar.Text = "&Limpar";
            this.btnLimpar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLimpar.UseVisualStyleBackColor = true;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.Image = ((System.Drawing.Image)(resources.GetObject("btnAlterar.Image")));
            this.btnAlterar.Location = new System.Drawing.Point(391, 26);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(125, 48);
            this.btnAlterar.TabIndex = 16;
            this.btnAlterar.Text = "&Alterar";
            this.btnAlterar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAlterar.UseVisualStyleBackColor = true;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastrar.Image")));
            this.btnCadastrar.Location = new System.Drawing.Point(241, 26);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(125, 48);
            this.btnCadastrar.TabIndex = 15;
            this.btnCadastrar.Text = "&Cadastrar";
            this.btnCadastrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCadastrar.UseVisualStyleBackColor = true;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisar.Image")));
            this.btnPesquisar.Location = new System.Drawing.Point(241, 102);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(125, 48);
            this.btnPesquisar.TabIndex = 18;
            this.btnPesquisar.Text = "&Pesquisar";
            this.btnPesquisar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // btnNovo
            // 
            this.btnNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.Image = ((System.Drawing.Image)(resources.GetObject("btnNovo.Image")));
            this.btnNovo.Location = new System.Drawing.Point(91, 26);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(125, 48);
            this.btnNovo.TabIndex = 14;
            this.btnNovo.Text = "&Novo";
            this.btnNovo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNovo.UseVisualStyleBackColor = true;
            // 
            // gpbInformacoesUsuarios
            // 
            this.gpbInformacoesUsuarios.Controls.Add(this.pcbFoto);
            this.gpbInformacoesUsuarios.Controls.Add(this.maskedTextBox1);
            this.gpbInformacoesUsuarios.Controls.Add(this.mskTelefone);
            this.gpbInformacoesUsuarios.Controls.Add(this.lblEstado);
            this.gpbInformacoesUsuarios.Controls.Add(this.cbbEstado);
            this.gpbInformacoesUsuarios.Controls.Add(this.txtNumero);
            this.gpbInformacoesUsuarios.Controls.Add(this.lblNumero);
            this.gpbInformacoesUsuarios.Controls.Add(this.lblCep);
            this.gpbInformacoesUsuarios.Controls.Add(this.txtCidade);
            this.gpbInformacoesUsuarios.Controls.Add(this.lblCidade);
            this.gpbInformacoesUsuarios.Controls.Add(this.txtBairro);
            this.gpbInformacoesUsuarios.Controls.Add(this.lblBairro);
            this.gpbInformacoesUsuarios.Controls.Add(this.lblEndereco);
            this.gpbInformacoesUsuarios.Controls.Add(this.txtNome);
            this.gpbInformacoesUsuarios.Controls.Add(this.lblNome);
            this.gpbInformacoesUsuarios.Controls.Add(this.txtEmail);
            this.gpbInformacoesUsuarios.Controls.Add(this.lblEmail);
            this.gpbInformacoesUsuarios.Controls.Add(this.txtEndereco);
            this.gpbInformacoesUsuarios.Controls.Add(this.lblTelefone);
            this.gpbInformacoesUsuarios.Controls.Add(this.txtCodigo);
            this.gpbInformacoesUsuarios.Controls.Add(this.lblCodigo);
            this.gpbInformacoesUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbInformacoesUsuarios.Location = new System.Drawing.Point(7, 12);
            this.gpbInformacoesUsuarios.Name = "gpbInformacoesUsuarios";
            this.gpbInformacoesUsuarios.Size = new System.Drawing.Size(730, 257);
            this.gpbInformacoesUsuarios.TabIndex = 7;
            this.gpbInformacoesUsuarios.TabStop = false;
            this.gpbInformacoesUsuarios.Text = "Informações do Voluntário";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtNome.Location = new System.Drawing.Point(20, 109);
            this.txtNome.MaxLength = 12;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(213, 26);
            this.txtNome.TabIndex = 1;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(16, 86);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(51, 20);
            this.lblNome.TabIndex = 6;
            this.lblNome.Text = "Nome";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtEmail.Location = new System.Drawing.Point(267, 109);
            this.txtEmail.MaxLength = 12;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(150, 26);
            this.txtEmail.TabIndex = 2;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(263, 86);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(53, 20);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "E-mail";
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(20, 163);
            this.txtEndereco.MaxLength = 50;
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(296, 26);
            this.txtEndereco.TabIndex = 4;
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(435, 86);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(71, 20);
            this.lblTelefone.TabIndex = 2;
            this.lblTelefone.Text = "Telefone";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(20, 54);
            this.txtCodigo.MaxLength = 5;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 26);
            this.txtCodigo.TabIndex = 0;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(16, 31);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(59, 20);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código";
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Location = new System.Drawing.Point(16, 140);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(78, 20);
            this.lblEndereco.TabIndex = 7;
            this.lblEndereco.Text = "Endereço";
            // 
            // txtBairro
            // 
            this.txtBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtBairro.Location = new System.Drawing.Point(332, 164);
            this.txtBairro.MaxLength = 12;
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(200, 26);
            this.txtBairro.TabIndex = 5;
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Location = new System.Drawing.Point(328, 140);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(51, 20);
            this.lblBairro.TabIndex = 9;
            this.lblBairro.Text = "Bairro";
            // 
            // txtCidade
            // 
            this.txtCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtCidade.Location = new System.Drawing.Point(20, 218);
            this.txtCidade.MaxLength = 12;
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(200, 26);
            this.txtCidade.TabIndex = 8;
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Location = new System.Drawing.Point(16, 195);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(59, 20);
            this.lblCidade.TabIndex = 11;
            this.lblCidade.Text = "Cidade";
            // 
            // lblCep
            // 
            this.lblCep.AutoSize = true;
            this.lblCep.Location = new System.Drawing.Point(629, 140);
            this.lblCep.Name = "lblCep";
            this.lblCep.Size = new System.Drawing.Size(41, 20);
            this.lblCep.TabIndex = 13;
            this.lblCep.Text = "CEP";
            // 
            // txtNumero
            // 
            this.txtNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtNumero.Location = new System.Drawing.Point(546, 164);
            this.txtNumero.MaxLength = 12;
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(72, 26);
            this.txtNumero.TabIndex = 6;
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(542, 140);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(65, 20);
            this.lblNumero.TabIndex = 15;
            this.lblNumero.Text = "Número";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(242, 195);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(60, 20);
            this.lblEstado.TabIndex = 17;
            this.lblEstado.Text = "Estado";
            // 
            // cbbEstado
            // 
            this.cbbEstado.FormattingEnabled = true;
            this.cbbEstado.Location = new System.Drawing.Point(246, 216);
            this.cbbEstado.Name = "cbbEstado";
            this.cbbEstado.Size = new System.Drawing.Size(163, 28);
            this.cbbEstado.TabIndex = 9;
            // 
            // mskTelefone
            // 
            this.mskTelefone.Location = new System.Drawing.Point(439, 108);
            this.mskTelefone.Mask = "(99)9999-9999";
            this.mskTelefone.Name = "mskTelefone";
            this.mskTelefone.Size = new System.Drawing.Size(113, 26);
            this.mskTelefone.TabIndex = 3;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(633, 163);
            this.maskedTextBox1.Mask = "99999-999";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(85, 26);
            this.maskedTextBox1.TabIndex = 7;
            // 
            // gpbInformacoesDoDirigente
            // 
            this.gpbInformacoesDoDirigente.Controls.Add(this.ckbStatus);
            this.gpbInformacoesDoDirigente.Controls.Add(this.dtpHora);
            this.gpbInformacoesDoDirigente.Controls.Add(this.dtpData);
            this.gpbInformacoesDoDirigente.Controls.Add(this.lblStatus);
            this.gpbInformacoesDoDirigente.Controls.Add(this.lblHora);
            this.gpbInformacoesDoDirigente.Controls.Add(this.lblData);
            this.gpbInformacoesDoDirigente.Controls.Add(this.lblAtribuições);
            this.gpbInformacoesDoDirigente.Controls.Add(this.cbbAtribuições);
            this.gpbInformacoesDoDirigente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbInformacoesDoDirigente.Location = new System.Drawing.Point(7, 275);
            this.gpbInformacoesDoDirigente.Name = "gpbInformacoesDoDirigente";
            this.gpbInformacoesDoDirigente.Size = new System.Drawing.Size(730, 97);
            this.gpbInformacoesDoDirigente.TabIndex = 8;
            this.gpbInformacoesDoDirigente.TabStop = false;
            this.gpbInformacoesDoDirigente.Text = "Informações do Dirigente";
            // 
            // lblAtribuições
            // 
            this.lblAtribuições.AutoSize = true;
            this.lblAtribuições.Location = new System.Drawing.Point(16, 26);
            this.lblAtribuições.Name = "lblAtribuições";
            this.lblAtribuições.Size = new System.Drawing.Size(88, 20);
            this.lblAtribuições.TabIndex = 19;
            this.lblAtribuições.Text = "Atribuições";
            // 
            // cbbAtribuições
            // 
            this.cbbAtribuições.FormattingEnabled = true;
            this.cbbAtribuições.Location = new System.Drawing.Point(20, 48);
            this.cbbAtribuições.Name = "cbbAtribuições";
            this.cbbAtribuições.Size = new System.Drawing.Size(346, 28);
            this.cbbAtribuições.TabIndex = 10;
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(387, 26);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(44, 20);
            this.lblData.TabIndex = 21;
            this.lblData.Text = "Data";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Location = new System.Drawing.Point(499, 26);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(44, 20);
            this.lblHora.TabIndex = 22;
            this.lblHora.Text = "Hora";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(610, 26);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(56, 20);
            this.lblStatus.TabIndex = 23;
            this.lblStatus.Text = "Status";
            // 
            // dtpData
            // 
            this.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpData.Location = new System.Drawing.Point(391, 49);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(102, 26);
            this.dtpData.TabIndex = 11;
            // 
            // dtpHora
            // 
            this.dtpHora.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHora.Location = new System.Drawing.Point(503, 49);
            this.dtpHora.Name = "dtpHora";
            this.dtpHora.Size = new System.Drawing.Size(82, 26);
            this.dtpHora.TabIndex = 12;
            // 
            // ckbStatus
            // 
            this.ckbStatus.AutoSize = true;
            this.ckbStatus.Location = new System.Drawing.Point(612, 50);
            this.ckbStatus.Name = "ckbStatus";
            this.ckbStatus.Size = new System.Drawing.Size(63, 24);
            this.ckbStatus.TabIndex = 13;
            this.ckbStatus.Text = "Ativo";
            this.ckbStatus.UseVisualStyleBackColor = true;
            // 
            // pcbFoto
            // 
            this.pcbFoto.Location = new System.Drawing.Point(586, 17);
            this.pcbFoto.Name = "pcbFoto";
            this.pcbFoto.Size = new System.Drawing.Size(132, 117);
            this.pcbFoto.TabIndex = 18;
            this.pcbFoto.TabStop = false;
            // 
            // frmGerenciarVoluntarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 592);
            this.Controls.Add(this.gpbInformacoesDoDirigente);
            this.Controls.Add(this.gpbInformacoesUsuarios);
            this.Controls.Add(this.pnlCrud);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmGerenciarVoluntarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GPSFrancisco - Gerenciar Voluntarios";
            this.Load += new System.EventHandler(this.frmGerenciarVoluntarios_Load);
            this.pnlCrud.ResumeLayout(false);
            this.gpbInformacoesUsuarios.ResumeLayout(false);
            this.gpbInformacoesUsuarios.PerformLayout();
            this.gpbInformacoesDoDirigente.ResumeLayout(false);
            this.gpbInformacoesDoDirigente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCrud;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.GroupBox gpbInformacoesUsuarios;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblCep;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.ComboBox cbbEstado;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.MaskedTextBox mskTelefone;
        private System.Windows.Forms.GroupBox gpbInformacoesDoDirigente;
        private System.Windows.Forms.CheckBox ckbStatus;
        private System.Windows.Forms.DateTimePicker dtpHora;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblAtribuições;
        private System.Windows.Forms.ComboBox cbbAtribuições;
        private System.Windows.Forms.PictureBox pcbFoto;
    }
}