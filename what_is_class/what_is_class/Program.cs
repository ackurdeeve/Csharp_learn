using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace what_is_class
{
    class Program
    {
        static void Main(string[] args)
        {
            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
            Console.WriteLine("Hello World!");
            Student stu1 = new Student(){ID = 1, Name = "Ackurdeeve"};//初始化器，默认构造器
            Console.WriteLine(stu1.ID);
            Console.WriteLine(stu1.Name);
            stu1.Report();
            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }

    class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public void Report()
        {
            Console.WriteLine($"I am #{ID} student, my name is {Name}.");
        }
    }
}
