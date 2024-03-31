//Задание по List
//Создайте класс Student. Добавьте в него два свойства Name и Age.
//Свойства должны быть доступны только для чтения.
//Инициализируйте их передачей значений в конструкторе.
//В Program.Main создайте список и студентов.
//Там же реализуйте меню:
//
//Пункты 1-3 должны делать то, что и описывают.
//Работать они должны с ранее созданным списком студентов.

namespace Practice._8._1.List;

class Program
{
    static void Main(string[] args)
    {

        List<Student> students = new List<Student>();
        //List<Student> students = [];

        int num = 0;
        bool isRun = true;
        while (isRun == true)
        {
            Console.WriteLine("---------------------------");
            Console.WriteLine("1. Добавить студента");
            Console.WriteLine("2. Удалить студента");
            Console.WriteLine("3. Вывести список студентов");
            Console.WriteLine("4. Выход");
            Console.WriteLine("---------------------------");

            Console.WriteLine("Введите команду");
            int x = int.Parse(Console.ReadLine());

            if (x == 1)
            {
                Console.WriteLine("Введите имя:");
                var name_add = Console.ReadLine();
                Console.WriteLine("Введите возраст:");
                var age_add = int.Parse(Console.ReadLine());
                num++;
                students.Add(new Student(name_add, age_add, num));
            }
            if (x == 2)
            {
                Console.WriteLine("Введите номер студента, которого хотите удалить:");
                PrintList();
                var num_del = int.Parse(Console.ReadLine());

                students.RemoveAt(num_del-1);
                //students.Remove(num_del);
            }
            if (x == 3)
            {
                Console.WriteLine("---------------------------");
                PrintList();
            }
            if (x == 4)
            {
                break;
            }
        }
        void PrintList()
        {
            foreach (var stud in students)
            {
                Console.WriteLine($"{stud.Num}. {stud.Name}, {stud.Age}");
            }
        }
    }

        //students.Add(new Student("Den", 35));
        //students.Add(new Student("Egor", 30));
        //students.Add(new Student("Igor", 25));
        //Console.WriteLine("Hello, World!");
}

//public class Student
//{
//    public string Name { get; }
//    public int Age { get; }
//    public static int Num = 0;

public class Student
{
    public string Name { get; }
    public int Age { get; }
    public int Num { get; }

    public Student(string _name, int _age, int _num)
    {
        Name = _name;
        Age = _age;
        Num = _num;
    }
}

//Вопрос, как правильно написать строку 51