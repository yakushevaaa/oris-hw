using CarBooking.Data;
using CarBooking.Enums;
using CarBooking.Models;
using Microsoft.AspNetCore.Mvc;

namespace CarBooking.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CarsController : ControllerBase
    {
        [HttpGet("GetCars")]
        //public IEnumerable<Car> Get() 
        //    => CarsData.Cars;
 
        public ActionResult<IEnumerable<CarVm>> GetAll()
        => Ok(CarsData.Cars.Select(x => new CarVm(x)));

        [HttpGet("GetCarById/{id:int}")]
        public Car? GetById([FromRoute]  int id)
            => CarsData.Cars.FirstOrDefault(x => x.Id == id);

        [HttpGet("GetFilteredCars")]
        public IEnumerable<CarVm>? GetFilteredCars(int? id, string? name, CategoryEnum? category, string? Img, TransmissionEnum? transmission, int? spaces, decimal? price   )
        {
            var result = CarsData.Cars.AsEnumerable();

            if (name != null)
                result = result.Where(i => i.Name.ToLower().Contains(name.ToLower()));


            if (category != null)
                result = result.Where(i => i.Category == category);

            if (transmission != null)
                result = result.Where(i => i.Transmission == transmission);

            if (spaces != null)
                result = result.Where(i => i.Spaces == spaces);

            if (price != null)
                result = result.Where(i => i.Price <= price);

            return result.Select(car => new CarVm(car));  
        }
   
}
}
