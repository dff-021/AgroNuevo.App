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
    public class EditModel : PageModel
    {
        private readonly IRepositorioDatosFinca repositorioDatosFinca;
        [BindProperty]

        public DatosFinca DatosFinca {set; get;}

        public EditModel()
        {
            this.repositorioDatosFinca = new RepositorioDatosFinca(new AgroNuevo.App.Persistencia.AppContext());
        }
        public IActionResult OnGet(int? datosfincaId)
        {
            if (datosfincaId.HasValue)
            {
                DatosFinca = repositorioDatosFinca.GetDatosFinca(datosfincaId.Value);
            }
            else 
            {
                DatosFinca = new DatosFinca();
            }
            if (DatosFinca == null)
            {
                return RedirectToPage("./Notfound");                
            }
            else
            {
                return Page();
            }

        }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            if (DatosFinca.Id>0)
            {
                DatosFinca= repositorioDatosFinca.UpdateDatosFinca(DatosFinca);
            }
            else
            {
                repositorioDatosFinca.AddDatosFinca(DatosFinca);
            }
            return Page();
        }        
        
    }
}
       