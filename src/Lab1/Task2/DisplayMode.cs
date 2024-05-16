using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.Task2
{
    /// <summary>
    /// Режим отображения данных
    /// </summary>
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
}
