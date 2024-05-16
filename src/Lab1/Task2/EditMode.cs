using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.Task2
{
    /// <summary>
    /// Режим редактирования данных
    /// </summary>
    public class EditMode
    {
        // Изменяет имя и возраст студента по переданным данным
        public void EditStudentData(Student student, string newName, int newAge)
        {
            student.Name = newName; // Задает новое имя
            student.Age = newAge;   // Задает новый возраст
        }

        // Изменяет старосту по переданным данным
        public void EditHeadStudentData(HeadStudent headStudent, string newPosition)
        {
            headStudent.Position = newPosition; // Задает нового старосту
        }
    }
}
