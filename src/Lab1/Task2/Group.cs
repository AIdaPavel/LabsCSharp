using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.Task2
{
    /// <summary>
    /// Класс для группы студентов
    /// </summary>
    public class Group
    {
        public List<Student> Students { get; set; } // Получить или установить Список студентов
        public HeadStudent Head { get; set; }       // Получить или установить Старосты группы
    }
}
