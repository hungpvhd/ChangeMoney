using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ChangeMoney.Data;
using ChangeMoney.Models;

namespace ChangeMoney.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChangeCurrencycsController : ControllerBase
    {
        private readonly ChangeMoneyContext _context;

        public ChangeCurrencycsController(ChangeMoneyContext context)
        {
            _context = context;
        }

        // GET: api/ChangeCurrencycs
        [HttpGet]
        public IEnumerable<ChangeCurrencycs> GetChangeCurrencycs()
        {
            return _context.ChangeCurrencycs;
        }

        // GET: api/ChangeCurrencycs/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetChangeCurrencycs([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var changeCurrencycs = await _context.ChangeCurrencycs.FindAsync(id);

            if (changeCurrencycs == null)
            {
                return NotFound();
            }

            return Ok(changeCurrencycs);
        }

        // PUT: api/ChangeCurrencycs/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutChangeCurrencycs([FromRoute] int id, [FromBody] ChangeCurrencycs changeCurrencycs)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != changeCurrencycs.Id)
            {
                return BadRequest();
            }

            _context.Entry(changeCurrencycs).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ChangeCurrencycsExists(id))
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

        // POST: api/ChangeCurrencycs
        [HttpPost]
        public async Task<IActionResult> PostChangeCurrencycs([FromBody] ChangeCurrencycs changeCurrencycs)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.ChangeCurrencycs.Add(changeCurrencycs);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetChangeCurrencycs", new { id = changeCurrencycs.Id }, changeCurrencycs);
        }

        // DELETE: api/ChangeCurrencycs/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteChangeCurrencycs([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var changeCurrencycs = await _context.ChangeCurrencycs.FindAsync(id);
            if (changeCurrencycs == null)
            {
                return NotFound();
            }

            _context.ChangeCurrencycs.Remove(changeCurrencycs);
            await _context.SaveChangesAsync();

            return Ok(changeCurrencycs);
        }

        private bool ChangeCurrencycsExists(int id)
        {
            return _context.ChangeCurrencycs.Any(e => e.Id == id);
        }
    }
}