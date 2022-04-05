using Microsoft.AspNetCore.Mvc;

namespace XYZCorp.InvoiceProcessing.Ui.Areas.Invoice.Controllers
{
    public class AllocationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
