using System;
using System.IO;

namespace StudentEnrollment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string directoryPath = @"C:\Users\dings\Documents\Requirements"; 

            string[] requiredFiles = 
            {
                "GOODMORAL.docx",
                "FORM137.docx",
                "SHSDIPLOMA.docx",
                "PSA.docx",
                "MEDCERT.docx"
            };

            Console.WriteLine("--Student Enrollment--");
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            Console.Write("Are you a new or existing student? (1 for New, 2 for Existing): ");
            string studentStatus = Console.ReadLine();

            if (studentStatus == "1")
            {
                HandleNewStudent(directoryPath, requiredFiles);
            }
            else if (studentStatus == "2")
            {
                HandleExistingStudent();
            }
            else
            {
                Console.WriteLine("Invalid status. Please enter '1' or '2'.");
                return;
            }

            DisplayCourses();

            Console.Write("Select your course: ");
            string course = Console.ReadLine();

            if (course.Equals("Nursing", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("You selected Nursing.");
            }
            else if (course.Equals("MedTech", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("You selected MedTech.");
            }
            else
            {
                Console.WriteLine("Invalid course selection.");
            }

            Console.Write("Payment option (1 for Cash, 2 for Installment): ");
            string paymentOption = Console.ReadLine();

            if (paymentOption == "1")
            {
                Console.WriteLine("You chose to pay in cash. The total is 32,000 pesos.");
            }
            else if (paymentOption == "2")
            {
                Console.WriteLine("You chose to pay in installments. Deposit: 10,000 pesos, 6,250 pesos per quarter.");
            }
            else
            {
                Console.WriteLine("Invalid payment option.");
            }
        }

        static void HandleNewStudent(string directoryPath, string[] requiredFiles)
        {
            Console.WriteLine("Welcome, new student!");
            Console.Write("Please enter your campus location: ");
            string campusLocation = Console.ReadLine();
            Console.WriteLine($"You are enrolling at the {campusLocation} campus.");

            Console.WriteLine("You need to submit the following documents:");
            foreach (string file in requiredFiles)
            {
                while (true)
                {
                    Console.Write($"Do you have the {Path.GetFileNameWithoutExtension(file)}? (Yes/No): ");
                    string response = Console.ReadLine();

                    if (response.Equals("Yes", StringComparison.OrdinalIgnoreCase))
                    {
                        Console.WriteLine($"{Path.GetFileNameWithoutExtension(file)} is available.");
                        break;
                    }
                    else if (response.Equals("No", StringComparison.OrdinalIgnoreCase))
                    {
                        Console.WriteLine($"Please make sure to obtain the {Path.GetFileNameWithoutExtension(file)}.");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid response. Please answer 'Yes' or 'No'.");
                    }
                }
            }
        }

        static void HandleExistingStudent()
        {
            Console.WriteLine("Welcome back, existing student!");
            Console.Write("Please enter your campus location: ");
            string campusLocation = Console.ReadLine();
            Console.WriteLine($"You are continuing your studies at the {campusLocation} campus.");
            Console.WriteLine("Since you're already a student, no additional documents are required.");
        }

        static void DisplayCourses()
        {
            Console.WriteLine("Available courses:");
            Console.WriteLine("1. Nursing - Focuses on patient care, medical practices, and healthcare principles.");
            Console.WriteLine("2. MedTech (Medical Technology) - Emphasizes laboratory work, medical diagnostics, and health sciences.");
        }
    }
}
