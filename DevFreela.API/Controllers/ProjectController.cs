using DevFreela.API.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevFreela.API.Controllers
{
    [Route("api/projects")]
    public class ProjectController : ControllerBase
    {
        // api/projects?query=net core
        [HttpGet]
        public IActionResult Get(string query)
        {
            // Buscar ou fltrar todos os objetos

            return Ok();
        }

        // api/projects/3
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            // Buscar o projeto

            // return NotFound();

            return Ok();
        }

        [HttpPost]
        public IActionResult Post([FromBody] CreateProjectModel createProject)
        {
            if (createProject.Title.Length > 50)
            {
                return BadRequest();
            }

            // Cadastrar o objeto

            return CreatedAtAction(nameof(GetById), new { id = createProject.Id }, createProject);
        }

        // api/projects/2
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] UpdateProjectModel updateProject)
        {
            if (updateProject.Description.Length > 200)
            {
                return BadRequest();
            }

            // Atualizar o objeto

            return NoContent();
        }

        // api/projects/3 DELETE
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            // Buscar, se não existir, retorna NotFound

            // Remover

            return NoContent();
        }
    }
}
