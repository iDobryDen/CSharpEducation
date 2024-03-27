using System;
using System.Xml.Linq;

namespace HW_5._1_8
{
	public class Student
	{
		public string FirstName;
        public string SecondName;
        public int Age;
        public string University;

		public void IntroduceYourself()
		{
			Console.WriteLine("Привет! Меня зовут Егор");
		}

        public Student(string _FirstName, string _SecondName, int _Age, string _University)
		{
            FirstName = _FirstName;
            SecondName = _SecondName;
            Age = _Age;
            University = _University;
        }
    }
}