using System;
using System.Collections.Generic;


public class Teacher
{
    //public static void Main(string[] args)
    //{
    //    ProgrammerTeacher teacher = new ProgrammerTeacher();
    //    teacher.AddLanguage("C#");
    //    teacher.AddLanguage("Python");

    //    Programmer programmer = new Programmer();
    //    teacher.Teach(programmer, "Python");
    //    teacher.Teach(programmer, "C#");

    //    foreach (var language in programmer.Languages)
    //        Console.WriteLine(language);
    //}


    public class Programmer
    {
        public List<string> Languages { get; set; } = new List<string>();

        public void AddLanguage(string language)
        {
            Languages.Add(language);
        }

    }

    public class ProgrammerTeacher : Programmer
    {
        public bool Teach(Programmer programmer, string language)
        {
            if (Languages.Contains(language))
            {
                programmer.Languages.Add(language);
                return true;
            }

            return false;
        }
    }
}