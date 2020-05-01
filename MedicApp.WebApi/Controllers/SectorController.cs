using Microsoft.AspNetCore.Mvc;
using MedicApp.BusinessLogic.Interfaces;
using MedicApp.Models.Dtos;

namespace MedicApp.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SectorController : ControllerBase
    {
        private readonly ISectorLogic _logic;
        public SectorController(ISectorLogic logic)
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
        public IActionResult Post([FromBody]Sector sector)
        {
            if (!ModelState.IsValid) return BadRequest();
            return Ok(_logic.Insert(sector));
        }
        [HttpPut]
        public IActionResult Put([FromBody]Sector sector)
        {
            if (ModelState.IsValid && _logic.Update(sector))
            {
                return Ok(new { Message = "El sector se actualizo correctamente" });
            }
            return BadRequest();
        }
        [HttpGet]
        [Route("GetPaginatedSector/{page:int}/{rows:int}")]
        public IActionResult GetPaginatedSector(int page, int rows)
        {
            return Ok(_logic.SectorPagedList(page, rows));
        }
        // DELETE: api/ApiWithActions/5
        [HttpDelete]
        public IActionResult Delete([FromBody]Sector sector)
        {
            if (sector.SectorId > 0)
            {
                return Ok(_logic.Delete(sector));
            }
            return BadRequest();
        }
    }
}
