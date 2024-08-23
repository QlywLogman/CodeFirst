namespace CodeFirst.Models
{
    public class PhoneNumer : BaseEntity
    {
        public string Number { get; set; }
        public int ResturantId { get; set; }
        public Resturant Resturant { get; set; }
    }
}