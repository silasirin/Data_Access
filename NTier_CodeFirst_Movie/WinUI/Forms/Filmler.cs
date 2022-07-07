using BLL.Service;
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
    public partial class Filmler : Form
    {
        public Filmler()
        {
            InitializeComponent();
        }
        ProjectContext db=new ProjectContext();
        Movie movie = new Movie();
        MovieService movieService = new MovieService();
        private void btnList_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            List<Movie> movies = db.Movies.ToList();
            foreach (Movie movie in movies)
            {
                listBox1.Items.Add(movie.MovieID +" "+movie.MovieName);
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            movie.MovieName = textBox1.Text;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (textBox1.Text!="")
            {
                
                movie.MovieName = textBox1.Text;
                string result = movieService.CreateMovie(movie);
                listBox1.Items.Add(result);
                db.SaveChanges();
            }
            else
            {
                MessageBox.Show("Film adi giriniz!");
            }
            
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            string result = movieService.DeleteMovie(movie.MovieID);
            MessageBox.Show(result);
            db.SaveChanges();
        }

        private void Filmler_Load(object sender, EventArgs e)
        {

        }
    }
}
