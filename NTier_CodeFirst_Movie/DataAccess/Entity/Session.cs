using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entity
{
    public class Session
    {
        public int SessionID { get; set; }
        public DateTime SessionTime { get; set; }
        public int Duration { get; set; }
    }
}
