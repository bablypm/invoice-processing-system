using Microsoft.AspNetCore.Mvc;

namespace ABCorp.InvoiceProcessing.Ui.Areas.Invoice.Controllers
{
    public class AttachmentsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
