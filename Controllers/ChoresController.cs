using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace chorelistt.Controllers
{
    [Route("api/chores")]
    public class ChoresController : Controller
    {
        private readonly ILogger<ChoresController> _logger;

        public ChoresController(ILogger<ChoresController> logger)
        {
            _logger = logger;
        }

        public ActionResult<List<Chore>> GetAll(){
            try 
            {
              return Ok()
            }
            catch (Exception e)
            {
              return BadRequest(e.Message);
            }
        }

        public IActionResult Index()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}