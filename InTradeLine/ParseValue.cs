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
        
        public static double ParseDollar()
        {
            var html = @"https://cbr.ru/";
            HtmlWeb web = new HtmlWeb();
            var htmlDoc = web.Load(html);
            var value = htmlDoc.DocumentNode.SelectSingleNode("(//div[@class='w_data_wrap'])[1]").InnerText;
            string resultString = string.Join(string.Empty, Regex.Matches(value, @"\d{2}\,\d{4}").OfType<Match>().Select(m => m.Value));
            return Convert.ToDouble(resultString);
        }
        public static double ParseEuro()
        {
            var html = @"https://cbr.ru/";
            HtmlWeb web = new HtmlWeb();
            var htmlDoc = web.Load(html);
            var value = htmlDoc.DocumentNode.SelectSingleNode("(//div[@class='w_data_wrap'])[2]").InnerText;
            string resultString = string.Join(string.Empty, Regex.Matches(value, @"\d*\,\d*").OfType<Match>().Select(m => m.Value));
            return Convert.ToDouble(resultString);
        }
        public static double ParseBTC()
        {
            var html = @"https://bitinfocharts.com/ru/markets/";
            HtmlWeb web = new HtmlWeb();
            var htmlDoc = web.Load(html);
            var value = htmlDoc.DocumentNode.SelectSingleNode("//a[@class='conv_cur']").InnerText;
            string resultString = string.Join(string.Empty, Regex.Matches(value, @"\d\,\d*").OfType<Match>().Select(m => m.Value));
            resultString = resultString.Replace(",", "");
            double toRub = Math.Round((Convert.ToDouble(resultString) * ParseDollar()), 0);
            return Convert.ToDouble(toRub);
        }
        public static double ParseETH()
        {
            var html = @"https://bitinfocharts.com/ru/markets/";
            HtmlWeb web = new HtmlWeb();
            var htmlDoc = web.Load(html);
            var value = htmlDoc.DocumentNode.SelectSingleNode("(//a[@class='conv_cur'])[2]").InnerText;
            string resultString = string.Join(string.Empty, Regex.Matches(value, @"\d*\.\d*").OfType<Match>().Select(m => m.Value));
            resultString = resultString.Replace(".", ",");
            double toRub = Math.Round((Convert.ToDouble(resultString) * ParseDollar()), 0);
            return Convert.ToDouble(toRub);
        }
    }
}
