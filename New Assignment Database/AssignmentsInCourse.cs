using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Part_A
{
    class AssignmentsInCourse
    {
        public Course course;
        public List<Assignment> assignmentsInCourse = new List<Assignment>();

        public AssignmentsInCourse(Course course, List<Assignment> assignmentsInCourse)
        {
            this.course = course;
            this.assignmentsInCourse = assignmentsInCourse;
            course.assignmentsInCourse = assignmentsInCourse; // βαζω τη λίστα με τα assignments του μαθηματος στο συγκεκριμένο μάθημα
            foreach (var assignment in assignmentsInCourse)
            {
                assignment.course = course;
            }
        }

        public void OutputAssignmentsInCourse()
        {
            int i = 1;  // αριθμει το καθε assignment
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(course.Title + " " + course.Type);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.White;
            foreach (var assignment in assignmentsInCourse)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("\tAssignment "+i+": ");
                Console.ForegroundColor = ConsoleColor.White;
                assignment.Output();

                if (i < assignmentsInCourse.Count)   //ΔΕΝ ΕΚΤΥΠΩΝΕΙ ΤΗ ΓΙΡΛΑΝΤΑ (ΔΙΑΚΕΚΟΜΜΕΝΗ ΓΡΑΜΜΗ) ΜΕΤΑ ΤΟ ΤΕΛΕΥΤΑΙΟ ASSIGNMENT
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\t"+new string('-', (92+assignment.Title.Length+assignment.SubDateTime.ToString().Length+ 
                        assignment.OralMark.ToString().Length+assignment.TotalMark.ToString().Length+ assignment.Description.Length)));
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\t" + new string('~', (92 + assignment.Title.Length + assignment.SubDateTime.ToString().Length +
                        assignment.OralMark.ToString().Length + assignment.TotalMark.ToString().Length + assignment.Description.Length)));
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine();
                }
                i++;
               
                
            }
        }
    }
}
