using MedicApp.BusinessLogic.Interfaces;
using MedicApp.Models.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace MedicApp.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CitasController : ControllerBase

    {
        private readonly ICitasLogic _logic;
        public CitasController(ICitasLogic logic)
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
        public IActionResult Post([FromBody]Citas cita)
        {
            if (!ModelState.IsValid) return BadRequest();
            return Ok(_logic.Insert(cita));
        }
        [HttpPut]
        public IActionResult Put([FromBody]Citas cita)
        {
            if (ModelState.IsValid && _logic.Update(cita))
            {
                return Ok(new { Message = "La cita se actualizo correctamente" });
            }
            return BadRequest();
        }
        [HttpGet]
        [Route("GetPaginatedCitas/{page:int}/{rows:int}")]
        public IActionResult GetPaginatedCitas(int page, int rows)
        {
            return Ok(_logic.CitasPagedList(page, rows));
        }
        // DELETE: api/ApiWithActions/5
        [HttpDelete]
        public IActionResult Delete([FromBody]Citas cita)
        {
            if (cita.CitasId > 0)
            {
                return Ok(_logic.Delete(cita));
            }
            return BadRequest();
        }
    }
}
