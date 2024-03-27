//1. +Создайте файл Student и в нём public класс Student.
//2. +Добавьте в класс поля, которые считаете нужными, чтобы описать Student.Например, имя, фамилия, возраст, университет, и т.д.
//3. +Добавьте в класс метод IntroduceYourself, который был писал в консоль приветствие. Например: "Привет! Меня зовут Егор".
//4. +Добавьте в класс конструктор, который принимает аргументы, количество и тип которых соответствует количеству и типу полей класса.
//5. +В классе Program создайте массив, состоящий из Student.Наполните его студентами.
//6. +Выведите список студентов красиво на экран консоли
//7. +Выведите список студентов, старше 21 года на экран консоли.
//8. Выведите на экран консоли самого взрослого и самого младшего студента.
namespace HW_5._1_8;

class Program
{
    static void Main(string[] args)
    {
        //Student Egor = new Student();
        //Egor.IntroduceYourself();

        Student[] Students = new Student[]
        {
            new Student( "Egor", "OneFamily", 30, "UdGU"),
            new Student( "Denis", "TwoFamily", 35, "UdGU"),
            new Student( "Igor", "ThreeFamily", 18, "IzhGTU"),
        };

        foreach (Student Stud in Students)
        {
            if (Stud.Age > 21)
            {
                Console.WriteLine($"Студент {Stud.FirstName} {Stud.SecondName} возрастом {Stud.Age} учится в {Stud.University}");
            }
        }
    }
}

