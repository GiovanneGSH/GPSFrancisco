namespace GPSFrancisco
{
    partial class frmCalendario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCalendario));
            this.dtpFormatLong = new System.Windows.Forms.DateTimePicker();
            this.dtpFormatShort = new System.Windows.Forms.DateTimePicker();
            this.dtpFormatTime = new System.Windows.Forms.DateTimePicker();
            this.dtpFormatCustom = new System.Windows.Forms.DateTimePicker();
            this.cldCalendario = new System.Windows.Forms.MonthCalendar();
            this.lblFormatLong = new System.Windows.Forms.Label();
            this.lblFormatShort = new System.Windows.Forms.Label();
            this.lblFormatTime = new System.Windows.Forms.Label();
            this.lblFormatCustom = new System.Windows.Forms.Label();
            this.btnCarregaData = new System.Windows.Forms.Button();
            this.txtCalendario = new System.Windows.Forms.TextBox();
            this.lblData = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dtpFormatLong
            // 
            this.dtpFormatLong.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFormatLong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFormatLong.Location = new System.Drawing.Point(12, 45);
            this.dtpFormatLong.Name = "dtpFormatLong";
            this.dtpFormatLong.Size = new System.Drawing.Size(330, 26);
            this.dtpFormatLong.TabIndex = 0;
            // 
            // dtpFormatShort
            // 
            this.dtpFormatShort.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFormatShort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFormatShort.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFormatShort.Location = new System.Drawing.Point(12, 114);
            this.dtpFormatShort.Name = "dtpFormatShort";
            this.dtpFormatShort.Size = new System.Drawing.Size(107, 26);
            this.dtpFormatShort.TabIndex = 1;
            // 
            // dtpFormatTime
            // 
            this.dtpFormatTime.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFormatTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFormatTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpFormatTime.Location = new System.Drawing.Point(12, 183);
            this.dtpFormatTime.Name = "dtpFormatTime";
            this.dtpFormatTime.Size = new System.Drawing.Size(107, 26);
            this.dtpFormatTime.TabIndex = 2;
            // 
            // dtpFormatCustom
            // 
            this.dtpFormatCustom.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFormatCustom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFormatCustom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFormatCustom.Location = new System.Drawing.Point(12, 252);
            this.dtpFormatCustom.Name = "dtpFormatCustom";
            this.dtpFormatCustom.Size = new System.Drawing.Size(107, 26);
            this.dtpFormatCustom.TabIndex = 3;
            // 
            // cldCalendario
            // 
            this.cldCalendario.Location = new System.Drawing.Point(375, 45);
            this.cldCalendario.Name = "cldCalendario";
            this.cldCalendario.TabIndex = 4;
            this.cldCalendario.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.cldCalendario_DateChanged);
            this.cldCalendario.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.cldCalendario_DateSelected);
            // 
            // lblFormatLong
            // 
            this.lblFormatLong.AutoSize = true;
            this.lblFormatLong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormatLong.Location = new System.Drawing.Point(12, 22);
            this.lblFormatLong.Name = "lblFormatLong";
            this.lblFormatLong.Size = new System.Drawing.Size(109, 20);
            this.lblFormatLong.TabIndex = 5;
            this.lblFormatLong.Text = "Format - Long";
            // 
            // lblFormatShort
            // 
            this.lblFormatShort.AutoSize = true;
            this.lblFormatShort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormatShort.Location = new System.Drawing.Point(12, 91);
            this.lblFormatShort.Name = "lblFormatShort";
            this.lblFormatShort.Size = new System.Drawing.Size(112, 20);
            this.lblFormatShort.TabIndex = 6;
            this.lblFormatShort.Text = "Format - Short";
            // 
            // lblFormatTime
            // 
            this.lblFormatTime.AutoSize = true;
            this.lblFormatTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormatTime.Location = new System.Drawing.Point(12, 160);
            this.lblFormatTime.Name = "lblFormatTime";
            this.lblFormatTime.Size = new System.Drawing.Size(107, 20);
            this.lblFormatTime.TabIndex = 7;
            this.lblFormatTime.Text = "Format - Time";
            // 
            // lblFormatCustom
            // 
            this.lblFormatCustom.AutoSize = true;
            this.lblFormatCustom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormatCustom.Location = new System.Drawing.Point(12, 229);
            this.lblFormatCustom.Name = "lblFormatCustom";
            this.lblFormatCustom.Size = new System.Drawing.Size(107, 20);
            this.lblFormatCustom.TabIndex = 8;
            this.lblFormatCustom.Text = "Format - Time";
            // 
            // btnCarregaData
            // 
            this.btnCarregaData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCarregaData.Location = new System.Drawing.Point(375, 243);
            this.btnCarregaData.Name = "btnCarregaData";
            this.btnCarregaData.Size = new System.Drawing.Size(227, 35);
            this.btnCarregaData.TabIndex = 9;
            this.btnCarregaData.Text = "Carrega Data";
            this.btnCarregaData.UseVisualStyleBackColor = true;
            this.btnCarregaData.Click += new System.EventHandler(this.btnCarregaData_Click);
            // 
            // txtCalendario
            // 
            this.txtCalendario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCalendario.Location = new System.Drawing.Point(12, 310);
            this.txtCalendario.Name = "txtCalendario";
            this.txtCalendario.Size = new System.Drawing.Size(776, 26);
            this.txtCalendario.TabIndex = 10;
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.Location = new System.Drawing.Point(12, 364);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(51, 20);
            this.lblData.TabIndex = 11;
            this.lblData.Text = "label1";
            // 
            // frmCalendario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.txtCalendario);
            this.Controls.Add(this.btnCarregaData);
            this.Controls.Add(this.lblFormatCustom);
            this.Controls.Add(this.lblFormatTime);
            this.Controls.Add(this.lblFormatShort);
            this.Controls.Add(this.lblFormatLong);
            this.Controls.Add(this.cldCalendario);
            this.Controls.Add(this.dtpFormatCustom);
            this.Controls.Add(this.dtpFormatTime);
            this.Controls.Add(this.dtpFormatShort);
            this.Controls.Add(this.dtpFormatLong);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmCalendario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GPSFrancisco - Calendário";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpFormatLong;
        private System.Windows.Forms.DateTimePicker dtpFormatShort;
        private System.Windows.Forms.DateTimePicker dtpFormatTime;
        private System.Windows.Forms.DateTimePicker dtpFormatCustom;
        private System.Windows.Forms.MonthCalendar cldCalendario;
        private System.Windows.Forms.Label lblFormatLong;
        private System.Windows.Forms.Label lblFormatShort;
        private System.Windows.Forms.Label lblFormatTime;
        private System.Windows.Forms.Label lblFormatCustom;
        private System.Windows.Forms.Button btnCarregaData;
        private System.Windows.Forms.TextBox txtCalendario;
        private System.Windows.Forms.Label lblData;
    }
}