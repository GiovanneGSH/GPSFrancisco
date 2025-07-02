namespace GPSFrancisco
{
    partial class frmPesquisaProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPesquisaProduto));
            this.gpbPesquisarProdutos = new System.Windows.Forms.GroupBox();
            this.lblDescricaoProduto = new System.Windows.Forms.Label();
            this.rdbCodigoProduto = new System.Windows.Forms.RadioButton();
            this.rdbNomeProduto = new System.Windows.Forms.RadioButton();
            this.txtDescricaoProduto = new System.Windows.Forms.TextBox();
            this.btnPesquisarProduto = new System.Windows.Forms.Button();
            this.btnLimparProduto = new System.Windows.Forms.Button();
            this.ltbPesquisarProduto = new System.Windows.Forms.ListBox();
            this.gpbPesquisarProdutos.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbPesquisarProdutos
            // 
            this.gpbPesquisarProdutos.Controls.Add(this.lblDescricaoProduto);
            this.gpbPesquisarProdutos.Controls.Add(this.rdbCodigoProduto);
            this.gpbPesquisarProdutos.Controls.Add(this.rdbNomeProduto);
            this.gpbPesquisarProdutos.Controls.Add(this.txtDescricaoProduto);
            this.gpbPesquisarProdutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbPesquisarProdutos.Location = new System.Drawing.Point(12, 12);
            this.gpbPesquisarProdutos.Name = "gpbPesquisarProdutos";
            this.gpbPesquisarProdutos.Size = new System.Drawing.Size(481, 100);
            this.gpbPesquisarProdutos.TabIndex = 15;
            this.gpbPesquisarProdutos.TabStop = false;
            this.gpbPesquisarProdutos.Text = "Pesquisar por";
            // 
            // lblDescricaoProduto
            // 
            this.lblDescricaoProduto.AutoSize = true;
            this.lblDescricaoProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricaoProduto.Location = new System.Drawing.Point(6, 58);
            this.lblDescricaoProduto.Name = "lblDescricaoProduto";
            this.lblDescricaoProduto.Size = new System.Drawing.Size(80, 20);
            this.lblDescricaoProduto.TabIndex = 6;
            this.lblDescricaoProduto.Text = "Descrição";
            // 
            // rdbCodigoProduto
            // 
            this.rdbCodigoProduto.AutoSize = true;
            this.rdbCodigoProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbCodigoProduto.Location = new System.Drawing.Point(104, 25);
            this.rdbCodigoProduto.Name = "rdbCodigoProduto";
            this.rdbCodigoProduto.Size = new System.Drawing.Size(77, 24);
            this.rdbCodigoProduto.TabIndex = 1;
            this.rdbCodigoProduto.Text = "Código";
            this.rdbCodigoProduto.UseVisualStyleBackColor = true;
            // 
            // rdbNomeProduto
            // 
            this.rdbNomeProduto.AutoSize = true;
            this.rdbNomeProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbNomeProduto.Location = new System.Drawing.Point(187, 25);
            this.rdbNomeProduto.Name = "rdbNomeProduto";
            this.rdbNomeProduto.Size = new System.Drawing.Size(69, 24);
            this.rdbNomeProduto.TabIndex = 2;
            this.rdbNomeProduto.Text = "Nome";
            this.rdbNomeProduto.UseVisualStyleBackColor = true;
            // 
            // txtDescricaoProduto
            // 
            this.txtDescricaoProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricaoProduto.Location = new System.Drawing.Point(92, 55);
            this.txtDescricaoProduto.MaxLength = 50;
            this.txtDescricaoProduto.Name = "txtDescricaoProduto";
            this.txtDescricaoProduto.Size = new System.Drawing.Size(288, 26);
            this.txtDescricaoProduto.TabIndex = 3;
            // 
            // btnPesquisarProduto
            // 
            this.btnPesquisarProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisarProduto.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisarProduto.Image")));
            this.btnPesquisarProduto.Location = new System.Drawing.Point(499, 12);
            this.btnPesquisarProduto.Name = "btnPesquisarProduto";
            this.btnPesquisarProduto.Size = new System.Drawing.Size(123, 100);
            this.btnPesquisarProduto.TabIndex = 17;
            this.btnPesquisarProduto.Text = "Pesquisar";
            this.btnPesquisarProduto.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPesquisarProduto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPesquisarProduto.UseVisualStyleBackColor = true;
            this.btnPesquisarProduto.Click += new System.EventHandler(this.btnPesquisarProduto_Click);
            // 
            // btnLimparProduto
            // 
            this.btnLimparProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimparProduto.Image = ((System.Drawing.Image)(resources.GetObject("btnLimparProduto.Image")));
            this.btnLimparProduto.Location = new System.Drawing.Point(499, 118);
            this.btnLimparProduto.Name = "btnLimparProduto";
            this.btnLimparProduto.Size = new System.Drawing.Size(123, 104);
            this.btnLimparProduto.TabIndex = 18;
            this.btnLimparProduto.Text = "Limpar";
            this.btnLimparProduto.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLimparProduto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnLimparProduto.UseVisualStyleBackColor = true;
            // 
            // ltbPesquisarProduto
            // 
            this.ltbPesquisarProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltbPesquisarProduto.FormattingEnabled = true;
            this.ltbPesquisarProduto.ItemHeight = 20;
            this.ltbPesquisarProduto.Location = new System.Drawing.Point(12, 118);
            this.ltbPesquisarProduto.Name = "ltbPesquisarProduto";
            this.ltbPesquisarProduto.Size = new System.Drawing.Size(481, 104);
            this.ltbPesquisarProduto.TabIndex = 16;
            this.ltbPesquisarProduto.SelectedIndexChanged += new System.EventHandler(this.ltbPesquisarProduto_SelectedIndexChanged);
            // 
            // frmPesquisaProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 231);
            this.Controls.Add(this.gpbPesquisarProdutos);
            this.Controls.Add(this.btnPesquisarProduto);
            this.Controls.Add(this.btnLimparProduto);
            this.Controls.Add(this.ltbPesquisarProduto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmPesquisaProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GPSFrancisco - Pesquisar Produtos";
            this.gpbPesquisarProdutos.ResumeLayout(false);
            this.gpbPesquisarProdutos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbPesquisarProdutos;
        private System.Windows.Forms.Label lblDescricaoProduto;
        private System.Windows.Forms.RadioButton rdbCodigoProduto;
        private System.Windows.Forms.RadioButton rdbNomeProduto;
        private System.Windows.Forms.TextBox txtDescricaoProduto;
        private System.Windows.Forms.Button btnPesquisarProduto;
        private System.Windows.Forms.Button btnLimparProduto;
        private System.Windows.Forms.ListBox ltbPesquisarProduto;
    }
}