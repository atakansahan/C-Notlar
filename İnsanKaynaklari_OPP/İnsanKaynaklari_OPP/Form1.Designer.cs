namespace İnsanKaynaklari_OPP
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
            this.label1 = new System.Windows.Forms.Label();
            this.LstBoxCalisan = new System.Windows.Forms.ListBox();
            this.comboMax = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SskNo = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Maas = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.SatısAdeti = new System.Windows.Forms.NumericUpDown();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SskNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Maas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SatısAdeti)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Eleman Türü";
            // 
            // LstBoxCalisan
            // 
            this.LstBoxCalisan.FormattingEnabled = true;
            this.LstBoxCalisan.Location = new System.Drawing.Point(218, 22);
            this.LstBoxCalisan.Name = "LstBoxCalisan";
            this.LstBoxCalisan.Size = new System.Drawing.Size(204, 186);
            this.LstBoxCalisan.TabIndex = 2;
            this.LstBoxCalisan.DoubleClick += new System.EventHandler(this.LstBoxCalisan_DoubleClick);
            // 
            // comboMax
            // 
            this.comboMax.FormattingEnabled = true;
            this.comboMax.Items.AddRange(new object[] {
            "Satış Temsilcisi"});
            this.comboMax.Location = new System.Drawing.Point(74, 9);
            this.comboMax.Name = "comboMax";
            this.comboMax.Size = new System.Drawing.Size(121, 21);
            this.comboMax.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(14, 185);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(187, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SskNo
            // 
            this.SskNo.Location = new System.Drawing.Point(81, 64);
            this.SskNo.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.SskNo.Name = "SskNo";
            this.SskNo.Size = new System.Drawing.Size(120, 20);
            this.SskNo.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "SSKNO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Maaş";
            // 
            // Maas
            // 
            this.Maas.Location = new System.Drawing.Point(81, 101);
            this.Maas.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.Maas.Name = "Maas";
            this.Maas.Size = new System.Drawing.Size(120, 20);
            this.Maas.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Satış Adeti";
            // 
            // SatısAdeti
            // 
            this.SatısAdeti.Location = new System.Drawing.Point(81, 138);
            this.SatısAdeti.Name = "SatısAdeti";
            this.SatısAdeti.Size = new System.Drawing.Size(120, 20);
            this.SatısAdeti.TabIndex = 9;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(208, 248);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(187, 135);
            this.button2.TabIndex = 11;
            this.button2.Text = "Ekle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 412);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SatısAdeti);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Maas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SskNo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboMax);
            this.Controls.Add(this.LstBoxCalisan);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SskNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Maas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SatısAdeti)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox LstBoxCalisan;
        private System.Windows.Forms.ComboBox comboMax;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown SskNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown Maas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown SatısAdeti;
        private System.Windows.Forms.Button button2;
    }
}

