using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Dominio.Entidades;

namespace Persistencia.AppRepositorios
{
    public interface IRepositorioLoteFinca
    {
        IEnumerable<LoteFinca> GetAllLoteFinca();

        LoteFinca AddLoteFinca(LoteFinca loteFinca);

        LoteFinca UpdateCosecha(LoteFinca loteFinca);

        void DeleteLoteFinca(int idLoteFinca);

        LoteFinca GetLoteFinca(int  idLoteFinca);
         
    }
}