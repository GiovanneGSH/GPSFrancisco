namespace GPSFrancisco
{
    partial class frmPesquisarUnidadesMedida
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPesquisarUnidadesMedida));
            this.gpbPesquisarUnidade = new System.Windows.Forms.GroupBox();
            this.lblDescricaoUnidade = new System.Windows.Forms.Label();
            this.rdbCodigoUnidade = new System.Windows.Forms.RadioButton();
            this.rdbNomeUnidade = new System.Windows.Forms.RadioButton();
            this.txtDescricaoUnidade = new System.Windows.Forms.TextBox();
            this.btnPesquisarUnidade = new System.Windows.Forms.Button();
            this.btnLimparUnidade = new System.Windows.Forms.Button();
            this.ltbPesquisarUnidade = new System.Windows.Forms.ListBox();
            this.gpbPesquisarUnidade.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbPesquisarUnidade
            // 
            this.gpbPesquisarUnidade.Controls.Add(this.lblDescricaoUnidade);
            this.gpbPesquisarUnidade.Controls.Add(this.rdbCodigoUnidade);
            this.gpbPesquisarUnidade.Controls.Add(this.rdbNomeUnidade);
            this.gpbPesquisarUnidade.Controls.Add(this.txtDescricaoUnidade);
            this.gpbPesquisarUnidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbPesquisarUnidade.Location = new System.Drawing.Point(12, 10);
            this.gpbPesquisarUnidade.Name = "gpbPesquisarUnidade";
            this.gpbPesquisarUnidade.Size = new System.Drawing.Size(481, 100);
            this.gpbPesquisarUnidade.TabIndex = 11;
            this.gpbPesquisarUnidade.TabStop = false;
            this.gpbPesquisarUnidade.Text = "Pesquisar por";
            // 
            // lblDescricaoUnidade
            // 
            this.lblDescricaoUnidade.AutoSize = true;
            this.lblDescricaoUnidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricaoUnidade.Location = new System.Drawing.Point(6, 58);
            this.lblDescricaoUnidade.Name = "lblDescricaoUnidade";
            this.lblDescricaoUnidade.Size = new System.Drawing.Size(80, 20);
            this.lblDescricaoUnidade.TabIndex = 6;
            this.lblDescricaoUnidade.Text = "Descrição";
            // 
            // rdbCodigoUnidade
            // 
            this.rdbCodigoUnidade.AutoSize = true;
            this.rdbCodigoUnidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbCodigoUnidade.Location = new System.Drawing.Point(104, 25);
            this.rdbCodigoUnidade.Name = "rdbCodigoUnidade";
            this.rdbCodigoUnidade.Size = new System.Drawing.Size(77, 24);
            this.rdbCodigoUnidade.TabIndex = 1;
            this.rdbCodigoUnidade.Text = "Código";
            this.rdbCodigoUnidade.UseVisualStyleBackColor = true;
            // 
            // rdbNomeUnidade
            // 
            this.rdbNomeUnidade.AutoSize = true;
            this.rdbNomeUnidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbNomeUnidade.Location = new System.Drawing.Point(187, 25);
            this.rdbNomeUnidade.Name = "rdbNomeUnidade";
            this.rdbNomeUnidade.Size = new System.Drawing.Size(69, 24);
            this.rdbNomeUnidade.TabIndex = 2;
            this.rdbNomeUnidade.Text = "Nome";
            this.rdbNomeUnidade.UseVisualStyleBackColor = true;
            // 
            // txtDescricaoUnidade
            // 
            this.txtDescricaoUnidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricaoUnidade.Location = new System.Drawing.Point(92, 55);
            this.txtDescricaoUnidade.MaxLength = 50;
            this.txtDescricaoUnidade.Name = "txtDescricaoUnidade";
            this.txtDescricaoUnidade.Size = new System.Drawing.Size(288, 26);
            this.txtDescricaoUnidade.TabIndex = 3;
            // 
            // btnPesquisarUnidade
            // 
            this.btnPesquisarUnidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisarUnidade.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisarUnidade.Image")));
            this.btnPesquisarUnidade.Location = new System.Drawing.Point(499, 10);
            this.btnPesquisarUnidade.Name = "btnPesquisarUnidade";
            this.btnPesquisarUnidade.Size = new System.Drawing.Size(123, 100);
            this.btnPesquisarUnidade.TabIndex = 13;
            this.btnPesquisarUnidade.Text = "Pesquisar";
            this.btnPesquisarUnidade.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPesquisarUnidade.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPesquisarUnidade.UseVisualStyleBackColor = true;
            this.btnPesquisarUnidade.Click += new System.EventHandler(this.btnPesquisarUnidade_Click);
            // 
            // btnLimparUnidade
            // 
            this.btnLimparUnidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimparUnidade.Image = ((System.Drawing.Image)(resources.GetObject("btnLimparUnidade.Image")));
            this.btnLimparUnidade.Location = new System.Drawing.Point(499, 116);
            this.btnLimparUnidade.Name = "btnLimparUnidade";
            this.btnLimparUnidade.Size = new System.Drawing.Size(123, 104);
            this.btnLimparUnidade.TabIndex = 14;
            this.btnLimparUnidade.Text = "Limpar";
            this.btnLimparUnidade.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLimparUnidade.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnLimparUnidade.UseVisualStyleBackColor = true;
            // 
            // ltbPesquisarUnidade
            // 
            this.ltbPesquisarUnidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltbPesquisarUnidade.FormattingEnabled = true;
            this.ltbPesquisarUnidade.ItemHeight = 20;
            this.ltbPesquisarUnidade.Location = new System.Drawing.Point(12, 116);
            this.ltbPesquisarUnidade.Name = "ltbPesquisarUnidade";
            this.ltbPesquisarUnidade.Size = new System.Drawing.Size(481, 104);
            this.ltbPesquisarUnidade.TabIndex = 12;
            this.ltbPesquisarUnidade.SelectedIndexChanged += new System.EventHandler(this.ltbPesquisarUnidade_SelectedIndexChanged);
            // 
            // frmPesquisarUnidadesMedida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 231);
            this.Controls.Add(this.gpbPesquisarUnidade);
            this.Controls.Add(this.btnPesquisarUnidade);
            this.Controls.Add(this.btnLimparUnidade);
            this.Controls.Add(this.ltbPesquisarUnidade);
            this.Name = "frmPesquisarUnidadesMedida";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PesquisarUnidadesMedida";
            this.gpbPesquisarUnidade.ResumeLayout(false);
            this.gpbPesquisarUnidade.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbPesquisarUnidade;
        private System.Windows.Forms.Label lblDescricaoUnidade;
        private System.Windows.Forms.RadioButton rdbCodigoUnidade;
        private System.Windows.Forms.RadioButton rdbNomeUnidade;
        private System.Windows.Forms.TextBox txtDescricaoUnidade;
        private System.Windows.Forms.Button btnPesquisarUnidade;
        private System.Windows.Forms.Button btnLimparUnidade;
        private System.Windows.Forms.ListBox ltbPesquisarUnidade;
    }
}