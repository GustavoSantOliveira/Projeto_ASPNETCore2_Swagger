using System;
using Microsoft.AspNetCore.Mvc;

namespace APITemperatura.Controllers
{
    [Route("api/[controller]")]
    public class ConversorTemperaturasController : Controller
    {
        /// <summary>
        /// Transforma uma temperatura em Celsius para o equivalente
        /// nas escalas Fahrenheit e Kelvin.
        /// </summary>
        /// <param name="temperatura">Temperatura em Celsius</param>
        /// <returns>Objeto contendo valores para uma temperatura
        /// nas escalas Celsius, Fahrenheit e Kelvin.</returns>
        [HttpGet("Celsius/{temperatura}")]
        public object GetConversaoCelsius(double temperatura)
        {
            Temperatura dados = new Temperatura();
            dados.ValorCelsius = temperatura;
            dados.ValorFahrenheit =
                Math.Round((temperatura * 9 / 5) + 32);
            dados.ValorKelvin = dados.ValorCelsius + 273.15;

            return dados;
        }
    }
}