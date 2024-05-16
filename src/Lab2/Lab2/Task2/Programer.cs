using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.Task2
{
    //Основной класс, для вызова
    public class Programer
    {
        //Класс, "содержаший" ХМЛ файл
        public static void ReadXML()
        {

            //Строка ХМЛ
            string xml = @" 
                        <shipOrder> 
                            <shipTo> 
                                <Name>Tove Svendson</Name> 
                                <street>Ragnhildvei 2</street> 
                                <addres>4000 Stavanger</addres> 
                                <country>Norway</country> 
                            </shipTo> 
                                <items> 
                                    <item> 
                                        <title>Empire Burlesque</title> 
                                        <quantity>1</quantity> 
                                        <Price>10,90</Price> 
                                    </item> 
                                    <item> 
                                        <title>Hide your heart</title> 
                                        <quantity>1</quantity> 
                                        <Price>9,90</Price> 
                                    </item> 
                                </items> 
                            </shipOrder>";

            //Вызов и Присвоение распарсенного  документа
            Order order = XmlParser.ParseXml(xml);

            //Вывод на корсоль данных
            Console.WriteLine($"Name: {order.Name}");
            Console.WriteLine($"Street: {order.Street}");
            Console.WriteLine($"Address: {order.Address}");
            Console.WriteLine($"Country: {order.Country}");
            Console.WriteLine("Items:");

            //Вывод на корсоль данных всех итемов "Вложенных объектов"
            foreach (Item item in order.Items)
            {
                Console.WriteLine($"Title: {item.Title}, Quantity: {item.Quantity}, Price: {item.Price}");
            }
        }
    }
}
