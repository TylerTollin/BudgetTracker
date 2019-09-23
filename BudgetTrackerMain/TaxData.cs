using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.IO;
using System.Text.RegularExpressions;
using System.Text;
using System.Threading.Tasks;

namespace BudgetTrackerMain
{
    class TaxData
    {
        private void GetTaxData()
        {
            WebClient web = new WebClient();

            string url = "https://www.quickenloans.com/blog/federal-income-tax-brackets";

            String html = web.DownloadString(url);

            MatchCollection m1 = Regex.Matches(html, @"", RegexOptions.Singleline);
        }
    }
}
