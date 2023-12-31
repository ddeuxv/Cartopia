﻿using CartopiaWeb.Interfaces;
using CartopiaWeb.Models;

namespace CartopiaWeb.Services
{
    public class CarCreatorService : ICarCreator
    {
        public CarInfo CreateCar(CarInfo car, byte[] photoInBytes)
        {
            CarInfo newCar = new()
            {
                TypeOfBrand = car.TypeOfBrand,
                Model = car.Model,
                Region = car.Region,
                Year = car.Year,
                EngineType  = car.EngineType,
                Price = car.Price,
                Bodyshell = car.Bodyshell,
                PhoneNumber = car.PhoneNumber,
                Photo = photoInBytes,
                Description = car.Description,
            };

            return newCar;
        }
    }
}
