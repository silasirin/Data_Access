using DataAccess.Context;
using DataAccess.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Service
{   
    public class MovieService
    {
        ProjectContext db = new ProjectContext();

        public string CreateMovie(Movie m)
        {
            try
            {
                db.Movies.Add(m);
                db.SaveChanges();
                return $"{m.MovieName} kaydedildi";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public List<Movie> MovieList()
        {
            return db.Movies.ToList();
        }

        public string UpdateMovie(Movie m)
        {
            try
            {
                db.Entry(m).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return "Guncelleme basarili!";

            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string DeleteMovie(int id)
        {
            try
            {
                Movie silinecek = db.Movies.Find(id);
                db.Movies.Remove(silinecek);
                db.SaveChanges();
                return "Silme islemi basarili";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
