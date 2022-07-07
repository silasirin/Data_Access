namespace WinUI
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
            this.saloonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sessionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminPaneliToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salonlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kategorilerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filmlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seanslarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.haftalarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saloonToolStripMenuItem,
            this.categoriesToolStripMenuItem,
            this.sessionsToolStripMenuItem,
            this.adminPaneliToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // saloonToolStripMenuItem
            // 
            this.saloonToolStripMenuItem.Name = "saloonToolStripMenuItem";
            this.saloonToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.saloonToolStripMenuItem.Text = "Saloons";
            this.saloonToolStripMenuItem.Click += new System.EventHandler(this.saloonToolStripMenuItem_Click);
            // 
            // categoriesToolStripMenuItem
            // 
            this.categoriesToolStripMenuItem.Name = "categoriesToolStripMenuItem";
            this.categoriesToolStripMenuItem.Size = new System.Drawing.Size(94, 24);
            this.categoriesToolStripMenuItem.Text = "Categories";
            this.categoriesToolStripMenuItem.Click += new System.EventHandler(this.categoriesToolStripMenuItem_Click);
            // 
            // sessionsToolStripMenuItem
            // 
            this.sessionsToolStripMenuItem.Name = "sessionsToolStripMenuItem";
            this.sessionsToolStripMenuItem.Size = new System.Drawing.Size(78, 24);
            this.sessionsToolStripMenuItem.Text = "Sessions";
            this.sessionsToolStripMenuItem.Click += new System.EventHandler(this.sessionsToolStripMenuItem_Click);
            // 
            // adminPaneliToolStripMenuItem
            // 
            this.adminPaneliToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salonlarToolStripMenuItem,
            this.kategorilerToolStripMenuItem,
            this.filmlerToolStripMenuItem,
            this.seanslarToolStripMenuItem,
            this.haftalarToolStripMenuItem});
            this.adminPaneliToolStripMenuItem.Name = "adminPaneliToolStripMenuItem";
            this.adminPaneliToolStripMenuItem.Size = new System.Drawing.Size(106, 24);
            this.adminPaneliToolStripMenuItem.Text = "AdminPaneli";
            // 
            // salonlarToolStripMenuItem
            // 
            this.salonlarToolStripMenuItem.Name = "salonlarToolStripMenuItem";
            this.salonlarToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.salonlarToolStripMenuItem.Text = "Salonlar";
            this.salonlarToolStripMenuItem.Click += new System.EventHandler(this.salonlarToolStripMenuItem_Click);
            // 
            // kategorilerToolStripMenuItem
            // 
            this.kategorilerToolStripMenuItem.Name = "kategorilerToolStripMenuItem";
            this.kategorilerToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.kategorilerToolStripMenuItem.Text = "Kategoriler";
            this.kategorilerToolStripMenuItem.Click += new System.EventHandler(this.kategorilerToolStripMenuItem_Click);
            // 
            // filmlerToolStripMenuItem
            // 
            this.filmlerToolStripMenuItem.Name = "filmlerToolStripMenuItem";
            this.filmlerToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.filmlerToolStripMenuItem.Text = "Filmler";
            this.filmlerToolStripMenuItem.Click += new System.EventHandler(this.filmlerToolStripMenuItem_Click);
            // 
            // seanslarToolStripMenuItem
            // 
            this.seanslarToolStripMenuItem.Name = "seanslarToolStripMenuItem";
            this.seanslarToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.seanslarToolStripMenuItem.Text = "Seanslar";
            this.seanslarToolStripMenuItem.Click += new System.EventHandler(this.seanslarToolStripMenuItem_Click);
            // 
            // haftalarToolStripMenuItem
            // 
            this.haftalarToolStripMenuItem.Name = "haftalarToolStripMenuItem";
            this.haftalarToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.haftalarToolStripMenuItem.Text = "Haftalar";
            this.haftalarToolStripMenuItem.Click += new System.EventHandler(this.haftalarToolStripMenuItem_Click);
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
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem saloonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoriesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sessionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminPaneliToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salonlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kategorilerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filmlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seanslarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem haftalarToolStripMenuItem;
    }
}

