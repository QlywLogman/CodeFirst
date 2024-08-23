using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst.Models
{
    public class Category : BaseEntity
    {
        public string Name { get; set; }
        public List<Dish> Dishes { get; set; }
    }
}
