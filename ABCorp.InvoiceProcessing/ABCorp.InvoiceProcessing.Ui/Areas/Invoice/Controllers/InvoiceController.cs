using Microsoft.AspNetCore.Mvc;

namespace XYZCorp.InvoiceProcessing.Ui.Areas.Invoice.Controllers
{
    public class InvoiceController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
