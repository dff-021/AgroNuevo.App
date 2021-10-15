using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Dominio.Entidades;

namespace Persistencia.AppRepositorios
{
    public interface IRepositorioInsumos
    {
        IEnumerable<Insumos> GetAllInsumos();

        Insumos AddInsumos(Insumos insumos);

        Insumos UpdateInsumos(Insumos insumos);

        void DeleteInsumos(int idInsumos );

        Insumos GetInsumos(int  idInsumos);
         
    }
}