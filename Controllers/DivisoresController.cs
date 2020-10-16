using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Divisores.Service.Divisores;
using Microsoft.AspNetCore.Mvc;

namespace Divisores.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DivisoresController : ControllerBase
    {
        private readonly IDivisores _divisores;
        public DivisoresController(IDivisores divisores){
            _divisores=divisores;
        }

        [HttpGet("BuscaDivisores/{dividendo}")]
        public IActionResult BuscaDivisores( int dividendo)
        { 

            try{
                List<int> resultado = _divisores.BuscaDivisores(dividendo);
                return Ok(resultado);
            }catch(Exception e){
                Console.WriteLine(e);
                return BadRequest("Erro ocorrido: "+ e.Message);
            }
        }
        [HttpGet("BuscaDivisoresPrimos/{dividendo}")]
        public IActionResult BuscaDivisoresPrimos( int dividendo)
        { 

            try{
                List<int> resultado = _divisores.BuscaDivisoresPrimos(dividendo);
                return Ok(resultado);
            }catch(Exception e){
                Console.WriteLine(e);
                return BadRequest("Erro ocorrido: "+ e.Message);
            }
        }
    }
}
