using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using myskillsapp.Object;
using System;
using System.Collections.Generic;
using System.Linq;

namespace myskillsapp.Controllers
{
    [Route("api/software")]
    [ApiController]
    public class SoftwareController : ControllerBase
    {
        private readonly List<Software> Softwares;
        public SoftwareController()
        {
            this.Softwares = CreateDataService.GetSoftwaresData();
        }

        // GET: api/<SoftwareController>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public IActionResult Get()
        {
            if (Softwares != null)
                return Ok(this.Softwares);
            else
                return StatusCode(StatusCodes.Status500InternalServerError);
        }

        // GET api/<SoftwareController>/5
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public IActionResult Get(int id)
        {
            if (Softwares != null)
            {
                try
                {
                    return (Ok(Softwares.First(software => software.Id == id)));
                }
                catch (Exception)
                {
                    return NotFound();
                }
            }
            else
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
    }
}
