namespace WFA_EF_Northwind
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.kategoriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.urunToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.musteriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calisanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.siparisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tedarikciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nakliyeciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.raporlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kategoriToolStripMenuItem,
            this.urunToolStripMenuItem,
            this.musteriToolStripMenuItem,
            this.calisanToolStripMenuItem,
            this.siparisToolStripMenuItem,
            this.tedarikciToolStripMenuItem,
            this.nakliyeciToolStripMenuItem,
            this.raporlarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // kategoriToolStripMenuItem
            // 
            this.kategoriToolStripMenuItem.Name = "kategoriToolStripMenuItem";
            this.kategoriToolStripMenuItem.Size = new System.Drawing.Size(80, 24);
            this.kategoriToolStripMenuItem.Text = "Kategori";
            this.kategoriToolStripMenuItem.Click += new System.EventHandler(this.kategoriToolStripMenuItem_Click);
            // 
            // urunToolStripMenuItem
            // 
            this.urunToolStripMenuItem.Name = "urunToolStripMenuItem";
            this.urunToolStripMenuItem.Size = new System.Drawing.Size(54, 24);
            this.urunToolStripMenuItem.Text = "Urun";
            this.urunToolStripMenuItem.Click += new System.EventHandler(this.urunToolStripMenuItem_Click);
            // 
            // musteriToolStripMenuItem
            // 
            this.musteriToolStripMenuItem.Name = "musteriToolStripMenuItem";
            this.musteriToolStripMenuItem.Size = new System.Drawing.Size(72, 24);
            this.musteriToolStripMenuItem.Text = "Musteri";
            this.musteriToolStripMenuItem.Click += new System.EventHandler(this.musteriToolStripMenuItem_Click);
            // 
            // calisanToolStripMenuItem
            // 
            this.calisanToolStripMenuItem.Name = "calisanToolStripMenuItem";
            this.calisanToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.calisanToolStripMenuItem.Text = "Calisan";
            // 
            // siparisToolStripMenuItem
            // 
            this.siparisToolStripMenuItem.Name = "siparisToolStripMenuItem";
            this.siparisToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.siparisToolStripMenuItem.Text = "Siparis";
            this.siparisToolStripMenuItem.Click += new System.EventHandler(this.siparisToolStripMenuItem_Click);
            // 
            // tedarikciToolStripMenuItem
            // 
            this.tedarikciToolStripMenuItem.Name = "tedarikciToolStripMenuItem";
            this.tedarikciToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
            this.tedarikciToolStripMenuItem.Text = "Tedarikci";
            // 
            // nakliyeciToolStripMenuItem
            // 
            this.nakliyeciToolStripMenuItem.Name = "nakliyeciToolStripMenuItem";
            this.nakliyeciToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.nakliyeciToolStripMenuItem.Text = "Nakliyeci";
            // 
            // raporlarToolStripMenuItem
            // 
            this.raporlarToolStripMenuItem.Name = "raporlarToolStripMenuItem";
            this.raporlarToolStripMenuItem.Size = new System.Drawing.Size(80, 24);
            this.raporlarToolStripMenuItem.Text = "Raporlar";
            this.raporlarToolStripMenuItem.Click += new System.EventHandler(this.raporlarToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem kategoriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem urunToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem musteriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calisanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem siparisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tedarikciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nakliyeciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem raporlarToolStripMenuItem;
    }
}

