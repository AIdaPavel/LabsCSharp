using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Lab2.Task2
{
    //Класс разбора ХМЛ файла
    public static class XmlParser
    {
        public static Order ParseXml(string xml)
        {
            //Создаем экземпляр класса
            Order order = new Order();

            //Задаем "эмулятор" ХМЛ документа
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(xml);

            //Читаем ХМЛ файл
            XmlNode shipToNode = doc.SelectSingleNode("/shipOrder/shipTo");
            order.Name = shipToNode.SelectSingleNode("Name")?.InnerText;
            order.Street = shipToNode.SelectSingleNode("street")?.InnerText;
            order.Address = shipToNode.SelectSingleNode("addres")?.InnerText;
            order.Country = shipToNode.SelectSingleNode("country")?.InnerText;
            XmlNodeList itemNodes = doc.SelectNodes("/shipOrder/items/item");

            //Проходимся по каждому итему
            foreach (XmlNode itemNode in itemNodes)
            {

                //Создаем каждый итем
                Item item = new Item
                {
                    //Присваивание каждому итему параметры
                    Title = itemNode.SelectSingleNode("title")?.InnerText,
                    Quantity = int.Parse(itemNode.SelectSingleNode("quantity")?.InnerText),
                    Price = decimal.Parse(itemNode.SelectSingleNode("Price")?.InnerText)
                };

                order.Items.Add(item);
            }

            //Возвращаем распарсенный объект
            return order;
        }
    }
}
