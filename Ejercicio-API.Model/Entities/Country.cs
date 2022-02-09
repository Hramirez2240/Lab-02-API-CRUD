using System;
using System.ComponentModel.DataAnnotations;

namespace Ejercicio_API.Models
{
    public class Country : Base
    {
        public string CountryName { get; set; }
        public int Population { get; set; }
    }
}
