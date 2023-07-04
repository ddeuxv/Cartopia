using CartopiaWeb.Models.Enums;

namespace CartopiaWeb.Models.DTOs
{
    public class CarDTO
    { 
            public string?  Name { get; set; }
            public Region? Region { get; set; }
            public int Year { get; set; }

            public EngineType EngineType { get; set; }
            public decimal Price { get; set; }

            public Bodyshell Bodyshell { get; set; }
            public string? PhoneNumber { get; set; }

           public byte[]? Photo { get; set; }
    }
}
