using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Dominio;
using AgroNuevo.App.Persistencia.AppRepositorios;

namespace AgroNuevo.App.Frontend.Pages
{
    public class LoginModel : PageModel
    {
        private readonly IRepositorioLoginClave ObjetoRepositorio;

        public LoginModel(IRepositorioLoginClave Repositorio)
        {
            ObjetoRepositorio = Repositorio;
        }

        public IActionResult OnPost(string User, string Pass)
        {
            //User = user;
            //Pass = pass;

            if (ObjetoRepositorio.GetLogin(User, Pass))
            {
                return Redirect("./Insumos");
            }
            else
            {
                //MessageBox.Show("Contraseña Invalidad");
                return Page();
            }


        }
        
    }
}
