using Microsoft.AspNetCore.Mvc;

namespace SmartSchool.webAPI.Controllers
{
    [ApiController]
   [ Route("api/[Controller]")]
    public class Professorcontroller : ControllerBase
    {
        public Professorcontroller(){}

        [HttpGet]
        public IActionResult Get()
        {
            return Ok ("Professores: Marcos ");
        }
        
    }
}