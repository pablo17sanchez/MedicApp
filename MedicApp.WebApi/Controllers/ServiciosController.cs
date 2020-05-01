using MedicApp.BusinessLogic.Interfaces;
using MedicApp.Models.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace MedicApp.WebApi.Controllers
{


    [Route("api/[controller]")]
    [ApiController]
    public class ServiciosController : ControllerBase
    {
        private readonly IServicioLogic _logic;
        public ServiciosController(IServicioLogic logic)
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
        public IActionResult Post([FromBody]Servicios servicio)
        {
            if (!ModelState.IsValid) return BadRequest();
            return Ok(_logic.Insert(servicio));
        }
        [HttpGet]
        [Route("GetPaginatedServicios/{page:int}/{rows:int}")]
        public IActionResult GetPaginatedServicios(int page, int rows)
        {
            return Ok(_logic.ServicioPagedList(page, rows));
        }
        [HttpPut]
        public IActionResult Put([FromBody]Servicios servicios)
        {
            if (ModelState.IsValid && _logic.Update(servicios))
            {
                return Ok(new { Message = "El ncf se actualizo correctamente" });
            }
            return BadRequest();
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete]
        public IActionResult Delete([FromBody]Servicios servicios)
        {
          /*  if (servicios.ServicioId > 0)
            {
                return Ok(_logic.Delete(nfc));
            }*/
            return BadRequest();
        }
    }
}
