using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using WebApp.services;

namespace WebApp.Pages
{
    public class IndexModel : PageModel
    {       

        public void OnGet()
        {
            var services = this.HttpContext.RequestServices;
            var log = (ILog)services.GetService(typeof(ILog));
            log.info("Indexe page requested !");
        }
    }
}