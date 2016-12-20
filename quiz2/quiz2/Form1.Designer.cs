namespace quiz2
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
            this.RbEv = new System.Windows.Forms.RadioButton();
            this.RbSirket = new System.Windows.Forms.RadioButton();
            this.TxtAboneAdı = new System.Windows.Forms.TextBox();
            this.TxtOnceki = new System.Windows.Forms.TextBox();
            this.TxtSonraki = new System.Windows.Forms.TextBox();
            this.BtnEkle = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.GBAboneTipi = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.GBAboneTipi.SuspendLayout();
            this.SuspendLayout();
            // 
            // RbEv
            // 
            this.RbEv.AutoSize = true;
            this.RbEv.Location = new System.Drawing.Point(6, 36);
            this.RbEv.Name = "RbEv";
            this.RbEv.Size = new System.Drawing.Size(39, 17);
            this.RbEv.TabIndex = 1;
            this.RbEv.TabStop = true;
            this.RbEv.Text = "EV";
            this.RbEv.UseVisualStyleBackColor = true;
            // 
            // RbSirket
            // 
            this.RbSirket.AutoSize = true;
            this.RbSirket.Location = new System.Drawing.Point(6, 73);
            this.RbSirket.Name = "RbSirket";
            this.RbSirket.Size = new System.Drawing.Size(115, 17);
            this.RbSirket.TabIndex = 2;
            this.RbSirket.TabStop = true;
            this.RbSirket.Text = "ŞİRKET / KURUM";
            this.RbSirket.UseVisualStyleBackColor = true;
            // 
            // TxtAboneAdı
            // 
            this.TxtAboneAdı.Location = new System.Drawing.Point(13, 43);
            this.TxtAboneAdı.Name = "TxtAboneAdı";
            this.TxtAboneAdı.Size = new System.Drawing.Size(100, 20);
            this.TxtAboneAdı.TabIndex = 3;
            // 
            // TxtOnceki
            // 
            this.TxtOnceki.Location = new System.Drawing.Point(237, 113);
            this.TxtOnceki.Name = "TxtOnceki";
            this.TxtOnceki.Size = new System.Drawing.Size(100, 20);
            this.TxtOnceki.TabIndex = 4;
            // 
            // TxtSonraki
            // 
            this.TxtSonraki.Location = new System.Drawing.Point(237, 179);
            this.TxtSonraki.Name = "TxtSonraki";
            this.TxtSonraki.Size = new System.Drawing.Size(100, 20);
            this.TxtSonraki.TabIndex = 5;
            // 
            // BtnEkle
            // 
            this.BtnEkle.Location = new System.Drawing.Point(138, 216);
            this.BtnEkle.Name = "BtnEkle";
            this.BtnEkle.Size = new System.Drawing.Size(75, 23);
            this.BtnEkle.TabIndex = 6;
            this.BtnEkle.Text = "EKLE";
            this.BtnEkle.UseVisualStyleBackColor = true;
            this.BtnEkle.Click += new System.EventHandler(this.BtnEkle_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(13, 245);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 7;
            this.listBox1.DoubleClick += new System.EventHandler(this.listBox1_DoubleClick);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(217, 245);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(120, 95);
            this.listBox2.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Ödeme Listesi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(248, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Ödenenler";
            // 
            // GBAboneTipi
            // 
            this.GBAboneTipi.Controls.Add(this.RbEv);
            this.GBAboneTipi.Controls.Add(this.RbSirket);
            this.GBAboneTipi.Location = new System.Drawing.Point(13, 88);
            this.GBAboneTipi.Name = "GBAboneTipi";
            this.GBAboneTipi.Size = new System.Drawing.Size(200, 100);
            this.GBAboneTipi.TabIndex = 11;
            this.GBAboneTipi.TabStop = false;
            this.GBAboneTipi.Text = "Abone Tipi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Abone Adı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(234, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Önceki İndex";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(234, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Sonraki İndex";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 386);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GBAboneTipi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.BtnEkle);
            this.Controls.Add(this.TxtSonraki);
            this.Controls.Add(this.TxtOnceki);
            this.Controls.Add(this.TxtAboneAdı);
            this.Name = "Form1";
            this.Text = "İZSU";
            this.GBAboneTipi.ResumeLayout(false);
            this.GBAboneTipi.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton RbEv;
        private System.Windows.Forms.RadioButton RbSirket;
        private System.Windows.Forms.TextBox TxtAboneAdı;
        private System.Windows.Forms.TextBox TxtOnceki;
        private System.Windows.Forms.TextBox TxtSonraki;
        private System.Windows.Forms.Button BtnEkle;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox GBAboneTipi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

