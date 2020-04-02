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
    [Route("api/columns")]
    [ApiController]
    public class columnsController : ControllerBase
    {
        private readonly MysqlContext _context;

        public columnsController(MysqlContext context)
        {
            _context = context;
        }

       
        

        // GET: api/columns/5
        [HttpGet("{id}")]
        public async Task<ActionResult<columns>> Getcolumns(long id)
        {
            var columns =  _context.columns.Find(id);

            if (columns == null)
            {
                return NotFound();
            }
             var json = new JObject ();
            json["status"] = columns.status;
            return Content (json.ToString (), "application/json");
            return  Content (json.ToString (), "application/json"); ;
        }

        // PUT: api/columns/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> Putcolumns(long id, columns columns)
        {
            var bat = _context.columns.Find (id);
            if (bat == null) {
                return NotFound ();
            }

            bat.status = columns.status;

            _context.columns.Update (bat);
            _context.SaveChanges ();
             var json = new JObject ();
            json["message"] = "the change of status is well done";
            return Content (json.ToString (), "application/json");
        }

       

    }
}
