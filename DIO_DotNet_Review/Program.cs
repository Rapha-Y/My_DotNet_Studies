using System;

namespace DIO_DotNet_Review
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose your desired option:");
            Console.WriteLine("1. Insert new student");
            Console.WriteLine("2. List students");
            Console.WriteLine("3. Calculate grades average");
            Console.WriteLine("X. Quit");
            Console.WriteLine();

            string userOption = Console.ReadLine();

            while(userOption.ToUpper() != "X") {
                switch(userOption) {
                    case "1": 
                        //TODO: insert student
                        break;
                    case "2":
                        //TODO: list students
                        break;
                    case "3":
                        //TODO: calc average grade
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }

                Console.WriteLine("Choose your desired option:");
                Console.WriteLine("1. Insert new student");
                Console.WriteLine("2. List students");
                Console.WriteLine("3. Calculate grades average");
                Console.WriteLine("X. Quit");
                Console.WriteLine();

                userOption = Console.ReadLine();
            }
        }
    }
}
