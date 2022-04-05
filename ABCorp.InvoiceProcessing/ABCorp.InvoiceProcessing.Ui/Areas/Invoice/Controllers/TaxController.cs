using Microsoft.AspNetCore.Mvc;

namespace XYZCorp.InvoiceProcessing.Ui.Areas.Invoice.Controllers
{
    public class TaxController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
