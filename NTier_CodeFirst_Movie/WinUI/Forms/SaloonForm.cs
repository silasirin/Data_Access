using DataAccess.Context;
using DataAccess.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinUI.Forms
{
    public partial class SaloonForm : Form
    {
        public SaloonForm()
        {
            InitializeComponent();
        }
        ProjectContext db = new ProjectContext();
        private void SaloonForm_Load(object sender, EventArgs e)
        {
            var result = db.Theaters.Select(x => new
            {
                SalonAdi = x.Saloon.SaloonName,
                FilmAdi = x.Movie.MovieName
            }).ToList();
            dataGridView1.DataSource = result;
        }
    }
}
