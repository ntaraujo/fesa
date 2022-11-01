namespace WindowsFormsApp2
{
    partial class FrmDateTimePicker2
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
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.txtDia = new System.Windows.Forms.TextBox();
            this.txtMes = new System.Windows.Forms.TextBox();
            this.txtAno = new System.Windows.Forms.TextBox();
            this.txtData = new System.Windows.Forms.TextBox();
            this.btnExibir = new System.Windows.Forms.Button();
            this.btnDefinir = new System.Windows.Forms.Button();
            this.btnHoje = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dtpData
            // 
            this.dtpData.CustomFormat = "";
            this.dtpData.Location = new System.Drawing.Point(33, 35);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(487, 22);
            this.dtpData.TabIndex = 0;
            this.dtpData.UseWaitCursor = true;
            this.dtpData.Value = new System.DateTime(2050, 1, 1, 0, 0, 0, 0);
            // 
            // txtDia
            // 
            this.txtDia.Location = new System.Drawing.Point(33, 93);
            this.txtDia.Name = "txtDia";
            this.txtDia.Size = new System.Drawing.Size(161, 22);
            this.txtDia.TabIndex = 1;
            this.txtDia.UseWaitCursor = true;
            // 
            // txtMes
            // 
            this.txtMes.Location = new System.Drawing.Point(196, 93);
            this.txtMes.Name = "txtMes";
            this.txtMes.Size = new System.Drawing.Size(161, 22);
            this.txtMes.TabIndex = 2;
            this.txtMes.UseWaitCursor = true;
            // 
            // txtAno
            // 
            this.txtAno.Location = new System.Drawing.Point(359, 92);
            this.txtAno.Name = "txtAno";
            this.txtAno.Size = new System.Drawing.Size(161, 22);
            this.txtAno.TabIndex = 3;
            this.txtAno.UseWaitCursor = true;
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(33, 64);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(487, 22);
            this.txtData.TabIndex = 4;
            this.txtData.UseWaitCursor = true;
            // 
            // btnExibir
            // 
            this.btnExibir.Location = new System.Drawing.Point(526, 35);
            this.btnExibir.Name = "btnExibir";
            this.btnExibir.Size = new System.Drawing.Size(137, 23);
            this.btnExibir.TabIndex = 5;
            this.btnExibir.Text = "exibir";
            this.btnExibir.UseVisualStyleBackColor = true;
            this.btnExibir.UseWaitCursor = true;
            this.btnExibir.Click += new System.EventHandler(this.btnExibir_Click);
            // 
            // btnDefinir
            // 
            this.btnDefinir.Location = new System.Drawing.Point(526, 92);
            this.btnDefinir.Name = "btnDefinir";
            this.btnDefinir.Size = new System.Drawing.Size(137, 23);
            this.btnDefinir.TabIndex = 6;
            this.btnDefinir.Text = "definir";
            this.btnDefinir.UseVisualStyleBackColor = true;
            this.btnDefinir.UseWaitCursor = true;
            this.btnDefinir.Click += new System.EventHandler(this.btnDefinir_Click);
            // 
            // btnHoje
            // 
            this.btnHoje.Location = new System.Drawing.Point(526, 63);
            this.btnHoje.Name = "btnHoje";
            this.btnHoje.Size = new System.Drawing.Size(137, 23);
            this.btnHoje.TabIndex = 7;
            this.btnHoje.Text = "hoje";
            this.btnHoje.UseVisualStyleBackColor = true;
            this.btnHoje.UseWaitCursor = true;
            this.btnHoje.Click += new System.EventHandler(this.btnHoje_Click);
            // 
            // FrmDateTimePicker2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 132);
            this.Controls.Add(this.btnHoje);
            this.Controls.Add(this.btnDefinir);
            this.Controls.Add(this.btnExibir);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.txtAno);
            this.Controls.Add(this.txtMes);
            this.Controls.Add(this.txtDia);
            this.Controls.Add(this.dtpData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmDateTimePicker2";
            this.Text = "DateTimePicker | Exemplo 2";
            this.UseWaitCursor = true;
            this.Load += new System.EventHandler(this.FrmDateTimePicker_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.TextBox txtDia;
        private System.Windows.Forms.TextBox txtMes;
        private System.Windows.Forms.TextBox txtAno;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.Button btnExibir;
        private System.Windows.Forms.Button btnDefinir;
        private System.Windows.Forms.Button btnHoje;
    }
}