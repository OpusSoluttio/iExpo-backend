using Dominios.Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dominios.Interfaces
{
    public interface ILogin
    {
        /// <summary>
        /// Busca o usuario pelos dados inseriods
        /// </summary>
        /// <param name="email">Email inserido pelo usuario</param>
        /// <param name="senha">Senha inserida pelo usuario</param>
        /// <returns>Retorna o usuario ou null caso nao encontre</returns>
        Usuarios BuscarUser(string email, string senha);
    }
}
