using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Part_A
{
    class AssignmentsPerStudent
    {
        public Student student;
        public List<Assignment> assignmentsStudent = new List<Assignment>();
        
        
        public List<AssignmentsInCourse> assignmentsInCourse { set; get; } = new List<AssignmentsInCourse>();

        public AssignmentsPerStudent(Student student, List<Assignment> assignmentsStudent)
        {
            this.student = student;
            this.assignmentsStudent = assignmentsStudent;
           
            foreach (var assignment in assignmentsStudent)
            {
                assignment.student = student;
            }
            student.Assignments = assignmentsStudent;
        }

        public void OutputAssignmentsPerStudent()
        {
            int i = 1; //αρίθμηση του καθε assignment
            Console.WriteLine(" ");
            Console.WriteLine(student.FirstName+" "+student.LastName);
            Console.WriteLine();
          
            foreach (var assignment in assignmentsStudent)
            {
                              
                Console.Write("Assignment "+i+": ");
                assignment.Output();
            }
        }
    }
}
