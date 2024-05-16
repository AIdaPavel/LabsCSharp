using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.Task3
{
    /// <summary>
    /// Определение класса Event для представления информации о событии
    /// </summary>
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
}
