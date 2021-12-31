
namespace SifrelemeOdevi
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
            this.rbSha256 = new System.Windows.Forms.RadioButton();
            this.rbSpn = new System.Windows.Forms.RadioButton();
            this.txtGirilenDeger = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOrijinalHali = new System.Windows.Forms.TextBox();
            this.txtSifrelenmisHali = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSifrele = new System.Windows.Forms.Button();
            this.btnGeriDonustur = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSecurityKey = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(723, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Şifreleme Tipi :";
            // 
            // rbSha256
            // 
            this.rbSha256.AutoSize = true;
            this.rbSha256.Location = new System.Drawing.Point(739, 72);
            this.rbSha256.Name = "rbSha256";
            this.rbSha256.Size = new System.Drawing.Size(86, 21);
            this.rbSha256.TabIndex = 1;
            this.rbSha256.Text = "SHA-256";
            this.rbSha256.UseVisualStyleBackColor = true;
            // 
            // rbSpn
            // 
            this.rbSpn.AutoSize = true;
            this.rbSpn.Checked = true;
            this.rbSpn.Location = new System.Drawing.Point(739, 128);
            this.rbSpn.Name = "rbSpn";
            this.rbSpn.Size = new System.Drawing.Size(57, 21);
            this.rbSpn.TabIndex = 2;
            this.rbSpn.TabStop = true;
            this.rbSpn.Text = "SPN";
            this.rbSpn.UseVisualStyleBackColor = true;
            // 
            // txtGirilenDeger
            // 
            this.txtGirilenDeger.Location = new System.Drawing.Point(316, 78);
            this.txtGirilenDeger.Name = "txtGirilenDeger";
            this.txtGirilenDeger.Size = new System.Drawing.Size(280, 22);
            this.txtGirilenDeger.TabIndex = 3;
            this.txtGirilenDeger.Enter += new System.EventHandler(this.txtGirilenDeger_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(39, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(221, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Girmek İstediğiniz Şifre :";
            // 
            // txtOrijinalHali
            // 
            this.txtOrijinalHali.Location = new System.Drawing.Point(42, 205);
            this.txtOrijinalHali.Multiline = true;
            this.txtOrijinalHali.Name = "txtOrijinalHali";
            this.txtOrijinalHali.Size = new System.Drawing.Size(347, 223);
            this.txtOrijinalHali.TabIndex = 5;
            // 
            // txtSifrelenmisHali
            // 
            this.txtSifrelenmisHali.Location = new System.Drawing.Point(507, 204);
            this.txtSifrelenmisHali.Multiline = true;
            this.txtSifrelenmisHali.Name = "txtSifrelenmisHali";
            this.txtSifrelenmisHali.Size = new System.Drawing.Size(347, 223);
            this.txtSifrelenmisHali.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(39, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(286, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Şifrenin Çözülmüş/Orijinal Hali :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(504, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Şifrelenmiş Hali :";
            // 
            // btnSifrele
            // 
            this.btnSifrele.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSifrele.Location = new System.Drawing.Point(133, 454);
            this.btnSifrele.Name = "btnSifrele";
            this.btnSifrele.Size = new System.Drawing.Size(256, 58);
            this.btnSifrele.TabIndex = 9;
            this.btnSifrele.Text = "Şifrele";
            this.btnSifrele.UseVisualStyleBackColor = true;
            this.btnSifrele.Click += new System.EventHandler(this.btnSifrele_Click);
            // 
            // btnGeriDonustur
            // 
            this.btnGeriDonustur.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGeriDonustur.Location = new System.Drawing.Point(507, 454);
            this.btnGeriDonustur.Name = "btnGeriDonustur";
            this.btnGeriDonustur.Size = new System.Drawing.Size(256, 58);
            this.btnGeriDonustur.TabIndex = 10;
            this.btnGeriDonustur.Text = "Şifreyi Geri Dönüştür";
            this.btnGeriDonustur.UseVisualStyleBackColor = true;
            this.btnGeriDonustur.Click += new System.EventHandler(this.btnGeriDonustur_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(957, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "Security Key :";
            // 
            // txtSecurityKey
            // 
            this.txtSecurityKey.Location = new System.Drawing.Point(949, 60);
            this.txtSecurityKey.Name = "txtSecurityKey";
            this.txtSecurityKey.Size = new System.Drawing.Size(142, 22);
            this.txtSecurityKey.TabIndex = 12;
            this.txtSecurityKey.Text = "security";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1285, 560);
            this.Controls.Add(this.txtSecurityKey);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnGeriDonustur);
            this.Controls.Add(this.btnSifrele);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSifrelenmisHali);
            this.Controls.Add(this.txtOrijinalHali);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtGirilenDeger);
            this.Controls.Add(this.rbSpn);
            this.Controls.Add(this.rbSha256);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbSha256;
        private System.Windows.Forms.RadioButton rbSpn;
        private System.Windows.Forms.TextBox txtGirilenDeger;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOrijinalHali;
        private System.Windows.Forms.TextBox txtSifrelenmisHali;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSifrele;
        private System.Windows.Forms.Button btnGeriDonustur;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSecurityKey;
    }
}

