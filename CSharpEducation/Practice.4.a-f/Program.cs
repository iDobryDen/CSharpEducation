namespace Practice._4.a_f;

//Это задачи должны быть выполнены в одном проекте в одном классе Program.
//В методе Main создайте массив строк, содержащий имена студентов.Заполните его не менее чем 5-ю произвольными именами.
//Напишите метод для вывода на экран всех имён студентов из массива.
//Напишите метод для добавления нового студента в группу. Метод должен принимать имя нового студента в качестве аргумента.
//Напишите метод для проверки находится ли студент в списке.Метод должен принимать через аргумент имя студента и признак того,
//есть ли студент в списке.
//Напишите метод, который будет очищать список студентов.
//** В методе Main напишите программу, которая бы выводила пользователю меню.Пример на картинке.Когда пользователь вводит цифру в консоль,
//то будет срабатывать определённая команда и вызываться определённый метод, реализованный в заданиях выше.
//Метод по удалению конкретного студента из списка реализуйте дополнительно.


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("1. Добавить студента");
        Console.WriteLine("2. Показать всех студентов");
        Console.WriteLine("3. Удалить студента");
        Console.WriteLine("4. Очистить список");
        Console.WriteLine("5. Проверить имя в списке");
        Console.WriteLine("6. Выход");

        string[] Names = new string[] { "Anna", "Denis", "Artem", "Sonya", "Egor" };

        Console.WriteLine("Выберете команду: ");
        int a = int.Parse(Console.ReadLine());
        if (a == 1)
        {
            Console.WriteLine("Введите имя нового студента: ");
            string newname = Console.ReadLine();
            AddName(ref Names, newname);
            PrintNames(Names);
        }
        else if (a == 2)
        {
            PrintNames(Names);
        }
        else if (a == 3)
        {
            Console.WriteLine("Введите имя студента, которого хотите удалить: ");
            string DelName = Console.ReadLine();
            DeleteName(ref Names, DelName);
            PrintNames(Names);
        }
        else if (a == 4)
        {
            CleanNames(Names);
            Console.WriteLine("список после очистки такой: ");
            PrintNames(Names);
        }
        else if (a == 5)
        {
            Console.WriteLine("Введите имя которое хотите проверить в списке: ");
            string check_name = Console.ReadLine();
            CheckName(Names, check_name);
        }
        else if (a == 6)
        {
            Console.WriteLine("Выход из программы");
            return;
        }
        else
        {
            Console.WriteLine($"Введенная команда: " + a + " недоступна");
        }

    }

    public static void DeleteName(ref string[] names, string DelName)
    {
        int n = names.Length;
        string[] Names_bezdel = new string[] { };
        for (int i = 0; i < names.Length; i++)
        {
            if (names[i] != DelName)
            {
                names[i] = Names_bezdel[i];
                names = Names_bezdel;
            }
            else
            {

            }
            Names_plus_1[i] = names[i];
        }
        Names_plus_1[Names_plus_1.Length - 1] = newName;
        names = Names_plus_1;
    }

    public static void CleanNames(string[] args)
    {
        int n = args.Length;
        string[] Names_clean = new string[n];
        for (int i = 0; i < args.Length; i++)
        {
            args[i] = null;
        }
        args = Names_clean;
    }

    public static void PrintNames(string[] args)
    {
        foreach (var item in args)
        {
            Console.WriteLine(item + " ");
        }
    }

    public static void AddName(ref string[] names, string newName)
    {
        int n = names.Length;
        string[] Names_plus_1 = new string[n + 1];
        for (int i = 0; i < Names_plus_1.Length - 1; i++)
        {
            Names_plus_1[i] = names[i];
        }
        Names_plus_1[Names_plus_1.Length - 1] = newName;
        names = Names_plus_1;
    }

    public static void CheckName(string[] names, string check_name)
    {
        int a = 0;
        int b = 0;
        for (int i = 0; i < names.Length; i++)
        {
            if (names[i] != check_name)
            {
                a = 0;
            }
            else
            {
                a = 1;
                b = b + a;
                Console.WriteLine($"Имя " + check_name + " в списке студентов");
            }
        }
        if (b == 0)
        {
            Console.WriteLine($"Имя " + check_name + " нет в списке студентов");
        }
    }
}

