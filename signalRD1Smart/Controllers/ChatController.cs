using Microsoft.AspNetCore.Mvc;

namespace signalRD1Smart.Controllers
{
    public class ChatController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
