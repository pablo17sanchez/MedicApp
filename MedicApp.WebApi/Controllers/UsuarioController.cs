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
    public class UsuarioController : ControllerBase
    {

        private readonly IUsuarioLogic _logic;
        public UsuarioController(IUsuarioLogic logic)
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
        public IActionResult Post([FromBody]Usuarios usuario)
        {
            if (!ModelState.IsValid) return BadRequest();
            return Ok(_logic.Insert(usuario));
        }
        [HttpPut]
        public IActionResult Put([FromBody]Usuarios usuario)
        {
            if (ModelState.IsValid && _logic.Update(usuario))
            {
                return Ok(new { Message = "La ars se actualizo correctamente" });
            }
            return BadRequest();
        }
        [HttpGet]
        [Route("GetPaginatedUsuarios/{page:int}/{rows:int}")]
        public IActionResult GetPaginatedUsuarios(int page, int rows)
        {
            return Ok(_logic.UsuarioPagedList(page, rows));
        }
        // DELETE: api/ApiWithActions/5
        [HttpDelete]
        public IActionResult Delete([FromBody]Usuarios usuario)
        {
            if (usuario.UsuarioId > 0)
            {
                return Ok(_logic.Delete(usuario));
            }
            return BadRequest();
        }
    }
}
