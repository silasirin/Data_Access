using DataAccess.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinUI.Forms;

namespace WinUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        void ChildForm(Form _childForm)
        {
            this.Width = _childForm.Width + 22;
            this.Height = _childForm.Height + 68;
            bool durum = false;

            foreach (Form form in this.MdiChildren)
            {
                if (form.Text == _childForm.Text)
                {
                    durum = true;
                    form.Activate();
                }
                else
                {
                    form.Close();
                }
            }
            if (durum == false)
            {
                _childForm.MdiParent = this;
                _childForm.StartPosition = FormStartPosition.Manual;
                _childForm.FormBorderStyle = FormBorderStyle.None;
                _childForm.Show();
            }
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void saloonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildForm(new SaloonForm());
            
        }

        private void categoriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildForm(new CategoryForm());
        }

        private void sessionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildForm(new SessionForm());
        }

        private void salonlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildForm(new Salonlar());
        }

        private void kategorilerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildForm(new Kategoriler());
        }

        private void filmlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildForm(new Filmler());
        }

        private void seanslarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildForm(new Seanslar());
        }

        private void haftalarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildForm(new Haftalar());
        }
    }
}
