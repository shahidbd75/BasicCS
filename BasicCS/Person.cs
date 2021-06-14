using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCS
{
    public static class Person
    {
        public static int Id { get; set; }
        public static string Name { get; set; }

        public static string GetNameCode()
        {
            return "Hello world";
        }
    }

    public class Student
    {
        public static void InsertAllStudent()
        {
            Console.WriteLine("All Srudent Inserted");
        }
    }
}
