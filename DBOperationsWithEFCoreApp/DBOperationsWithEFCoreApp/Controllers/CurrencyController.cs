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
    public class CurrencyController : ControllerBase
    {
        private readonly AppDBContext _appDBContext;
        public CurrencyController(AppDBContext appDBContext)
        {
            _appDBContext = appDBContext;
        }

        [HttpGet("")]
        public IActionResult GetAllCurrencies()
        {
            // var result = _appDBContext.CurrencyTypes.ToList();

            var result = (from CurrencyType in _appDBContext.CurrencyTypes
                          select CurrencyType)

                .ToList();


            return Ok(result);
        }


        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetCurrencyByID([FromRoute] int id)
        {
            var result = await _appDBContext.CurrencyTypes.FindAsync(id);
            if (result is not null)
                return Ok(result);
            else
               return NotFound();
        }


        [HttpGet("{name}")]
        public async Task<IActionResult> GetCurrencyByName([FromRoute] string name)
        {
            var result = await _appDBContext.CurrencyTypes.Where(x=> x.Currency==name).FirstOrDefaultAsync();
            if (result is not null)
                return Ok(result);
            else
                return NotFound();
        }
    }
}
