﻿using MedicApp.BusinessLogic.Interfaces;
using MedicApp.Models.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace MedicApp.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProvinciaController : ControllerBase
    {
        private readonly IProvinciaLogic _logic;
        public ProvinciaController(IProvinciaLogic logic)
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
        [HttpGet]
        [Route("GetPaginatedProvincias/{page:int}/{rows:int}")]
        public IActionResult GetPaginatedProvincias(int page, int rows)
        {
            return Ok(_logic.ProvinciaPagedList(page, rows));
        }
        // POST: api/Paciente
        [HttpPost]
        public IActionResult Post([FromBody]Provincia provincia)
        {
            if (!ModelState.IsValid) return BadRequest();
            return Ok(_logic.Insert(provincia));
        }
        [HttpPut]
        public IActionResult Put([FromBody]Provincia provincia)
        {
            if (ModelState.IsValid && _logic.Update(provincia))
            {
                return Ok(new { Message = "La provincia se actualizo correctamente" });
            }
            return BadRequest();
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete]
        public IActionResult Delete([FromBody]Provincia provincia)
        {
            if (provincia.ProvinciaId > 0)
            {
                return Ok(_logic.Delete(provincia));
            }
            return BadRequest();
        }
    }
}
