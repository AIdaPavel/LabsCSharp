using System.Xml;


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
