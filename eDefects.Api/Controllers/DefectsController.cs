using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eDefectsPilotBackend.Data;
using eDefectsPilotBackend.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace eDefectsPilotBackend.Controllers
{
   [Route("api/[controller]")]
   // [ApiController]
    public class DefectsController : ControllerBase
    {

        private readonly eDefectsDbContext _context;

        public DefectsController(eDefectsDbContext context)
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

    }
}
