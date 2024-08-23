namespace CodeFirst.Models
{
    public class Review : BaseEntity
    {
        public string Comment {  get; set; }
        public int UserId {  get; set; }
        public int ResturantId {  get; set; } 
        public User User { get; set; }
        public Resturant Resturant { get; set; }
    }
}