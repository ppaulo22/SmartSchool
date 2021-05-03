using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using SmartSchool.API.Models;

namespace SmartSchool.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AlunoController : ControllerBase
    {
        public List<Aluno> Alunos = new List<Aluno>() {
            new Aluno() {
                Id = 1,
                Nome = "Pedro",
                Sobrenome = "dos Santos",
                Telefone = "999999999"
            },

             new Aluno() {
                Id = 2,
                Nome = "Dandinha",
                Sobrenome = "Colorida",
                Telefone = "999999999"
            },

             new Aluno() {
                Id = 3,
                Nome = "Preta",
                Sobrenome = "Preta",
                Telefone = "999999999"
            },

             new Aluno() {
                Id = 4,
                Nome = "Dandinho",
                Sobrenome = "Preto",
                Telefone = "999999999"
            }
        };
        public AlunoController() { }
        
        public IActionResult Get()
        {
            return Ok(Alunos);
        }
        // api/aluno/"id"
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var aluno = Alunos.FirstOrDefault(a => a.Id == id);
            if (aluno == null) return BadRequest("O aluno não foi encontrado"); 
            return Ok(aluno);
        }
    }
}