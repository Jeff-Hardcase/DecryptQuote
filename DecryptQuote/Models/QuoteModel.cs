using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DecryptQuote.Models
{
    public class QuoteModel
    {
        public string OriginalText { get; set; }
        public Dictionary<string,int> KeyStats { get; set; }

        public QuoteModel()
        {
            KeyStats = new Dictionary<string, int>(StringComparer.InvariantCultureIgnoreCase);
        }
    }
}