using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Dominio.Entidades;

namespace Persistencia.AppRepositorios
{
    public interface IRepositorioCultivos
    {
        IEnumerable<Cultivos> GetAllCultivos();

        Cultivos AddCultivos(Cultivos cultivos);
        Cultivos UpdateCultivos(Cultivos cultivos);

        void DeleteCultivos(int idCultivos);

        Cultivos GetCultivos(int  idCultivos);
         
    }
}