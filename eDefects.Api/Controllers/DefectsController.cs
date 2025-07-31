using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eDefects.Api.Data;
using eDefects.Api.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace eDefects.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DefectsController : ControllerBase
    {

        private readonly EDefectsDbContext _context;

        public DefectsController(EDefectsDbContext context)
        {
            _context = context;
        }

        //[Route("defects")]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Defect>>> GetAllDefects()
        {
            var defects = await _context.Defects.ToListAsync();
            return Ok(defects);
        }

        [HttpGet("db-health")]
        public async Task<IActionResult> CheckDatabaseConnection()
        {
            try
            {
                // Try to connect and query the database
                await _context.Database.ExecuteSqlRawAsync("SELECT 1");
                return Ok("Database connection is working.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Database connection failed: {ex.Message}");
            }
        }

    }
}
