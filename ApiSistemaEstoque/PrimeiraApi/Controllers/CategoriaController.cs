using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PrimeiraApi.DTOs.CategoriaDto;
using PrimeiraApi.Models;

namespace PrimeiraApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriaController : ControllerBase
    {
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]

        public IActionResult GetAll()
        {
            return Ok();
        }

        [HttpPost]
        [ProducesResponseType(typeof(CategoriaCreateDto), StatusCodes.Status201Created)]

        public IActionResult RegistrarCategoria([FromBody] CategoriaCreateDto request) 
        {

            var categoria = new Categoria
            {
                Cat_Nome = request.Cat_Nome,
                Cat_PaiId = request.Cat_PaiId,
            };

            //_repository.Add(categoria);

            return Created($"/api/categoria/{categoria.Cat_Id}", request);
        }

        [HttpGet]
        [Route("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]

        public IActionResult GetById([FromRoute] int id)
        {
            return Created();
        }


        [HttpPut]

        public IActionResult UpdateCategoria([FromBody] CategoriaUpdateDto request)
        {
            return NoContent();
        }


    }

    
}
