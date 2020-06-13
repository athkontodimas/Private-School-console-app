using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Part_A
{
     class StudentsWithDueAssignments
    {
        public Student student;
        List<Assignment> assignmentDue = new List<Assignment>();

        
        public void  AddAssignment(Assignment assignmentDue) {
            this.assignmentDue.Add(assignmentDue);
        }
                
        // --------------------- Εμφανιζει το ονομα του μαθητή και τα assignments που εχει να παραδωσει
        public void Output()
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(student.FirstName+" "+student.LastName);
            Console.WriteLine(new string('-', (1 + student.FirstName.Length + student.LastName.Length)));
            Console.ForegroundColor = ConsoleColor.White;
            int index = 1;
            foreach (var assignment in assignmentDue)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("Assignment "+index+": ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(assignment.Title + " - Submission by: " + assignment.SubDateTime);


                if (index < assignmentDue.Count)
                {
                    Console.WriteLine(new string('-', (32 + assignment.Title.Length + assignment.SubDateTime.ToString().Length)));
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(new string('=', (32 + assignment.Title.Length + assignment.SubDateTime.ToString().Length)));
                    Console.ForegroundColor = ConsoleColor.White;
                }
                index++;
            }
            
        }// end Output
       
        // Μεθοδος που φτιαχνει λιστα με τους μαθητές που πρέπει να δωσουν assignment μεσα στη βδομαδα
        public static List<StudentsWithDueAssignments> PrintStudentsToSubmitAssignmentList(Database db, DateTime startOfWeek, DateTime endOfWeek)
        {
            List<StudentsWithDueAssignments> studentSubmitAssign = new List<StudentsWithDueAssignments>();


            foreach (var student in db.students)
            {
                StudentsWithDueAssignments sda1 = new StudentsWithDueAssignments();
                foreach (var course in student.Courses)
                {
                    foreach (var assignment in course.assignmentsInCourse)
                    {
                        if (assignment.SubDateTime <= endOfWeek && assignment.SubDateTime >= startOfWeek)
                        {

                            sda1.student = student;
                            sda1.AddAssignment(assignment);
                            studentSubmitAssign.Add(sda1);

                        }

                    }
                }
            }
            // 1ος ΤΡΟΠΟΣ  ΓΙΑ ΝΑ ΑΦΑΙΡΟΥΝΤΑ ΤΑ ΔΙΠΛΑ ΟΝΟΜΑΤΑ ΑΠΟ ΤΗ ΛΙΣΤΑ ΜΑΘΗΤΩΝ ΠΟΥ ΠΑΡΑΔΙΔΟΥΝ ΕΡΓΑΣΙΑ ΑΥΤΗ ΤΗ ΒΔΟΜΑΔΑ (για να μην εμφανιζονται 2 φορες οσοι δινουν περισσοτερες από 1 εργασιες)
            studentSubmitAssign = studentSubmitAssign.Distinct().ToList();

            // 2ος ΤΡΟΠΟΣ ΓΙΑ ΝΑ ΑΦΑΙΡΟΥΝΤΑΙ ΤΑ ΔΙΠΛΑ ΟΝΟΜΑΤΑ ΑΠΟ ΤΗ ΛΙΣΤΑ ΜΑΘΗΤΩΝ ΠΟΥ ΠΑΡΑΔΙΔΟΥΝ ΕΡΓΑΣΙΑ ΑΥΤΗ ΤΗ ΒΔΟΜΑΔΑ

            //for (int i = 1; i < studentSubmitAssign.Count; i++)
            //{
            //    if (studentSubmitAssign[i - 1] == studentSubmitAssign[i])
            //    {
            //        studentSubmitAssign.RemoveAt(i - 1);
            //    }
            //}

            return studentSubmitAssign;

        }//end printStudentsToSubmitAssignment
    }
}
