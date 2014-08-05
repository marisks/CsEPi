using System.Web.Mvc;
using CsEPi.Models;
using EPiServer.Web.Mvc;

namespace CsEPi.Controllers
{
    public class StartPageController : PageController<StartPage>
    {
        public virtual ActionResult Index(StartPage currentPage)
        {
            return View(currentPage);
        }
    }
}