using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using System.Web;


namespace HackerRankProblems.Implementations
{
    public class EsoServer
    {
        const string endPointUrl = "https://esoserverstatus.net/";


        public static Dictionary<string, string> GetEsoServersStatuses()
        {
            HtmlString html = GetEsoServerStatusPage();

            var doc = new HtmlDocument();
            doc.LoadHtml(html.ToHtmlString());

            var xpath = "//div[@class=\"list-group\"]/div[@class=\"list-group-item\"]/h4";
            HtmlNodeCollection itemList = doc.DocumentNode.SelectNodes(xpath);

            Dictionary<string, string> serverAndState = new Dictionary<string, string>();

            foreach (var item in itemList)
            {
                var texts = item.InnerText.Split(new string[] { "\r", "\n" }, StringSplitOptions.None);

                serverAndState.Add(texts[1].Trim(), texts[2].Trim());
            }

            return serverAndState;
        }

        public static HtmlString GetEsoServerStatusPage()
        {
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(endPointUrl);
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();

                Stream receiveStream = response.GetResponseStream();
                StreamReader readStream = new StreamReader(receiveStream, Encoding.UTF8);
                HtmlString htmlString = new HtmlString(readStream.ReadToEnd());

                response.Close();
                readStream.Close();

                return htmlString;
            }
            catch (WebException ex)
            {
                Console.WriteLine(ex.Message);           
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return null;
        }
    }
}
