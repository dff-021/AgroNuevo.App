using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Dominio.Entidades;

namespace Persistencia.AppRepositorios
{
    public interface IRepositorioCostoProduccion    
    {
        IEnumerable<CostoProduccion> GetAllCostoProduccion();

        CostoProduccion AddCostoProduccion(CostoProduccion costoProduccion);

        CostoProduccion UpdateCostoProduccion(CostoProduccion costoProduccion);

        void DeleteCostoProduccion(int idCostoProduccion );

        CostoProduccion GetCostoProduccion(int  idCostoProduccion);
         
    }
}