
namespace KutuphaneOtomasyonWinForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.adGiristxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.sifreGiristxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.personelGirisbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // adGiristxt
            // 
            this.adGiristxt.Location = new System.Drawing.Point(397, 184);
            this.adGiristxt.Name = "adGiristxt";
            this.adGiristxt.Size = new System.Drawing.Size(215, 20);
            this.adGiristxt.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(317, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Personel Adı";
            // 
            // sifreGiristxt
            // 
            this.sifreGiristxt.Location = new System.Drawing.Point(397, 247);
            this.sifreGiristxt.Name = "sifreGiristxt";
            this.sifreGiristxt.Size = new System.Drawing.Size(215, 20);
            this.sifreGiristxt.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(317, 254);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Şifre";
            // 
            // personelGirisbtn
            // 
            this.personelGirisbtn.Location = new System.Drawing.Point(463, 295);
            this.personelGirisbtn.Name = "personelGirisbtn";
            this.personelGirisbtn.Size = new System.Drawing.Size(75, 23);
            this.personelGirisbtn.TabIndex = 4;
            this.personelGirisbtn.Text = "Giriş";
            this.personelGirisbtn.UseVisualStyleBackColor = true;
            this.personelGirisbtn.Click += new System.EventHandler(this.personelGirisbtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 548);
            this.Controls.Add(this.personelGirisbtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sifreGiristxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.adGiristxt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox adGiristxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox sifreGiristxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button personelGirisbtn;
    }
}

