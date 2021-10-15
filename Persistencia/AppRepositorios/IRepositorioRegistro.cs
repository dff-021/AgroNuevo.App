using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Dominio.Entidades;

namespace AgroNuevo.App.Persistencia.AppRepositorios
{
    public interface IRepositorioRegistro
    {
      IEnumerable<Registro> GetAllRegistros();  

      //Registro AddRegistro(Registro registro);

		  //Registro UpdateRegistro(Registro registro);

	  	//void DeleteRegistro(int idRegistro);

	  	//Registro GetRegistro(int idRegistro);

	  
    }
}