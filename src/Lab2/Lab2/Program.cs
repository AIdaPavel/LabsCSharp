#region Main
//Лабораторная 2
//Задание 1
using Lab2.Task2;
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
#endregion
