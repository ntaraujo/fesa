namespace WindowsFormsApp2
{
    partial class FrmLinkLabel
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
            this.lklFesa = new System.Windows.Forms.LinkLabel();
            this.lblValor = new System.Windows.Forms.Label();
            this.txtConteudo = new System.Windows.Forms.TextBox();
            this.btnExibir = new System.Windows.Forms.Button();
            this.lklCalculadora = new System.Windows.Forms.LinkLabel();
            this.lblDiversos = new System.Windows.Forms.LinkLabel();
            this.lklPaint = new System.Windows.Forms.LinkLabel();
            this.lblPesquisa = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lklFesa
            // 
            this.lklFesa.AutoSize = true;
            this.lklFesa.Location = new System.Drawing.Point(12, 99);
            this.lklFesa.Name = "lklFesa";
            this.lklFesa.Size = new System.Drawing.Size(42, 16);
            this.lklFesa.TabIndex = 0;
            this.lklFesa.TabStop = true;
            this.lklFesa.Text = "FESA";
            this.lklFesa.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lklFesa_LinkClicked);
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(13, 13);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(37, 16);
            this.lblValor.TabIndex = 1;
            this.lblValor.Text = "valor";
            // 
            // txtConteudo
            // 
            this.txtConteudo.Location = new System.Drawing.Point(60, 10);
            this.txtConteudo.Name = "txtConteudo";
            this.txtConteudo.Size = new System.Drawing.Size(291, 22);
            this.txtConteudo.TabIndex = 2;
            // 
            // btnExibir
            // 
            this.btnExibir.Location = new System.Drawing.Point(276, 38);
            this.btnExibir.Name = "btnExibir";
            this.btnExibir.Size = new System.Drawing.Size(75, 23);
            this.btnExibir.TabIndex = 3;
            this.btnExibir.Text = "exibir";
            this.btnExibir.UseVisualStyleBackColor = true;
            this.btnExibir.Click += new System.EventHandler(this.button1_Click);
            // 
            // lklCalculadora
            // 
            this.lklCalculadora.AutoSize = true;
            this.lklCalculadora.Location = new System.Drawing.Point(195, 99);
            this.lklCalculadora.Name = "lklCalculadora";
            this.lklCalculadora.Size = new System.Drawing.Size(80, 16);
            this.lklCalculadora.TabIndex = 4;
            this.lklCalculadora.TabStop = true;
            this.lklCalculadora.Text = "Calculadora";
            this.lklCalculadora.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lklCalculadora_LinkClicked);
            // 
            // lblDiversos
            // 
            this.lblDiversos.AutoSize = true;
            this.lblDiversos.Location = new System.Drawing.Point(13, 138);
            this.lblDiversos.Name = "lblDiversos";
            this.lblDiversos.Size = new System.Drawing.Size(306, 16);
            this.lblDiversos.TabIndex = 5;
            this.lblDiversos.TabStop = true;
            this.lblDiversos.Text = "TIOBE - REMOTERS - REMOTAR - W3SCHOOLS";
            this.lblDiversos.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblDiversos_LinkClicked);
            // 
            // lklPaint
            // 
            this.lklPaint.AutoSize = true;
            this.lklPaint.Location = new System.Drawing.Point(314, 99);
            this.lklPaint.Name = "lklPaint";
            this.lklPaint.Size = new System.Drawing.Size(37, 16);
            this.lklPaint.TabIndex = 6;
            this.lklPaint.TabStop = true;
            this.lklPaint.Text = "Paint";
            this.lklPaint.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lklPaint_LinkClicked);
            // 
            // lblPesquisa
            // 
            this.lblPesquisa.AutoSize = true;
            this.lblPesquisa.Location = new System.Drawing.Point(93, 99);
            this.lblPesquisa.Name = "lblPesquisa";
            this.lblPesquisa.Size = new System.Drawing.Size(63, 16);
            this.lblPesquisa.TabIndex = 7;
            this.lblPesquisa.TabStop = true;
            this.lblPesquisa.Text = "pesquisa";
            this.lblPesquisa.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // FrmLinkLabel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 176);
            this.Controls.Add(this.lblPesquisa);
            this.Controls.Add(this.lklPaint);
            this.Controls.Add(this.lblDiversos);
            this.Controls.Add(this.lklCalculadora);
            this.Controls.Add(this.btnExibir);
            this.Controls.Add(this.txtConteudo);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.lklFesa);
            this.Name = "FrmLinkLabel";
            this.Text = "LinkLabel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel lklFesa;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.TextBox txtConteudo;
        private System.Windows.Forms.Button btnExibir;
        private System.Windows.Forms.LinkLabel lklCalculadora;
        private System.Windows.Forms.LinkLabel lblDiversos;
        private System.Windows.Forms.LinkLabel lklPaint;
        private System.Windows.Forms.LinkLabel lblPesquisa;
    }
}