using System.ComponentModel.DataAnnotations;

namespace Ejercicio_API.Bl.Dto
{
    public class CountryDto : BaseDto
    {
        public string CountryName { get; set; }
        public int Population { get; set; }
    }
}
