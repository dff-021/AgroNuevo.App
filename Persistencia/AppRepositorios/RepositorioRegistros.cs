using System;
using System.Collections.Generic;
using System.Linq;
using Dominio.Entidades;



namespace AgroNuevo.App.Persistencia.AppRepositorios
{
    public class RepositorioRegistros : IRepositorioRegistro
    {
        List<Registro> registros;

        public RepositorioRegistros()
        {
            registros = new List<Registro>()
            {
                new Registro {Id=1, Nombre="Jose Arias", Contraseña="1154" },
                new Registro {Id=2, Nombre="Danilo Zapata", Contraseña="3369" },
                new Registro {Id=3, Nombre="Carlos Lopez", Contraseña="0123" }
            };
        }

        public IEnumerable<Registro> GetAllRegistros()
        {
            return registros;
        }
    }
}