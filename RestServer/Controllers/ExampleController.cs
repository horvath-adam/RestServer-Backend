﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RestServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExampleController : ControllerBase
    {
        // GET: api/<ExampleController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<ExampleController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(new { key = "value" });
        }

        // POST api/<ExampleController>
        [HttpPost]
        public IActionResult Post([FromBody] object value)
        {
            return Created("created", value);
        }

        // PUT api/<ExampleController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] object value)
        {
            return NoContent();
        }

        // DELETE api/<ExampleController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok(id);
        }
    }
}
