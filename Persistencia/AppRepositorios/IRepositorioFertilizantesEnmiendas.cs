using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Dominio.Entidades;

namespace Persistencia.AppRepositorios
{
    public interface IRepositorioFertilizantesEnmiendas
    {
        IEnumerable<FertilizantesEnmiendas> GetAllFertilizantesEnmiendas();

        FertilizantesEnmiendas AddFertilizantesEnmiendas(FertilizantesEnmiendas fertilizantesEnmiendas);

        FertilizantesEnmiendas UpdateFertilizantesEnmiendas(FertilizantesEnmiendas fertilizantesEnmiendas);

        void DeleteFertilizantesEnmiendas(int idFertilizantesEnmiendas );

        Cosecha GetFertilizantesEnmiendas(int  idFertilizantesEnmiendas);
         
    }
}