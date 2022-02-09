using Ejercicio_API.Bl.Dto;
using Ejercicio_API.Data;
using Ejercicio_API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;

namespace Ejercicio_API.Services
{
    public interface IProductService : IBaseService<Product, ProductDto>
    {

    }

    public class ProductService : BaseService<Product, ProductDto>, IProductService
    {
        public ProductService(ApplicationDbContext context, IMapper mapper) : base(context, mapper)
        {

        }
    }
}
