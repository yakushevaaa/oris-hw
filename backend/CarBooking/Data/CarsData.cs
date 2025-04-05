using CarBooking.Models;
using CarBooking.Enums;

namespace CarBooking.Data
{
    public static class CarsData
    {
        public static List<Car> Cars = new List<Car>{
            new Car{Id = 1, Name = "LADA Granta", Category = CategoryEnum.Седан, Img = "https://static.lada.ru/images/v6/cars/configurator/granta/sedan.webp", Transmission = TransmissionEnum.Manual, Spaces = 3, Price = 99},
            new Car{Id = 2 , Name = "LADA Granta", Category = CategoryEnum.Лифтбек, Img = "https://static.lada.ru/images/v6/cars/configurator/granta/liftback.webp", Transmission = TransmissionEnum.Manual, Spaces = 2, Price = 100 },
            new Car{Id = 3 , Name = "LADA Granta", Category = CategoryEnum.Sport, Img = "https://static.lada.ru/images/v6/cars/configurator/granta/cross.webp", Transmission = TransmissionEnum.Automatic, Spaces = 5, Price = 80 },
            new Car{Id = 4 , Name = "LADA Vesta", Category = CategoryEnum.Седан, Img = "https://static.lada.ru/images/v6/cars/configurator/vesta_new/sedan.webp", Transmission = TransmissionEnum.Manual, Spaces = 4, Price = 50 },
            new Car{Id = 5 , Name = "LADA Vesta", Category = CategoryEnum.Cross, Img = "https://static.lada.ru/images/v6/cars/configurator/vesta_new/cross.webp", Transmission = TransmissionEnum.Automatic, Spaces = 4, Price = 120 },
            new Car{Id = 6 , Name = "LADA Vesta", Category = CategoryEnum.SW, Img = "https://static.lada.ru/images/v6/cars/configurator/vesta_new/sw.webp", Transmission = TransmissionEnum.Automatic, Spaces = 5, Price = 100 },
            new Car{Id = 7 , Name = "LADA Largus", Category = CategoryEnum.Универсал, Img = "https://static.lada.ru/images/v6/cars/configurator/vesta_new/sedan.webp", Transmission = TransmissionEnum.Manual, Spaces = 5, Price = 40 },
            new Car{Id = 8 , Name = "LADA Largus", Category = CategoryEnum.Cross, Img = "https://static.lada.ru/images/v6/cars/configurator/vesta_new/cross.webp", Transmission = TransmissionEnum.Automatic, Spaces = 4, Price = 40 },
            new Car{Id = 9 , Name = "LADA Vesta", Category = CategoryEnum.Sport, Img = "https://static.lada.ru/images/v6/cars/configurator/vesta_new/sportline.webp", Transmission = TransmissionEnum.Automatic, Spaces = 5, Price = 100 },
            new Car{Id = 10 , Name = "LADA Granta", Category = CategoryEnum.Sport, Img = "https://static.lada.ru/images/v6/cars/configurator/granta/sportline.webp", Transmission = TransmissionEnum.Manual, Spaces = 5, Price = 120 },
        };

