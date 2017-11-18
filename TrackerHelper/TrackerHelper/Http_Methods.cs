using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace TrackerHelper
{
    class Http_Methods
    {
        CookieContainer cookies = new CookieContainer();

        #region http_post
        public void post_http(string url, string data)//создаём метод с двумя аргументами url и data
        {
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);//создаём экзепляр класса HttpWebRequest, req
            req.Method = "POST"; // выбираем метод запроса 
            req.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8"; // добавляем заголовок и его значение
            req.CookieContainer = cookies; // прикрепляем к запросу куки
            req.Headers.Add("DNT", "1");// добавляем заголовок и его значение
            req.UserAgent = "Mozilla/5.0 (Windows NT 6.1; WOW64; rv:17.0) Gecko/20100101 Firefox/17.0"; // можно выбрать другой UserAgent opera, chrome, IE
            req.Referer = "http://www.cyberforum.ru/"; // от куда мы пришли
            req.ContentType = "application/x-www-form-urlencoded"; // определяет тип документа для ответа, так же есть multipart
            using (var requestStream = req.GetRequestStream())//отправляем поток данных
            using (var sw = new StreamWriter(requestStream)) //создаём переменную в которой будет храниться запрос
            {
                sw.Write(data);//записываем в поток данные
            }

            using (var responseStream = req.GetResponse().GetResponseStream())//возвращаем поток данных
            using (var sr = new StreamReader(responseStream))//переменная в которой храниться ответ
            {
                var result = sr.ReadToEnd();//считывем ответ в переменную
                using (var sw = new StreamWriter("page.html", false, Encoding.GetEncoding(1251)))//false значит что файл будет перезаписываться каждый раз, и указываем кодировку ту что была на сайте
                    sw.Write(result);//записываем
            }
        }
        #endregion

        #region http_get
        public string get_http(string url)
        {
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
            req.UserAgent = "Mozilla/5.0 (Windows NT 6.1; WOW64; rv:17.0) Gecko/20100101 Firefox/17.0";
            req.CookieContainer = cookies;
            req.Headers.Add("DNT", "1");
            req.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8";
            HttpWebResponse resp = (HttpWebResponse)req.GetResponse();
            Stream stream = resp.GetResponseStream();
            StreamReader sr = new StreamReader(stream);            
            string text = sr.ReadToEnd();
            resp.Close();
            sr.Close();
            //   using (var sw = new StreamWriter("page1.html"))
            //       sw.Write(text);
            return text;
        }
        #endregion
    }

}
