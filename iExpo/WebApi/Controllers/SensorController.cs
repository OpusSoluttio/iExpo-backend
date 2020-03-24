using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominios.Classes;
using Dominios.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Servicos.ViewModels;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SensorController : ControllerBase
    {

        private ISensores _sensorRepositorio;

        public SensorController(ISensores sensorRepositorio)
        {
            _sensorRepositorio = sensorRepositorio;
        }


        public IActionResult Listar()
        {
            try
            {
                return Ok(_sensorRepositorio.Listar());
            }
            catch (Exception ex)
            {
                return BadRequest(new { sucesso = false, mensagem = ex.Message });
            }
        }

        [HttpPost]
        [Route("cadastrar")]
        public IActionResult Cadastrar(CadastrarSensorViewModel sensor)
        {
            try
            {
                Sensores Sensor = new Sensores()
                {
                    Codigo = sensor.Codigo,
                    Modelo = sensor.Modelo,
                    Titulo = sensor.Titulo,
                    Texto = sensor.Texto,
                    Status = sensor.Status
                };

                _sensorRepositorio.Cadastrar(Sensor);
                return Ok();
            }
            catch (Exception)
            {
                return BadRequest();
                throw;
            }
        }


    }
}