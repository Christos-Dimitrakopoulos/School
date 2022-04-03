using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructureOfPrivateSchool.Entities
{
    public class Course
    {
        public Course()
        {

        }

        public Course(int id, string title, string stream, string type, DateTime startDate, DateTime endDate)
        {
            ID = id;
            Title = title;
            Stream = stream;
            Type = type;
            StartDate = startDate;
            EndDate = endDate;
        }

        public int ID { get; set; }
        public string Title { get; set; }
        public string Stream { get; set; }
        public string Type { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public List<Trainer> Trainers { get; set; } = new List<Trainer>();
        public List<Student> Students { get; set; } = new List<Student>();
        public List<Assignment> Assignments { get; set; } = new List<Assignment>();

        public void Print()
        {
            Console.WriteLine($"{new string('-', 5)}-+{new string('-', 15)}+{new string('-', 15)}+{new string('-', 15)}+{new string('-', 15)}+{ new string('-', 15) }+");
            Console.WriteLine($"|{ID,-5}|{Title,-15}|{Stream,-15}|{Type,-15}|{StartDate.ToShortDateString(),-15}|{EndDate.ToShortDateString(),-15}|");
        }

        public void PrintCourseTitle()
        {
            Console.WriteLine($"|{ "",-15}|{ "",-15}|{Title,-15}|");
        }

        //Method for AssignmentsPerCourse
        public void PrintCourseTitle1()
        {
            Console.WriteLine($"|{Title,-15}|{ "",-30}|{"",-30}|");
        }

        //Method for StudentsPerCourse
        public void PrintCourseTitle2()
        {
            Console.WriteLine($"|{Title,-15}|{ "",-15}|{"",-15}|");
        }

        //Method For StudentsPerCoursePerAssignment
        public void PrintCourseTitle3()
        {
            Console.WriteLine($"|{ Title,-15}|{ "",-15}|{ "",-15}|{"",-30}|{"",-30}|");
        }
    }
}