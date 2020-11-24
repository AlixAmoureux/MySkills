using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using myskillsapp.Object;

namespace myskillsapp.Controllers
{
    [Route("api/framework")]
    [ApiController]
    public class FrameworkController : ControllerBase
    {
        private List<Language> Languages;
        private List<Framework> Frameworks;

        private void InitData()
        {
            Languages = CreateDataService.GetLangageData();
            Frameworks = Languages.Where(language => language.Framework != null).ToList().SelectMany(language => language.Framework).ToList();
        }

        public FrameworkController()
        {
            this.InitData();
        }

        // GET: api/Frameworks
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public IActionResult GetFrameworks()
        {
            if ((Languages != null) && (Frameworks != null))
                return Ok(Frameworks);
            else
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        // GET: api/Frameworks/5
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public IActionResult GetFramework(int id)
        {
            if ((Languages != null) && (Frameworks != null))
            {
                try
                {
                    return (Ok(Frameworks.First(framework => framework.Id == id)));
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
