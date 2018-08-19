using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DecryptQuote.Controllers
{
    public class SolveController : Controller
    {
        // GET: Solve
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult Grid(string encryptedQuote)
        {
            var gridModel = new DecryptQuote.Models.QuoteModel();

            gridModel.OriginalText = encryptedQuote;
            gridModel.SplitText = encryptedQuote.Split('');


            return PartialView(gridModel);
        }
    }
}