using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using myskillsapp.Object;
using System;
using System.Collections.Generic;
using System.Linq;

namespace myskillsapp.Controllers
{
    [Route("api/language")]
    [ApiController]
    public class LanguageController : ControllerBase
    {
        private readonly List<Language> Languages;
        public LanguageController()
        {
            this.Languages = CreateDataService.GetLangageData();
        }

        // GET: api/<LanguageController>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public IActionResult Get()
        {
            if (Languages != null)
                return Ok(this.Languages);
            else
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }            
        }

        // GET api/<LanguageController>/5
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public IActionResult Get(int id)
        {
            if (Languages != null)
            {
                try
                {
                    return (Ok(Languages.First(language => language.Id == id)));
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
