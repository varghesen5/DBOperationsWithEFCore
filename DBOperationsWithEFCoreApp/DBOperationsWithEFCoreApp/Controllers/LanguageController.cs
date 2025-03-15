using DBOperationsWithEFCoreApp.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBOperationsWithEFCoreApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LanguageController : ControllerBase
    {
        private readonly AppDBContext _appDBContext;
        public LanguageController(AppDBContext appDBContext)
        {
            _appDBContext = appDBContext;
        }

        [HttpGet("")]
        public IActionResult GetAllLanguages()
        {
            var result = _appDBContext.Languages.ToList();

            return Ok(result);
        }

        [HttpGet("Asyncmethod")]
        public async Task<IActionResult> GetAsyncAllLanguages()
        {
            var result = await  _appDBContext.Languages.ToListAsync();

            return Ok(result);
        }
    }
}
