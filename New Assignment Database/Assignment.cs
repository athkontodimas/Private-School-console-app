using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Part_A
{
    class Assignment
    {
        public string Title { set; get; }
        public string Description { set; get; }
        public DateTime SubDateTime { set; get; } = new DateTime();
        public int OralMark { set; get; }
        public int TotalMark { set; get; }
        public Course course;
        public Student student;
        //-------------------------------------------SYNTHETIC DATA ------------------------------------------------------
        string[] assignTitle = new string[3] { "Eshop", "Database", "Website" };
        string[] assignDescription = new string[3] { "Create an e-shop", "Create a database", "Create a dynamic website" };
        DateTime[] subDateTime = new DateTime[3] { new DateTime (2019, 3, 15), new DateTime(2019 , 6 , 5) , new DateTime(2020 , 1 , 12) };
        int[] oralMark = new int[3] { 65,75,85};
        int[] totalMark = new int[3] { 82,80,92 };
        //------------------------------------------------------CONSTRUCTORS ---------------------------------------------------------------
        public Assignment() { }  // parameterless constructor
        public Assignment(string title, string description, DateTime subDateTime, int oralMark, int totalMark)
        {
            Title = title;
            Description = description;
            SubDateTime = subDateTime;
            OralMark = oralMark;
            TotalMark = totalMark;
        }
        //------------------------------------------------- ΠΡΟΣΘΗΚΗ ASSIGNMENT ΑΠΟ ΤΟ ΧΡΗΣΤΗ ---------------------------------------------
        public void setAssignmentInfo()
        {
            Random rand = new Random(); // επιλεγει τυχαια τα στοιχεια απο τα synthetic data σε περιπτωση που δεν δώσει ο χρηστης
            int r = rand.Next(0, 3);
            Console.WriteLine("Please give assignment's title");  
            string inputTitle = Console.ReadLine();
            if (inputTitle == " " || inputTitle == "")
            {
                Title = assignTitle[r] ;
            }
            else
            {
                Title = inputTitle;
            }


            Console.WriteLine("Please give assignment's description");  
            string inputDescription = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(inputDescription))
            {
                Description = assignDescription[r];
            }
            else
            {
                Description = inputDescription;
            }

            try
            {
                Console.WriteLine("Please give assignment's submission date in DD/MM//YYYY format");  
                string inputSubDate = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(inputSubDate))
                {
                    SubDateTime = subDateTime[r];
                }
                else
                {
                    SubDateTime = Convert.ToDateTime(inputSubDate);
                }

                Console.WriteLine("Please give assignment's oral mark (with max value 100)");  
                string inputOralMark = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(inputOralMark))
                {
                    OralMark = oralMark[r];
                }
                else
                {
                    OralMark = int.Parse(inputOralMark);
                }

                Console.WriteLine("Please give assignment's total mark (with max value 100)");  
                string inputTotalMark = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(inputTotalMark))
                {
                    TotalMark = totalMark[r];
                }
                else
                {
                    TotalMark = int.Parse(inputTotalMark);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        } //end setter
        //-------------------------------------------------------------------OUTPUT--------------------------------------------------------
        public void Output()
        {
            Console.WriteLine("  Title: "+Title + " || Description: "+ Description + " || Submission date: " + SubDateTime + " || Oral mark: " + OralMark + " || Total mark: "+ TotalMark);
            
        }
    }
}
