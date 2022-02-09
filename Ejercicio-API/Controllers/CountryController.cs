using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Ejercicio_API.Data;
using Ejercicio_API.Models;
using Ejercicio_API.Bl.Dto;
using Ejercicio_API.Services;

namespace Ejercicio_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountryController : BaseController<Country, CountryDto>
    {
        public CountryController(ICountryService countryService) : base(countryService)
        {

        }

        /*private readonly IBaseService<Country, CountryDto> _service;

        public CountryController(IBaseService<Country, CountryDto> service)
        {
            _service = service;
        }

        // GET: api/Country
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Country>>> GetCountry()
        {
            return await _service.Get();
        }

        // GET: api/Country/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CountryDto>> GetCountry(int id)
        {
            return await _service.Get(id);
        }

        // PUT: api/Country/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCountry(int id, CountryDto country)
        {
            return await _service.Edit(id, country);
        }

        // POST: api/Country
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<CountryDto>> PostCountry(CountryDto dto)
        {
            var CreatedCountry = await _service.Add(dto);
            return CreatedAtAction("GetCountry", new { id = CreatedCountry.Id }, dto);
        }

        // DELETE: api/Country/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCountry(int id)
        {
            return await _service.Delete(id);
        }*/
    }
}
