using DataAccess.Context;
using DataAccess.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinUI.Forms
{
    public partial class CategoryForm : Form
    {
        public CategoryForm()
        {
            InitializeComponent();
        }
        ProjectContext db = new ProjectContext();
        private void CategoryForm_Load(object sender, EventArgs e)
        {
            //AYNI TABLODA KATEGORILERI VE FILM ADLARINI LISTELEME:
            int id = 1;
            //var result = db.Categories.Where(c => c.Movies.Any(x => x.MovieID == id)).ToList();
            var result = db.Categories.Where(c => c.CategoryID == id).SelectMany(c => c.Movies).ToList();

            dataGridView1.DataSource = result;
        }
    }
}
