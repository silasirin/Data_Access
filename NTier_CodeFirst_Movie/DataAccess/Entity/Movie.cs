using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entity
{
    public class Movie
    {
        public int MovieID { get; set; }
        public string MovieName { get; set; }

        //Bir movie'nin birden fazla kategorisi olur
        public List<Category> Categories { get; set; }
    }
}
