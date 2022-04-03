using StructureOfPrivateSchool.Entities;
using StructureOfPrivateSchool.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructureOfPrivateSchool.Database
{
    public class MyDatabase
    {
        public List<Course> Courses { get; set; } = new List<Course>();
        public List<Trainer> Trainers { get; set; } = new List<Trainer>();
        public List<Student> Students { get; set; } = new List<Student>();
        public List<Assignment> Assignments { get; set; } = new List<Assignment>();

        public MyDatabase()
        {
            //Synthetic Data
            #region Courses
            Course c1 = new Course(1, "Python", "CB-12", "Part Time", new DateTime(2019, 02, 07), new DateTime(2019, 08, 07));
            Course c2 = new Course(2, "JavaScript", "CB-13", "Full Time", new DateTime(2020, 09, 04), new DateTime(2020, 12, 04));
            Course c3 = new Course(3, "Java", "CB-14", "Full Time", new DateTime(2020, 09, 04), new DateTime(2020, 12, 04));
            Course c4 = new Course(4, "C#", "CB-15", "Part Time", new DateTime(2021, 10, 10), new DateTime(2022, 04, 22));
            #endregion

            #region Trainers
            Trainer t1 = new Trainer(1, "Ektoras", "Gkatsos", Subject.BackEnd);
            t1.Courses = new List<Course>() { c1, c4 };
            c1.Trainers.Add(t1);
            c4.Trainers.Add(t1);

            Trainer t2 = new Trainer(2, "Nikos", "Korompos", Subject.BackEnd);
            t2.Courses = new List<Course>() { c1, c4 };
            c1.Trainers.Add(t2);
            c4.Trainers.Add(t2);

            Trainer t3 = new Trainer(3, "Giannis", "Petaloudas", Subject.BackEnd);
            t3.Courses = new List<Course>() { c1, c4 };
            c1.Trainers.Add(t3);
            c4.Trainers.Add(t3);

            Trainer t4 = new Trainer(4, "Marios", "Dermetzoglou", Subject.FrontEnd);
            t4.Courses = new List<Course>() { c2 };
            c2.Trainers.Add(t4);

            Trainer t5 = new Trainer(5, "Despoina", "Vasiliou", Subject.OOP);
            t5.Courses = new List<Course>() { c3 };
            c3.Trainers.Add(t5);

            Trainer t6 = new Trainer(6, "Maria", "Pentagiotisa", Subject.OOP);
            t6.Courses = new List<Course>() { c3 };
            c3.Trainers.Add(t6);

            Trainer t7 = new Trainer(7, "Mixalis", "Arseniou", Subject.FrontEnd);
            t7.Courses = new List<Course>() { c2 };
            c2.Trainers.Add(t7);

            Trainer t8 = new Trainer(8, "Alikh", "Antonopoulou", Subject.BackEnd);
            t8.Courses = new List<Course>() { c1, c4 };
            c1.Trainers.Add(t8);
            c4.Trainers.Add(t8);
            #endregion

            #region Students
            Student s1 = new Student(1, "Christos", "Dimitrakopoulos", new DateTime(1995, 10, 21), 0);
            s1.Courses = new List<Course>() { c4 };
            c4.Students.Add(s1);

            Student s2 = new Student(2, "Theofilos", "Grigoriadis", new DateTime(1993, 03, 12), 2500);
            s2.Courses = new List<Course>() { c4 };
            c4.Students.Add(s2);

            Student s3 = new Student(3, "Zafiris", "Argiros", new DateTime(1995, 10, 19), 2500);
            s3.Courses = new List<Course>() { c4 };
            c4.Students.Add(s3);

            Student s4 = new Student(4, "Stratos", "Aggelakoudis", new DateTime(1999, 12, 10), 0);
            s4.Courses = new List<Course>() { c4 };
            c4.Students.Add(s4);

            Student s5 = new Student(5, "Andreas", "Kratsas", new DateTime(1985, 03, 10), 2500);
            s5.Courses = new List<Course>() { c4 };
            c4.Students.Add(s5);

            Student s6 = new Student(6, "Tasos", "Maurodoglosis", new DateTime(1992, 10, 10), 0);
            s6.Courses = new List<Course>() { c1 };
            c1.Students.Add(s6);

            Student s7 = new Student(7, "Alexandros", "Kanavos", new DateTime(1980, 03, 02), 2500);
            s7.Courses = new List<Course>() { c1 };
            c1.Students.Add(s7);

            Student s8 = new Student(8, "Babis", "Markos", new DateTime(1993, 11, 10), 0);
            s8.Courses = new List<Course>() { c1 };
            c1.Students.Add(s8);

            Student s9 = new Student(9, "Andreas", "Karampalis", new DateTime(1995, 04, 28), 2500);
            s9.Courses = new List<Course>() { c1 };
            c1.Students.Add(s9);

            Student s10 = new Student(10, "Petros", "Sotiropoulos", new DateTime(1999, 10, 06), 0);
            s10.Courses = new List<Course>() { c1 };
            c1.Students.Add(s10);

            Student s11 = new Student(11, "Aris", "Gerakelis", new DateTime(1994, 10, 25), 2500);
            s11.Courses = new List<Course>() { c2 };
            c2.Students.Add(s11);

            Student s12 = new Student(12, "Alexandros", "Adamopoulos", new DateTime(1991, 10, 12), 0);
            s12.Courses = new List<Course>() { c2 };
            c2.Students.Add(s12);

            Student s13 = new Student(13, "Bagelis", "Antwniou", new DateTime(1989, 01, 11), 0);
            s13.Courses = new List<Course>() { c2 };
            c2.Students.Add(s13);

            Student s14 = new Student(14, "Giorgos", "Sulas", new DateTime(1995, 06, 08), 2500);
            s14.Courses = new List<Course>() { c2 };
            c2.Students.Add(s14);

            Student s15 = new Student(15, "Nikolas", "Groubas", new DateTime(1995, 09, 30), 2500);
            s15.Courses = new List<Course>() { c2 };
            c2.Students.Add(s15);

            Student s16 = new Student(16, "Nikos", "Stasinopoulos", new DateTime(1993, 04, 18), 0);
            s16.Courses = new List<Course>() { c3 };
            c3.Students.Add(s16);

            Student s17 = new Student(17, "Nikiforos", "Mpaths", new DateTime(1991, 10, 12), 2500);
            s17.Courses = new List<Course>() { c3 };
            c3.Students.Add(s17);

            Student s18 = new Student(18, "Boula", "Mpalatasi", new DateTime(1980, 03, 02), 0);
            s18.Courses = new List<Course>() { c3 };
            c3.Students.Add(s18);

            Student s19 = new Student(19, "Vaso", "Arseniou", new DateTime(1999, 12, 10), 2500);
            s19.Courses = new List<Course>() { c3 };
            c3.Students.Add(s19);

            Student s20 = new Student(20, "Eleni", "Skeuh", new DateTime(1993, 11, 10), 0);
            s20.Courses = new List<Course>() { c3 };
            c3.Students.Add(s20);
            #endregion

            #region Assignments
            Assignment a1 = new Assignment(1, "Assignment 1", "Create a banking system", new DateTime(2022, 10, 21), 40, 60);
            Assignment a2 = new Assignment(2, "Assignment 2", "Create an e-shop layout", new DateTime(2022, 11, 06), 50, 50);
            Assignment a3 = new Assignment(3, "Assignment 3", "Create a functional calculator", new DateTime(2022, 05, 03), 30, 70);
            Assignment a4 = new Assignment(4, "Assignment 4", "Create a game", new DateTime(2022, 09, 26), 30, 70);
            Assignment a5 = new Assignment(5, "Assignment 5", "Create a game", new DateTime(2021, 12, 12), 20, 80);
            Assignment a6 = new Assignment(6, "individual Project", "Create a web site", new DateTime(2021, 12, 30), 40, 60);
            Assignment a7 = new Assignment(7, "Team Project", "Create a server", new DateTime(2022, 12, 29), 10, 90);
            c1.Assignments = new List<Assignment>() { a1, a2, a3, a4, a5, a6, a7 };
            a1.Course = c1;
            a2.Course = c1;
            a3.Course = c1;
            a4.Course = c1;
            a5.Course = c1;
            a6.Course = c1;
            a7.Course = c1;

            Assignment a8 = new Assignment(8, "Assignment 6", "Create a banking system", new DateTime(2022, 10, 21), 40, 60);
            Assignment a9 = new Assignment(9, "Assignment 7", "Create an e-shop layout", new DateTime(2022, 11, 06), 50, 50);
            Assignment a10 = new Assignment(10, "Assignment 8", "Create a functional calculator", new DateTime(2022, 05, 03), 30, 70);
            Assignment a11 = new Assignment(11, "Assignment 9", "Create a game", new DateTime(2022, 09, 26), 30, 70);
            Assignment a12 = new Assignment(12, "Assignment 10", "Create a game", new DateTime(2021, 12, 12), 20, 80);
            Assignment a13 = new Assignment(13, "individual Project", "Create a web site", new DateTime(2021, 12, 30), 40, 60);
            Assignment a14 = new Assignment(14, "Team Project", "Create a server", new DateTime(2022, 12, 29), 10, 90);
            c2.Assignments = new List<Assignment>() { a8, a9, a10, a11, a12, a13, a14 };
            a8.Course = c2;
            a9.Course = c2;
            a10.Course = c2;
            a11.Course = c2;
            a12.Course = c2;
            a13.Course = c2;
            a14.Course = c2;

            Assignment a15 = new Assignment(15, "Assignment 11", "Create a banking system", new DateTime(2022, 10, 21), 40, 60);
            Assignment a16 = new Assignment(16, "Assignment 12", "Create an e-shop layout", new DateTime(2022, 11, 06), 50, 50);
            Assignment a17 = new Assignment(17, "Assignment 13", "Create a functional calculator", new DateTime(2022, 05, 03), 30, 70);
            Assignment a18 = new Assignment(18, "Assignment 14", "Create a game", new DateTime(2022, 09, 26), 30, 70);
            Assignment a19 = new Assignment(19, "Assignment 15", "Create a game", new DateTime(2021, 12, 12), 20, 80);
            Assignment a20 = new Assignment(20, "individual Project", "Create a web site", new DateTime(2021, 12, 30), 40, 60);
            Assignment a21 = new Assignment(21, "Team Project", "Create a server", new DateTime(2022, 12, 29), 10, 90);
            c3.Assignments = new List<Assignment>() { a15, a16, a17, a18, a19, a20, a21 };
            a15.Course = c3;
            a16.Course = c3;
            a17.Course = c3;
            a18.Course = c3;
            a19.Course = c3;
            a20.Course = c3;
            a21.Course = c3;

            Assignment a22 = new Assignment(22, "Assignment 16", "Create a banking system", new DateTime(2022, 10, 21), 40, 60);
            Assignment a23 = new Assignment(23, "Assignment 17", "Create an e-shop layout", new DateTime(2022, 11, 06), 50, 50);
            Assignment a24 = new Assignment(24, "Assignment 18", "Create a functional calculator", new DateTime(2022, 05, 03), 30, 70);
            Assignment a25 = new Assignment(25, "Assignment 19", "Create a game", new DateTime(2022, 09, 26), 30, 70);
            Assignment a26 = new Assignment(26, "Assignment 20", "Create a game", new DateTime(2021, 12, 12), 20, 80);
            Assignment a27 = new Assignment(27, "individual Project", "Create a web site", new DateTime(2021, 12, 30), 40, 60);
            Assignment a28 = new Assignment(28, "Team Project", "Create a server", new DateTime(2022, 12, 29), 10, 90);
            c4.Assignments = new List<Assignment>() { a22, a23, a24, a25, a26, a27, a28 };
            a22.Course = c4;
            a23.Course = c4;
            a24.Course = c4;
            a25.Course = c4;
            a26.Course = c4;
            a27.Course = c4;
            a28.Course = c4;
            #endregion

            //Populate Data
            List<Course> courses = new List<Course>() { c1, c2, c3, c4 };
            Courses.AddRange(courses);
            List<Student> students = new List<Student>() { s1, s2, s3, s4, s5, s6, s7, s8, s9, s10, s11, s12, s13, s14, s15, s16, s17, s18, s19, s20 };
            Students.AddRange(students);
            List<Trainer> trainers = new List<Trainer>() { t1, t2, t3, t4, t5, t6, t7, t8 };
            Trainers.AddRange(trainers);
            List<Assignment> assignments = new List<Assignment>() { a1, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, a12, a13, a14, a15, a16, a17, a18, a19, a20, a21, a22, a23, a24, a25, a26, a27, a28 };
            Assignments.AddRange(assignments);
        }
    }
}