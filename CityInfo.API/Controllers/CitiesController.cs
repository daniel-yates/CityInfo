namespace CityInfo.API.Controllers
{
    using System.Linq;

    using Microsoft.AspNetCore.Mvc;

    [Route("api/cities")]
    public class CitiesController : Controller
    {        
        public IActionResult GetCities()
        {
            return Ok(CitiesDataStore.Current.Cities);
        }

        [HttpGet("{id}")]
        public IActionResult GetCity(int id)
        {
            var citytoReturn = CitiesDataStore.Current.Cities.FirstOrDefault(c => c.Id == id);
            if (citytoReturn == null)
            {
                return NotFound();
            }

            return Ok(citytoReturn);
        }
    }
}
