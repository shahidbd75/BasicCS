using System;
#nullable enable
namespace BasicCS
{
    public struct StudentStruct
    {
        public string FirstName;
        public string? MiddleName;
        public string LastName;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person.Id = 0;
            Person.Name = "Ab";

            Console.WriteLine(Person.GetNameCode());

            Student std = new Student();

            Student.InsertAllStudent();
            PrintStudent(default);
        }

        public static void PrintStudent(StudentStruct student)
        {
            Console.WriteLine($"First name: {student.FirstName.ToUpper()}");
            Console.WriteLine($"Middle name: {student.MiddleName.ToUpper()}");
            Console.WriteLine($"Last name: {student.LastName.ToUpper()}");
        }

    }


}
