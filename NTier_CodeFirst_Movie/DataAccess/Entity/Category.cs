using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entity
{
    public class Category
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }

        //Bir kategorinin birden fazla filmi olur
        public List<Movie> Movies { get; set; }
    }
}
