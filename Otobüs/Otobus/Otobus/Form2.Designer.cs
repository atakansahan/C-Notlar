namespace OtobusBilet
{
    partial class YolcuForm
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
            this.KoltukNoLBL = new System.Windows.Forms.Label();
            this.adSoyadLBL = new System.Windows.Forms.Label();
            this.KoltukNoTBOX = new System.Windows.Forms.TextBox();
            this.adSoyadTBOX = new System.Windows.Forms.TextBox();
            this.kaydetBTN = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // KoltukNoLBL
            // 
            this.KoltukNoLBL.AutoSize = true;
            this.KoltukNoLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KoltukNoLBL.Location = new System.Drawing.Point(24, 19);
            this.KoltukNoLBL.Name = "KoltukNoLBL";
            this.KoltukNoLBL.Size = new System.Drawing.Size(106, 24);
            this.KoltukNoLBL.TabIndex = 0;
            this.KoltukNoLBL.Text = "Koltuk No:";
            // 
            // adSoyadLBL
            // 
            this.adSoyadLBL.AutoSize = true;
            this.adSoyadLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.adSoyadLBL.Location = new System.Drawing.Point(24, 64);
            this.adSoyadLBL.Name = "adSoyadLBL";
            this.adSoyadLBL.Size = new System.Drawing.Size(111, 24);
            this.adSoyadLBL.TabIndex = 1;
            this.adSoyadLBL.Text = "Ad Soyadı:";
            // 
            // KoltukNoTBOX
            // 
            this.KoltukNoTBOX.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.KoltukNoTBOX.Location = new System.Drawing.Point(141, 12);
            this.KoltukNoTBOX.Multiline = true;
            this.KoltukNoTBOX.Name = "KoltukNoTBOX";
            this.KoltukNoTBOX.ReadOnly = true;
            this.KoltukNoTBOX.Size = new System.Drawing.Size(69, 31);
            this.KoltukNoTBOX.TabIndex = 2;
            this.KoltukNoTBOX.TabStop = false;
            this.KoltukNoTBOX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // adSoyadTBOX
            // 
            this.adSoyadTBOX.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.adSoyadTBOX.Location = new System.Drawing.Point(141, 53);
            this.adSoyadTBOX.Multiline = true;
            this.adSoyadTBOX.Name = "adSoyadTBOX";
            this.adSoyadTBOX.Size = new System.Drawing.Size(327, 35);
            this.adSoyadTBOX.TabIndex = 3;
            // 
            // kaydetBTN
            // 
            this.kaydetBTN.Location = new System.Drawing.Point(484, 19);
            this.kaydetBTN.Name = "kaydetBTN";
            this.kaydetBTN.Size = new System.Drawing.Size(111, 69);
            this.kaydetBTN.TabIndex = 4;
            this.kaydetBTN.Text = "Kaydet";
            this.kaydetBTN.UseVisualStyleBackColor = true;
            this.kaydetBTN.Click += new System.EventHandler(this.kaydetBTN_Click);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 24;
            this.listBox1.Location = new System.Drawing.Point(28, 94);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(567, 124);
            this.listBox1.TabIndex = 5;
            // 
            // YolcuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Salmon;
            this.ClientSize = new System.Drawing.Size(607, 224);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.kaydetBTN);
            this.Controls.Add(this.adSoyadTBOX);
            this.Controls.Add(this.KoltukNoTBOX);
            this.Controls.Add(this.adSoyadLBL);
            this.Controls.Add(this.KoltukNoLBL);
            this.Name = "YolcuForm";
            this.Text = "YolcuForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label KoltukNoLBL;
        private System.Windows.Forms.Label adSoyadLBL;
        private System.Windows.Forms.Button kaydetBTN;
        public System.Windows.Forms.TextBox KoltukNoTBOX;
        private System.Windows.Forms.ListBox listBox1;
        public System.Windows.Forms.TextBox adSoyadTBOX;
    }
}