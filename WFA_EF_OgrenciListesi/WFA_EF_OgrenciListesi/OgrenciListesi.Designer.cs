namespace WFA_EF_OgrenciListesi
{
    partial class OgrenciListesi
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
            this.btnEslestir = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEslestir
            // 
            this.btnEslestir.Location = new System.Drawing.Point(39, 162);
            this.btnEslestir.Margin = new System.Windows.Forms.Padding(4);
            this.btnEslestir.Name = "btnEslestir";
            this.btnEslestir.Size = new System.Drawing.Size(120, 39);
            this.btnEslestir.TabIndex = 6;
            this.btnEslestir.Text = "Gozat";
            this.btnEslestir.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(171, 143);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // OgrenciListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnEslestir);
            this.Name = "OgrenciListesi";
            this.Text = "OgrenciListesi";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnEslestir;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}