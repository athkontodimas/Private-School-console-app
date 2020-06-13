using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Part_A
{
    class StudentsInCourse
    {
        public Course Course { set; get; }
        public Student Student { set; get; }
        

        public List<Student> studentsInCourse { set; get; } = new List<Student>();
        
        //---------------------------------- CONSTRUCTOR FOR INDIVIDUAL STUDENT AND COURSE-------------------------------------------------------
        public StudentsInCourse(Student student, Course course)
        {
            Course = course;
            Student = student;
            student.Courses.Add(course); //προσθετω το μάθημα στη λίστα μαθηματων του μαθητη
            course.studentsInCourse.Add(student); //προσθέτω το μαθητή στη λίστα μαθητών του μαθήματος
        }
        //------------------------------------------------- CONSTRUCTOR WITH A STUDENT LIST -------------------------------
        public StudentsInCourse(List<Student> students, Course course)
        {
            Course = course;
            studentsInCourse = students;           
            course.studentsInCourse.AddRange(students); //προσθέτω το μαθητή στη λίστα μαθητών του μαθήματος
            foreach (var student in studentsInCourse)
            {                
                student.Courses.Add(course); //προσθετω το μάθημα στη λίστα μαθηματων του μαθητη

            }
            
        }

       
        public void OutputStudents()
        {
            int i = 1;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(" "+Course.Title+" | "+Course.Type);
            Console.WriteLine(new string('=', (14 + Course.Title.Length + Course.Type.Length)));
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\tStudents");
            
            foreach (Student mathiti in studentsInCourse)
            {
                //mathiti.Output(); //print with full details
                Console.ForegroundColor = ConsoleColor.Magenta;
                
                Console.Write(" "+i+": ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(mathiti.FirstName + " " + mathiti.LastName); //print only first and last name
                Console.WriteLine(" "+new string('-', (4 + mathiti.LastName.Length + mathiti.FirstName.Length)));
                i++;
            }
        }
        
    }
}
