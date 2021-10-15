using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace AgroNuevo.App.Frontend.Pages
{
    public class IngresoModel : PageModel
    {
        private readonly ILogger<IngresoModel> _logger;

        public IngresoModel(ILogger<IngresoModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}
