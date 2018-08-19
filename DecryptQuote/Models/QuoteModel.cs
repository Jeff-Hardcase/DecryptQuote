using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DecryptQuote.Models
{
    public class QuoteModel
    {
        public string OriginalText { get; set; }
        public string[] SplitText { get; set; }
    }
}