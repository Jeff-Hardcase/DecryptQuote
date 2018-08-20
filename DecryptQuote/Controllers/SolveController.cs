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
            var alpha = "abcdefghijklmnopqrstuvwxyz";

            //initialize the keystats with zero values
            foreach(var c in alpha)
            {
                gridModel.KeyStats[c.ToString()] = 0;
            }

            //now increase the value when the puzzle values exist
            foreach(var c in encryptedQuote)
            {
                gridModel.KeyStats[c.ToString()] += 1;
            }

            return PartialView(gridModel);
        }
    }
}