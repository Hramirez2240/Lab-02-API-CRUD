using Ejercicio_API.Bl.Dto;
using Ejercicio_API.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Ejercicio_API
{
    public interface IBaseService<T, TDto> where T : IBase where TDto : IBaseDto
    {
        Task<List<T>> Get();
        public Task<TDto> Get(int id);

        public Task<TDto> Add(TDto dto);

        public Task<IActionResult> Edit(int id, TDto dto);

        public Task<IActionResult> Delete(int id);

        public bool Exists(int id);
    }
}
