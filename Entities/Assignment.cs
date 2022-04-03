using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructureOfPrivateSchool.Entities
{
    public class Assignment
    {
        public Assignment()
        {

        }

        public Assignment(int iD, string title, string description, DateTime subDateTime, int oralMark, int totalMark)
        {
            ID = iD;
            Title = title;
            Description = description;
            SubDateTime = subDateTime;
            OralMark = oralMark;
            TotalMark = totalMark;
        }

        public int ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime SubDateTime { get; set; }
        public int OralMark { get; set; }
        public int TotalMark { get; set; }
        public Course Course { get; set; }
        public List<Student> Students { get; set; } = new List<Student>();

        public void Print()
        {
            Console.WriteLine($"{new string('-', 5)}-+{new string('-', 30)}+{new string('-', 30)}+{new string('-', 15)}+{new string('-', 15)}+{new string('-', 15)}+");
            Console.WriteLine($"|{ID,-5}|{Title,-30}|{Description,-30}|{SubDateTime.ToShortDateString(),-15}|{OralMark,-15}|{TotalMark,-15}|");
        }

        public void PrintAssignmentTitleAndDescription()
        {
            Console.WriteLine($"|{ "",-15}|{Title,-30}|{Description,-30}|");
        }

        //Method For StudentsPerCoursePerAssignment
        public void PrintAssignmentTitleAndDescription1()
        {
            Console.WriteLine($"|{ "",-15}|{ "",-15}|{ "",-15}|{Title,-30}|{Description,-30}|");
        }
    }
}
