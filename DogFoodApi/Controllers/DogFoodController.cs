using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace DogFoodApi.Controllers
{
    [Route("dog/food")]
    public class DogFood : ControllerBase
    {
        private static int _foodCount = 0;
        [HttpGet]
        public IActionResult GetFood(int food)
        {
            Task.Delay(200).Wait();
            _foodCount += food;
            return Ok($"{_foodCount} count");
        }
    }
}
