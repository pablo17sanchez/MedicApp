using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MedicApp.BusinessLogic.Interfaces;
using MedicApp.Models.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MedicApp.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConsultorioController : ControllerBase
    {
        // GET: api/Consultorio
        private readonly IConsultorioLogic _logic;
        public ConsultorioController(IConsultorioLogic logic)
        {
            _logic = logic;

        }
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_logic.GetList());
        }
        // GET: api/Paciente/5
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok(_logic.GetById(id));

        }

        // POST: api/Paciente
        [HttpPost]
        public IActionResult Post([FromBody]Consultorio consultorio)
        {
            if (!ModelState.IsValid) return BadRequest();
            return Ok(_logic.Insert(consultorio));
        }
        [HttpPut]
        public IActionResult Put([FromBody]Consultorio consultorio)
        {
            if (ModelState.IsValid && _logic.Update(consultorio))
            {
                return Ok(new { Message = "El consultiro se actualizo correctamente" });
            }
            return BadRequest();
        }
        [HttpGet]
        [Route("GetPaginatedConsultorio/{page:int}/{rows:int}")]
        public IActionResult GetPaginatedConsultorio(int page, int rows)
        {
            return Ok(_logic.ConsultorioPagedList(page, rows));
        }
        // DELETE: api/ApiWithActions/5
        [HttpDelete]
        public IActionResult Delete([FromBody]Consultorio consultorio)
        {
            if (consultorio.ConsultorioId > 0)
            {
                return Ok(_logic.Delete(consultorio));
            }
            return BadRequest();
        }
    }
}
