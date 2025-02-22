namespace DövizHesaplamaUygulaması
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnDolar = new System.Windows.Forms.Button();
            this.btnEuro = new System.Windows.Forms.Button();
            this.btnAltın = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDolar
            // 
            this.btnDolar.BackColor = System.Drawing.Color.SpringGreen;
            this.btnDolar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDolar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDolar.Location = new System.Drawing.Point(77, 261);
            this.btnDolar.Name = "btnDolar";
            this.btnDolar.Size = new System.Drawing.Size(160, 122);
            this.btnDolar.TabIndex = 0;
            this.btnDolar.Text = "Dolar";
            this.btnDolar.UseVisualStyleBackColor = false;
            this.btnDolar.Click += new System.EventHandler(this.btnDolar_Click);
            // 
            // btnEuro
            // 
            this.btnEuro.BackColor = System.Drawing.Color.MediumPurple;
            this.btnEuro.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEuro.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEuro.Location = new System.Drawing.Point(360, 261);
            this.btnEuro.Name = "btnEuro";
            this.btnEuro.Size = new System.Drawing.Size(160, 122);
            this.btnEuro.TabIndex = 1;
            this.btnEuro.Text = "Euro";
            this.btnEuro.UseVisualStyleBackColor = false;
            this.btnEuro.Click += new System.EventHandler(this.btnEuro_Click);
            // 
            // btnAltın
            // 
            this.btnAltın.BackColor = System.Drawing.Color.Gold;
            this.btnAltın.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAltın.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAltın.Location = new System.Drawing.Point(650, 261);
            this.btnAltın.Name = "btnAltın";
            this.btnAltın.Size = new System.Drawing.Size(160, 122);
            this.btnAltın.TabIndex = 2;
            this.btnAltın.Text = "Altın";
            this.btnAltın.UseVisualStyleBackColor = false;
            this.btnAltın.Click += new System.EventHandler(this.btnAltın_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(24, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(860, 50);
            this.label1.TabIndex = 3;
            this.label1.Text = "Lütfen Hesaplamak İstediğiniz Döviz Türünü Seçin";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(899, 585);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAltın);
            this.Controls.Add(this.btnEuro);
            this.Controls.Add(this.btnDolar);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Döviz Hesapla";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDolar;
        private System.Windows.Forms.Button btnEuro;
        private System.Windows.Forms.Button btnAltın;
        private System.Windows.Forms.Label label1;
    }
}

