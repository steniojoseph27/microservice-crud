using App.Data.Contexts;
using App.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : ControllerBase
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_context.VmtCounties);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] VmtCounty vmtCountry)
        {
            await _context.VmtCounties.AddAsync(vmtCountry);
            await _context.SaveChangesAsync();

            return Ok(vmtCountry);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            var vmtCountry = await _context.VmtCounties.SingleOrDefaultAsync(vt => vt.CountyFips == id);

            if (vmtCountry == null)
            {
                return NotFound();
            }

            _context.VmtCounties.Remove(vmtCountry);
            await _context.SaveChangesAsync();

            return Ok(vmtCountry);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update([FromRoute] int id, [FromBody] VmtCounty vmtCountry)
        {
            _context.Update(vmtCountry);

            await _context.SaveChangesAsync();

            return Ok(vmtCountry);
        }
    }
}
