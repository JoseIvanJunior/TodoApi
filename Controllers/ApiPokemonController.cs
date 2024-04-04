using Flurl;
using Flurl.Http;
using Microsoft.AspNetCore.Mvc;

namespace TodoApi.Controllers;

[ApiController]
[Route("[controller]")]
public class ApiPokemonController : ControllerBase
{
    private const string ALL_POKEMON_URL = "https://pokeapi.co/api/v2/pokemon";
    
    [HttpGet("/api/pokemon")]
    public async Task<IActionResult> GetAllPokemon()
    {
        var result = await ALL_POKEMON_URL
            .SetQueryParams(new { limit = 151 }) // ?limit=151
            .GetJsonAsync<NamedAPIResourceList>();

        return Ok(result);
    }
}