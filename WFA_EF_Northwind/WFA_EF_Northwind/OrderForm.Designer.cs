namespace WFA_EF_Northwind
{
    partial class OrderForm
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
            this.rbAsc = new System.Windows.Forms.RadioButton();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.rbDesc = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // rbAsc
            // 
            this.rbAsc.AutoSize = true;
            this.rbAsc.Location = new System.Drawing.Point(164, 58);
            this.rbAsc.Name = "rbAsc";
            this.rbAsc.Size = new System.Drawing.Size(96, 20);
            this.rbAsc.TabIndex = 21;
            this.rbAsc.TabStop = true;
            this.rbAsc.Text = "Sort by Asc";
            this.rbAsc.UseVisualStyleBackColor = true;
            this.rbAsc.CheckedChanged += new System.EventHandler(this.rbAsc_CheckedChanged);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(65, 97);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(678, 429);
            this.listView1.TabIndex = 20;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Order ID";
            this.columnHeader1.Width = 290;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Order Date";
            this.columnHeader2.Width = 351;
            // 
            // rbDesc
            // 
            this.rbDesc.AutoSize = true;
            this.rbDesc.Location = new System.Drawing.Point(456, 58);
            this.rbDesc.Name = "rbDesc";
            this.rbDesc.Size = new System.Drawing.Size(105, 20);
            this.rbDesc.TabIndex = 22;
            this.rbDesc.TabStop = true;
            this.rbDesc.Text = "Sort by Desc";
            this.rbDesc.UseVisualStyleBackColor = true;
            this.rbDesc.CheckedChanged += new System.EventHandler(this.rbDesc_CheckedChanged);
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 577);
            this.Controls.Add(this.rbDesc);
            this.Controls.Add(this.rbAsc);
            this.Controls.Add(this.listView1);
            this.Name = "OrderForm";
            this.Text = "OrderForm";
            this.Load += new System.EventHandler(this.OrderForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbAsc;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.RadioButton rbDesc;
    }
}