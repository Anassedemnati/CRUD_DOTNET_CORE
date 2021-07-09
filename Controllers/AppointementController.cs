using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace inandout.Controllers
{
    public class AppointementController : Controller
    {
        public IActionResult Index()
        {
            return View();
            //string todayDate = DateTime.Now.ToShortDateString();
            //return Ok(todayDate);
        }
        public IActionResult Dettails(int id)
        {

            return Ok("you have entered id = " + id);

        }
        public IActionResult GetSomeData([FromQuery] string values)
        {
            return Ok("The value : " + values + "is from Query string");
        }
        [HttpPost]
        public IActionResult Post([FromHeader] string parentRequestId)
        {
            return Ok($"Got a heder whit parentRequestId: {parentRequestId}");
        }
    }
}
