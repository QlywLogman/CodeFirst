using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst.Models
{
    public class Fovarite
    {
        public int UserID { get; set; }
        public int ResturantID {  get; set; }
        public User User { get; set; }
        public Resturant Resturant { get; set; }

    }
}
