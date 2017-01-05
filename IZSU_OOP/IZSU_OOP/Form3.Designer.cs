namespace IZSU_OOP
{
    partial class Form3
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
            this.BtnGeri = new System.Windows.Forms.Button();
            this.TxtOdenenMiktar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtAdSoyad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtAboneNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtToplamOdeme = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnGeri
            // 
            this.BtnGeri.BackColor = System.Drawing.Color.DarkGreen;
            this.BtnGeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnGeri.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnGeri.Location = new System.Drawing.Point(6, 121);
            this.BtnGeri.Name = "BtnGeri";
            this.BtnGeri.Size = new System.Drawing.Size(292, 31);
            this.BtnGeri.TabIndex = 34;
            this.BtnGeri.Text = "GERİ";
            this.BtnGeri.UseVisualStyleBackColor = false;
            this.BtnGeri.Click += new System.EventHandler(this.BtnGeri_Click);
            // 
            // TxtOdenenMiktar
            // 
            this.TxtOdenenMiktar.Location = new System.Drawing.Point(142, 58);
            this.TxtOdenenMiktar.Name = "TxtOdenenMiktar";
            this.TxtOdenenMiktar.ReadOnly = true;
            this.TxtOdenenMiktar.Size = new System.Drawing.Size(156, 20);
            this.TxtOdenenMiktar.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(3, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 17);
            this.label4.TabIndex = 29;
            this.label4.Text = "Ödenen Miktar";
            // 
            // TxtAdSoyad
            // 
            this.TxtAdSoyad.Location = new System.Drawing.Point(142, 32);
            this.TxtAdSoyad.Name = "TxtAdSoyad";
            this.TxtAdSoyad.ReadOnly = true;
            this.TxtAdSoyad.Size = new System.Drawing.Size(156, 20);
            this.TxtAdSoyad.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(3, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 17);
            this.label2.TabIndex = 25;
            this.label2.Text = "İsim Soyisim";
            // 
            // TxtAboneNo
            // 
            this.TxtAboneNo.Location = new System.Drawing.Point(142, 6);
            this.TxtAboneNo.Name = "TxtAboneNo";
            this.TxtAboneNo.ReadOnly = true;
            this.TxtAboneNo.Size = new System.Drawing.Size(156, 20);
            this.TxtAboneNo.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 23;
            this.label1.Text = "Abone No";
            // 
            // TxtToplamOdeme
            // 
            this.TxtToplamOdeme.Location = new System.Drawing.Point(142, 84);
            this.TxtToplamOdeme.Name = "TxtToplamOdeme";
            this.TxtToplamOdeme.ReadOnly = true;
            this.TxtToplamOdeme.Size = new System.Drawing.Size(156, 20);
            this.TxtToplamOdeme.TabIndex = 36;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(3, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 17);
            this.label6.TabIndex = 35;
            this.label6.Text = "Toplam Ödenen";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 161);
            this.Controls.Add(this.TxtToplamOdeme);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.BtnGeri);
            this.Controls.Add(this.TxtOdenenMiktar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtAdSoyad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtAboneNo);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnGeri;
        private System.Windows.Forms.TextBox TxtOdenenMiktar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtAdSoyad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtAboneNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtToplamOdeme;
        private System.Windows.Forms.Label label6;
    }
}