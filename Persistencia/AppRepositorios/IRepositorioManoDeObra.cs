using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Dominio.Entidades;

namespace Persistencia.AppRepositorios
{
    public interface IRepositorioManoDeObra
    {
        IEnumerable<ManoDeObra> GetAllManoDeObra();

        ManoDeObra AddManoDeObra(ManoDeObra manoDeObra);

        ManoDeObra UpdateManoDeObra(ManoDeObra manoDeObra);

        void DeleteManoDeObra(int idManoDeObra);

        ManoDeObra GetManoDeObra(int idManoDeObra);
         
    }
}