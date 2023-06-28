using CartopiaWeb.Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace CartopiaWeb.Models
{
    public class CarInfo
    {
        public int Id { get; set; }
        public string? TypeOfBrand { get; set; }
        public string? Model { get; set; }
        public Region? Region { get; set; }
        public int Year { get; set; }

        public EngineType EngineType { get; set; }
        public decimal Price { get; set; }

        public Bodyshell Bodyshell { get; set; }

        public string? PhoneNumber { get; set; }

        public byte[]? PhotoBinary { get; set; }

        [StringLength(500)]
        public string Description { get; set; }

    }
}
