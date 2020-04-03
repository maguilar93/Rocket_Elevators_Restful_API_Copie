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
    [Route("api/buildings")]
    [ApiController]
    public class buildingsController : ControllerBase{
        private readonly MysqlContext _context;

        public buildingsController(MysqlContext context)
        {
            _context = context;
        }

        // GET api/buildings
        [HttpGet]
        public ActionResult<List<buildings>> GetAll () {
            var list = _context.buildings
                .Include (bu => bu.batteries)
                .ThenInclude (b => b.columns)
                .ThenInclude (c => c.elevators);

            if (list == null) {
                return NotFound ("Not Found");
            }

            // To build a "buildings" list
            List<buildings> list_buildings_intervention = new List<buildings> ();
            var verification = false;

            foreach (var building in list) {
                verification = false;
                foreach (var battery in building.batteries) {
                    if (battery.status == "Intervention") {
                        verification = true;
                    }
                    foreach (var column in battery.columns) {
                        if (column.status == "Intervention") {
                            verification = true;
                        }

                        foreach (var elevator in column.elevators) {
                            if (elevator.status == "Intervention") {
                                verification = true;
                            }
                        }
                    }
                }
                if (verification == true) {
                    var found_building = _context.buildings.Find (building.id);
                    list_buildings_intervention.Add (found_building);
                }
            }
            return list_buildings_intervention;
        }

      
    }
}
