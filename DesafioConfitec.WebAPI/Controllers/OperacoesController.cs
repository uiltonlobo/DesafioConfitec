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

        /// <summary>
        /// Realiza o somatório entre dois valores.
        /// </summary>
        /// <param name="valor1">Primeiro valor a ser somado.</param>
        /// <param name="valor2">Segundo valor a ser somado.</param>
        /// <returns>Resultado da soma entre os valores.</returns>
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

        /// <summary>
        /// Realiza a subtração entre dois valores.
        /// </summary>
        /// <param name="valor1">Primeiro valor a ser subtraído.</param>
        /// <param name="valor2">Segundo valor a ser subtraído.</param>
        /// <returns>Resultado da subtração entre os valores.</returns>        
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

        /// <summary>
        /// Realiza a multiplicação entre dois valores.
        /// </summary>
        /// <param name="valor1">Primeiro valor a ser multiplicado.</param>
        /// <param name="valor2">Segundo valor a ser multiplicado.</param>
        /// <returns>Resultado da multiplicação entre os valores.</returns>
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

        /// <summary>
        /// Realiza a divisão entre dois valores.
        /// </summary>
        /// <param name="valor1">Primeiro valor a ser dividido (dividendo).</param>
        /// <param name="valor2">Primeiro valor a ser dividido (divisor).</param>
        /// <returns>Resultado da soma entre os valores (quociente).</returns>
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
