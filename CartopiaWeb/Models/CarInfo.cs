using CartopiaWeb.Models.Enums;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CartopiaWeb.Models
{
    public class CarInfo
    {
        public int Id { get; set; }
        public string? CreatedByUserId { get; set; }
        public string? TypeOfBrand { get; set; } 
        public string? Model { get; set; }  
        public Region? Region { get; set; }
        public int Year { get; set; }

        public EngineType EngineType { get; set; }
        
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }

        public Bodyshell Bodyshell { get; set; }

        public string? PhoneNumber { get; set; }

        public byte[]? Photo { get; set; }

        [StringLength(500)]
        public string? Description { get; set; }

    }
}
