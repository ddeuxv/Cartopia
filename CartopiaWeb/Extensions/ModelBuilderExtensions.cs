using CartopiaWeb.Interfaces;
using CartopiaWeb.Models;
using CartopiaWeb.Models.Enums;
using Microsoft.EntityFrameworkCore;

namespace CartopiaWeb.Extensions
{
    public static class ModelBuilderExtensions
    {
        
        public static void SeedInitialCars(this ModelBuilder modelBuilder, IPhotoConverter photoConverter)
        {
            modelBuilder.Entity<CarInfo>().HasData(
                new CarInfo
                {
                    Id = 1,
                    TypeOfBrand = "BMW",
                    Model = "X5",
                    Region = Region.Київська,
                    Year = 2017,
                    EngineType = EngineType.Diesel,
                    Price = 33000,
                    Bodyshell = Bodyshell.Crossover,
                    PhoneNumber = "0672004564",
                    Photo = photoConverter.GetPhotoBytesFromFile("starter_car1.jpg"),
                    Description = "В продажі BMW X5 з дизельним двигуном, автоматичною коробкою передач і повним приводом.",
                    
                },
                new CarInfo
                {
                    Id = 2,
                    TypeOfBrand = "ВАЗ",
                    Model = "2115",
                    Region = Region.Харківська,
                    Year = 2008,
                    EngineType = EngineType.Pertol,
                    Price = 3490,
                    Bodyshell = Bodyshell.Sedan,
                    PhoneNumber = "0672004564",
                    Photo = photoConverter.GetPhotoBytesFromFile("starter_car2.jpg"),
                    Description = "Продам Ваз 21154 від власника. Автомобіль 2008 року, у відмінному стані як технічно, так і по кузову.",
                }
            );

        }
    }
}
