using System.Net.Sockets;
using System.Security.Cryptography.X509Certificates;

namespace CodeFirst.Models
{
    public class Resturant : BaseEntity
    {
        public string Name { get; set; }
        public TimeOnly OpenTime { get; set; }
        public TimeOnly CloseTime { get; set; }
        public Address Address {  get; set; } 
        public List<Dish> Dishes { get; set; }
        public List<Review> Reviews { get; set; } 
        public List<PhoneNumer> PhoneNumbers { get; set; }
        public int AddressId { get; set; }
    }
}