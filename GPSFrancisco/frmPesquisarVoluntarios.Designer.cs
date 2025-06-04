namespace GPSFrancisco
{
    partial class frmPesquisarVoluntarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPesquisarVoluntarios));
            this.gpbPesquisarVoluntario = new System.Windows.Forms.GroupBox();
            this.lblNomeVoluntario = new System.Windows.Forms.Label();
            this.rdbCodigoVoluntario = new System.Windows.Forms.RadioButton();
            this.rdbNomeVoluntario = new System.Windows.Forms.RadioButton();
            this.txtNomeVoluntario = new System.Windows.Forms.TextBox();
            this.btnPesquisarVoluntario = new System.Windows.Forms.Button();
            this.btnLimparNome = new System.Windows.Forms.Button();
            this.ltbPesquisarVoluntario = new System.Windows.Forms.ListBox();
            this.gpbPesquisarVoluntario.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbPesquisarVoluntario
            // 
            this.gpbPesquisarVoluntario.Controls.Add(this.lblNomeVoluntario);
            this.gpbPesquisarVoluntario.Controls.Add(this.rdbCodigoVoluntario);
            this.gpbPesquisarVoluntario.Controls.Add(this.rdbNomeVoluntario);
            this.gpbPesquisarVoluntario.Controls.Add(this.txtNomeVoluntario);
            this.gpbPesquisarVoluntario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbPesquisarVoluntario.Location = new System.Drawing.Point(12, 10);
            this.gpbPesquisarVoluntario.Name = "gpbPesquisarVoluntario";
            this.gpbPesquisarVoluntario.Size = new System.Drawing.Size(481, 100);
            this.gpbPesquisarVoluntario.TabIndex = 11;
            this.gpbPesquisarVoluntario.TabStop = false;
            this.gpbPesquisarVoluntario.Text = "Pesquisar por";
            // 
            // lblNomeVoluntario
            // 
            this.lblNomeVoluntario.AutoSize = true;
            this.lblNomeVoluntario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeVoluntario.Location = new System.Drawing.Point(6, 58);
            this.lblNomeVoluntario.Name = "lblNomeVoluntario";
            this.lblNomeVoluntario.Size = new System.Drawing.Size(80, 20);
            this.lblNomeVoluntario.TabIndex = 6;
            this.lblNomeVoluntario.Text = "Descrição";
            // 
            // rdbCodigoVoluntario
            // 
            this.rdbCodigoVoluntario.AutoSize = true;
            this.rdbCodigoVoluntario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbCodigoVoluntario.Location = new System.Drawing.Point(104, 25);
            this.rdbCodigoVoluntario.Name = "rdbCodigoVoluntario";
            this.rdbCodigoVoluntario.Size = new System.Drawing.Size(77, 24);
            this.rdbCodigoVoluntario.TabIndex = 1;
            this.rdbCodigoVoluntario.Text = "Código";
            this.rdbCodigoVoluntario.UseVisualStyleBackColor = true;
            this.rdbCodigoVoluntario.CheckedChanged += new System.EventHandler(this.rdbCodigoVoluntario_CheckedChanged);
            // 
            // rdbNomeVoluntario
            // 
            this.rdbNomeVoluntario.AutoSize = true;
            this.rdbNomeVoluntario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbNomeVoluntario.Location = new System.Drawing.Point(187, 25);
            this.rdbNomeVoluntario.Name = "rdbNomeVoluntario";
            this.rdbNomeVoluntario.Size = new System.Drawing.Size(69, 24);
            this.rdbNomeVoluntario.TabIndex = 2;
            this.rdbNomeVoluntario.Text = "Nome";
            this.rdbNomeVoluntario.UseVisualStyleBackColor = true;
            this.rdbNomeVoluntario.CheckedChanged += new System.EventHandler(this.rdbNomeVoluntario_CheckedChanged);
            // 
            // txtNomeVoluntario
            // 
            this.txtNomeVoluntario.Enabled = false;
            this.txtNomeVoluntario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeVoluntario.Location = new System.Drawing.Point(92, 55);
            this.txtNomeVoluntario.MaxLength = 50;
            this.txtNomeVoluntario.Name = "txtNomeVoluntario";
            this.txtNomeVoluntario.Size = new System.Drawing.Size(288, 26);
            this.txtNomeVoluntario.TabIndex = 3;
            // 
            // btnPesquisarVoluntario
            // 
            this.btnPesquisarVoluntario.Enabled = false;
            this.btnPesquisarVoluntario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisarVoluntario.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisarVoluntario.Image")));
            this.btnPesquisarVoluntario.Location = new System.Drawing.Point(499, 10);
            this.btnPesquisarVoluntario.Name = "btnPesquisarVoluntario";
            this.btnPesquisarVoluntario.Size = new System.Drawing.Size(123, 100);
            this.btnPesquisarVoluntario.TabIndex = 13;
            this.btnPesquisarVoluntario.Text = "Pesquisar";
            this.btnPesquisarVoluntario.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPesquisarVoluntario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPesquisarVoluntario.UseVisualStyleBackColor = true;
            this.btnPesquisarVoluntario.Click += new System.EventHandler(this.btnPesquisarVoluntario_Click);
            // 
            // btnLimparNome
            // 
            this.btnLimparNome.Enabled = false;
            this.btnLimparNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimparNome.Image = ((System.Drawing.Image)(resources.GetObject("btnLimparNome.Image")));
            this.btnLimparNome.Location = new System.Drawing.Point(499, 116);
            this.btnLimparNome.Name = "btnLimparNome";
            this.btnLimparNome.Size = new System.Drawing.Size(123, 104);
            this.btnLimparNome.TabIndex = 14;
            this.btnLimparNome.Text = "Limpar";
            this.btnLimparNome.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLimparNome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnLimparNome.UseVisualStyleBackColor = true;
            this.btnLimparNome.Click += new System.EventHandler(this.btnLimparNome_Click);
            // 
            // ltbPesquisarVoluntario
            // 
            this.ltbPesquisarVoluntario.Enabled = false;
            this.ltbPesquisarVoluntario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltbPesquisarVoluntario.FormattingEnabled = true;
            this.ltbPesquisarVoluntario.ItemHeight = 20;
            this.ltbPesquisarVoluntario.Location = new System.Drawing.Point(12, 116);
            this.ltbPesquisarVoluntario.Name = "ltbPesquisarVoluntario";
            this.ltbPesquisarVoluntario.Size = new System.Drawing.Size(481, 104);
            this.ltbPesquisarVoluntario.TabIndex = 12;
            this.ltbPesquisarVoluntario.SelectedIndexChanged += new System.EventHandler(this.ltbPesquisarVoluntario_SelectedIndexChanged);
            // 
            // frmPesquisarVoluntarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 231);
            this.Controls.Add(this.gpbPesquisarVoluntario);
            this.Controls.Add(this.btnPesquisarVoluntario);
            this.Controls.Add(this.btnLimparNome);
            this.Controls.Add(this.ltbPesquisarVoluntario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmPesquisarVoluntarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GPSFrancisco - Pesquisar Voluntários";
            this.gpbPesquisarVoluntario.ResumeLayout(false);
            this.gpbPesquisarVoluntario.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbPesquisarVoluntario;
        private System.Windows.Forms.Label lblNomeVoluntario;
        private System.Windows.Forms.RadioButton rdbCodigoVoluntario;
        private System.Windows.Forms.RadioButton rdbNomeVoluntario;
        private System.Windows.Forms.TextBox txtNomeVoluntario;
        private System.Windows.Forms.Button btnPesquisarVoluntario;
        private System.Windows.Forms.Button btnLimparNome;
        private System.Windows.Forms.ListBox ltbPesquisarVoluntario;
    }
}