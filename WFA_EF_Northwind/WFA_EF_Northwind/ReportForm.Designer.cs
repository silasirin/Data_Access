namespace WFA_EF_Northwind
{
    partial class ReportForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstKategori = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnPersonel = new System.Windows.Forms.Button();
            this.txtCalisanAdi = new System.Windows.Forms.TextBox();
            this.lstPersoneleGore = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lstCalisanlar = new System.Windows.Forms.ListBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnTarih = new System.Windows.Forms.Button();
            this.lstTariheGore = new System.Windows.Forms.ListBox();
            this.dateMin = new System.Windows.Forms.DateTimePicker();
            this.dateMax = new System.Windows.Forms.DateTimePicker();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.nudMaxFiyat = new System.Windows.Forms.NumericUpDown();
            this.nudMinFiyat = new System.Windows.Forms.NumericUpDown();
            this.lstFiyataGore = new System.Windows.Forms.ListBox();
            this.btnFiyat = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.lstSiparisler = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxFiyat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinFiyat)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstKategori);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(224, 275);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kategoriye Gore Urun Sayisi";
            // 
            // lstKategori
            // 
            this.lstKategori.FormattingEnabled = true;
            this.lstKategori.ItemHeight = 16;
            this.lstKategori.Location = new System.Drawing.Point(6, 30);
            this.lstKategori.Name = "lstKategori";
            this.lstKategori.Size = new System.Drawing.Size(202, 228);
            this.lstKategori.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnPersonel);
            this.groupBox2.Controls.Add(this.txtCalisanAdi);
            this.groupBox2.Controls.Add(this.lstPersoneleGore);
            this.groupBox2.Location = new System.Drawing.Point(274, 312);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(224, 340);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Personele Gore Siparisler";
            // 
            // btnPersonel
            // 
            this.btnPersonel.Location = new System.Drawing.Point(143, 49);
            this.btnPersonel.Name = "btnPersonel";
            this.btnPersonel.Size = new System.Drawing.Size(65, 23);
            this.btnPersonel.TabIndex = 2;
            this.btnPersonel.Text = "Listele";
            this.btnPersonel.UseVisualStyleBackColor = true;
            this.btnPersonel.Click += new System.EventHandler(this.btnPersonel_Click);
            // 
            // txtCalisanAdi
            // 
            this.txtCalisanAdi.Location = new System.Drawing.Point(6, 50);
            this.txtCalisanAdi.Name = "txtCalisanAdi";
            this.txtCalisanAdi.Size = new System.Drawing.Size(131, 22);
            this.txtCalisanAdi.TabIndex = 3;
            // 
            // lstPersoneleGore
            // 
            this.lstPersoneleGore.FormattingEnabled = true;
            this.lstPersoneleGore.ItemHeight = 16;
            this.lstPersoneleGore.Location = new System.Drawing.Point(6, 95);
            this.lstPersoneleGore.Name = "lstPersoneleGore";
            this.lstPersoneleGore.Size = new System.Drawing.Size(202, 228);
            this.lstPersoneleGore.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lstCalisanlar);
            this.groupBox3.Location = new System.Drawing.Point(544, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(224, 275);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ulkelere Gore Calisanlar";
            // 
            // lstCalisanlar
            // 
            this.lstCalisanlar.FormattingEnabled = true;
            this.lstCalisanlar.ItemHeight = 16;
            this.lstCalisanlar.Location = new System.Drawing.Point(6, 31);
            this.lstCalisanlar.Name = "lstCalisanlar";
            this.lstCalisanlar.Size = new System.Drawing.Size(202, 228);
            this.lstCalisanlar.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnTarih);
            this.groupBox4.Controls.Add(this.lstTariheGore);
            this.groupBox4.Controls.Add(this.dateMin);
            this.groupBox4.Controls.Add(this.dateMax);
            this.groupBox4.Location = new System.Drawing.Point(19, 312);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(224, 340);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Tarihe Gore Siparisler";
            // 
            // btnTarih
            // 
            this.btnTarih.Location = new System.Drawing.Point(139, 50);
            this.btnTarih.Name = "btnTarih";
            this.btnTarih.Size = new System.Drawing.Size(69, 23);
            this.btnTarih.TabIndex = 2;
            this.btnTarih.Text = "Listele";
            this.btnTarih.UseVisualStyleBackColor = true;
            this.btnTarih.Click += new System.EventHandler(this.btnTarih_Click);
            // 
            // lstTariheGore
            // 
            this.lstTariheGore.FormattingEnabled = true;
            this.lstTariheGore.ItemHeight = 16;
            this.lstTariheGore.Location = new System.Drawing.Point(6, 95);
            this.lstTariheGore.Name = "lstTariheGore";
            this.lstTariheGore.Size = new System.Drawing.Size(202, 228);
            this.lstTariheGore.TabIndex = 0;
            // 
            // dateMin
            // 
            this.dateMin.Location = new System.Drawing.Point(6, 34);
            this.dateMin.Name = "dateMin";
            this.dateMin.Size = new System.Drawing.Size(126, 22);
            this.dateMin.TabIndex = 1;
            // 
            // dateMax
            // 
            this.dateMax.Location = new System.Drawing.Point(6, 62);
            this.dateMax.Name = "dateMax";
            this.dateMax.Size = new System.Drawing.Size(126, 22);
            this.dateMax.TabIndex = 1;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.nudMaxFiyat);
            this.groupBox5.Controls.Add(this.nudMinFiyat);
            this.groupBox5.Controls.Add(this.lstFiyataGore);
            this.groupBox5.Controls.Add(this.btnFiyat);
            this.groupBox5.Location = new System.Drawing.Point(544, 312);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(224, 340);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Fiyata Gore Siparisler";
            // 
            // nudMaxFiyat
            // 
            this.nudMaxFiyat.Location = new System.Drawing.Point(12, 65);
            this.nudMaxFiyat.Name = "nudMaxFiyat";
            this.nudMaxFiyat.Size = new System.Drawing.Size(120, 22);
            this.nudMaxFiyat.TabIndex = 4;
            // 
            // nudMinFiyat
            // 
            this.nudMinFiyat.Location = new System.Drawing.Point(12, 37);
            this.nudMinFiyat.Name = "nudMinFiyat";
            this.nudMinFiyat.Size = new System.Drawing.Size(120, 22);
            this.nudMinFiyat.TabIndex = 4;
            // 
            // lstFiyataGore
            // 
            this.lstFiyataGore.FormattingEnabled = true;
            this.lstFiyataGore.ItemHeight = 16;
            this.lstFiyataGore.Location = new System.Drawing.Point(6, 95);
            this.lstFiyataGore.Name = "lstFiyataGore";
            this.lstFiyataGore.Size = new System.Drawing.Size(202, 228);
            this.lstFiyataGore.TabIndex = 0;
            // 
            // btnFiyat
            // 
            this.btnFiyat.Location = new System.Drawing.Point(138, 49);
            this.btnFiyat.Name = "btnFiyat";
            this.btnFiyat.Size = new System.Drawing.Size(70, 23);
            this.btnFiyat.TabIndex = 2;
            this.btnFiyat.Text = "Listele";
            this.btnFiyat.UseVisualStyleBackColor = true;
            this.btnFiyat.Click += new System.EventHandler(this.btnFiyat_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.lstSiparisler);
            this.groupBox6.Location = new System.Drawing.Point(274, 13);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(224, 275);
            this.groupBox6.TabIndex = 0;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Personele Gore Siparisler";
            // 
            // lstSiparisler
            // 
            this.lstSiparisler.FormattingEnabled = true;
            this.lstSiparisler.ItemHeight = 16;
            this.lstSiparisler.Location = new System.Drawing.Point(6, 30);
            this.lstSiparisler.Name = "lstSiparisler";
            this.lstSiparisler.Size = new System.Drawing.Size(202, 228);
            this.lstSiparisler.TabIndex = 0;
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 683);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ReportForm";
            this.Text = "ReportForm";
            this.Load += new System.EventHandler(this.ReportForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxFiyat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinFiyat)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lstKategori;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lstPersoneleGore;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox lstCalisanlar;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListBox lstTariheGore;
        private System.Windows.Forms.DateTimePicker dateMin;
        private System.Windows.Forms.DateTimePicker dateMax;
        private System.Windows.Forms.Button btnTarih;
        private System.Windows.Forms.Button btnPersonel;
        private System.Windows.Forms.TextBox txtCalisanAdi;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ListBox lstFiyataGore;
        private System.Windows.Forms.Button btnFiyat;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.ListBox lstSiparisler;
        private System.Windows.Forms.NumericUpDown nudMaxFiyat;
        private System.Windows.Forms.NumericUpDown nudMinFiyat;
    }
}