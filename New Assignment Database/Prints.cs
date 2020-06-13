using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Part_A
{
    class Prints
    {
        //τυπώνει ολους τους μαθητες από τα concrete data
        public static void PrintAllStudents(Database db)
        {

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\t    ALL STUDENTS");
            Console.WriteLine("  "+new string('=', 36));
            Console.ForegroundColor = ConsoleColor.White;
            int i = 1;
            foreach (var item in db.students)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(" " + i + ":");
                Console.Write(" ");
                Console.ForegroundColor = ConsoleColor.White;
                item.Output();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("   " + new string('~', 35)); //girlanta
                Console.ForegroundColor = ConsoleColor.White;
                i++;
            }
        }
        //τυπωνει ολα τα courses απο τα concrete data
        public static void PrintAllCourses(Database db)
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(new string('\t',6)+"ALL COURSES");
            Console.WriteLine(" "+new string('=',115));
            Console.ForegroundColor = ConsoleColor.White;
            int i = 1;

            foreach (var item in db.courses)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(" Course " + i + ":");
                Console.Write(" ");
                Console.ForegroundColor = ConsoleColor.White;
                item.Output();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("   " + new string('~', (59+item.Title.Length+item.Stream.Length+item.startDate.ToString().Length+item.endDate.ToString().Length+item.Type.Length))); //35
                Console.ForegroundColor = ConsoleColor.White;
                i++;
            }
        }
        //τυπωνει ολους τους trainers απο τα concrete data
        public static void PrintAllTrainers(Database db)
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\t\t    TRAINERS");
            Console.WriteLine(" "+new string('=', 46));
            Console.ForegroundColor = ConsoleColor.White;
            int i = 1;
            foreach (var item in db.trainers)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(" Trainer " + i + ":");
                Console.Write(" ");
                Console.ForegroundColor = ConsoleColor.White;
                item.Output();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("   " + new string('~', (12+item.FirstName.Length+item.LastName.Length+item.Subject.Length)));
                Console.ForegroundColor = ConsoleColor.White;
                i++;
            }
        }

        //τυπωνει ολα τα assignments απο τα concrete data
        public static void PrintAllAssignments(Database db)
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(new string('\t',7)+"     ASSIGNMENTS");
            Console.WriteLine(" "+new string('=', 130));
            Console.ForegroundColor = ConsoleColor.White;

            int i = 1;
            foreach (var item in db.assignments)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine(" Assignment " + i + ":");
                Console.Write(" ");
                Console.ForegroundColor = ConsoleColor.White;
                item.Output();
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine(" " + new string('~', (78+item.Title.Length+item.Description.Length+item.OralMark.ToString().Length+
                    item.TotalMark.ToString().Length+item.SubDateTime.ToString().Length)));
                Console.ForegroundColor = ConsoleColor.White;
                i++;
            }
        }

        //  τυπωνει ολους τους students σε καθε course απο τα concrete data
        public static void PrintStudentsInCourse(Database db)
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(new string(' ',2)+"STUDENTS IN EACH COURSE");
            Console.WriteLine(new string('=', 27));
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
            int i = 1;
            foreach (var item in db.studInCourse)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("Course " + i + ": ");
                Console.ForegroundColor = ConsoleColor.White;
                item.OutputStudents();
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.ForegroundColor = ConsoleColor.White;
                i++;
            }
        }
        //  τυπωνει ολους τους trainers σε καθε course απο τα concrete data
        public static void PrintTrainersInCourse(Database db)
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(new string(' ', 5) + "TRAINERS IN EACH COURSE");
            Console.WriteLine(new string('=', 35));
            Console.ForegroundColor = ConsoleColor.White;
            int i = 1;
            foreach (var item in db.trainInCourse)
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("Course " + i + ": ");
                Console.ForegroundColor = ConsoleColor.White;
                item.OutputTrainers();
                Console.ForegroundColor = ConsoleColor.Yellow;
                //Console.WriteLine(new string('~', (10+item.Course.Title.Length+item.Course.Type.Length)));
                Console.ForegroundColor = ConsoleColor.White;
                i++;
            }
        }

        //  τυπωνει ολα τα assignments σε καθε course απο τα concrete data
        public static void PrintAssignmentsInCourse(Database db)
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(new string('\t',8)+"ASSIGNMENTS IN EACH COURSE");
            Console.WriteLine(new string('=', 155));
            Console.ForegroundColor = ConsoleColor.White;
            int i = 1;
            foreach (var item in db.assignmentsInCourse)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Course " + i + ": ");
                Console.ForegroundColor = ConsoleColor.White;
                item.OutputAssignmentsInCourse();
               
                i++;
            }
        }
        // ------------------------------- βρισκει τους μαθητές που έχουν πάνω από 2 μαθήματα και τους εμφανιζει ====================

        public static void PrintStudentsMultipleCourses(Database db)
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Students who enrolled to more than 1 course");
            Console.WriteLine(new string('=', 45));
            Console.ForegroundColor = ConsoleColor.White;
            int studIndex = 1;  // αριθμεί τους μαθητές που εμφανιζονται στη λίστα


            foreach (var stud in db.students)
            {
                //επιστρεφει true αν ο μαθητήε έχει πολλά μαθηματα και τον εμφανιζει
                bool hasMultipleCoursesFlag = stud.OutputStudentMultipleCourses(studIndex);

                if (hasMultipleCoursesFlag) { studIndex++; }  //αν ο μαθητής έχει πολλά μαθηματα (true) αυξάνει τον αύξων αριθμό του μαθητή κατα 1

            }

        }

        //---------------- ΤΥΠΩΝΕΙ ΤΑ ASSIGNMENTS (PER COURSE) PER STUDENT -------------------------------------------------
        public static void AssignmentsPerStudent(Database db)
        {

            int studInd = 1;  // αυξων αριθμος του μαθητη
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine();
            Console.WriteLine(new string('\t',8)+"ASSIGNMENTS PER STUDENT");
            Console.WriteLine(new string('=',155));
            Console.ForegroundColor = ConsoleColor.White;

            foreach (var stud in db.students)
            {
                if (stud.Courses.Count != 0)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Student " + studInd + ": " + stud.FirstName + " " + stud.LastName);
                    Console.WriteLine(new string('-', 13 + stud.FirstName.Length + stud.LastName.Length));  //επαναλαμανει τις παυλες (μηκος γραμμης) αναλογα με το μηκος καθε ονοματος + τα σταθερα κενα
                    Console.ForegroundColor = ConsoleColor.White;
                    SearchInCourses(stud);  // ψάχνει τη λίστα με τα courses κάθε μαθητή
                    studInd++;
                }

            }//end foreach
        }// end method AssignmentsPerStudent
        
        //--------------- Μεθοδος που ψαχνει μεσα στη λίστα των courses καθε μαθητη ---(ΧΡΗΣΗ ΜΕΣΑ ΣΤΟ AssignmensPerStudent)
        private static void SearchInCourses(Student stud)
        {
            int courseInd = 1; // αυξων αριθμος του μαθηματος
            foreach (var course in stud.Courses)
            {
                Console.ForegroundColor = ConsoleColor.Red;

                Console.Write("  Course " + courseInd + ": ");
                Console.ForegroundColor = ConsoleColor.White;
                course.Output();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("  " + new string('-', (71+course.Title.Length+course.Type.Length+course.Stream.Length+ course.startDate.ToString().Length+
                    course.endDate.ToString().Length)));
                Console.ForegroundColor = ConsoleColor.White;
                int assignmentInd = 1; // αυξων αριθμος της εργασίας
                assignmentInd = SearchAssignments(course, assignmentInd);   // καλεί μεθοδο που ψάχνει στη λίστα των assignments και τυπώνει τα στοιχεία τους
                courseInd++;
            }//end foreach
        }

        // Μέθοδος που ψαχνει τα assignments καθε course και τυπώνει τα στοιχεία του assignment --- (ΧΡΗΣΗ ΜΕΣΑ ΣΤΟ SearchInCourses)
        private static int SearchAssignments(Course course, int assignmentInd)
        {
            foreach (var assignment in course.assignmentsInCourse)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("\t");
                Console.Write("Assignment " + assignmentInd + ": ");

                Console.Write("\t");
                Console.ForegroundColor = ConsoleColor.White;
                assignment.Output();

                // ΤΥΠΩΝΕΙ ΔΙΑΚΕΚΟΜΜΕΝΗ ΓΡΑΜΜΗ (ΓΙΡΛΑΝΤΑ) ΜΕΤΑ ΑΠΟ ΚΑΘΕ ASSIGNMENT ΕΚΤΟΣ ΑΠΟ ΤΟ ΤΕΛΕΥΤΑΙΟ
                if (assignmentInd < course.assignmentsInCourse.Count)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\t" + new string('-', 94 + assignment.Title.Length + assignment.Description.Length + assignment.OralMark.ToString().Length +
                        assignment.TotalMark.ToString().Length + assignment.SubDateTime.ToString().Length));
                    Console.ForegroundColor = ConsoleColor.White;
                }//end if
                else
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\t" + new string('~', 94 + assignment.Title.Length + assignment.Description.Length + assignment.OralMark.ToString().Length +
                        assignment.TotalMark.ToString().Length + assignment.SubDateTime.ToString().Length));
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine();
                }

                assignmentInd++;

            }//end foreach

            return assignmentInd;
        }

        // Μεθοδος που τυπώνει τους μαθητες που πρεπει να δωσουν εργασια τη βδομαδα αυτη
        public static void PrintsStudentsNeedSubmitAssignment(Database db, DateTime startOfWeek, DateTime endOfWeek)
        {
            List<StudentsWithDueAssignments> studentsPouDinounErgasia;// φτιαχνω λιστα με τους μαθητες που δινουν εργασια μεσα στη βδομαδα αυτη
            studentsPouDinounErgasia = StudentsWithDueAssignments.PrintStudentsToSubmitAssignmentList(db, startOfWeek, endOfWeek);  //η μεθοδος μου δινει τη λιστα με τους μαθητες αυτους και τη βαζω στη λιστα που εφτιαξα
            DecorForStudentsToSubmitAssignment(startOfWeek, endOfWeek); //τυπωνει κειμενο που αναφερει την εναρξη και το τελος της βδομαδας
            if (studentsPouDinounErgasia.Count > 0)   // αν η λιστα δεν ειναι αδεια (δηλ υπαρχουν μαθητες που να δινουν εργασια αυτη τη βδομαδα) τυπωνω τους μαθητες
            {
                
                foreach (var stud in studentsPouDinounErgasia)
                {
                             stud.Output();
                }
            }
            else
            {
                Console.WriteLine("There are no students who need to subitt their assignments in this week.");
            }
        }//end PrintsStudentsNeedSubmitAssignment


        //Μεθοδος που εμφανίζει λεζάντα για τους μαθητες που πρεπει να δωσουν το assignment μεσα στη βδομαδα
        private static void DecorForStudentsToSubmitAssignment(DateTime startOfWeek, DateTime endOfWeek)
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Following students should submit their assignments between {startOfWeek} and {endOfWeek}");
            Console.WriteLine(new string('-', 105));
            Console.ForegroundColor = ConsoleColor.White;
        }
        
    }
}