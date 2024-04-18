namespace password_storage_app
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
            this.şifre_giriş = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.şifre_isim_ver = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.onay_mesajı_label = new System.Windows.Forms.Label();
            this.kaydet_button = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.şifre_cıkısı = new System.Windows.Forms.Label();
            this.şifre_ismi_cıkısı = new System.Windows.Forms.Label();
            this.ara_button = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.şifre_ismi_arama = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tüm_şifreleri_göster_button = new System.Windows.Forms.Button();
            this.tüm_şifreleri_göster = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Şifre\'ne İsim Ver - Name Your Password";
            // 
            // şifre_giriş
            // 
            this.şifre_giriş.Location = new System.Drawing.Point(32, 107);
            this.şifre_giriş.Name = "şifre_giriş";
            this.şifre_giriş.Size = new System.Drawing.Size(248, 22);
            this.şifre_giriş.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Şifreni Gir - Enter your password";
            // 
            // şifre_isim_ver
            // 
            this.şifre_isim_ver.Location = new System.Drawing.Point(32, 63);
            this.şifre_isim_ver.Name = "şifre_isim_ver";
            this.şifre_isim_ver.Size = new System.Drawing.Size(248, 22);
            this.şifre_isim_ver.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.onay_mesajı_label);
            this.panel1.Controls.Add(this.kaydet_button);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.şifre_giriş);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.şifre_isim_ver);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(311, 227);
            this.panel1.TabIndex = 5;
            // 
            // onay_mesajı_label
            // 
            this.onay_mesajı_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.onay_mesajı_label.Location = new System.Drawing.Point(15, 170);
            this.onay_mesajı_label.Name = "onay_mesajı_label";
            this.onay_mesajı_label.Size = new System.Drawing.Size(265, 37);
            this.onay_mesajı_label.TabIndex = 5;
            this.onay_mesajı_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // kaydet_button
            // 
            this.kaydet_button.Location = new System.Drawing.Point(69, 135);
            this.kaydet_button.Name = "kaydet_button";
            this.kaydet_button.Size = new System.Drawing.Size(157, 23);
            this.kaydet_button.TabIndex = 4;
            this.kaydet_button.Text = "Kaydet";
            this.kaydet_button.UseVisualStyleBackColor = true;
            this.kaydet_button.Click += new System.EventHandler(this.kaydet_button_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(68, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "Şifre Kayıt";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.şifre_cıkısı);
            this.panel2.Controls.Add(this.şifre_ismi_cıkısı);
            this.panel2.Controls.Add(this.ara_button);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.şifre_ismi_arama);
            this.panel2.Location = new System.Drawing.Point(361, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(308, 227);
            this.panel2.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(87, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "Şifre Arama";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // şifre_cıkısı
            // 
            this.şifre_cıkısı.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.şifre_cıkısı.Location = new System.Drawing.Point(24, 176);
            this.şifre_cıkısı.Name = "şifre_cıkısı";
            this.şifre_cıkısı.Size = new System.Drawing.Size(275, 23);
            this.şifre_cıkısı.TabIndex = 6;
            this.şifre_cıkısı.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // şifre_ismi_cıkısı
            // 
            this.şifre_ismi_cıkısı.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.şifre_ismi_cıkısı.Location = new System.Drawing.Point(24, 133);
            this.şifre_ismi_cıkısı.Name = "şifre_ismi_cıkısı";
            this.şifre_ismi_cıkısı.Size = new System.Drawing.Size(275, 23);
            this.şifre_ismi_cıkısı.TabIndex = 5;
            this.şifre_ismi_cıkısı.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ara_button
            // 
            this.ara_button.Location = new System.Drawing.Point(91, 106);
            this.ara_button.Name = "ara_button";
            this.ara_button.Size = new System.Drawing.Size(157, 23);
            this.ara_button.TabIndex = 4;
            this.ara_button.Text = "Ara";
            this.ara_button.UseVisualStyleBackColor = true;
            this.ara_button.Click += new System.EventHandler(this.ara_button_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(81, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(167, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Şifre İsmi - password name";
            // 
            // şifre_ismi_arama
            // 
            this.şifre_ismi_arama.Location = new System.Drawing.Point(42, 72);
            this.şifre_ismi_arama.Name = "şifre_ismi_arama";
            this.şifre_ismi_arama.Size = new System.Drawing.Size(241, 22);
            this.şifre_ismi_arama.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gainsboro;
            this.panel3.Controls.Add(this.tüm_şifreleri_göster);
            this.panel3.Controls.Add(this.tüm_şifreleri_göster_button);
            this.panel3.Location = new System.Drawing.Point(12, 259);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(659, 296);
            this.panel3.TabIndex = 8;
            // 
            // tüm_şifreleri_göster_button
            // 
            this.tüm_şifreleri_göster_button.Location = new System.Drawing.Point(18, 14);
            this.tüm_şifreleri_göster_button.Name = "tüm_şifreleri_göster_button";
            this.tüm_şifreleri_göster_button.Size = new System.Drawing.Size(630, 46);
            this.tüm_şifreleri_göster_button.TabIndex = 0;
            this.tüm_şifreleri_göster_button.Text = "Tüm Şifreleri Göster";
            this.tüm_şifreleri_göster_button.UseVisualStyleBackColor = true;
            this.tüm_şifreleri_göster_button.Click += new System.EventHandler(this.tüm_şifreleri_göster_button_Click);
            // 
            // tüm_şifreleri_göster
            // 
            this.tüm_şifreleri_göster.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tüm_şifreleri_göster.Location = new System.Drawing.Point(17, 57);
            this.tüm_şifreleri_göster.Name = "tüm_şifreleri_göster";
            this.tüm_şifreleri_göster.Size = new System.Drawing.Size(642, 233);
            this.tüm_şifreleri_göster.TabIndex = 8;
            this.tüm_şifreleri_göster.Click += new System.EventHandler(this.label6_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 558);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Password Storage App";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox şifre_giriş;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox şifre_isim_ver;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label onay_mesajı_label;
        private System.Windows.Forms.Button kaydet_button;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label şifre_ismi_cıkısı;
        private System.Windows.Forms.Button ara_button;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox şifre_ismi_arama;
        private System.Windows.Forms.Label şifre_cıkısı;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label tüm_şifreleri_göster;
        private System.Windows.Forms.Button tüm_şifreleri_göster_button;
    }
}

