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
    public class MedicoController : ControllerBase
    {


        private readonly IMedicoLogic _logic;
        public MedicoController(IMedicoLogic logic)
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
        public IActionResult Post([FromBody]Medico medico)
        {
            if (!ModelState.IsValid) return BadRequest();
            return Ok(_logic.Insert(medico));
        }
        [HttpGet]
        [Route("GetPaginatedMedicos/{page:int}/{rows:int}")]
        public IActionResult GetPaginatedCustomer(int page, int rows)
        {
            return Ok(_logic.MedicoPagedList(page, rows));
        }
        [HttpPut]
        public IActionResult Put([FromBody]Medico medico)
        {
            if (ModelState.IsValid && _logic.Update(medico))
            {
                return Ok(new { Message = "El medico se actualizo correctamente" });
            }
            return BadRequest();
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete]
        public IActionResult Delete([FromBody]Medico medico)
        {
            if (medico.MedicoId > 0)
            {
                return Ok(_logic.Delete(medico));
            }
            return BadRequest();
        }
    }
}
