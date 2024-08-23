using System.Net.Http.Headers;

namespace CodeFirst.Models
{
    public class Dish : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public int CategoryId { get; set; }
        public int ResturantId { get; set; }
        public int MeidaId { get; set; }
        public Category Category { get; set; }
        public Resturant Resturant { get; set; }
        public Media Photo { get; set; }

    }
}