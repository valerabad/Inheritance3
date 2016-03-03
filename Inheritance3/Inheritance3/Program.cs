using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Inheritance3
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                int task;
                Console.WriteLine("Enter task 1 or 2");
                int.TryParse(Console.ReadLine(), out task);
                switch (task)
                { 
                    case 1:
                        Printer p;
                        p = new Printer();
                        p.Print("test message");

                        p = new JetPrinter();
                        ((JetPrinter)p).Print("test message");
                        p = new InkPrinter();

                        ((InkPrinter)p).Print("test message");
                        p = new LaserPrinter();
                        ((LaserPrinter)p).Print("test message");
                    break;
                    case 2:
                        Pupil badPupil = new BadPupil("Иванов");
                        Pupil goodPupil = new GoodPupil("Сидоров");
                        Pupil exelentPupil = new ExcelentPupil("Петров");
                        Pupil testPupil = new GoodPupil("Бадица");

                        Classroom classroom = new Classroom(badPupil, goodPupil, exelentPupil, testPupil);
                        classroom.showInfo();
                    break;
                }
                
            }          
            Console.ReadKey();
        }
    }
}

