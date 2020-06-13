using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Part_A
{
    class Input
    {
        // =================  Μέθοδος για εισαγωγη στοιχείων από το χρήστη ================
        public static void InputData(Database db)
        {
            try
            {
                string input;
                do
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(new string('~', 50));
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("  -- ");

                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("  If you want to enter ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("student ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("data, press ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("1");
                    Console.WriteLine();

                    Console.Write("  -- ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("  If you want to enter ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("trainer ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("data, press ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("2");
                    Console.WriteLine();

                    Console.Write("  -- ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("  If you want to enter ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("course ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("data, press ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("3");
                    Console.WriteLine();

                    Console.Write("  -- ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("  If you want to enter ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("assignment ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("data, press ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("4");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(new string('~', 50));
                    Console.ForegroundColor = ConsoleColor.White;
                    string choice = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(choice) || !(int.Parse(choice) > 0) || !(int.Parse(choice) < 5)) //ελεγχος αν δωσει λαθος αριθμο ή κενο χαρακτηρα ή τιποτα
                    {
                        Console.WriteLine("\nPlease give a number between 1-4 from the following menu\n");
                        input = "Y";
                        continue;
                    }


                    switch (choice)
                    {
                        case "1":
                            Student st1 = new Student();
                            st1.setPersonalInfo();
                            db.students.Add(st1);
                            break;
                        case "2":
                            Trainer tr1 = new Trainer();
                            tr1.setTrainerInfo();
                            db.trainers.Add(tr1);
                            break;
                        case "3":
                            Course c1 = new Course();
                            c1.setCourseInfo();
                            db.courses.Add(c1);
                            break;
                        case "4":
                            Assignment a1 = new Assignment();
                            a1.setAssignmentInfo();
                            db.assignments.Add(a1);
                            break;
                    }

                    input = continueGivingData();//---- ASK USER TO CONTINUE GIVING DATA
                    
                } while (input == "Y"); //end do while


            } //END OF TRY

            catch (Exception e)
            {
                Console.WriteLine(e);
            }

        }

        // Μεθοδος που ρωταει το χρήστη αν θα συνεχισει να εισαγει δεδομενα -----------------------------------
        private static string continueGivingData()
        {
            string input;
            string valid;   // flag για τον ελεγχο του εσωτερικου while

            do
            {
                Console.WriteLine("Do you want to add more data? Y/N");
                input = Console.ReadLine().ToUpper();

                if (string.IsNullOrWhiteSpace(input) || !(input == "Y" || input == "N"))
                {
                    Console.WriteLine("Answer with Y or N");
                    valid = "Y";
                }
                else { valid = "N"; }// end else

                Console.Clear();

            } while (valid == "Y");//end do while
            return input;
        }

        //Ζηταει απο το χρηστη αν θελει να ζητησει κατι αλλο από το βασικό μενού επιλογών ή να φυγει τελειως απο το πρόγραμμα
        public static string AskUserToContinueInTheProgram()
        {
            string inputMenu;
            bool invalidInput;
            do
            {

                Console.WriteLine("Do you want to do anything else? Y/N");
                inputMenu = Console.ReadLine().ToUpper();
                Console.WriteLine(new string('=', 100) + "\n");
                if (string.IsNullOrWhiteSpace(inputMenu) || ((inputMenu != "Y") && (inputMenu != "N")))   //if user gives y or n, condition's second half would return the  of true ("false") and proceed to "else"
                {
                    invalidInput = true;
                    Console.WriteLine("Please give a Y or N answer");
                }
                else
                {
                    invalidInput = false;
                    Console.Clear();
                    Console.WriteLine();
                }
            } while (invalidInput);
            return inputMenu;
        }
    }
}
