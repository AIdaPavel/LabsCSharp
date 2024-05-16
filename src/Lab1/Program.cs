using System.Text.RegularExpressions;
using System.Xml;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml.Linq;
using System.Collections.Generic;


#region Main
//Лабораторная 1
//Задание 1
//Создаем 2 массива разной длины
var EvenNumber = new int[6, 8];
var OddNumber = new int[7, 5];

//Заполнение массивов случайными числами
FillArray(EvenNumber);
FillArray(OddNumber);

//Вывод полученныч массивов на экран
PrintArray(EvenNumber);
PrintArray(OddNumber);

//Меняем столбцы местами, первым и последним с движением к центру
Swap(EvenNumber);
Swap(OddNumber);

//Выводим полученный результат после обмена
PrintArray(EvenNumber);
PrintArray(OddNumber);

//Лабораторная 1
//Задание 2
//Вывод результата Задания 2
ProgramClass.ClassStudents();

// Разделение между заданиями
Console.WriteLine();

//Лабораторная 1
//Задание 3
//Вывод результата Задания 3
ProgramXML.Main();

#endregion

#region Functions

//Функция, заполняющая массив случайными числами
static void FillArray(int[,] array) 
{
    var RandomNumber = new Random(DateTime.Now.Microsecond); //Гениратор рандомных чисел

    //Вложенный цикл. Пробегает по всем элементам массива и присваивает рандомное число
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            //Заполнение Элемента случайным числом
            array[i, j] = RandomNumber.Next(100);
        }
    }
}



//Функция, вывода массива на экран
static void PrintArray(int[,] array)
{

    //Вложенный цикл. Пробегает по всему массиву и выводит каждый элемент на экран
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j]); //Печать Элемента на экран

            //Условие для уравнения визуального выравнивания при печати массива на экран
            if (array[i, j] < 10)
            {
                Console.Write("  "); 
            } 
            else
            {
                Console.Write(" ");
            }
        }
        Console.WriteLine();    //Разделение строки массива
    }
    Console.WriteLine();        //Переход на новую строку, чтобы разделить информацию на экране
}

//Функция, меняющая местами столбцы
static void Swap(int[,] array)
{
    //Середину длины строки
    var Half = array.GetLength(1) / 2 - 1;  

    //Вложенный цикл. Мемяем местами элементы колонок
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j <= Half; j++)
        {
            //Алгоритм замены
            (array[i, j], array[i, array.GetLength(1) - j - 1]) 
                = (array[i, array.GetLength(1) - j - 1], array[i, j]);
        }
    }
}

#endregion

#region Question2
// Базовый класс для студента
public class Student
{
    public string Name { get; set; } // Получить или установить Имя студента
    public int Age { get; set; }     // Получить или установить Возраст студента
}

// Класс для старосты группы
public class HeadStudent : Student       //  Класс наследуется от класа "Студент"
{
    public string Position { get; set; } // Получить или установить Старосту группы
}

// Класс для группы студентов
public class Group
{
    public List<Student> Students { get; set; } // Получить или установить Список студентов
    public HeadStudent Head { get; set; }       // Получить или установить Старосты группы
}

// Режим отображения данных
public class DisplayMode
{
    // Отображение класса "Студенты"
    public void DisplayStudentData(Student student)
    {
        // Выводит на дисплей Имя и возраст студента
        Console.WriteLine($"Student Name: {student.Name}");
        Console.WriteLine($"Student Age: {student.Age}");
    }

    // Отображение класса "Группы"
    public void DisplayGroupData(Group group)
    {
        // Перебирает группы студентов
        foreach (var student in group.Students)
        {
            // Вызывает метод отображения студентов в группе
            DisplayStudentData(student);
        }

        // Выводит на экран Старосту группы
        Console.WriteLine($"Head Student Name: {group.Head.Name}");
        Console.WriteLine($"Head Student Position: {group.Head.Position}");
    }
}

// Режим редактирования данных
public class EditMode
{
    // Изменяет имя и возраст студента по переданным данным
    public void EditStudentData(Student student, string newName, int newAge)
    {
        student.Name = newName; // Задает новое имя
        student.Age = newAge;   // Задает новый возраст
    }

    // Изменяет старосту по переданным данным
    public void EditHeadStudentData(HeadStudent headStudent, string newPosition)
    {
        headStudent.Position = newPosition; // Задает нового старосту
    }
}

// Основной класс где все формируется
class ProgramClass
{
    //Метод инициализации
    public static void ClassStudents()
    {
        // Создает 2х студентов
        Student student1 = new Student { Name = "Alice", Age = 20 };
        Student student2 = new Student { Name = "Bob", Age = 21 };
        // Создает Старосту и через наследование присваивает его как старосту
        HeadStudent headStudent = new HeadStudent { Name = "Charlie", Age = 22, Position = "Head" };

        // Создает список группы
        Group group = new Group
        {
            // Добавляет в список всех студентов
            Students = new List<Student> { student1, student2 },
            Head = headStudent
        };

        // Создаем переменные для последующего вызова
        DisplayMode displayMode = new DisplayMode();
        EditMode editMode = new EditMode();

        // Режим отображения данных до редактирования
        displayMode.DisplayGroupData(group);

        // Режим редактирования данных
        editMode.EditStudentData(student1, "Alice Smith", 21);
        editMode.EditHeadStudentData(headStudent, "Vice Head");

        // Режим отображения данных после редактирования
        displayMode.DisplayGroupData(group);
    }
}
#endregion

#region Question3
// Определение класса Event для представления информации о событии
public class Event
{
    // Свойства класса Event
    public string Date { get; set; } // Дата события
    public string Result { get; set; } // Результат события
    public string IpFrom { get; set; } // IP-адрес источника
    public string Method { get; set; } // Метод запроса
    public string UrlTo { get; set; } // URL-адрес 
    public string Response { get; set; } // Ответ сервера
}

// Определение класса Log для представления журнала событий
public class Log
{
    // Свойство класса Log для хранения списка событий
    public List<Event> Events { get; set; }

    // Конструктор класса Log
    public Log()
    {
        // Инициализация списка событий при создании объекта
        Events = new List<Event>();
    }
}

// Статический класс XmlParser для парсинга XML-данных
public static class XmlParser
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

// Главный класс программы
class ProgramXML
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
#endregion
