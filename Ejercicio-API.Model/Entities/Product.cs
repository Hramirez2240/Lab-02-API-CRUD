using Microsoft.EntityFrameworkCore;
using System;

namespace Ejercicio_API.Models
{
    public class Product : Base
    {
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public string ProviderName { get; set; }
        public DateTime Date { get; set; } = Convert.ToDateTime(DateTime.Now.ToString("dd/MM/yyyy"));
    }
}
