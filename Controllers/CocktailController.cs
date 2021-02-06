using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System.Collections.Generic;
using CocktailApi.Context;
using CocktailApi.Models;

namespace CocktailApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CocktailController : ControllerBase
    {
        private readonly CocktailContext _context;
        public CocktailController(CocktailContext context)
        {
            _context = context;
        } 

        [HttpGet("{id}", Name="GetCocktail")]
        public async Task<IActionResult> GetCocktail(int id)
        {
            var objCocktail = await _context.Cocktails.FirstOrDefaultAsync( x => x.Id == id);
           // return Ok(new Cocktail(){Id = 10, Title = "Test"});


            if (objCocktail == null)
                return NotFound();

            return Ok(objCocktail);
        }

        [HttpGet]
        public async Task<IActionResult> GetCocktails()
        {
            var objCocktails = await _context.Cocktails.ToListAsync();

            if (objCocktails == null)
                return NotFound();

            return Ok(objCocktails);
        }        
    }
}