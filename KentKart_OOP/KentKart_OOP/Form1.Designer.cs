namespace KentKart_OOP
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtBakiye = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.GbOkulAdı = new System.Windows.Forms.GroupBox();
            this.TxtOkulAdı = new System.Windows.Forms.TextBox();
            this.RbTam = new System.Windows.Forms.RadioButton();
            this.RbOgrenci = new System.Windows.Forms.RadioButton();
            this.BtnEkle = new System.Windows.Forms.Button();
            this.RbOgretmen = new System.Windows.Forms.RadioButton();
            this.LstBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.GbOkulAdı.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxtBakiye);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.GbOkulAdı);
            this.groupBox1.Controls.Add(this.RbTam);
            this.groupBox1.Controls.Add(this.RbOgrenci);
            this.groupBox1.Controls.Add(this.BtnEkle);
            this.groupBox1.Controls.Add(this.RbOgretmen);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(247, 202);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kart Oluştur";
            // 
            // TxtBakiye
            // 
            this.TxtBakiye.Location = new System.Drawing.Point(113, 46);
            this.TxtBakiye.Name = "TxtBakiye";
            this.TxtBakiye.Size = new System.Drawing.Size(100, 20);
            this.TxtBakiye.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(110, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Bakiye";
            // 
            // GbOkulAdı
            // 
            this.GbOkulAdı.Controls.Add(this.TxtOkulAdı);
            this.GbOkulAdı.Location = new System.Drawing.Point(113, 86);
            this.GbOkulAdı.Name = "GbOkulAdı";
            this.GbOkulAdı.Size = new System.Drawing.Size(122, 69);
            this.GbOkulAdı.TabIndex = 6;
            this.GbOkulAdı.TabStop = false;
            this.GbOkulAdı.Text = "Okul Adı";
            // 
            // TxtOkulAdı
            // 
            this.TxtOkulAdı.Location = new System.Drawing.Point(6, 30);
            this.TxtOkulAdı.Name = "TxtOkulAdı";
            this.TxtOkulAdı.Size = new System.Drawing.Size(100, 20);
            this.TxtOkulAdı.TabIndex = 6;
            // 
            // RbTam
            // 
            this.RbTam.AutoSize = true;
            this.RbTam.Location = new System.Drawing.Point(6, 49);
            this.RbTam.Name = "RbTam";
            this.RbTam.Size = new System.Drawing.Size(46, 17);
            this.RbTam.TabIndex = 3;
            this.RbTam.TabStop = true;
            this.RbTam.Text = "Tam";
            this.RbTam.UseVisualStyleBackColor = true;
            // 
            // RbOgrenci
            // 
            this.RbOgrenci.AutoSize = true;
            this.RbOgrenci.Location = new System.Drawing.Point(6, 86);
            this.RbOgrenci.Name = "RbOgrenci";
            this.RbOgrenci.Size = new System.Drawing.Size(62, 17);
            this.RbOgrenci.TabIndex = 0;
            this.RbOgrenci.TabStop = true;
            this.RbOgrenci.Text = "Öğrenci";
            this.RbOgrenci.UseVisualStyleBackColor = true;
            this.RbOgrenci.CheckedChanged += new System.EventHandler(this.RbOgrenci_CheckedChanged);
            // 
            // BtnEkle
            // 
            this.BtnEkle.Location = new System.Drawing.Point(6, 173);
            this.BtnEkle.Name = "BtnEkle";
            this.BtnEkle.Size = new System.Drawing.Size(75, 23);
            this.BtnEkle.TabIndex = 2;
            this.BtnEkle.Text = "EKLE";
            this.BtnEkle.UseVisualStyleBackColor = true;
            this.BtnEkle.Click += new System.EventHandler(this.BtnEkle_Click);
            // 
            // RbOgretmen
            // 
            this.RbOgretmen.AutoSize = true;
            this.RbOgretmen.Location = new System.Drawing.Point(6, 119);
            this.RbOgretmen.Name = "RbOgretmen";
            this.RbOgretmen.Size = new System.Drawing.Size(71, 17);
            this.RbOgretmen.TabIndex = 1;
            this.RbOgretmen.TabStop = true;
            this.RbOgretmen.Text = "Öğretmen";
            this.RbOgretmen.UseVisualStyleBackColor = true;
            // 
            // LstBox
            // 
            this.LstBox.FormattingEnabled = true;
            this.LstBox.Location = new System.Drawing.Point(12, 247);
            this.LstBox.Name = "LstBox";
            this.LstBox.Size = new System.Drawing.Size(247, 121);
            this.LstBox.TabIndex = 4;
            this.LstBox.DoubleClick += new System.EventHandler(this.LstBox_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 231);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Yolcular";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 380);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LstBox);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.GbOkulAdı.ResumeLayout(false);
            this.GbOkulAdı.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RbTam;
        private System.Windows.Forms.RadioButton RbOgrenci;
        private System.Windows.Forms.Button BtnEkle;
        private System.Windows.Forms.RadioButton RbOgretmen;
        private System.Windows.Forms.ListBox LstBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtOkulAdı;
        private System.Windows.Forms.GroupBox GbOkulAdı;
        private System.Windows.Forms.TextBox TxtBakiye;
        private System.Windows.Forms.Label label2;
    }
}

