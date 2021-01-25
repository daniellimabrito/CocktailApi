using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System.Collections.Generic;
using CocktailApi.Context;
using CocktailApi.Models;

namespace CocktailApi.Controllers
{
    [ApiController]
    [Route("v1/[controller]")]
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
            var obj = await _context.Cocktails.FindAsync(id);
            return Ok(obj);
        }

        [HttpGet]
        public async Task<IEnumerable<Cocktail>> Get()
        {
            var users = await _context.Cocktails.ToListAsync();

            return users;
        }        
    }
}