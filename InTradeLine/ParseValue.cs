using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using HtmlAgilityPack;

namespace InTradeLine
{
    public class ParseValue
    {
        
        public static string ParseDollar()
        {
            var html = @"https://cbr.ru/";
            HtmlWeb web = new HtmlWeb();
            var htmlDoc = web.Load(html);
            var value = htmlDoc.DocumentNode.SelectSingleNode("//div[@class='w_data_wrap']").InnerText;
            string resultString = string.Join(string.Empty, Regex.Matches(value, @"\d{2}\,\d{4}").OfType<Match>().Select(m => m.Value));
            return resultString;
            
        }
    }
}
