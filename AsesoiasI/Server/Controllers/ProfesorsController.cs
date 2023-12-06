﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AsesoiasI.Server.Data;
using AsesoiasI.Shared.Modelos;

namespace AsesoiasI.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfesorsController : ControllerBase
    {
        private readonly BDContextAsesoria _context;

        public ProfesorsController(BDContextAsesoria context)
        {
            _context = context;
        }

        // GET: api/Profesors
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Profesor>>> GetProfesores()
        {
          if (_context.Profesores == null)
          {
              return NotFound();
          }
            return await _context.Profesores.ToListAsync();
        }

        // GET: api/Profesors/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Profesor>> GetProfesor(int id)
        {
          if (_context.Profesores == null)
          {
              return NotFound();
          }
            var profesor = await _context.Profesores.FindAsync(id);

            if (profesor == null)
            {
                return NotFound();
            }

            return profesor;
        }

        // PUT: api/Profesors/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProfesor(int id, Profesor profesor)
        {
            if (id != profesor.Id)
            {
                return BadRequest();
            }

            _context.Entry(profesor).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProfesorExists(id))
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

        // POST: api/Profesors
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Profesor>> PostProfesor(Profesor profesor)
        {
          if (_context.Profesores == null)
          {
              return Problem("Entity set 'BDContextAsesoria.Profesores'  is null.");
          }
            _context.Profesores.Add(profesor);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetProfesor", new { id = profesor.Id }, profesor);
        }

        // DELETE: api/Profesors/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProfesor(int id)
        {
            if (_context.Profesores == null)
            {
                return NotFound();
            }
            var profesor = await _context.Profesores.FindAsync(id);
            if (profesor == null)
            {
                return NotFound();
            }

            _context.Profesores.Remove(profesor);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ProfesorExists(int id)
        {
            return (_context.Profesores?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
