namespace GG.PlugInTabanliHesapMakinesi.WinUI
{
    partial class frmMain
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
            this.lstCommands = new System.Windows.Forms.ListBox();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.txtSayi2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSayi1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstCommands
            // 
            this.lstCommands.FormattingEnabled = true;
            this.lstCommands.Location = new System.Drawing.Point(258, 6);
            this.lstCommands.Name = "lstCommands";
            this.lstCommands.Size = new System.Drawing.Size(76, 173);
            this.lstCommands.TabIndex = 11;
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(12, 70);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(230, 23);
            this.btnHesapla.TabIndex = 10;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // txtSayi2
            // 
            this.txtSayi2.Location = new System.Drawing.Point(82, 32);
            this.txtSayi2.Name = "txtSayi2";
            this.txtSayi2.Size = new System.Drawing.Size(160, 20);
            this.txtSayi2.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Sayı 2";
            // 
            // txtSayi1
            // 
            this.txtSayi1.Location = new System.Drawing.Point(82, 6);
            this.txtSayi1.Name = "txtSayi1";
            this.txtSayi1.Size = new System.Drawing.Size(160, 20);
            this.txtSayi1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Sayı 1";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 189);
            this.Controls.Add(this.lstCommands);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.txtSayi2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSayi1);
            this.Controls.Add(this.label1);
            this.Name = "frmMain";
            this.Text = "Hesap Makinesi UI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstCommands;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.TextBox txtSayi2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSayi1;
        private System.Windows.Forms.Label label1;
    }
}

