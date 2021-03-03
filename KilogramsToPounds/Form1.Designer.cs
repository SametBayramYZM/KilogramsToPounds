
namespace KilogramsToPounds
{
    partial class KilogramsToPounds
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbKilograms = new System.Windows.Forms.Label();
            this.btnConvert = new System.Windows.Forms.Button();
            this.tbKilograms = new System.Windows.Forms.TextBox();
            this.lbPounds = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pounds :";
            // 
            // lbKilograms
            // 
            this.lbKilograms.AutoSize = true;
            this.lbKilograms.Location = new System.Drawing.Point(12, 100);
            this.lbKilograms.Name = "lbKilograms";
            this.lbKilograms.Size = new System.Drawing.Size(58, 13);
            this.lbKilograms.TabIndex = 1;
            this.lbKilograms.Text = "Kilograms :";
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(148, 202);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(75, 23);
            this.btnConvert.TabIndex = 2;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // tbKilograms
            // 
            this.tbKilograms.Location = new System.Drawing.Point(100, 97);
            this.tbKilograms.Name = "tbKilograms";
            this.tbKilograms.Size = new System.Drawing.Size(123, 20);
            this.tbKilograms.TabIndex = 3;
            // 
            // lbPounds
            // 
            this.lbPounds.AutoSize = true;
            this.lbPounds.Location = new System.Drawing.Point(97, 150);
            this.lbPounds.Name = "lbPounds";
            this.lbPounds.Size = new System.Drawing.Size(0, 13);
            this.lbPounds.TabIndex = 4;
            // 
            // KilogramsToPounds
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 286);
            this.Controls.Add(this.lbPounds);
            this.Controls.Add(this.tbKilograms);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.lbKilograms);
            this.Controls.Add(this.label1);
            this.Name = "KilogramsToPounds";
            this.Text = "KilogramsToPounds";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbKilograms;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.TextBox tbKilograms;
        private System.Windows.Forms.Label lbPounds;
    }
}

