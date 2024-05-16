using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.Task2
{
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
}
