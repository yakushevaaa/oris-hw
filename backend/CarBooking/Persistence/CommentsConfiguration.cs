using CarBooking.Enums;
using CarBooking.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarBooking.Persistence
{
    public class CommentsConfiguration: IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
        {
            builder.HasData( new Comment { Id = 1, Name = "Tagir Akhmetshin", Position = "Senior Backend Developer", Text = "Отличная машина, лучше всех. Мне очень нравится", Date = new DateTime(2025, 4, 25), Img = "/images/tagir.jpg", CarId = 1 },
            new Comment { Id = 2, Name = "Vlada Yakusheva", Position = "Senior Frontend Developer", Text = "Супер машина, все удочки помещаются", Date = new DateTime(2025, 4, 25), Img = "/images/vlada.jpg", CarId = 1 },
            new Comment { Id = 3, Name = "Ivan Ivanov", Position = "Developer", Text = "Really good car", Date = new DateTime(2025, 4, 25)   , Img = "https://camo.githubusercontent.com/619e60801937aeb64755546251df3a4ffe1a786a38e91ee33d2c81eccca9685e/68747470733a2f2f617661746172732e6d64732e79616e6465782e6e65742f693f69643d34316661666336623632636363313037623761666233396435376266633564665f6c2d373130363839392d696d616765732d7468756d6273266e3d3133", CarId = 2 },
            new Comment { Id = 4, Name = "Ivan Ivanov", Position = "Developer", Text = "Really good car", Date = new DateTime(2025, 4, 25), Img = "https://camo.githubusercontent.com/619e60801937aeb64755546251df3a4ffe1a786a38e91ee33d2c81eccca9685e/68747470733a2f2f617661746172732e6d64732e79616e6465782e6e65742f693f69643d34316661666336623632636363313037623761666233396435376266633564665f6c2d373130363839392d696d616765732d7468756d6273266e3d3133", CarId = 3 },
            new Comment { Id = 5, Name = "Ivan Ivanov", Position = "Developer", Text = "Really good car", Date = new DateTime(2025, 4, 25), Img = "https://camo.githubusercontent.com/619e60801937aeb64755546251df3a4ffe1a786a38e91ee33d2c81eccca9685e/68747470733a2f2f617661746172732e6d64732e79616e6465782e6e65742f693f69643d34316661666336623632636363313037623761666233396435376266633564665f6c2d373130363839392d696d616765732d7468756d6273266e3d3133", CarId = 4 },
            new Comment { Id = 6, Name = "Ivan Ivanov", Position = "Developer", Text = "Really good car", Date = new DateTime(2025, 4, 25), Img = "https://camo.githubusercontent.com/619e60801937aeb64755546251df3a4ffe1a786a38e91ee33d2c81eccca9685e/68747470733a2f2f617661746172732e6d64732e79616e6465782e6e65742f693f69643d34316661666336623632636363313037623761666233396435376266633564665f6c2d373130363839392d696d616765732d7468756d6273266e3d3133", CarId = 5 },
            new Comment { Id = 7, Name = "Ivan Ivanov", Position = "Developer", Text = "Really good car", Date = new DateTime(2025, 4, 25), Img = "https://camo.githubusercontent.com/619e60801937aeb64755546251df3a4ffe1a786a38e91ee33d2c81eccca9685e/68747470733a2f2f617661746172732e6d64732e79616e6465782e6e65742f693f69643d34316661666336623632636363313037623761666233396435376266633564665f6c2d373130363839392d696d616765732d7468756d6273266e3d3133", CarId = 6 },
            new Comment { Id = 8, Name = "Ivan Ivanov", Position = "Developer", Text = "Really good car", Date = new DateTime(2025, 4, 25), Img = "https://camo.githubusercontent.com/619e60801937aeb64755546251df3a4ffe1a786a38e91ee33d2c81eccca9685e/68747470733a2f2f617661746172732e6d64732e79616e6465782e6e65742f693f69643d34316661666336623632636363313037623761666233396435376266633564665f6c2d373130363839392d696d616765732d7468756d6273266e3d3133", CarId = 7 },
            new Comment { Id = 9, Name = "Ivan Ivanov", Position = "Developer", Text = "Really good car", Date = new DateTime(2025, 4, 25), Img = "https://camo.githubusercontent.com/619e60801937aeb64755546251df3a4ffe1a786a38e91ee33d2c81eccca9685e/68747470733a2f2f617661746172732e6d64732e79616e6465782e6e65742f693f69643d34316661666336623632636363313037623761666233396435376266633564665f6c2d373130363839392d696d616765732d7468756d6273266e3d3133", CarId = 8 },
            new Comment { Id = 10, Name = "Ivan Ivanov", Position = "Developer", Text = "Really good car", Date = new DateTime(2025, 4, 25)  , Img = "https://camo.githubusercontent.com/619e60801937aeb64755546251df3a4ffe1a786a38e91ee33d2c81eccca9685e/68747470733a2f2f617661746172732e6d64732e79616e6465782e6e65742f693f69643d34316661666336623632636363313037623761666233396435376266633564665f6c2d373130363839392d696d616765732d7468756d6273266e3d3133", CarId = 9 },
            new Comment { Id = 11, Name = "Ivan Ivanov", Position = "Developer", Text = "Really good car", Date = new DateTime(2025, 4, 25), Img = "https://camo.githubusercontent.com/619e60801937aeb64755546251df3a4ffe1a786a38e91ee33d2c81eccca9685e/68747470733a2f2f617661746172732e6d64732e79616e6465782e6e65742f693f69643d34316661666336623632636363313037623761666233396435376266633564665f6c2d373130363839392d696d616765732d7468756d6273266e3d3133", CarId = 10 });

        }
    }
}
