using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HomeworkAPI.Domain;
using HomeworkAPI.Services;
using HomeworkAPI.Dto;


namespace HomeworkAPI.Controllers
{
    [ApiController]
    [Route("api/{controller}")] 
    public class SubjectsController : ControllerBase
    {
        private readonly ISubjectsService _subjectsService;

        public SubjectsController(ISubjectsService subjectsService)
        {
            _subjectsService = subjectsService;
        }

        [HttpGet]
        [Route("list")]
        public IActionResult GetAll()
        {
            try
            {
                return Ok(_subjectsService.GetAll().ConvertAll(t => t.ConvertToSubjectsDto()));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        [HttpGet]
        [Route("{id}")]
        public IActionResult GetById(int id)
        {
            try
            {
                return Ok(_subjectsService.GetById(id).ConvertToSubjectsDto());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        [Route("create")]
        public IActionResult Create([FromBody] Subjects subjects)
        {
            try
            {
                _subjectsService.Create(subjects);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete]
        [Route("delete")]
        public IActionResult Delete([FromBody] Subjects subjects)
        {
            try
            {
                _subjectsService.Delete(subjects);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        [Route("update")]
        public IActionResult Update([FromBody] Subjects subjects)
        {
            try
            {
                _subjectsService.Update(subjects);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
    
}
