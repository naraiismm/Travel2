using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccess.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TravelApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TravelController : ControllerBase
    {
        private readonly ITravelManager  _travelManager;
        public TravelController(ITravelManager travelManager)
        {
            _travelManager = travelManager;
        }
        

       [ HttpGet("GetAll")]
        public IActionResult GetTravel()
        {
            var result=_travelManager.GetAll();
            if(result.Success)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(result);
            }
            

        }
        [HttpGet("Get")]
        public IActionResult Get(int id)
        {
            var result = _travelManager.Get(id);
            if(result.Success)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(result);
            }

        }
        [HttpPost("AddTravel")]
        public IActionResult Add(Travel travel)
        {
            var result = _travelManager.Add(travel);
            if (result.Success) 
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(result);
            }

        }

        [HttpPut("Delete")]
        public IActionResult Delete(int id)
        {
            var result= _travelManager.Delete(id);
            if (result.Success)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(result);
            }
        }

        [HttpPost("Update")]

        public IActionResult Update(Travel travel)
        {
            var result=_travelManager.Update(travel);
            if (result.Success)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(result);
            }

        }





    }
}
