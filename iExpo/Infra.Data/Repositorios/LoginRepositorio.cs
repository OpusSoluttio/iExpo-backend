using Dominios.Classes;
using Dominios.Interfaces;
using Infra.Data.Contextos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infra.Data.Repositorios
{
    public class LoginRepositorio : ILogin, IDisposable
    {
        //Declara uma váriavel do tipo Context
        private iExpoContext _context;

        //Utiliza injeção de dependência.
        public LoginRepositorio(iExpoContext context)
        {
            _context = context;
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        public Usuarios BuscarUser(string email, string senha)
        {

            try
            {
                var user = _context.Usuarios.FirstOrDefault(x => x.Email == email && x.Senha == senha);
                if (user == null) return null;
                return user;

            }
            catch (System.Exception ex)
            {

                throw new System.Exception(ex.Message);
            }
        }


    }
}
