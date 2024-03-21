

var EvenNumber = new int[6,8];
var OddNumber = new int[7,5];

void FillArray(int[,] array) 
{
    var RandomNumber = new Random(DateTime.Now.Microsecond);

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = RandomNumber.Next(100);
        }
    }
}

FillArray(EvenNumber);
FillArray(OddNumber);

void PrintArray(int[,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j]);

            if (array[i, j] < 10)
            {
                Console.Write("  ");
            } 
            else
            {
                Console.Write(" ");
            }
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

PrintArray(EvenNumber);
PrintArray(OddNumber);

void Swap(int[,] array)
{
    var Half = array.GetLength(1) / 2 - 1;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j <= Half; j++)
        {
            (array[i, j], array[i, array.GetLength(1) - j - 1]) 
                = (array[i, array.GetLength(1) - j - 1], array[i, j]);
        }
    }
}

Swap(EvenNumber);
Swap(OddNumber);

PrintArray(EvenNumber);
PrintArray(OddNumber);