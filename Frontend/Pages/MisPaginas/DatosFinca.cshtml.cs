using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Dominio.Entidades;
using AgroNuevo.App.Persistencia.AppRepositorios;
using Microsoft.AspNetCore.Authorization;

namespace AgroNuevo.Frontend.Pages
{
    public class DatosFincaModel : PageModel
    {
        private readonly IRepositorioDatosFinca repositorioDatosFinca;

        public IEnumerable<DatosFinca> DatosFinca {get; set;}
        public DatosFincaModel()
        {
            this.repositorioDatosFinca = new RepositorioDatosFinca(new AgroNuevo.App.Persistencia.AppContext());            
        }

        public void OnGet(string filtroBusqueda)     
        {
            DatosFinca = repositorioDatosFinca.GetAllDatosFinca();
        }  
        
    }
}
