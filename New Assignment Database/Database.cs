using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Part_A
{

    class Database
    {
        public List<Student> students = new List<Student>();
        public List<Trainer> trainers = new List<Trainer>();
        public List<Assignment> assignments = new List<Assignment>();
        public List<Course> courses = new List<Course>();
        public List<StudentsInCourse> studInCourse = new List<StudentsInCourse>();
        public List<TrainersInCourse> trainInCourse = new List<TrainersInCourse>();
        public List<AssignmentsInCourse> assignmentsInCourse = new List<AssignmentsInCourse>();
        

       

        public Database()
        {
            Student s1 = new Student("Sotiris", "Papadopoulos", 1985, 2500);
            Student s2 = new Student("Maria", "Giannakopoulou", 1993, 2250);
            Student s3 = new Student("Giannis", "Golas", 1998, 2500);
            Student s4 = new Student("Kyriakh", "Nolemh", 1979, 1200);
            Student s5 = new Student("Giwrgos", "Ipatiou", 1995, 2500);
            Student s6 = new Student("Mixalis", "Kwnstantinou", 1988, 2500);
            Student s7 = new Student("Athanasios", "Liopidas", 1990, 2250);
            Student s8 = new Student("Panagiotis", "Sekinas", 1989, 2500);
            Student s9 = new Student("Hlias", "Liopis", 1982, 2500);
            Student s10 = new Student("Vasilikh", "Xouliara", 1991, 2500);
            students.Add(s1);
            students.Add(s2);
            students.Add(s3);
            students.Add(s4);
            students.Add(s5);
            students.Add(s6);
            students.Add(s7);
            students.Add(s8);
            students.Add(s9);
            students.Add(s10);

            Course c1 = new Course(title: "CB8", stream: "C#", type: "Part-time", startDate: new DateTime(2019, 2, 10), endDate: new DateTime(2019, 8, 1));
            Course c2 = new Course(title: "CB9", stream: "Java", type: "Part-time", startDate: new DateTime(2019, 4, 5), endDate: new DateTime(2019, 10, 1));
            Course c3 = new Course(title: "CB9", stream: "C#", type: "Full-time", startDate: new DateTime(2019, 4, 5), endDate: new DateTime(2019, 7, 11));
            Course c4 = new Course(title: "CB10", stream: "SQL", type: "Part-time", startDate: new DateTime(2019, 11, 07), endDate: new DateTime(2020, 1, 10));
            Course c5 = new Course(title: "CB10", stream: "Java", type: "Full-time", startDate: new DateTime(2019, 11, 5), endDate: new DateTime(2020, 6, 1));
            Course c6 = new Course(title: "CB11", stream: "HTML", type: "Full-time", startDate: new DateTime(2019, 12, 07), endDate: new DateTime(2020, 1, 10));
            courses.Add(c1);
            courses.Add(c2);
            courses.Add(c3);
            courses.Add(c4);
            courses.Add(c5);
            courses.Add(c6);
            Assignment a1 = new Assignment("Eshop","Create an e-shop", new DateTime(2019,02,20), 21, 95);
            Assignment a2 = new Assignment("Database", "Create a database", new DateTime(2019 , 04,  05), 40, 81);
            Assignment a3 = new Assignment("Website", "Create a dynamic website", new DateTime(2019, 06 , 10), 32, 92);
            Assignment a4 = new Assignment("School", "Create a school database", new DateTime(2020, 03, 12), 24, 90);
            Assignment a5 = new Assignment("Blog", "Create a blog", new DateTime(2020, 03, 25), 45, 100);
            Assignment a6 = new Assignment("Script", "Create a visual basic script", new DateTime(2020, 03, 25), 45, 100);
            Assignment a7 = new Assignment("Mobile", "Create a mobile app", new DateTime(2020, 03, 25), 45, 100);
            assignments.Add(a1);
            assignments.Add(a2);
            assignments.Add(a3);
            assignments.Add(a4);
            assignments.Add(a5);
            assignments.Add(a6);
            assignments.Add(a7);
            Trainer t1 = new Trainer("George","Pikoulis", "Communications");
            Trainer t2 = new Trainer("Giannis", "Sotiriou", "Databases");
            Trainer t3 = new Trainer("Efthimios", "Dimitriou", "Unit Testing");
            Trainer t4 = new Trainer("Petros", "Afentras", "Mobile Architectures");
            Trainer t5 = new Trainer("Kyriakos", "Pampelas", "Security");
            Trainer t6 = new Trainer("Xaralampos", "Eleutheriou", "ECDL");
            trainers.Add(t1);
            trainers.Add(t2);
            trainers.Add(t3);
            trainers.Add(t4);
            trainers.Add(t5);
            trainers.Add(t6);
            List<Student> studentsC1 = new List<Student> { s1,s2,s5 }; //φτιαχνω λιστα με τους μαθητές στο course 1
            List<Student> studentsC2 = new List<Student> { s2,s4,s6 }; ////φτιαχνω λιστα με τους μαθητές στο course 2
            List<Student> studentsC3 = new List<Student> { s3, s7, s9 }; ////φτιαχνω λιστα με τους μαθητές στο course 3
            List<Student> studentsC4 = new List<Student> { s10, s8 }; ////φτιαχνω λιστα με τους μαθητές στο course 4
            List<Student> studentsC5 = new List<Student> { s1, s2, s4, s5, s7, s8 }; ////φτιαχνω λιστα με τους μαθητές στο course 5
            List<Student> studentsC6 = new List<Student> { s1, s9, s6, s5 }; ////φτιαχνω λιστα με τους μαθητές στο course 6
            StudentsInCourse sc1 = new StudentsInCourse(studentsC1,c1); //φτιαχνω αντικειμενα που περιεχουν τους μαθητές στο course 1
            StudentsInCourse sc2 = new StudentsInCourse(studentsC2,c2);  //φτιαχνω αντικειμενα που περιεχουν τους μαθητές στο course 2
            StudentsInCourse sc3 = new StudentsInCourse(studentsC3, c3);  //φτιαχνω αντικειμενα που περιεχουν τους μαθητές στο course 3
            StudentsInCourse sc4 = new StudentsInCourse(studentsC4, c4);  //φτιαχνω αντικειμενα που περιεχουν τους μαθητές στο course 4
            StudentsInCourse sc5 = new StudentsInCourse(studentsC5, c5);  //φτιαχνω αντικειμενα που περιεχουν τους μαθητές στο course 5
            StudentsInCourse sc6 = new StudentsInCourse(studentsC6, c6);  //φτιαχνω αντικειμενα που περιεχουν τους μαθητές στο course 6
            studInCourse.Add(sc1);  // αποθηκεύω σε λίστα τα απραπανω αντικειμενα
            studInCourse.Add(sc2);
            studInCourse.Add(sc3);
            studInCourse.Add(sc4);
            studInCourse.Add(sc5);
            studInCourse.Add(sc6);

            List<Trainer> trainersC1 = new List<Trainer> {t1, t6};// φτιαχνω λιστα με τους trainers σε κάθε course
            List<Trainer> trainersC2 = new List<Trainer> {t2, t3};
            List<Trainer> trainersC3 = new List<Trainer> {t1, t2};
            List<Trainer> trainersC4 = new List<Trainer> {t2, t3,t1};
            List<Trainer> trainersC5 = new List<Trainer> {t3, t5, t4};
            List<Trainer> trainersC6 = new List<Trainer> {t6, t4};

            TrainersInCourse trCour1 = new TrainersInCourse(c1, trainersC1);// φτιαχνω αντικείμενα με τους trainers του συγκεκριμένου course
            TrainersInCourse trCour2 = new TrainersInCourse(c2, trainersC2);
            TrainersInCourse trCour3 = new TrainersInCourse(c3, trainersC3);
            TrainersInCourse trCour4 = new TrainersInCourse(c4, trainersC4);
            TrainersInCourse trCour5 = new TrainersInCourse(c5, trainersC5);
            TrainersInCourse trCour6 = new TrainersInCourse(c6, trainersC6);

            trainInCourse.Add(trCour1);//αποθηκεύω σε λίστα τα απραπανω αντικειμενα
            trainInCourse.Add(trCour2);
            trainInCourse.Add(trCour3);
            trainInCourse.Add(trCour4);
            trainInCourse.Add(trCour5);
            trainInCourse.Add(trCour6);
           
            List<Assignment> assignmentsC1 = new List<Assignment> { a1, a2, a3 };  //list containing assignments for course 1
            List<Assignment> assignmentsC2 = new List<Assignment> { a2, }; //list containing assignments for course 2
            List<Assignment> assignmentsC3 = new List<Assignment> { a2,a3 };  //list containing assignments for course 3
            List<Assignment> assignmentsC4 = new List<Assignment> { a4 }; //list containing assignments for course 4
            List<Assignment> assignmentsC5 = new List<Assignment> { a5, a6,};  //list containing assignments for course 5
            List<Assignment> assignmentsC6 = new List<Assignment> { a6, a7}; //list containing assignments for course 6
            AssignmentsInCourse assignCourse1 = new AssignmentsInCourse(c1, assignmentsC1); // create object with the list of assignments for course 1
            AssignmentsInCourse assignCourse2 = new AssignmentsInCourse(c2, assignmentsC2); // create object with the list of assignments for course 2
            AssignmentsInCourse assignCourse3 = new AssignmentsInCourse(c3, assignmentsC3); // create object with the list of assignments for course 3
            AssignmentsInCourse assignCourse4 = new AssignmentsInCourse(c4, assignmentsC4); // create object with the list of assignments for course 4
            AssignmentsInCourse assignCourse5 = new AssignmentsInCourse(c5, assignmentsC5); // create object with the list of assignments for course 5
            AssignmentsInCourse assignCourse6 = new AssignmentsInCourse(c6, assignmentsC6); // create object with the list of assignments for course 6
            assignmentsInCourse.Add(assignCourse1);
            assignmentsInCourse.Add(assignCourse2);
            assignmentsInCourse.Add(assignCourse3);
            assignmentsInCourse.Add(assignCourse4); 
            assignmentsInCourse.Add(assignCourse5);
            assignmentsInCourse.Add(assignCourse6);

            
        }

        
    }//end class database



}

