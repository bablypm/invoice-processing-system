using Microsoft.AspNetCore.Mvc;

namespace XYZCorp.InvoiceProcessing.Ui.Areas.Invoice.Controllers
{
    [Area("Invoice")]
    public class InvoiceController : Controller
    {
      
        [Route("invoice/create")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
