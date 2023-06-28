using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace CartopiaWeb.Models.Enums
{
    public enum Bodyshell
    {
        [Display(Name = "Cедан")]
        Sedan,
        [Display(Name = "Купе")]
        Coupe,
        [Display(Name = "Хетчбек")]
        Hatchback,
        [Display(Name = "Мінівен")]
        Minivan,
        [Display(Name = "Кросовер")]
        Crossover
    }
}
