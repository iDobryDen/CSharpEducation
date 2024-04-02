﻿//Задание по Stack:
//Создайте класс Student. Добавьте в него два свойства Name и Age. Свойства должны быть доступны только для чтения.
//Инициализируйте их передачей значений в конструкторе. Можно использовать реализацию из других задач.
//В Program.Main создайте Stack студентов. Добавьте в него элементы программно, не запрашивая ничего у пользователя.
//Реализуйте поиск студента по имени и возрасту в стеке. 
//На входе: имя и возраст студента
//На выходе: объект типа Student. Если такого студента нет, то метод поиска должен вернуть null.
//Проверьте реализацию поиска в методе Main. Исходный стек после поиска должен содержать исходное количество
//элементов в том же порядке, в котором и был до поиска.


namespace Practice._8._2.Stack;

class Program
{
    static void Main(string[] args)
    {
        Stack<Student> students = new Stack<Student>();

        students.Push(new Student("Den", 35));
        students.Push(new Student("Egor", 30));
        students.Push(new Student("Igor", 25));
        students.Push(new Student("Den1", 34));
        students.Push(new Student("Egor1", 29));
        students.Push(new Student("Igor1", 24));
        students.Push(new Student("Den2", 33));
        students.Push(new Student("Egor2", 28));
        students.Push(new Student("Igor2", 23));
    }
}
public class Student
{
    public string Name { get; }
    public int Age { get; }
  

    public Student(string _name, int _age)
    {
        Name = _name;
        Age = _age;
        
    }
}

