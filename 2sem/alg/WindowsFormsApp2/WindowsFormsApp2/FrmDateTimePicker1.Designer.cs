namespace WindowsFormsApp2
{
    partial class FrmDateTimePicker1
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
            this.label1 = new System.Windows.Forms.Label();
            this.dtpDataLong = new System.Windows.Forms.DateTimePicker();
            this.dtpDataShort = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpDataTime = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpDataCustom = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Long";
            // 
            // dtpDataLong
            // 
            this.dtpDataLong.Location = new System.Drawing.Point(97, 10);
            this.dtpDataLong.Name = "dtpDataLong";
            this.dtpDataLong.Size = new System.Drawing.Size(315, 22);
            this.dtpDataLong.TabIndex = 1;
            this.dtpDataLong.Value = new System.DateTime(2050, 1, 1, 0, 0, 0, 0);
            // 
            // dtpDataShort
            // 
            this.dtpDataShort.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataShort.Location = new System.Drawing.Point(97, 38);
            this.dtpDataShort.Name = "dtpDataShort";
            this.dtpDataShort.Size = new System.Drawing.Size(315, 22);
            this.dtpDataShort.TabIndex = 3;
            this.dtpDataShort.Value = new System.DateTime(2050, 1, 1, 0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Short";
            // 
            // dtpDataTime
            // 
            this.dtpDataTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpDataTime.Location = new System.Drawing.Point(97, 66);
            this.dtpDataTime.Name = "dtpDataTime";
            this.dtpDataTime.Size = new System.Drawing.Size(315, 22);
            this.dtpDataTime.TabIndex = 5;
            this.dtpDataTime.Value = new System.DateTime(2050, 1, 1, 0, 0, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Time";
            // 
            // dtpDataCustom
            // 
            this.dtpDataCustom.CustomFormat = "ddd, dd/MMM/yyyy";
            this.dtpDataCustom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDataCustom.Location = new System.Drawing.Point(97, 94);
            this.dtpDataCustom.Name = "dtpDataCustom";
            this.dtpDataCustom.Size = new System.Drawing.Size(315, 22);
            this.dtpDataCustom.TabIndex = 7;
            this.dtpDataCustom.Value = new System.DateTime(2050, 1, 1, 0, 0, 0, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Custom";
            // 
            // FrmDateTimePicker1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 142);
            this.Controls.Add(this.dtpDataCustom);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpDataTime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpDataShort);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpDataLong);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmDateTimePicker1";
            this.Text = "DateTimePicker | Exemplo 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpDataLong;
        private System.Windows.Forms.DateTimePicker dtpDataShort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpDataTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpDataCustom;
        private System.Windows.Forms.Label label4;
    }
}