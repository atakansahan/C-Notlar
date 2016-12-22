namespace İZSU
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
            this.RbSirket = new System.Windows.Forms.RadioButton();
            this.RbEv = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ListBoxÖdenenler = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtSonraki = new System.Windows.Forms.TextBox();
            this.TxtOnceki = new System.Windows.Forms.TextBox();
            this.buttonkaydet = new System.Windows.Forms.Button();
            this.ListBoxÖdemeListesi = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtAboneNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtAdSoyad = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RbSirket);
            this.groupBox1.Controls.Add(this.RbEv);
            this.groupBox1.Location = new System.Drawing.Point(13, 107);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(155, 100);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Abone Tipi";
            // 
            // RbSirket
            // 
            this.RbSirket.AutoSize = true;
            this.RbSirket.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.RbSirket.Location = new System.Drawing.Point(6, 70);
            this.RbSirket.Name = "RbSirket";
            this.RbSirket.Size = new System.Drawing.Size(68, 24);
            this.RbSirket.TabIndex = 4;
            this.RbSirket.TabStop = true;
            this.RbSirket.Text = "Şirket";
            this.RbSirket.UseVisualStyleBackColor = true;
            // 
            // RbEv
            // 
            this.RbEv.AutoSize = true;
            this.RbEv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.RbEv.Location = new System.Drawing.Point(6, 33);
            this.RbEv.Name = "RbEv";
            this.RbEv.Size = new System.Drawing.Size(45, 24);
            this.RbEv.TabIndex = 3;
            this.RbEv.TabStop = true;
            this.RbEv.Text = "Ev";
            this.RbEv.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(217, 260);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 20);
            this.label7.TabIndex = 28;
            this.label7.Text = "ÖDENENLER";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(24, 260);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 20);
            this.label5.TabIndex = 27;
            this.label5.Text = "ÖDEME LİSTESİ";
            // 
            // ListBoxÖdenenler
            // 
            this.ListBoxÖdenenler.FormattingEnabled = true;
            this.ListBoxÖdenenler.Location = new System.Drawing.Point(202, 283);
            this.ListBoxÖdenenler.Name = "ListBoxÖdenenler";
            this.ListBoxÖdenenler.Size = new System.Drawing.Size(156, 121);
            this.ListBoxÖdenenler.TabIndex = 26;
            this.ListBoxÖdenenler.DoubleClick += new System.EventHandler(this.ListBoxÖdenenler_DoubleClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(186, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 20);
            this.label4.TabIndex = 25;
            this.label4.Text = "Son kullanım";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(186, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 20);
            this.label3.TabIndex = 24;
            this.label3.Text = "Önceki kullanım";
            // 
            // TxtSonraki
            // 
            this.TxtSonraki.Location = new System.Drawing.Point(202, 187);
            this.TxtSonraki.Name = "TxtSonraki";
            this.TxtSonraki.Size = new System.Drawing.Size(100, 20);
            this.TxtSonraki.TabIndex = 23;
            // 
            // TxtOnceki
            // 
            this.TxtOnceki.Location = new System.Drawing.Point(202, 140);
            this.TxtOnceki.Name = "TxtOnceki";
            this.TxtOnceki.Size = new System.Drawing.Size(100, 20);
            this.TxtOnceki.TabIndex = 22;
            // 
            // buttonkaydet
            // 
            this.buttonkaydet.Location = new System.Drawing.Point(289, -36);
            this.buttonkaydet.Name = "buttonkaydet";
            this.buttonkaydet.Size = new System.Drawing.Size(100, 30);
            this.buttonkaydet.TabIndex = 21;
            this.buttonkaydet.Text = "kaydet";
            this.buttonkaydet.UseVisualStyleBackColor = true;
            // 
            // ListBoxÖdemeListesi
            // 
            this.ListBoxÖdemeListesi.FormattingEnabled = true;
            this.ListBoxÖdemeListesi.Location = new System.Drawing.Point(12, 283);
            this.ListBoxÖdemeListesi.Name = "ListBoxÖdemeListesi";
            this.ListBoxÖdemeListesi.Size = new System.Drawing.Size(156, 121);
            this.ListBoxÖdemeListesi.TabIndex = 20;
            this.ListBoxÖdemeListesi.DoubleClick += new System.EventHandler(this.listBox1_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(36, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Abone Adı";
            // 
            // TxtAboneNo
            // 
            this.TxtAboneNo.Location = new System.Drawing.Point(39, 46);
            this.TxtAboneNo.Name = "TxtAboneNo";
            this.TxtAboneNo.Size = new System.Drawing.Size(100, 20);
            this.TxtAboneNo.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(161, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 30;
            this.label2.Text = "İsim Soyisim";
            // 
            // TxtAdSoyad
            // 
            this.TxtAdSoyad.Location = new System.Drawing.Point(165, 46);
            this.TxtAdSoyad.Name = "TxtAdSoyad";
            this.TxtAdSoyad.Size = new System.Drawing.Size(100, 20);
            this.TxtAdSoyad.TabIndex = 31;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 226);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(346, 20);
            this.button1.TabIndex = 32;
            this.button1.Text = "KAYIT EKLE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 417);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TxtAdSoyad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ListBoxÖdenenler);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtSonraki);
            this.Controls.Add(this.TxtOnceki);
            this.Controls.Add(this.buttonkaydet);
            this.Controls.Add(this.ListBoxÖdemeListesi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtAboneNo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RbSirket;
        private System.Windows.Forms.RadioButton RbEv;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox ListBoxÖdenenler;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtSonraki;
        private System.Windows.Forms.TextBox TxtOnceki;
        private System.Windows.Forms.Button buttonkaydet;
        private System.Windows.Forms.ListBox ListBoxÖdemeListesi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtAboneNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtAdSoyad;
        private System.Windows.Forms.Button button1;
    }
}

