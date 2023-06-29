using CartopiaWeb.Models.Enums;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CartopiaWeb.Models
{
    public class CarInfo
    {
        public int Id { get; set; }
        public string? TypeOfBrand { get; set; } // write text 
        public string? Model { get; set; } // write text 
        public Region? Region { get; set; } // enum select
        public int Year { get; set; } // write text 

        public EngineType EngineType { get; set; } // enum select
        
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; } // write text 

        public Bodyshell Bodyshell { get; set; } // enum select

        public string? PhoneNumber { get; set; } // write text 

        public byte[]? PhotoBinary { get; set; } //upload file throw IFileLoad

        [StringLength(500)]
        public string? Description { get; set; } // text area send with post

    }
}
