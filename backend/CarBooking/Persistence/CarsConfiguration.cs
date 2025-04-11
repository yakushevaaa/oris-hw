using CarBooking.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using CarBooking.Enums;

namespace CarBooking.Persistence
{

    public class CarsConfiguration : IEntityTypeConfiguration<Car>
    {
        public void Configure(EntityTypeBuilder<Car> builder)
        {
            builder.HasData(new Car { Id = 1, Name = "LADA Granta", Category = CategoryEnum.Седан, Img = "https://static.lada.ru/images/v6/cars/configurator/granta/sedan.webp", Transmission = TransmissionEnum.Manual, Spaces = 3, Price = 99 },
            new Car { Id = 2, Name = "LADA Granta", Category = CategoryEnum.Лифтбек, Img = "https://static.lada.ru/images/v6/cars/configurator/granta/liftback.webp", Transmission = TransmissionEnum.Manual, Spaces = 2, Price = 100 },
            new Car { Id = 3, Name = "LADA Granta", Category = CategoryEnum.Sport, Img = "https://static.lada.ru/images/v6/cars/configurator/granta/cross.webp", Transmission = TransmissionEnum.Automatic, Spaces = 5, Price = 80 },
            new Car { Id = 4, Name = "LADA Vesta", Category = CategoryEnum.Седан, Img = "https://static.lada.ru/images/v6/cars/configurator/vesta_new/sedan.webp", Transmission = TransmissionEnum.Manual, Spaces = 4, Price = 50 },
            new Car { Id = 5, Name = "LADA Vesta", Category = CategoryEnum.Cross, Img = "https://static.lada.ru/images/v6/cars/configurator/vesta_new/cross.webp", Transmission = TransmissionEnum.Automatic, Spaces = 4, Price = 120 },
            new Car { Id = 6, Name = "LADA Vesta", Category = CategoryEnum.SW, Img = "https://static.lada.ru/images/v6/cars/configurator/vesta_new/sw.webp", Transmission = TransmissionEnum.Automatic, Spaces = 5, Price = 100 },
            new Car { Id = 7, Name = "LADA Largus", Category = CategoryEnum.Универсал, Img = "https://static.lada.ru/images/v6/cars/configurator/vesta_new/sedan.webp", Transmission = TransmissionEnum.Manual, Spaces = 5, Price = 40 },
            new Car { Id = 8, Name = "LADA Largus", Category = CategoryEnum.Cross, Img = "https://static.lada.ru/images/v6/cars/configurator/vesta_new/cross.webp", Transmission = TransmissionEnum.Automatic, Spaces = 4, Price = 40 },
            new Car { Id = 9, Name = "LADA Vesta", Category = CategoryEnum.Sport, Img = "https://static.lada.ru/images/v6/cars/configurator/vesta_new/sportline.webp", Transmission = TransmissionEnum.Automatic, Spaces = 5, Price = 100 },
            new Car { Id = 10, Name = "LADA Granta", Category = CategoryEnum.Sport, Img = "https://static.lada.ru/images/v6/cars/configurator/granta/sportline.webp", Transmission = TransmissionEnum.Manual, Spaces = 5, Price = 120 });
            
        }
    }
}