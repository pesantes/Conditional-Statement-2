/*
 Author: Fernando Pesantes
 Date: 1/20/2019
 Assignment: Conditional Statement Class Project for ISM 4300. 
 I need to ask the user what they expect to recieve in ISM 4300. INTEGER VALE
 Then display the letter grade per the syllabus.
 */

using System;

namespace Condtional_Statement_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Here the user is asked for input
            Console.WriteLine("Please enter the number grade you expect in ISM 4300...");
            /* 
             Try catch block to validate the input from the user
             The user will handle errors for bad inputs
             a message will be displayed
            */
            try
            {
                // This variable will obtain the input from the user.
                string input = Console.ReadLine();
                /*
                 This variable will be stored for letterGrade after the
                 input variable has been parsed to integer
                 */
                int numberGrade = int.Parse(input);
                /*
                 If statements for grades
                 Going to try to use just write line messages for the ifs
                 */
                 if((numberGrade >= 98) && (numberGrade <= 100))
                {
                    Console.WriteLine("Your expected grade is A+");
                    Console.ReadKey(true);
                }
                 if((numberGrade >= 92) && (numberGrade <= 97))
                {
                    Console.WriteLine("Your expected grade is A");
                    Console.ReadKey(true);
                }
                 if((numberGrade >= 90) && (numberGrade <= 91))
                {
                    Console.WriteLine("Your expected grade is A-");
                    Console.ReadKey(true);
                }
                 if((numberGrade >= 88) && (numberGrade <= 89))
                {
                    Console.WriteLine("Your expected grade is B+");
                    Console.ReadKey(true);
                }
                 if ((numberGrade >= 82) && (numberGrade <= 87))
                {
                    Console.WriteLine("Your expected grade is B");
                    Console.ReadKey(true);
                }
                 if ((numberGrade >= 80) && (numberGrade <= 81))
                {
                    Console.WriteLine("Your expected grade is B-");
                    Console.ReadKey(true);
                }
                 if ((numberGrade >= 78) && (numberGrade <= 79))
                {
                    Console.WriteLine("Your expected grade is C+");
                    Console.ReadKey(true);
                }
                 if ((numberGrade >= 72) && (numberGrade <= 77))
                {
                    Console.WriteLine("Your expected grade is C");
                    Console.ReadKey(true);
                }
                if ((numberGrade >= 70) && (numberGrade <= 71))
                {
                    Console.WriteLine("Your expected grade is C-");
                    Console.ReadKey(true);
                }
                if ((numberGrade >= 68) && (numberGrade <= 69))
                {
                    Console.WriteLine("Your expected grade is D+");
                    Console.ReadKey(true);
                }
                if ((numberGrade >= 62) && (numberGrade <= 67))
                {
                    Console.WriteLine("Your expected grade is D");
                    Console.ReadKey(true);
                }
                if ((numberGrade >= 60) && (numberGrade <= 61))
                {
                    Console.WriteLine("Your expected grade is D-");
                    Console.ReadKey(true);
                }
                if ((numberGrade >= 0) && (numberGrade < 60))
                {
                    Console.WriteLine("Your expected grade is F");
                    Console.ReadKey(true);
                }
            } // End of try
            catch
            {
                Console.WriteLine("Please use a whole integer for your expected letter grade");
                Console.WriteLine("Press any key to exit the program and try again");
                Console.ReadKey(true);
            } // End of catch
        } // End of Main
    } // End of class
} // End of namespace