        public static List<Comment> Comments = new List<Comment>
        {
            new Comment{Id = 1 , Name = "Tagir Akhmetshin", Position = "Senior Backend Developer", Text = "Отличная машина, лучше всех. Мне очень нравится",  Date = DateTime.Parse("20-04-2025"),  Img = "/images/tagir.jpg", CarId = 1},
            new Comment{Id = 2 , Name = "Vlada Yakusheva", Position = "Senior Frontend Developer", Text = "Супер машина, все удочки помещаются",  Date = DateTime.Parse("20-04-2025"),  Img = "/images/vlada.jpg", CarId = 1},
            new Comment{Id = 3 , Name = "Ivan Ivanov", Position = "Developer", Text = "Really good car",  Date = DateTime.Parse("20-04-2025"),  Img = "https://camo.githubusercontent.com/619e60801937aeb64755546251df3a4ffe1a786a38e91ee33d2c81eccca9685e/68747470733a2f2f617661746172732e6d64732e79616e6465782e6e65742f693f69643d34316661666336623632636363313037623761666233396435376266633564665f6c2d373130363839392d696d616765732d7468756d6273266e3d3133", CarId = 2},
            new Comment{Id = 4 , Name = "Ivan Ivanov", Position = "Developer", Text = "Really good car",  Date = DateTime.Parse("20-04-2025"),  Img = "https://camo.githubusercontent.com/619e60801937aeb64755546251df3a4ffe1a786a38e91ee33d2c81eccca9685e/68747470733a2f2f617661746172732e6d64732e79616e6465782e6e65742f693f69643d34316661666336623632636363313037623761666233396435376266633564665f6c2d373130363839392d696d616765732d7468756d6273266e3d3133", CarId = 3},
            new Comment{Id = 5 , Name = "Ivan Ivanov", Position = "Developer", Text = "Really good car",  Date = DateTime.Parse("20-04-2025"),  Img = "https://camo.githubusercontent.com/619e60801937aeb64755546251df3a4ffe1a786a38e91ee33d2c81eccca9685e/68747470733a2f2f617661746172732e6d64732e79616e6465782e6e65742f693f69643d34316661666336623632636363313037623761666233396435376266633564665f6c2d373130363839392d696d616765732d7468756d6273266e3d3133", CarId = 4},
            new Comment{Id = 6 , Name = "Ivan Ivanov", Position = "Developer", Text = "Really good car",  Date = DateTime.Parse("20-04-2025"),  Img = "https://camo.githubusercontent.com/619e60801937aeb64755546251df3a4ffe1a786a38e91ee33d2c81eccca9685e/68747470733a2f2f617661746172732e6d64732e79616e6465782e6e65742f693f69643d34316661666336623632636363313037623761666233396435376266633564665f6c2d373130363839392d696d616765732d7468756d6273266e3d3133", CarId = 5},
            new Comment{Id = 7 , Name = "Ivan Ivanov", Position = "Developer", Text = "Really good car",  Date = DateTime.Parse("20-04-2025"),  Img = "https://camo.githubusercontent.com/619e60801937aeb64755546251df3a4ffe1a786a38e91ee33d2c81eccca9685e/68747470733a2f2f617661746172732e6d64732e79616e6465782e6e65742f693f69643d34316661666336623632636363313037623761666233396435376266633564665f6c2d373130363839392d696d616765732d7468756d6273266e3d3133", CarId = 6},
            new Comment{Id = 8 , Name = "Ivan Ivanov", Position = "Developer", Text = "Really good car",  Date = DateTime.Parse("20-04-2025"),  Img = "https://camo.githubusercontent.com/619e60801937aeb64755546251df3a4ffe1a786a38e91ee33d2c81eccca9685e/68747470733a2f2f617661746172732e6d64732e79616e6465782e6e65742f693f69643d34316661666336623632636363313037623761666233396435376266633564665f6c2d373130363839392d696d616765732d7468756d6273266e3d3133", CarId = 7},
            new Comment{Id = 9 , Name = "Ivan Ivanov", Position = "Developer", Text = "Really good car",  Date = DateTime.Parse("20-04-2025"),  Img = "https://camo.githubusercontent.com/619e60801937aeb64755546251df3a4ffe1a786a38e91ee33d2c81eccca9685e/68747470733a2f2f617661746172732e6d64732e79616e6465782e6e65742f693f69643d34316661666336623632636363313037623761666233396435376266633564665f6c2d373130363839392d696d616765732d7468756d6273266e3d3133", CarId = 8},
            new Comment{Id = 10 , Name = "Ivan Ivanov", Position = "Developer", Text = "Really good car",  Date = DateTime.Parse("20-04-2025"),  Img = "https://camo.githubusercontent.com/619e60801937aeb64755546251df3a4ffe1a786a38e91ee33d2c81eccca9685e/68747470733a2f2f617661746172732e6d64732e79616e6465782e6e65742f693f69643d34316661666336623632636363313037623761666233396435376266633564665f6c2d373130363839392d696d616765732d7468756d6273266e3d3133", CarId = 9},
            new Comment{Id = 11, Name = "Ivan Ivanov", Position = "Developer", Text = "Really good car",  Date = DateTime.Parse("20-04-2025"),  Img = "https://camo.githubusercontent.com/619e60801937aeb64755546251df3a4ffe1a786a38e91ee33d2c81eccca9685e/68747470733a2f2f617661746172732e6d64732e79616e6465782e6e65742f693f69643d34316661666336623632636363313037623761666233396435376266633564665f6c2d373130363839392d696d616765732d7468756d6273266e3d3133", CarId = 10},

        };
    }
}
