
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Dominio.Entidades;


namespace AgroNuevo.App.Persistencia.AppRepositorios
{
    public interface IRepositorioLoginClave
    {
        bool GetLogin(string User, string Pass);
        //ListaLogin AddListaLogin(ListaLogin listalogin);
        //ListaLogin list22 ();        
    }
}