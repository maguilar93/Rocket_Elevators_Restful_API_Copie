using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TodoApi.Models;
using Newtonsoft.Json.Linq;

namespace Rocket.Controllers {
    [Route ("api/batteries")]
    [ApiController]
    public class BatteriesController : ControllerBase {
        private readonly MysqlContext _context;

        public BatteriesController (MysqlContext context) {
            _context = context;
        }

        // GET api/batteries/5
        [HttpGet ("{id}")]
        public async Task<IActionResult> GetById (string Status, long id) {
            var item = _context.batteries.Find (id);
            if (item == null) {
                return NotFound ("Not found");
            }
           var json = new JObject ();
            json["status"] = item.Status;
            return Content (json.ToString (), "application/json");
        }

        // PUT api/batteries/5
        [HttpPut ("{id}")]
        public async Task<IActionResult> Update (long id, batteries battery) {
            var bat = _context.batteries.Find (id);
            if (bat == null) {
                return NotFound ();
            }

            bat.Status = battery.Status;

            _context.batteries.Update (bat);
            _context.SaveChanges ();
            var json = new JObject ();
            json["message"] = "the change of el status is well done";
            return Content (json.ToString (), "application/json");
        }
    }}