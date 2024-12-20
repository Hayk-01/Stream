using System;
using System.Collections.Generic;

namespace UniversityApp
{
    // Student class
    public class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Major { get; set; }

        public Student(string name, int age, string major)
        {
            Name = name;
            Age = age;
            Major = major;
        }

        public override string ToString()
        {
            return $"Name: {Name}, Age: {Age}, Major: {Major}";
        }
    }

    // University class
    public class University
    {
        public List<Student> Students { get; set; } = new List<Student>();

        // Events
        public event Action<Student> OnAdd;
        public event Action<Student> OnRemove;

        // Method to add a student
        public void AddStudent(Student student)
        {
            Students.Add(student);
            OnAdd?.Invoke(student); // Trigger OnAdd event
        }

        // Method to remove a student
        public void RemoveStudent(Student student)
        {
            if (Students.Contains(student))
            {
                Students.Remove(student);
                OnRemove?.Invoke(student); // Trigger OnRemove event
            }
            else
            {
                Console.WriteLine("Student not found.");
            }
        }

        // Method to display all students
        public void DisplayStudents()
        {
            if (Students.Count == 0)
            {
                Console.WriteLine("No students in the list.");
                return;
            }

            foreach (var student in Students)
            {
                Console.WriteLine(student);
            }
        }
    }

    // Program to interact with the user
    class Program
    {
        static void Main(string[] args)
        {
            University university = new University();

            // Subscribe to events
            university.OnAdd += student => Console.WriteLine($"Student added: {student}");
            university.OnRemove += student => Console.WriteLine($"Student removed: {student}");

            bool running = true;

            while (running)
            {
                Console.WriteLine("\nUniversity Management System");
                Console.WriteLine("1. Add a new student");
                Console.WriteLine("2. Remove a student");
                Console.WriteLine("3. View all students");
                Console.WriteLine("4. Exit");
                Console.Write("Choose an option: ");

                var choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        // Add a new student
                        Console.Write("Enter student's name: ");
                        string name = Console.ReadLine();

                        Console.Write("Enter student's age: ");
                        int age = int.Parse(Console.ReadLine());

                        Console.Write("Enter student's major: ");
                        string major = Console.ReadLine();

                        Student newStudent = new Student(name, age, major);
                        university.AddStudent(newStudent);
                        break;

                    case "2":
                        // Remove a student
                        Console.Write("Enter the student's name to remove: ");
                        string removeName = Console.ReadLine();

                        var studentToRemove = university.Students.Find(s => s.Name.Equals(removeName, StringComparison.OrdinalIgnoreCase));

                        if (studentToRemove != null)
                        {
                            university.RemoveStudent(studentToRemove);
                        }
                        else
                        {
                            Console.WriteLine("Student not found.");
                        }
                        break;

                    case "3":
                        // View all students
                        university.DisplayStudents();
                        break;

                    case "4":
                        // Exit
                        running = false;
                        break;

                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }
        }
    }
}

