namespace Constructor
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
            this.BtnOlustur = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.CBoxPozisyon = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // BtnOlustur
            // 
            this.BtnOlustur.Location = new System.Drawing.Point(67, 112);
            this.BtnOlustur.Name = "BtnOlustur";
            this.BtnOlustur.Size = new System.Drawing.Size(75, 23);
            this.BtnOlustur.TabIndex = 0;
            this.BtnOlustur.Text = "Oluştur";
            this.BtnOlustur.UseVisualStyleBackColor = true;
            this.BtnOlustur.Click += new System.EventHandler(this.BtnOlustur_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pozisyon";
            // 
            // CBoxPozisyon
            // 
            this.CBoxPozisyon.FormattingEnabled = true;
            this.CBoxPozisyon.Items.AddRange(new object[] {
            "Kaleci",
            "Defans",
            "Orta Sağa",
            "Forvet"});
            this.CBoxPozisyon.Location = new System.Drawing.Point(67, 59);
            this.CBoxPozisyon.Name = "CBoxPozisyon";
            this.CBoxPozisyon.Size = new System.Drawing.Size(121, 21);
            this.CBoxPozisyon.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.CBoxPozisyon);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnOlustur);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnOlustur;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CBoxPozisyon;
    }
}

