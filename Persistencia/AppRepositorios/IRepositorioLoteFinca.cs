using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Dominio.Entidades;

namespace AgroNuevo.App.Persistencia.AppRepositorios
{
    public interface IRepositorioLoteFinca
    {
        IEnumerable<LoteFinca> GetAllLoteFinca();

        LoteFinca AddLoteFinca(LoteFinca loteFinca);

        LoteFinca UpdateLoteFinca(LoteFinca loteFinca);

        void DeleteLoteFinca(int idLoteFinca);

        LoteFinca GetLoteFinca(int idLoteFinca);
         
    }
}