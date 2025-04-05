using CarBooking.Enums;
using Microsoft.OpenApi.Extensions;

namespace CarBooking.Models
{
    public class CarVm
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }  
        public string Img { get; set; }
        public string Transmission { get; set; }  
        public int Spaces { get; set; }
        public decimal Price { get; set; }

        public CarVm(Car car)
        {
            Id = car.Id;
            Name = car.Name;
            Category = car.Category.GetDisplayName(); 
            Img = car.Img;
            Transmission = car.Transmission.GetDisplayName();  
            Spaces = car.Spaces;
            Price = car.Price;
        }
    }
}
