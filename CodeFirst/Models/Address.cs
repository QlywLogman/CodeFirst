namespace CodeFirst.Models
{
    public class Address : BaseEntity
    { 
        public string City {  get; set; }
        public string Country { get; set; }
        public string Street { get; set; }
        public Resturant Resturant { get; set; }
    }
}