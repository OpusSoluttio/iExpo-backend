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


        /// <summary>
        /// Atualiza os dados de um Sensor, há de estar logado como admin para realizar tal função
        /// </summary>
        /// <param name="sensor">Recebe o sensor com os dados à serem atualizadas</param>
        /// <param name="id">Recebe o Id da categoria à ser alterada</param>
        /// <returns>Caso haja sucesso no registro retorna Ok, caso não, retorna BadRequest</returns>
        [HttpPut("{id}")]
        public IActionResult Alterar(Sensores sensor, int id)
        {
            sensor.Id = id;
            try
            {
                _sensorRepositorio.Alterar(sensor);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(new { mensagem = "Ocorreu um erro " + ex });
            }
        }


    }
}