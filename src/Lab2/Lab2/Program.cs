#region Main
//Лабораторная 2
//Задание 1
using System.Xml;

Console.WriteLine("Лабораторная работа 2");
Console.WriteLine("Задание 1\n");

//Вызов метода чтения файлов
Read();

//Задание 2
Console.WriteLine("Задание 2");
//вызов метода чтения ХМЛ
Programer.ReadXML();

#endregion

#region Functions
//Функция чтения файла по Заданию 1 ЛП2
static void Read()
{
    //Используем попытку
    try
    {
        List<string> sentences = new List<string>();

        // Чтение предложений из файла
        using (StreamReader sr = new StreamReader("C:\\Users\\Arche\\OneDrive\\Desktop\\textfile.txt"))
        {
            string line;

            //Считываем строки в файле не больше 3х штук
            while ((line = sr.ReadLine()) != null && sentences.Count < 3)
            {
                //Добавляем полученные строки в список
                sentences.Add(line);
            }

        }

        // Вывод предложений в обратном порядке
        for (int i = sentences.Count - 1; i >= 0; i--)
        {
            //Вывод строки
            Console.WriteLine(sentences[i]);
        }
    }
    //Вызываем исключение если попытка была неудачная
    catch (Exception e)
    {
        //Вывод текст ошибки в консоль
        Console.WriteLine("Ошибка: " + e.Message);
    }
}

//Задание 2
// Класс для представления товара
public class Item
{
    public string Title //Конструктор для поля строки Заголовка
    {
        get; set;
    }
    public int Quantity //Конструктор для числового поля Объема
    {
        get; set;
    }
    public decimal Price //Конструктор для числового поля Цены
    {
        get; set;
    }
}
// Класс для представления заказа
public class Order
{
    public string Name //Конструктор для поля строки Имени
    {
        get; set;
    }
    public string Street //Конструктор для поля строки Улицы
    {
        get; set;
    }
    public string Address //Конструктор для поля строки Адреса
    {
        get; set;
    }
    public string Country //Конструктор для поля строки Улицы
    {
        get; set;
    }
    public List<Item> Items //Конструктор для списка
    {
        get; set;
    }
    //
    public Order()

    {
        // Задаем итему новый список
        Items = new List<Item>();
    }
}

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



#endregion
