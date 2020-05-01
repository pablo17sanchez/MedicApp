using MedicApp.BusinessLogic.Interfaces;
using MedicApp.Models.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace MedicApp.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NCFController : ControllerBase
    {
        // GET: api/Consultorio
        private readonly INCFLogic _logic;
        public NCFController(INCFLogic logic)
        {
            _logic = logic;

        }
        // GET: api/Medico/5
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok(_logic.GetById(id));


        }
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_logic.GetList());
        }

        [HttpPost]
        public IActionResult Post([FromBody]NCF ncf)
        {
            if (!ModelState.IsValid) return BadRequest();
            return Ok(_logic.Insert(ncf));
        }
        [HttpGet]
        [Route("GetPaginatedNcf/{page:int}/{rows:int}")]
        public IActionResult GetPaginatedNcf(int page, int rows)
        {
            return Ok(_logic.NCFPagedList(page, rows));
        }
        [HttpPut]
        public IActionResult Put([FromBody]NCF ncf)
        {
            if (ModelState.IsValid && _logic.Update(ncf))
            {
                return Ok(new { Message = "El ncf se actualizo correctamente" });
            }
            return BadRequest();
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete]
        public IActionResult Delete([FromBody]NCF nfc)
        {
            if (nfc.NCFId > 0)
            {
                return Ok(_logic.Delete(nfc));
            }
            return BadRequest();
        }
    }
}
