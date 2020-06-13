using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Part_A
{
    class Student
    {
        public string FirstName { set; get; }
        public string LastName { set; get; }
        public int YearOfBirth { set; get; }
        public double TuitionFees { set; get; }
        public List<Course> Courses { set; get; } = new List<Course>();
        public List<Assignment> Assignments { set; get; } = new List<Assignment>();
       

        //================================== SYNTHETIC DATA ===========================================================================================
        string[] firstNames = new string[10] { "Sotiris", "Maria", "Giannis", "Kyriakh", "Giwrgos", "Mixalis", "Athanasios", "Panagiotis", "Hlias", "Vasilikh" };
        string[] lastNames = new string[10] { "Papadopoulos", "Giannakopoulou", "Golas", "Nolemh", "Ipatiou", "Kwnstantinou", "Liopidas", "Sekinas", "Liopis", "Xouliara" };
        int[] yearOfBirth = new int[10] { 1985, 1993, 1998, 1979, 1995, 1988, 1990, 1989, 1982, 1991 };
        double[] fees = new double[10] { 2500, 2250, 2500, 1200, 2500, 2500, 2250, 2250, 2500, 2500 };

        // --------------------------- constructor ----------------------------

        public Student() { } // parameterless constructor

        public Student(string firstName, string lastName, int yearOfBirth, double tuitionFees)
        {
            FirstName = firstName;
            LastName = lastName;
            YearOfBirth = yearOfBirth;
            TuitionFees = tuitionFees;
            
        }

        // --------------------------------------- METHOD SETTER FOR USER INPUT------------------------------
        public void setPersonalInfo()    
        {
            Random random = new Random(); //τυχαια μεταβλητη για επιλογη ονοματος σε περιπτωση που δεν δωσει ο χρηστης
            int r = random.Next(0, 10); // για την τυχαία επιλογή ονόματος
            Console.WriteLine("Please give student's first name");
            string inputName = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(inputName))
            {
                FirstName = firstNames[r];
            }
            else
            {
                this.FirstName = inputName;
            }

            Console.WriteLine("Please give student's last name");
            string inputLastName = Console.ReadLine();
            if (inputLastName == " " || inputLastName == "")
            {
                LastName = lastNames[r];
            }
            else
            {
                this.LastName = inputLastName;
            }
            Console.WriteLine("Please give student's year of birth in YYYY format");
            var inputYearOfBirth = Console.ReadLine();
            if (inputYearOfBirth == " " || inputYearOfBirth == "")
            {
                this.YearOfBirth = yearOfBirth[r];
            }
            else
            {
                YearOfBirth = Convert.ToInt32(inputYearOfBirth);
            }
            Console.WriteLine("Please give student's tuition fees");
            var inputFees = Console.ReadLine();
            if (inputFees == " " || inputFees == "")
            {
                this.TuitionFees = fees[r];
            }
            else
            {
                TuitionFees = Convert.ToDouble(inputFees);
            }


        }
        //------------------------------------------------------- Output -----------------------------------------

        public void Output()
        {
            Console.WriteLine("  "+FirstName+" "+LastName);
            Console.WriteLine("   Born in " + YearOfBirth + ", paid " + TuitionFees + " euros");
        }
        //Εμφανιζει τους μαθητές με πολλά μαθηματα και επιστρεφει true οταν ισχυει αυτο.(Η bool μεταβλητη χρησιμοποιείται για την αριθμηση των μαθητων στη λιστα)
        public bool OutputStudentMultipleCourses(int studentNumber)
        {
            bool hasMultipleCourses = false;
            if (Courses.Count > 1)
            {
                hasMultipleCourses = true;
                //Output();  // print full student personal info
                //Console.WriteLine(new string('~', 35));
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(studentNumber);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(": "+FirstName +" "+ LastName); // print only first and last name
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(new string(' ',3)+new string('-',(1+FirstName.Length+LastName.Length)));
                Console.ForegroundColor = ConsoleColor.White;

            }
           return hasMultipleCourses;
        }
        
    }
}
