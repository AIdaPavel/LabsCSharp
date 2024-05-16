using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.Task2
{
    /// <summary>
    /// Класс для старосты группы
    /// </summary>
    public class HeadStudent : Student //  Класс наследуется от класа "Студент"
    {
        public string Position { get; set; } // Получить или установить Старосту группы
    }
}
