using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Dominio.Entidades;

namespace Persistencia.AppRepositorios
{
    public interface IRepositorioCosecha
    {
        IEnumerable<Cosecha> GetAllCosecha();

        Cosecha AddCosecha(Cosecha cosecha);

        Cosecha UpdateCosecha(Cosecha cosecha);

        void DeleteCosecha(int idCosecha );

        Cosecha GetCosecha(int  idCosecha);
         
    }
}