using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Lab1.Task3
{ 
    /// <summary>
    /// Статический класс XmlParser для парсинга XML-данных
    /// </summary>
    public class XmlParser
    {
        // Метод для парсинга XML-строки в объект Log
        public static Log ParseXml(string xml)
        {
            // Создание нового объекта Log
            Log log = new Log();

            // Создание объекта XmlDocument для работы с XML-документом
            XmlDocument xmlDoc = new XmlDocument();

            // Загрузка XML-данных в объект XmlDocument
            xmlDoc.LoadXml(xml);

            // Выборка узлов с именем "event" из XML-документа
            XmlNodeList eventNodes = xmlDoc.SelectNodes("//event");

            // Итерация по узлам "event"
            foreach (XmlNode eventNode in eventNodes)
            {
                // Создание нового объекта Event
                Event newEvent = new Event();

                // Заполнение свойств объекта Event данными из атрибутов и дочерних узлов
                newEvent.Date = eventNode.Attributes["date"].Value.Trim(); // Извлечение значения атрибута "date"
                newEvent.Result = eventNode.Attributes["result"].Value.Trim(); // Извлечение значения атрибута "result"
                newEvent.IpFrom = eventNode.SelectSingleNode("ip-from").InnerText.Trim(); // Извлечение значения узла "ip-from"
                newEvent.Method = eventNode.SelectSingleNode("method").InnerText.Trim(); // Извлечение значения узла "method"
                newEvent.UrlTo = eventNode.SelectSingleNode("url-to").InnerText.Trim(); // Извлечение значения узла "url-to"
                newEvent.Response = eventNode.SelectSingleNode("response").InnerText.Trim(); // Извлечение значения узла "response"

                // Добавление нового объекта Event в список событий
                log.Events.Add(newEvent);
            }

            // Возврат объекта Log с заполненным списком событий
            return log;
        }
    }
}
