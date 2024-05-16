using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.Task2
{
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
}
