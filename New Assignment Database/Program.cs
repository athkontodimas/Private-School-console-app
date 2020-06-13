using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Part_A
{
    class Program
    {
        static void Main(string[] args)
        {
            UserChoices();

        }//end Main

        //καλει τις επιμερους μεθοδους για να εκτελεσει τη λειτουργια που θελει ο χρηστης
        private static void UserChoices()
        {
            Database db = new Database();

            string inputMenu;
            
            do
            {
                Menu();
                inputMenu = Console.ReadLine();
                while (string.IsNullOrWhiteSpace(inputMenu))    //check if user entered correct number
                {
                    Console.WriteLine("Please give a number between 1-12");
                    inputMenu = Console.ReadLine();
                }//end while
                Console.Clear(); // καθαρίζει την κονσολα---σβηνει το μενου και αφηνει μονο τα prints
                switch (inputMenu)
                {
                    case "1":

                        Input.InputData(db);
                        break;
                    case "2":
                        Prints.PrintAllStudents(db);
                        break;
                    case "3":
                        Prints.PrintAllCourses(db);
                        break;
                    case "4":
                        Prints.PrintAllTrainers(db);
                        break;
                    case "5":
                        Prints.PrintAllAssignments(db);
                        break;
                    case "6":
                        Prints.PrintStudentsInCourse(db);
                        break;
                    case "7":
                        Prints.PrintTrainersInCourse(db);
                        break;
                    case "8":
                        Prints.PrintAssignmentsInCourse(db);
                        break;
                    case "9":
                        Prints.AssignmentsPerStudent(db);
                        break;
                    case "10":
                        Prints.PrintStudentsMultipleCourses(db);
                        break;
                    case "11":

                        FindStudentsWithDueAssignmentsThisWeek(db);
                        break;
                    case "12":
                        
                        Console.WriteLine("GoodBye!!");
                        continue;
                      
                }
                inputMenu = Input.AskUserToContinueInTheProgram();
                if (inputMenu == "N") 
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("\tGoodbye!!\n");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else { Console.Clear(); }  //καθαριζει την κονσολα απο το προηγουμενο κειμενο
            } while (inputMenu == "Y");
        }

        //περιεχει τις μεθοδους που χρησιμοποιούνται για να εμφανιστούν οι μαθητες που παραδιδουν εργασια τη βδομαδα που εδωσε ο χρηστης
        private static void FindStudentsWithDueAssignmentsThisWeek(Database db)
        {
            DateTime endWeek;
            DateTime startWeek;
            startWeek = FindAssignmentWeek(out endWeek);
            Prints.PrintsStudentsNeedSubmitAssignment(db,startWeek, endWeek);
        }

        //ο χρηστης δινει μια ημ/νια βρίσκει την πρώτη και τελευταια μερα της βδομαδας που αντιστοιχει στην ημ/νια
        public static DateTime FindAssignmentWeek(out DateTime endOfWeek)
        {
            DateTime startOfWeek = new DateTime();
            endOfWeek = new DateTime();
            try
            {
                DateTime date = new DateTime();
                bool validDateFlag;
                
                    Console.WriteLine("Please give a date in DD/MM/YYYY format");
                do
                {
                    validDateFlag = DateTime.TryParse(Console.ReadLine(), out date);   //επιστρεφει true αν γινει η μετατροπη string σε DateTime και αποθηκεύει την ημ/νια στην date
                    
                    if (validDateFlag == false) 
                    { 
                        Console.WriteLine("Please give a valid date in  DD/MM/YYYY format"); 
                    }
                } while (validDateFlag == false);

                 DayOfWeek day = date.DayOfWeek;


                for (int i = 0; i < 7; i++)  // βλέπει τη μέρα που έχω δώσει και περνώντας απο ολες τις μερες της βδομαδας ελέγχει και υπολογίζει την αρχή και τέλος της βδομάδας 
                {

                    if ((int)day == 0)
                    {
                        startOfWeek = date.AddDays(-6);
                        endOfWeek = date.AddDays(-2);

                    }
                    else if ((int)day == i)
                    {
                        startOfWeek = date.AddDays(-(i - 1));
                        endOfWeek = date.AddDays((5 - i));

                    }
                }//end for
                
                return startOfWeek;
            } //END OF TRY

            catch
            {
                Console.WriteLine("Not valid date format. It should be \"dd/mm/yyyy\".");
                return startOfWeek;
            } //END OF CATCH
            
        } //end method FindAssignmentWeek

        
        // το αρχικό μενού επιλογων
        public static void Menu()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\t\t\t M E N U ");
            Console.WriteLine("Welcome to our school. What would you like to do?");
            Console.WriteLine(new string('=', 70));
            Console.ForegroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("1.");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" If you want to ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("enter new students, courses, trainers or assignments, ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("press ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("1\n");

           
            Console.Write("2.");
            Console.ForegroundColor = ConsoleColor.White;
            
            Console.Write(" If you want to ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("see");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" the ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("list of students from the concrete data,");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" press ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("2\n");
            
            Console.Write("3.");
            Console.ForegroundColor = ConsoleColor.White;
            
            Console.Write(" If you want to ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("see");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" the ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("list of courses from the concrete data, ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("press ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("3\n");
           
            Console.Write("4.");
            Console.ForegroundColor = ConsoleColor.White;
           
            Console.Write(" If you want to ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("see");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" the ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("list of trainers from the concrete data, ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("press ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("4\n"); ;
           
            Console.Write("5.");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" If you want to ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("see");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" the ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("list of assignments from the concrete data, ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("press ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("5\n"); ;
           
            Console.Write("6.");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" If you want to ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("see");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" the ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("list of students in each course, ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("press ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("6\n"); ;
            
            Console.Write("7.");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" If you want to ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("see");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" the ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("list of trainers in each course, ");
            Console.ForegroundColor = ConsoleColor.White;
           
            Console.Write("press ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("7\n"); ;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("8.");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" If you want to ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("see");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" the ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("list of assignments in each course, ");
            Console.ForegroundColor = ConsoleColor.White;
           
            Console.Write("press ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("8\n"); ;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("9.");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" If you want to ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("see");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" the ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("list of assignments per student, ");
            Console.ForegroundColor = ConsoleColor.White;
           
            Console.Write("press ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("9\n"); ;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("10.");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("If you want to ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("see");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" the ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("list of students that belong to more than one course, ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("press ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("10\n");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("11.");
            Console.ForegroundColor = ConsoleColor.White;
           
            Console.Write("If you want to ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("check");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" which ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("students are to submit assignments in a specific date, ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("press ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("11\n");
            
            Console.Write("12.");
            Console.ForegroundColor = ConsoleColor.White;

            Console.Write("If you want to ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("exit,");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" press ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("12");
            Console.ForegroundColor = ConsoleColor.White;

        }







    }//end class Program
}//end namespace
