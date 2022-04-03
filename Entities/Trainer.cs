using StructureOfPrivateSchool.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructureOfPrivateSchool.Entities
{
    public class Trainer
    {
        public Trainer()
        {

        }

        public Trainer(int id, string firstName, string lastName, Subject subject)
        {
            ID = id;
            FirstName = firstName;
            LastName = lastName;
            Subject = subject;
        }

        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Subject Subject { get; set; }
        public List<Course> Courses { get; set; } = new List<Course>();
        public List<Student> Students { get; set; } = new List<Student>();

        public void Print()
        {
            Console.WriteLine($"{new string('-', 5)}-+{new string('-', 15)}+{new string('-', 15)}+{new string('-', 15)}+");
            Console.WriteLine($"|{ID,-5}|{FirstName,-15}|{LastName,-15}|{Subject,-15}|");
        }

        public void PrintTrainersFullName()
        {
            Console.WriteLine($"{new string('-', 15)}-+{new string('-', 15)}+{new string('-', 15)}+");
            Console.WriteLine($"|{FirstName,-15}|{LastName,-15}|{"",-15}|");
        }
    }
}
