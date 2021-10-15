using System;
using System.Collections.Generic;
using System.Linq;
using Dominio.Entidades;


namespace AgroNuevo.App.Persistencia.AppRepositorios
{
    public class RepositorioLogin : IRepositorioLoginClave
    {
        List<ListaLogin> listado3 = new List<ListaLogin>()
            {
                new ListaLogin{User="jarias", Pass="5541"},
                new ListaLogin{User="davidf", Pass="1133"}
            };     
     
        public bool GetLogin(string user, string pass)
        {
          foreach (ListaLogin adress in listado3)
          {

              if (adress.User == user){
                  if (adress.Pass == pass){
                      return true;
                  }
              }              
          }
          return false;
        }
    }
}