using Ejercicio_API.Data;
using Ejercicio_API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Ejercicio_API.Bl.Dto;

namespace Ejercicio_API
{       
    public class BaseService<T,TDto> : ControllerBase, IBaseService<T,TDto> where T : Base where TDto : BaseDto
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;
        public BaseService(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<List<T>> Get()
        {
            return await _context.Set<T>().ToListAsync();
        }

        public async Task<TDto> Get(int id)
        {
            var entity = await _context.Set<T>().FindAsync(id);

            if (entity == null)
            {
                return null;
            }

            var dto = _mapper.Map<TDto>(entity);

            return dto;
        }

        public async Task<TDto> Add(TDto dto)
        {
            var entity = _mapper.Map<T>(dto);

            _context.Set<T>().Add(entity);

            await _context.SaveChangesAsync();

            return _mapper.Map(entity, dto);
        }

        public async Task<IActionResult> Edit(int id, TDto dto)
        {
            var entity = await _context.Set<T>().FindAsync(id);

            if (entity == null)
            {
                return BadRequest();
            }

            entity = _mapper.Map(dto, entity);

            _context.Entry(entity).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Exists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        public async Task<IActionResult> Delete(int id)
        {
            var entity = await _context.Set<T>().FindAsync(id);
            if (entity == null)
            {
                return NotFound();
            }

            _context.Set<T>().Remove(entity);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        public bool Exists(int id)
        {
            return _context.Set<T>().Any(e => e.Id == id);
        }
    }
}
