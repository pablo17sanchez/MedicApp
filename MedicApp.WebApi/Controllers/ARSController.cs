using MedicApp.BusinessLogic.Interfaces;
using MedicApp.Models.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace MedicApp.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ARSController : ControllerBase
    {

        private readonly IArsLogic _logic;
        public ARSController(IArsLogic logic)
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
        public IActionResult Post([FromBody]ARS ars)
        {
            if (!ModelState.IsValid) return BadRequest();
            return Ok(_logic.Insert(ars));
        }
        [HttpPut]
        public IActionResult Put([FromBody]ARS ars)
        {
            if (ModelState.IsValid && _logic.Update(ars))
            {
                return Ok(new { Message = "La ars se actualizo correctamente" });
            }
            return BadRequest();
        }
        [HttpGet]
        [Route("GetPaginatedArs/{page:int}/{rows:int}")]
        public IActionResult GetPaginatedArs(int page, int rows)
        {
            return Ok(_logic.ARSPagedList(page, rows));
        }
        // DELETE: api/ApiWithActions/5
        [HttpDelete]
        public IActionResult Delete([FromBody]ARS ars)
        {
            if (ars.ARSId > 0)
            {
                return Ok(_logic.Delete(ars));
            }
            return BadRequest();
        }
    }
}
