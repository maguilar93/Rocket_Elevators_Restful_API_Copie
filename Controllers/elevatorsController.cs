using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TodoApi.Models;
using Newtonsoft.Json.Linq;
namespace TodoApi.Controllers
{
    [Route("api/elevators")]
    [ApiController]
    public class elevatorsController : ControllerBase
    {
        private readonly MysqlContext _context;

        public elevatorsController(MysqlContext context)
        {
            _context = context;
        }

        // GET: api/elevators
        // GET: api/elevators/5
      [HttpGet ("{id}")]        
      public async Task<ActionResult<elevators>> Getelevators(long id)
        {
            var elevators =  _context.elevators.Find(id);

            if (elevators == null)
            {
                return NotFound();
            }
             var json = new JObject ();
            json["status"] = elevators.status;
            return Content (json.ToString (), "application/json");
           
        }
          // GET: api/elevators/list
         [HttpGet]
        public ActionResult<List<elevators>> GetAll () {
            var list = _context.elevators.ToList ();
            if (list == null) {
                return NotFound ("Not Found");
            }
            List<elevators> list_alarm_inac = new List<elevators> ();

            foreach (var e in list) {

                if (e.status != "active"  ) {
                    list_alarm_inac.Add (e);
                }
            }
            return list_alarm_inac;
        }

        // PUT: api/elevators/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> Putelevators(long id, elevators elevators)
        {
            var bat = _context.elevators.Find (id);
            if (bat == null) {
                return NotFound ();
            }

            bat.status = elevators.status;

            _context.elevators.Update (bat);
            _context.SaveChanges ();
             var json = new JObject ();
            json["message"] = "the change of el status is well done";
            return Content (json.ToString (), "application/json");
        }
    }
}
