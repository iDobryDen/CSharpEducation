//Задание по Queue:
//Создайте класс Student. Добавьте в него два свойства Name и Age. Свойства должны быть доступны только для чтения.
//Инициализируйте их передачей значений в конструкторе. Можно использовать реализацию из других задач.
//В Program.Main создайте Queue со студентами.
//Там же реализуйте меню.	
//“Добавить студента в очередь" – добавить студента в Queue со студентами.
//“Убрать следующего в очереди студента” – получить следующего в очереди студента и убрать его из очереди.
//“Узнать, кто следующий в очереди” – посмотреть кто следующий в очереди без извлечения из неё.

using System;

namespace Practice._8._3.Queue;

class Program
{
    static void Main(string[] args)
    {
        Queue<Student> students = new Queue<Student>();

        students.Enqueue(new Student("Den", 35));
        students.Enqueue(new Student("Egor", 30));
        students.Enqueue(new Student("Igor", 28));
        students.Enqueue(new Student("Den1", 36));
        students.Enqueue(new Student("Egor1", 31));
        students.Enqueue(new Student("Igor1", 29));
        students.Enqueue(new Student("Den2", 37));
        students.Enqueue(new Student("Egor2", 32));
        students.Enqueue(new Student("Igor2", 30));

        bool isRun = true;
        while (isRun == true)
        {
            Console.WriteLine("---------------------------");
            Console.WriteLine("1. Добавить студента в очередь");
            Console.WriteLine("2. Убрать следующего в очереди студента");
            Console.WriteLine("3. Узнать кто следующий в очереди");
            Console.WriteLine("4. Выход");
            Console.WriteLine("---------------------------");

            Console.WriteLine("Введите команду");
            int x = int.Parse(Console.ReadLine());

            if (x == 1)
            {
                Console.WriteLine("Введите имя нового студента:");
                var name_add = Console.ReadLine();
                Console.WriteLine("Введите возраст нового студента:");
                var age_add = int.Parse(Console.ReadLine());
                students.Enqueue(new Student(name_add, age_add));
            }
            if (x == 2)
            {
                students.Dequeue();
            }
            if (x == 3)
            {
                var firstStudent = students.Peek();
                Console.WriteLine($"Первый студет в очереди {firstStudent.Name} возрастом {firstStudent.Age}");
            }
            if (x == 4)
            {
                break;
            }
        }
    }
}
public class Student
{
    public string Name { get; }
    public int Age { get; }


    public Student(string _name, int _age)
    {
        Name = _name;
        this.Age = _age;
    }
}
