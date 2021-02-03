using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using CocktailApi.Context;
using CocktailApi.Models;


namespace CocktailApi.Data
{
    public static class Seed
    {
        public static void SeedUsers(CocktailContext context)
        {
            if (!context.Cocktails.Any())
            {
                var cocktailData = System.IO.File.ReadAllText("Data/CocktailSeedData.json");
                var cocktails = JsonConvert.DeserializeObject<List<Cocktail>>(cocktailData);

                context.SaveChanges();
            }
        }
    }
}