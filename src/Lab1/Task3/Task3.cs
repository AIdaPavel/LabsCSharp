using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

#region Question3
namespace Lab1.Task3
{
    /// <summary>
    /// Главный класс программы
    /// </summary>
    public class Task3
    {
        // Точка входа в программу
        public static void Main()
        {
            // Определение XML-строки с данными о событиях
            string xml = "<log>" +
                            "<event date=\"27/may/1999:02:32:46\" result=\"success\">" +
                                "<ip-from>195.151.62.18</ip-from>" +
                                "<method>get</method>" +
                                "<url-to>/mise/</url-to>" +
                                "<response>200</response>" +
                            "</event>" +
                            "<event date=\"27/may/1999:02:41:47\" result=\"success\">" +
                                "<ip-from>195.209.248.12</ip-from>" +
                                "<method>get</method>" +
                                "<url-to>soft.htm</url-to>" +
                                "<response>200</response>" +
                            "</event>" +
                            "<event date=\"27/May/1999:02:32:46 \" result=\"success\">" +
                                "<ip-from> 195.151.62.18 </ip-from>" +
                                "<method>GET</method>" +
                                "<url-to> /mise/</url-to>" +
                                "<response>200</response>" +
                            "</event>" +
                            "<event date=\" 27/May/1999:02:41:47 \" result=\"success\">" +
                                "<ip-from> 195.209.248.12 </ip-from>" +
                                "<method>GET</method>" +
                                "<url-to>soft.htm</url-to>" +
                                "<response>200</response>" +
                            "</event>" +
                        "</log>";

            // Парсинг XML-строки в объект Log
            Log log = XmlParser.ParseXml(xml);

            // Вывод информации о событиях на консоль
            foreach (Event e in log.Events)
            {
                Console.WriteLine($"Date: {e.Date}");
                Console.WriteLine($"Result: {e.Result}");
                Console.WriteLine($"IP From: {e.IpFrom}");
                Console.WriteLine($"Method: {e.Method}");
                Console.WriteLine($"URL To: {e.UrlTo}");
                Console.WriteLine($"Response: {e.Response}");
                Console.WriteLine();
            }
        }
    }
}
#endregion
