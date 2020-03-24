using Dominios.Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dominios.Interfaces
{
    public interface ISensores
    {
        /// <summary>
        /// Lista todos sensores vindos do Banco de Dados
        /// </summary>
        /// <returns>Retorna uma lista com todos os sensores</returns>
        List<Sensores> Listar();

        /// <summary>
        /// Cadastra um novo sensor no Banco de Dados
        /// </summary>
        /// <param name="produto">Recebe um sensor com todas informações preenchidas</param>
        /// <returns>Retorna o sensor cadastrado caso tenha sucesso ou null caso haja falha</returns>
        Sensores Cadastrar(Sensores sensor);

        /// <summary>
        /// Altera as informações de um determinado sensor
        /// </summary>
        /// <param name="produto">Recebe as informações do sensor a serem mudadas</param>
        /// <returns>Retorna o sensor alterado caso tenha sucesso ou null caso haja falha</returns>
        Sensores Alterar(Sensores sensor);

        /// <summary>
        /// Altera o Status do Sensor
        /// </summary>
        /// <param name="IdProduto">Recebe o ID do sensor a ter sua sua informação alterada<//param>
        /// <returns>Retorna o sensor com a nova informação ou null caso haja falha</returns>
        Sensores AlterarStatus(int IdSensor);

    }
}
