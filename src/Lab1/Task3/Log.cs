using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.Task3
{
    /// <summary>
    /// Определение класса Log для представления журнала событий
    /// </summary>
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
}
