namespace HelloWord_WinForms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.AdTxtb = new System.Windows.Forms.TextBox();
            this.SifreTxtb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.KaydetBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AdTxtb
            // 
            this.AdTxtb.Location = new System.Drawing.Point(75, 48);
            this.AdTxtb.Name = "AdTxtb";
            this.AdTxtb.Size = new System.Drawing.Size(100, 20);
            this.AdTxtb.TabIndex = 1;
            // 
            // SifreTxtb
            // 
            this.SifreTxtb.Location = new System.Drawing.Point(75, 104);
            this.SifreTxtb.Name = "SifreTxtb";
            this.SifreTxtb.Size = new System.Drawing.Size(100, 20);
            this.SifreTxtb.TabIndex = 1;
            this.SifreTxtb.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ad Soyad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Black", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sifre";
            // 
            // KaydetBtn
            // 
            this.KaydetBtn.BackgroundImage = global::HelloWord_WinForms.Properties.Resources._1481124099_check;
            this.KaydetBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.KaydetBtn.Location = new System.Drawing.Point(104, 154);
            this.KaydetBtn.Name = "KaydetBtn";
            this.KaydetBtn.Size = new System.Drawing.Size(39, 37);
            this.KaydetBtn.TabIndex = 0;
            this.KaydetBtn.UseVisualStyleBackColor = true;
            this.KaydetBtn.Click += new System.EventHandler(this.KaydetBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(239, 252);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SifreTxtb);
            this.Controls.Add(this.AdTxtb);
            this.Controls.Add(this.KaydetBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "İlk Uygulama";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button KaydetBtn;
        private System.Windows.Forms.TextBox AdTxtb;
        private System.Windows.Forms.TextBox SifreTxtb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

