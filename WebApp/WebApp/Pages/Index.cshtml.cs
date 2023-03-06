using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using WebApp.services;

namespace WebApp.Pages
{
    public class IndexModel : PageModel
    {       

        public void OnGet([FromServices] ILog log)
        {
            log.info("Indexe page requested !");
        }
    }
}