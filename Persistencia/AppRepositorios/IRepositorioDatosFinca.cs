using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Dominio.Entidades;


namespace AgroNuevo.App.Persistencia.AppRepositorios
{
    public interface IRepositorioDatosFinca
    {
        IEnumerable<DatosFinca> GetAllDatosFinca();

        DatosFinca AddDatosFinca(DatosFinca datosfinca);

        DatosFinca UpdateDatosFinca(DatosFinca datosfinca);

        void DeleteDatosFinca(int idDatosFinca );

        DatosFinca GetDatosFinca(int  idDatosFinca);
    }
}