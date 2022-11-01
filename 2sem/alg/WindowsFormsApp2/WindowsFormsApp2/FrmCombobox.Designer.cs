namespace WindowsFormsApp2
{
    partial class FrmCombobox
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
            this.cboFrutas = new System.Windows.Forms.ComboBox();
            this.btnExibir = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.txtFrutaPreferida = new System.Windows.Forms.TextBox();
            this.lblNovaFruta = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cboFrutas
            // 
            this.cboFrutas.FormattingEnabled = true;
            this.cboFrutas.Items.AddRange(new object[] {
            "banana",
            "maçã",
            "laranja",
            "mamão",
            "manga",
            "açaí",
            "melancia",
            "tangerina",
            "abacaxi",
            "uva"});
            this.cboFrutas.Location = new System.Drawing.Point(13, 13);
            this.cboFrutas.Name = "cboFrutas";
            this.cboFrutas.Size = new System.Drawing.Size(223, 24);
            this.cboFrutas.TabIndex = 0;
            this.cboFrutas.SelectedIndexChanged += new System.EventHandler(this.cboFrutas_SelectedIndexChanged);
            // 
            // btnExibir
            // 
            this.btnExibir.Location = new System.Drawing.Point(256, 8);
            this.btnExibir.Name = "btnExibir";
            this.btnExibir.Size = new System.Drawing.Size(122, 33);
            this.btnExibir.TabIndex = 1;
            this.btnExibir.Text = "exibir";
            this.btnExibir.UseVisualStyleBackColor = true;
            this.btnExibir.Click += new System.EventHandler(this.btnExibir_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(256, 47);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(122, 33);
            this.btnLimpar.TabIndex = 2;
            this.btnLimpar.Text = "limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(256, 131);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(122, 33);
            this.btnAdicionar.TabIndex = 4;
            this.btnAdicionar.Text = "adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // txtFrutaPreferida
            // 
            this.txtFrutaPreferida.Location = new System.Drawing.Point(13, 136);
            this.txtFrutaPreferida.Name = "txtFrutaPreferida";
            this.txtFrutaPreferida.Size = new System.Drawing.Size(223, 22);
            this.txtFrutaPreferida.TabIndex = 5;
            this.txtFrutaPreferida.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtFrutaPreferida_MouseClick);
            // 
            // lblNovaFruta
            // 
            this.lblNovaFruta.AutoSize = true;
            this.lblNovaFruta.Location = new System.Drawing.Point(13, 114);
            this.lblNovaFruta.Name = "lblNovaFruta";
            this.lblNovaFruta.Size = new System.Drawing.Size(89, 16);
            this.lblNovaFruta.TabIndex = 6;
            this.lblNovaFruta.Text = "fruta preferida";
            // 
            // FrmCombobox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 453);
            this.Controls.Add(this.lblNovaFruta);
            this.Controls.Add(this.txtFrutaPreferida);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnExibir);
            this.Controls.Add(this.cboFrutas);
            this.Name = "FrmCombobox";
            this.Text = "ComboBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboFrutas;
        private System.Windows.Forms.Button btnExibir;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.TextBox txtFrutaPreferida;
        private System.Windows.Forms.Label lblNovaFruta;
    }
}