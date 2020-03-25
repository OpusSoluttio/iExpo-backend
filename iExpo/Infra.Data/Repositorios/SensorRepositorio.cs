using Dominios.Classes;
using Dominios.Interfaces;
using Infra.Data.Contextos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infra.Data.Repositorios
{
    public class SensorRepositorio : ISensores, IDisposable
    {
        //Declara uma váriavel do tipo Context
        private iExpoContext _context;

        //Utiliza injeção de dependência.
        public SensorRepositorio(iExpoContext context)
        {
            _context = context;
        }
        public List<Sensores> Listar()
        {

            try
            {
                return _context.Sensores.ToList();
            }
            catch (Exception)
            {
                return null;
            }
        }

        public Sensores Cadastrar(Sensores sensor)
        {
            try
            {
                _context.Sensores.Add(sensor);

                _context.SaveChanges();

                return sensor;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Sensores Alterar(Sensores sensor)
        {
            try
            {

                _context.Sensores.Update(sensor);
                _context.SaveChanges();
                return sensor;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public Sensores AlterarStatus(int IdSensor)
        {
            throw new NotImplementedException();
        }


        public void Dispose()
        {
            _context.Dispose();
        }

    }
}
