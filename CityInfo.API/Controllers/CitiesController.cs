namespace CityInfo.API.Controllers
{
    using System.Linq;

    using Microsoft.AspNetCore.Mvc;

    public class CitiesController : Controller
    {
        [HttpGet("api/cities")]
        public IActionResult GetCities()
        {
            return Ok(CitiesDataStore.Current.Cities);
        }

        [HttpGet("api/cities/{id}")]
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
