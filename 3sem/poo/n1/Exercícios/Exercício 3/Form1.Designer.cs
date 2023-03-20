namespace Exercício3
{
    partial class Form1
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
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtRG = new System.Windows.Forms.TextBox();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblRG = new System.Windows.Forms.Label();
            this.lblSalario = new System.Windows.Forms.Label();
            this.btnCódigo = new System.Windows.Forms.Button();
            this.btnNome = new System.Windows.Forms.Button();
            this.btnRG = new System.Windows.Forms.Button();
            this.btnSalário = new System.Windows.Forms.Button();
            this.btnExibir = new System.Windows.Forms.Button();
            this.lblExibir = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(88, 50);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 22);
            this.txtCodigo.TabIndex = 0;
            this.txtCodigo.TextChanged += new System.EventHandler(this.txtCodigo_TextChanged);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(88, 78);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 22);
            this.txtNome.TabIndex = 1;
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // txtRG
            // 
            this.txtRG.Location = new System.Drawing.Point(88, 106);
            this.txtRG.Name = "txtRG";
            this.txtRG.Size = new System.Drawing.Size(100, 22);
            this.txtRG.TabIndex = 2;
            this.txtRG.TextChanged += new System.EventHandler(this.txtRG_TextChanged);
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(88, 134);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(100, 22);
            this.txtSalario.TabIndex = 3;
            this.txtSalario.TextChanged += new System.EventHandler(this.txtSalario_TextChanged);
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(27, 53);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(54, 16);
            this.lblCodigo.TabIndex = 4;
            this.lblCodigo.Text = "Código:";
            this.lblCodigo.Click += new System.EventHandler(this.lblCodigo_Click);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(27, 84);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(47, 16);
            this.lblNome.TabIndex = 5;
            this.lblNome.Text = "Nome:";
            this.lblNome.Click += new System.EventHandler(this.lblNome_Click);
            // 
            // lblRG
            // 
            this.lblRG.AutoSize = true;
            this.lblRG.Location = new System.Drawing.Point(27, 112);
            this.lblRG.Name = "lblRG";
            this.lblRG.Size = new System.Drawing.Size(30, 16);
            this.lblRG.TabIndex = 6;
            this.lblRG.Text = "RG:";
            this.lblRG.Click += new System.EventHandler(this.lblRG_Click);
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.Location = new System.Drawing.Point(27, 140);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(53, 16);
            this.lblSalario.TabIndex = 7;
            this.lblSalario.Text = "Salário:";
            this.lblSalario.Click += new System.EventHandler(this.lblSalario_Click);
            // 
            // btnCódigo
            // 
            this.btnCódigo.Location = new System.Drawing.Point(211, 49);
            this.btnCódigo.Name = "btnCódigo";
            this.btnCódigo.Size = new System.Drawing.Size(98, 23);
            this.btnCódigo.TabIndex = 8;
            this.btnCódigo.Text = "Avançar";
            this.btnCódigo.UseVisualStyleBackColor = true;
            this.btnCódigo.Click += new System.EventHandler(this.btnCódigo_Click);
            // 
            // btnNome
            // 
            this.btnNome.Enabled = false;
            this.btnNome.Location = new System.Drawing.Point(211, 81);
            this.btnNome.Name = "btnNome";
            this.btnNome.Size = new System.Drawing.Size(98, 23);
            this.btnNome.TabIndex = 9;
            this.btnNome.Text = "Avançar";
            this.btnNome.UseVisualStyleBackColor = true;
            this.btnNome.Click += new System.EventHandler(this.btnNome_Click);
            // 
            // btnRG
            // 
            this.btnRG.Enabled = false;
            this.btnRG.Location = new System.Drawing.Point(211, 109);
            this.btnRG.Name = "btnRG";
            this.btnRG.Size = new System.Drawing.Size(98, 23);
            this.btnRG.TabIndex = 10;
            this.btnRG.Text = "Avançar";
            this.btnRG.UseVisualStyleBackColor = true;
            this.btnRG.Click += new System.EventHandler(this.btnRG_Click);
            // 
            // btnSalário
            // 
            this.btnSalário.Enabled = false;
            this.btnSalário.Location = new System.Drawing.Point(211, 137);
            this.btnSalário.Name = "btnSalário";
            this.btnSalário.Size = new System.Drawing.Size(98, 23);
            this.btnSalário.TabIndex = 11;
            this.btnSalário.Text = "Avançar";
            this.btnSalário.UseVisualStyleBackColor = true;
            this.btnSalário.Click += new System.EventHandler(this.btnSalário_Click);
            // 
            // btnExibir
            // 
            this.btnExibir.Enabled = false;
            this.btnExibir.Location = new System.Drawing.Point(90, 182);
            this.btnExibir.Name = "btnExibir";
            this.btnExibir.Size = new System.Drawing.Size(98, 23);
            this.btnExibir.TabIndex = 12;
            this.btnExibir.Text = "Adicionar";
            this.btnExibir.UseVisualStyleBackColor = true;
            this.btnExibir.Click += new System.EventHandler(this.btnExibir_Click);
            // 
            // lblExibir
            // 
            this.lblExibir.AutoSize = true;
            this.lblExibir.Location = new System.Drawing.Point(87, 227);
            this.lblExibir.Name = "lblExibir";
            this.lblExibir.Size = new System.Drawing.Size(0, 16);
            this.lblExibir.TabIndex = 13;
            this.lblExibir.Click += new System.EventHandler(this.lblExibir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblExibir);
            this.Controls.Add(this.btnExibir);
            this.Controls.Add(this.btnSalário);
            this.Controls.Add(this.btnRG);
            this.Controls.Add(this.btnNome);
            this.Controls.Add(this.btnCódigo);
            this.Controls.Add(this.lblSalario);
            this.Controls.Add(this.lblRG);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.txtRG);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtCodigo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtRG;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblRG;
        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.Button btnCódigo;
        private System.Windows.Forms.Button btnNome;
        private System.Windows.Forms.Button btnRG;
        private System.Windows.Forms.Button btnSalário;
        private System.Windows.Forms.Button btnExibir;
        private System.Windows.Forms.Label lblExibir;
    }
}

