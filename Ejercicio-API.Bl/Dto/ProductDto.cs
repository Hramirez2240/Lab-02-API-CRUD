using System;
using System.ComponentModel.DataAnnotations;

namespace Ejercicio_API.Bl.Dto
{
    public class ProductDto : BaseDto
    {
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public string ProviderName { get; set; }
        public DateTime Date { get; set; } = Convert.ToDateTime(DateTime.Now.ToString("dd/MM/yyyy"));
    }
}
