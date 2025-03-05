using PdfSharp.Pdf.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MTG_Proxy_to_PDF
{
    public class DeckListConverter
    {
        public static List<string> ProcessList(List<string> inputList)
        {
            List<string> result = new List<string>();

            foreach (var item in inputList)
            {
                string pattern = @"^\d+\s+(.+?)\s+\(\w+\)\s+\d+";
                Match match = Regex.Match(item, pattern);

                if (match.Success)
                    result.Add(match.Groups[1].Value);
            }

            return result;
        }
    }
}
