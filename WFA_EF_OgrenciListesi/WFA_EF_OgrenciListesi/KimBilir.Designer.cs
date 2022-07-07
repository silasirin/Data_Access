namespace WFA_EF_OgrenciListesi
{
    partial class KimBilir
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnEslestir = new System.Windows.Forms.Button();
            this.lstDersListesi = new System.Windows.Forms.ListBox();
            this.lstSinifListesi = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(581, 25);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(482, 340);
            this.listView1.TabIndex = 11;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Ogrenci Adi";
            this.columnHeader1.Width = 184;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Konu Adi";
            this.columnHeader2.Width = 193;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Puan";
            this.columnHeader3.Width = 97;
            // 
            // btnEslestir
            // 
            this.btnEslestir.Location = new System.Drawing.Point(276, 392);
            this.btnEslestir.Margin = new System.Windows.Forms.Padding(4);
            this.btnEslestir.Name = "btnEslestir";
            this.btnEslestir.Size = new System.Drawing.Size(120, 39);
            this.btnEslestir.TabIndex = 10;
            this.btnEslestir.Text = "Eslestir";
            this.btnEslestir.UseVisualStyleBackColor = true;
            this.btnEslestir.Click += new System.EventHandler(this.btnEslestir_Click);
            // 
            // lstDersListesi
            // 
            this.lstDersListesi.FormattingEnabled = true;
            this.lstDersListesi.ItemHeight = 16;
            this.lstDersListesi.Location = new System.Drawing.Point(292, 26);
            this.lstDersListesi.Margin = new System.Windows.Forms.Padding(4);
            this.lstDersListesi.Name = "lstDersListesi";
            this.lstDersListesi.Size = new System.Drawing.Size(257, 340);
            this.lstDersListesi.TabIndex = 8;
            // 
            // lstSinifListesi
            // 
            this.lstSinifListesi.FormattingEnabled = true;
            this.lstSinifListesi.ItemHeight = 16;
            this.lstSinifListesi.Location = new System.Drawing.Point(41, 26);
            this.lstSinifListesi.Margin = new System.Windows.Forms.Padding(4);
            this.lstSinifListesi.Name = "lstSinifListesi";
            this.lstSinifListesi.Size = new System.Drawing.Size(243, 340);
            this.lstSinifListesi.TabIndex = 9;
            this.lstSinifListesi.SelectedIndexChanged += new System.EventHandler(this.lstSinifListesi_SelectedIndexChanged);
            // 
            // KimBilir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 450);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnEslestir);
            this.Controls.Add(this.lstDersListesi);
            this.Controls.Add(this.lstSinifListesi);
            this.Name = "KimBilir";
            this.Text = "KimBilir";
            this.Load += new System.EventHandler(this.KimBilir_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button btnEslestir;
        private System.Windows.Forms.ListBox lstDersListesi;
        private System.Windows.Forms.ListBox lstSinifListesi;
    }
}