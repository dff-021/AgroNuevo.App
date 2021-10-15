using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Dominio.Entidades;


namespace AgroNuevo.App.Persistencia.AppRepositorios
{
    public interface IRepositorioAgroquimicos
    {
        IEnumerable<Agroquimicos> GetAllAgroquimicos();

        Agroquimicos AddAgroquimicos(Agroquimicos agroquimicos);

        Agroquimicos UpdateAgroquimicos(Agroquimicos agroquimicos);

        void DeleteAgroquimicos(int idAgroquimicos );

        Agroquimicos GetAgroquimicos(int  idAgroquimicos);
         
    }
}