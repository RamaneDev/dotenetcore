using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using WebApp.services;

namespace WebApp.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILog _log;

        public IndexModel(ILog log)
        {
            _log = log;
        }

        public void OnGet()
        {
            _log.info("Indexe page requested !");
        }
    }
}