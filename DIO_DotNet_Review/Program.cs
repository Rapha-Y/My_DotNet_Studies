using System;

namespace DIO_DotNet_Review
{
    class Program
    {
        static void Main(string[] args)
        {
            Student[] students = new Student[5];
            var stdIndex = 0;
            string userOption = GetUserOption();

            while(userOption.ToUpper() != "X") 
            {
                switch(userOption) 
                {
                    case "1": 
                    
                        Student student = new Student();

                        Console.WriteLine("Type the student's name:");
                        student.Name = Console.ReadLine();

                        Console.WriteLine("Type the student's grade:");
                        if(decimal.TryParse(Console.ReadLine(), out decimal grade)) 
                        {
                            student.Grade = grade;
                        } else {
                            throw new ArgumentException("Grade value must be a decimal");
                        }

                        students[stdIndex] = student;
                        stdIndex++;

                        break;

                    case "2":

                        foreach(var std in students) 
                        {
                            if(!string.IsNullOrEmpty(std.Name)) 
                            {
                                Console.WriteLine($"Student: {std.Name} - Grade: {std.Grade}");
                            }
                        }

                        break;

                    case "3":
                        
                        decimal totalGrade = 0;
                        var studentNumber = 0;

                        for(int i = 0; i < students.Length; i++) 
                        {
                            if(!string.IsNullOrEmpty(students[i].Name)) 
                            {
                                totalGrade += students[i].Grade;
                                studentNumber++;
                            }
                        }

                        var average = totalGrade/studentNumber;
                        EnumConcept concept;

                        if(average < 4.5m)
                        {
                            concept = EnumConcept.F;
                        }
                        else if(average < 5)
                        {
                            concept = EnumConcept.D;
                        }
                        else if(average < 7)
                        {
                            concept = EnumConcept.C;
                        }
                        else if(average < 9)
                        {
                            concept = EnumConcept.B;
                        }
                        else
                        {
                            concept = EnumConcept.A;
                        }

                        Console.WriteLine($"Average grade: {average} - Concept: {concept}");
                        
                        break;

                    default:
                        throw new ArgumentOutOfRangeException();
                }
                userOption = GetUserOption();
            }
        }

        private static string GetUserOption() 
        {
            Console.WriteLine();
            Console.WriteLine("Choose your desired option:");
            Console.WriteLine("1. Insert new student");
            Console.WriteLine("2. List students");
            Console.WriteLine("3. Calculate grades average");
            Console.WriteLine("X. Quit");
            Console.WriteLine();

            string userOption = Console.ReadLine();
            return userOption;
        }
    }
}
