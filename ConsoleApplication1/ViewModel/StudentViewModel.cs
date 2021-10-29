using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication1.Model;

namespace ConsoleApplication1.ViewModel
{
    public class StudentViewModel
    {
        public List<StudentModel> ListOfSudents = new List<StudentModel>();
        public StudentModel model;
        public void AddStudents()
        {
            ListOfSudents.Add(model);
        }     
        
        
        public void DisplayMenu()
        {
            Console.WriteLine("1. Add Student:");
            Console.WriteLine("2. Remove Student:");
            Console.WriteLine("3. Display Student list:");
            Console.Write("Select options:");

            var option = Console.ReadLine();
            switch(option)
            {
                case "1":
                    AddStudent();
                    break;
                case "3":
                    DisplayStudent();
                    break;
                default:
                    Console.WriteLine("Invalid input");
                    DisplayMenu();
                    break;

            }
        }   


        public void AddStudent()
        {
            model = new StudentModel();
            Console.WriteLine("Enter Firstname: ");
            model.Firstname = Console.ReadLine();
            Console.WriteLine("Enter Lastname: ");
            model.Lastname = Console.ReadLine();
            ListOfSudents.Add(model);
            DisplayMenu();
        }


        public void DisplayStudent()
        {
            Console.WriteLine("List of students");
            ListOfSudents.ForEach(student =>
            {
                Console.WriteLine($"{student.Lastname}, {student.Firstname}");
            });

            DisplayMenu();

        }
    }
}
