using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Question2
namespace Lab1.Task2
{
    /// <summary>
    /// Основной класс где все формируется
    /// </summary>
    public class Task2
    {
        /// <summary>
        /// Метод инициализации
        /// Вызывает и инициалезирует все классы
        /// </summary>
        public static void ClassStudents()
        {
            // Создает 2х студентов
            Student student1 = new Student { Name = "Alice", Age = 20 };
            Student student2 = new Student { Name = "Bob", Age = 21 };
            // Создает Старосту и через наследование присваивает его как старосту
            HeadStudent headStudent = new HeadStudent { Name = "Charlie", Age = 22, Position = "Head" };

            // Создает список группы
            Group group = new Group
            {
                // Добавляет в список всех студентов
                Students = new List<Student> { student1, student2 },
                Head = headStudent
            };

            // Создаем переменные для последующего вызова
            DisplayMode displayMode = new DisplayMode();
            EditMode editMode = new EditMode();

            // Режим отображения данных до редактирования
            displayMode.DisplayGroupData(group);

            // Режим редактирования данных
            editMode.EditStudentData(student1, "Alice Smith", 21);
            editMode.EditHeadStudentData(headStudent, "Vice Head");

            // Режим отображения данных после редактирования
            displayMode.DisplayGroupData(group);
        }
    }
}
#endregion
