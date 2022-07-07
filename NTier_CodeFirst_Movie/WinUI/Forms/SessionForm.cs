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
    public partial class SessionForm : Form
    {
        public SessionForm()
        {
            InitializeComponent();
        }
        ProjectContext db = new ProjectContext();
        private void SessionForm_Load(object sender, EventArgs e)
        {
            var result = db.Theaters.Select(x => new
            {
                FilmAdi = x.Movie.MovieName,
                Saat = x.Session.SessionTime,
                SalonAdi= x.Saloon.SaloonName
            }).ToList();
            dataGridView1.DataSource = result;
        }
    }
}
