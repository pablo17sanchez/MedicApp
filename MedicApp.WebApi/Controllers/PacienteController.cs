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
    public class PacienteController : ControllerBase
    {


        private readonly IPacienteLogic _logic;
        public PacienteController(IPacienteLogic logic)
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
        public IActionResult Post([FromBody]Paciente paciente)
        {
            if (!ModelState.IsValid) return BadRequest();
            return Ok(_logic.Insert(paciente));
        }
        [HttpPut]
        public IActionResult Put([FromBody]Paciente paciente)
        {
            if (ModelState.IsValid && _logic.Update(paciente))
            {
                return Ok(new { Message = "El paciente se actualizo correctamente" });
            }
            return BadRequest();
        }
        [HttpGet]
        [Route("GetPaginatedPacientes/{page:int}/{rows:int}")]
        public IActionResult GetPaginatedPacientes(int page, int rows)
        {
            return Ok(_logic.PacientePagedList(page, rows));
        }
        [HttpDelete]
        public IActionResult Delete([FromBody]Paciente paceinte)
        {
            if (paceinte.IdPaciente > 0)
            {
                return Ok(_logic.Delete(paceinte));
            }
            return BadRequest();
        }
    }
}
