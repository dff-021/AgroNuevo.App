using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Dominio.Entidades;

namespace Persistencia.AppRepositorios
{
    public interface IRepositorioTrazabilidad
    {
        IEnumerable<Trazabilidad> GetAllTrazabilidad();

        Trazabilidad AddTrazabilidad(Trazabilidad trazabilidad);

        Trazabilidad UpdateTrazabilidad(Trazabilidad trazabilidad);

        void DeleteTrazabilidad(int idTrazabilidad);

        Trazabilidad GetTrazabilidad(int  idTrazabilidad);
         
    }
}