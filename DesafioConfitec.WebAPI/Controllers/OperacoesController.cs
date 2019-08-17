using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesafioConfitec.Business.Service;
using Microsoft.AspNetCore.Mvc;

namespace DesafioConfitec.WebAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class OperacoesController : ControllerBase
    {
        private IOperacoesService service;

        public OperacoesController(IOperacoesService service)
        {
            this.service = service;
        }

        [HttpGet("{valor1}/{valor2}")]
        public IActionResult Somar(double valor1, double valor2)
        {
            try
            {
                double resultado = this.service.Somar(valor1, valor2);
                return Ok(resultado);
            }
            catch (Exception)
            {
                return StatusCode(500, "Erro interno. Tente novamente.");
            }
        }

        [HttpGet("{valor1}/{valor2}")]
        public IActionResult Subtrair(double valor1, double valor2)
        {
            try 
            {
                double resultado = this.service.Subtrair(valor1, valor2);
                return Ok(resultado);
            }
            catch (Exception) 
            {
                return StatusCode(500, "Erro interno. Tente novamente.");
            }
        }

        [HttpGet("{valor1}/{valor2}")]
        public IActionResult Multiplicar(double valor1, double valor2)
        {
            try 
            {
                double resultado = this.service.Multiplicar(valor1, valor2);
                return Ok(resultado);
            }
            catch (Exception) 
            {
                return StatusCode(500, "Erro interno. Tente novamente.");
            }
        }

        [HttpGet("{valor1}/{valor2}")]
        public IActionResult Dividir(double valor1, double valor2)
        {
            try 
            {
                if (valor2 == 0)
                    throw new DivideByZeroException();

                double resultado = this.service.Dividir(valor1, valor2);
                return Ok(resultado);
            }
            catch (DivideByZeroException)
            {
                return StatusCode(500, "Não é possível a divisão por zero.");
            }
            catch (Exception) 
            {
                return StatusCode(500, "Erro interno. Tente novamente.");
            }
        }

    }
}
