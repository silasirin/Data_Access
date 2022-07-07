namespace WFA_EF_OgrenciListesi
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
            this.kimBilirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ogrenciListesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kimBilirToolStripMenuItem,
            this.ogrenciListesiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(939, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // kimBilirToolStripMenuItem
            // 
            this.kimBilirToolStripMenuItem.Name = "kimBilirToolStripMenuItem";
            this.kimBilirToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.kimBilirToolStripMenuItem.Text = "Kim Bilir";
            this.kimBilirToolStripMenuItem.Click += new System.EventHandler(this.kimBilirToolStripMenuItem_Click);
            // 
            // ogrenciListesiToolStripMenuItem
            // 
            this.ogrenciListesiToolStripMenuItem.Name = "ogrenciListesiToolStripMenuItem";
            this.ogrenciListesiToolStripMenuItem.Size = new System.Drawing.Size(119, 24);
            this.ogrenciListesiToolStripMenuItem.Text = "Ogrenci Listesi";
            this.ogrenciListesiToolStripMenuItem.Click += new System.EventHandler(this.ogrenciListesiToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 503);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem kimBilirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ogrenciListesiToolStripMenuItem;
    }
}

