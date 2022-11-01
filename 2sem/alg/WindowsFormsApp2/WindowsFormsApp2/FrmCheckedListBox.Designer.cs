namespace WindowsFormsApp2
{
    partial class FrmCheckedListBox
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
            this.chlFrutas = new System.Windows.Forms.CheckedListBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnExibir = new System.Windows.Forms.Button();
            this.txtAdicionar = new System.Windows.Forms.TextBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.lblAdicionar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // chlFrutas
            // 
            this.chlFrutas.FormattingEnabled = true;
            this.chlFrutas.Items.AddRange(new object[] {
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
            this.chlFrutas.Location = new System.Drawing.Point(12, 12);
            this.chlFrutas.Name = "chlFrutas";
            this.chlFrutas.Size = new System.Drawing.Size(317, 293);
            this.chlFrutas.TabIndex = 0;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(13, 373);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(317, 31);
            this.btnLimpar.TabIndex = 2;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnExibir
            // 
            this.btnExibir.Location = new System.Drawing.Point(13, 410);
            this.btnExibir.Name = "btnExibir";
            this.btnExibir.Size = new System.Drawing.Size(317, 31);
            this.btnExibir.TabIndex = 3;
            this.btnExibir.Text = "Exibir";
            this.btnExibir.UseVisualStyleBackColor = true;
            this.btnExibir.Click += new System.EventHandler(this.btnExibir_Click);
            // 
            // txtAdicionar
            // 
            this.txtAdicionar.Location = new System.Drawing.Point(13, 345);
            this.txtAdicionar.Name = "txtAdicionar";
            this.txtAdicionar.Size = new System.Drawing.Size(225, 22);
            this.txtAdicionar.TabIndex = 4;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(244, 344);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(86, 23);
            this.btnAdicionar.TabIndex = 5;
            this.btnAdicionar.Text = "adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // lblAdicionar
            // 
            this.lblAdicionar.AutoSize = true;
            this.lblAdicionar.Location = new System.Drawing.Point(13, 323);
            this.lblAdicionar.Name = "lblAdicionar";
            this.lblAdicionar.Size = new System.Drawing.Size(147, 16);
            this.lblAdicionar.TabIndex = 6;
            this.lblAdicionar.Text = "insira outra fruta favorita";
            // 
            // FrmCheckedListBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 453);
            this.Controls.Add(this.lblAdicionar);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.txtAdicionar);
            this.Controls.Add(this.btnExibir);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.chlFrutas);
            this.Name = "FrmCheckedListBox";
            this.Text = "CheckedListBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox chlFrutas;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnExibir;
        private System.Windows.Forms.TextBox txtAdicionar;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Label lblAdicionar;
    }
}