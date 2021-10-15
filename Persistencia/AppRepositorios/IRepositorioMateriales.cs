using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Dominio.Entidades;

namespace Persistencia.AppRepositorios
{
    public interface IRepositorioMateriales
    {
        IEnumerable<Materiales> GetAllMateriales();

        Materiales AddMateriales(Materiales materiales);

        Materiales UpdateMateriales(Materiales materiales);

        void DeleteMateriales(int idMateriales);

        Materiales GetMateriales(int  idMateriales);
         
    }
}