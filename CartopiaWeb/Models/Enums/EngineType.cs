using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace CartopiaWeb.Models.Enums
{
    public enum EngineType
    {
        [Display(Name = "Дизель")]
        Diesel,
        [Display(Name = "Бензин")]
        Pertol,
        [Display(Name = "Електро")]
        Electric,
        [Display(Name = "Гібрид")]
        Hybrid,
        [Display(Name = "Газ")]
        Gas
    }
}
