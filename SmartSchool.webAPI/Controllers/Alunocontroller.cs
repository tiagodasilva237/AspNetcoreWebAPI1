using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using SmartSchool.webAPI.Models;

namespace SmartSchool.webAPI.Controllers
{
    [ApiController]
   [ Route("api/[Controller]")]
    public class Alunocontroller : ControllerBase
    {
        public List<Aluno> Alunos = new List<Aluno>(){
            new Aluno(){
                Id = 1,
                Nome= "Marcos",
                Sobrenome = "silva",
                Telefone = "32151997"

            },
             new Aluno(){
                Id = 2,
                Nome= "Laura",
                Sobrenome = "silvata",
                Telefone = "32151996"

            },
             new Aluno(){
                Id = 3,
                Nome= "Lulu",
                Sobrenome = "silvas",
                Telefone = "32151998"

            },
        };
        public Alunocontroller(){}

        [HttpGet]
        public IActionResult Get()
        {
            return Ok (Alunos);
       
            
        }
         [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var aluno =Alunos.FirstOrDefault(a => a.Id == id);
            if (aluno == null) return BadRequest("o aluno não foi encontrado");
            return Ok (aluno);
        }

        [HttpPost]
        public IActionResult Post(Aluno aluno)
        {
            
            return Ok (aluno);

        }

        [HttpPut("{id}")]
        public IActionResult Put(int id,Aluno aluno)
        {
          
            return Ok (aluno);
        }

         [HttpPatch("{id}")]
        public IActionResult Patch(int id, Aluno aluno)
        {
          
            return Ok (aluno);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
          
            return Ok ();
        }

        
        

       
        
    }
}