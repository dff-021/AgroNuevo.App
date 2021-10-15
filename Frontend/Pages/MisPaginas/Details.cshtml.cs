using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Dominio.Entidades;
using AgroNuevo.App.Persistencia.AppRepositorios;
using Microsoft.AspNetCore.Authorization;

namespace AgroNuevo.App.Frontend.Pages
{
    public class DetailsModel : PageModel
    {
        private readonly IRepositorioDatosFinca RepositorioDatosFinca;
        
        public DatosFinca DatosFinca {set; get;}

        public DetailsModel()
        {
            this.RepositorioDatosFinca = new RepositorioDatosFinca(new AgroNuevo.App.Persistencia.AppContext());
        }
        public IActionResult OnGet(int datosfincaId)
        {
            DatosFinca = RepositorioDatosFinca.GetDatosFinca(datosfincaId);
            if(DatosFinca==null)
            {
                return RedirectToPage("./NotFound");
            }
            else
            {
                return Page();
            }
        }
        
    }
}
