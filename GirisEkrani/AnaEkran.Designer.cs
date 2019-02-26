namespace GirisEkrani
{
    partial class AnaEkran
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaEkran));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Hane_Adres = new System.Windows.Forms.Button();
            this.Tüm_Kisiler = new System.Windows.Forms.Button();
            this.Yönetici = new System.Windows.Forms.Button();
            this.Nufus = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(664, 100);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(40, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 94);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(191, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(457, 65);
            this.label1.TabIndex = 0;
            this.label1.Text = "Muhtarlık Bilgi Sistemi";
            // 
            // Hane_Adres
            // 
            this.Hane_Adres.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Hane_Adres.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Hane_Adres.ImageKey = "(none)";
            this.Hane_Adres.Location = new System.Drawing.Point(12, 176);
            this.Hane_Adres.Name = "Hane_Adres";
            this.Hane_Adres.Size = new System.Drawing.Size(109, 52);
            this.Hane_Adres.TabIndex = 1;
            this.Hane_Adres.Text = "Hane Bilgisi ve Adres";
            this.Hane_Adres.UseVisualStyleBackColor = true;
            this.Hane_Adres.Click += new System.EventHandler(this.Hane_Adres_Click);
            // 
            // Tüm_Kisiler
            // 
            this.Tüm_Kisiler.Location = new System.Drawing.Point(382, 176);
            this.Tüm_Kisiler.Name = "Tüm_Kisiler";
            this.Tüm_Kisiler.Size = new System.Drawing.Size(109, 52);
            this.Tüm_Kisiler.TabIndex = 2;
            this.Tüm_Kisiler.Text = "Tüm Kişiler";
            this.Tüm_Kisiler.UseVisualStyleBackColor = true;
            // 
            // Yönetici
            // 
            this.Yönetici.Location = new System.Drawing.Point(567, 176);
            this.Yönetici.Name = "Yönetici";
            this.Yönetici.Size = new System.Drawing.Size(109, 52);
            this.Yönetici.TabIndex = 3;
            this.Yönetici.Text = "Yönetici (Kullanıcı)";
            this.Yönetici.UseVisualStyleBackColor = true;
            // 
            // Nufus
            // 
            this.Nufus.Location = new System.Drawing.Point(197, 176);
            this.Nufus.Name = "Nufus";
            this.Nufus.Size = new System.Drawing.Size(109, 52);
            this.Nufus.TabIndex = 4;
            this.Nufus.Text = "Nüfus Bilgisi";
            this.Nufus.UseVisualStyleBackColor = true;
            this.Nufus.Click += new System.EventHandler(this.Nufus_Click);
            // 
            // AnaEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(679, 261);
            this.Controls.Add(this.Nufus);
            this.Controls.Add(this.Yönetici);
            this.Controls.Add(this.Tüm_Kisiler);
            this.Controls.Add(this.Hane_Adres);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AnaEkran";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Muhtarlık Bilgi Sistemi";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Hane_Adres;
        private System.Windows.Forms.Button Tüm_Kisiler;
        private System.Windows.Forms.Button Yönetici;
        private System.Windows.Forms.Button Nufus;
    }
}