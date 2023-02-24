using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using erRelnAPI.Models;

namespace erRelnAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExampleController : ControllerBase
    {
        private readonly Ace42023Context _context;

        public ExampleController(Ace42023Context context)
        {
            _context = context;
        }

        // GET: api/Example
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Empharshit>>> GetEmpharshit()
        {
            return await _context.Empharshit.ToListAsync();
        }

        // GET: api/Example/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Empharshit>> GetEmpharshit(int id)
        {
            var empharshit = await _context.Empharshit.FindAsync(id);

            if (empharshit == null)
            {
                return NotFound();
            }

            return empharshit;
        }

        // PUT: api/Example/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEmpharshit(int id, Empharshit empharshit)
        {
            if (id != empharshit.Eid)
            {
                return BadRequest();
            }

            _context.Entry(empharshit).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EmpharshitExists(id))
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

        // POST: api/Example
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Empharshit>> PostEmpharshit(Empharshit empharshit)
        {
            _context.Empharshit.Add(empharshit);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (EmpharshitExists(empharshit.Eid))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetEmpharshit", new { id = empharshit.Eid }, empharshit);
        }

        // DELETE: api/Example/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEmpharshit(int id)
        {
            var empharshit = await _context.Empharshit.FindAsync(id);
            if (empharshit == null)
            {
                return NotFound();
            }

            _context.Empharshit.Remove(empharshit);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool EmpharshitExists(int id)
        {
            return _context.Empharshit.Any(e => e.Eid == id);
        }
    }
}
