using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_EF_OgrenciListesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void ChildForm(Form _childForm)
        {
            this.Width=_childForm.Width+30;
            this.Height=_childForm.Height+40;
            bool formAcikmi = false;

            foreach (Form form in this.MdiChildren)
            {
                if (form.Text==_childForm.Text)
                {
                    formAcikmi = true;
                    form.Activate();
                }
                else
                {
                    form.Close();
                }
            }
            if (formAcikmi==false)
            {
                _childForm.MdiParent = this;
                _childForm.StartPosition = FormStartPosition.Manual;
                _childForm.FormBorderStyle = FormBorderStyle.None;
                _childForm.Show();
            }
        }
        private void kimBilirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildForm(new KimBilir());
        }

        private void ogrenciListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildForm(new OgrenciListesi());
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
