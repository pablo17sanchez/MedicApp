using MedicApp.BusinessLogic.Interfaces;
using MedicApp.Models.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace MedicApp.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DocumentosController : ControllerBase
    {

        private readonly IDocumentosLogic _logic;
        public DocumentosController(IDocumentosLogic logic)
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
        public IActionResult Post([FromBody]Documentos documento)
        {
            if (!ModelState.IsValid) return BadRequest();
            return Ok(_logic.Insert(documento));
        }
        [HttpPut]
        public IActionResult Put([FromBody]Documentos documento)
        {
            if (ModelState.IsValid && _logic.Update(documento))
            {
                return Ok(new { Message = "El documento se actualizo correctamente" });
            }
            return BadRequest();
        }
        [HttpGet]
        [Route("GetPaginatedDocumentos/{page:int}/{rows:int}")]
        public IActionResult GetPaginatedDocumentos(int page, int rows)
        {
            return Ok(_logic.DocumentosPagedList(page, rows));
        }
        // DELETE: api/ApiWithActions/5
        [HttpDelete]
        public IActionResult Delete([FromBody]Documentos documento)
        {
            if (documento.DocumentoId > 0)
            {
                return Ok(_logic.Delete(documento));
            }
            return BadRequest();
        }
    }
}
