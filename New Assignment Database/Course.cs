using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Part_A
{
    class Course
    {
       
        public string Title { set; get; }
        public string Stream { set; get; }
        public string Type { set; get; }
        public DateTime startDate { set; get; } = new DateTime();
        public DateTime endDate { set; get; } = new DateTime();
        public List<Student> studentsInCourse { set; get; } = new List<Student>();
        public List<Trainer> trainersInCourse { set; get; } = new List<Trainer>();
        public List<Assignment> assignmentsInCourse { set; get; } = new List<Assignment>();
        //===================================== SYNTHETIC DATA ========================================================================
        string[] courseTitle = new string[4] { "CB8", "CB9", "CB10", "CB11" };
        string[] courseStream = new string[4] { "C#", "Java", "SQL", "HTML" };
        string[] courseType = new string[4] {"Part-time","Full-time", "Part-time", "Full-time" };
        DateTime[] courseStartDate = new DateTime[4] {new DateTime(2019,2,15), new DateTime(2019,5,3), new DateTime(2019,9,9), new DateTime(2019,11,12) };
        DateTime[] courseEndDate = new DateTime[4] { new DateTime(2019 , 8 , 5), new DateTime(2019, 8 ,10 ), new DateTime(2020 , 3 , 14), new DateTime(2020 , 2 , 20) };

        // -------------------------------------------------- constructor ------------------------------------------------
        public Course() { } // parameterless constructor
        public Course(string title, string stream, string type, DateTime startDate, DateTime endDate)
        {
            Title = title;
            Stream = stream;
            Type = type;
            this.startDate = startDate;
            this.endDate = endDate;
        }
        //-------------------------------------- SET COURSE INFO FROM USER ------------------------------------
        public void setCourseInfo()   
        {

            try
            {
                Random rand = new Random(); // επιλεγει τυχαια τα στοιχεια απο τα synthetic data σε περιπτωση που δεν δώσει ο χρηστης
                int r = rand.Next(0, 4);
                Console.WriteLine("Please give course's title");  
                string inputTitle = Console.ReadLine().ToUpper();
                if (inputTitle == " " || inputTitle == "")
                {
                    Title = courseTitle[r];
                }
                else
                {
                    Title = inputTitle;
                }

                Console.WriteLine("Please give course's stream");  
                string inputStream = Console.ReadLine().ToUpper();
                if (inputStream == " " || inputStream == "")
                {
                    Stream = courseStream[r];
                }
                else
                {
                    Stream = inputStream;
                }
                Console.WriteLine("Please give course's type");  
                string inputType = Console.ReadLine().ToUpper();
                if (inputType == " " || inputType == "")
                {
                    Type =courseType[r];
                }
                else
                {
                    Type = inputType;
                }
                Console.WriteLine("Please give course's start date in DD/MM//YYYY format"); 
                string date1 = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(date1))
                {
                    startDate = courseStartDate[r];
                }
                else
                {
                    startDate = Convert.ToDateTime(date1);
                }
                              
                do
                {
                    Console.WriteLine("Please give course's end date in DD/MM//YYYY format");  
                    string date2 = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(date2))
                    {
                        endDate = courseEndDate[r];
                    }
                    else
                    {
                        endDate = Convert.ToDateTime(date2);
                    }
                    //ΕΛΕΓΧΟΣ ΑΝ Ο ΧΡΗΣΤΗΣ ΕΔΩΣΕ ΣΩΣΤΑ ΤΗΝ ΗΜΕΡΟΜΗΝΙΑ ΛΗΞΗΣ ΤΟΥ ΜΑΘΗΜΑΤΟΣ. ΕΠΑΝΑΛΑΜΒΑΝΕΤΑΙ ΜΕΧΡΙ Η ΗΜ/ΝΙΑ ΛΗΞΗΣ ΝΑ ΕΙΝΑΙ ΜΕΤΑΓΕΝΕΣΤΕΡΗ ΤΗΣ ΗΜ/ΝΙΑΣ ΕΝΑΡΞΗΣ
                    if (endDate <= startDate)
                    {
                        Console.WriteLine("End date should be later than {0}", startDate);
                    }
                    else if (string.IsNullOrWhiteSpace(date2))
                    {
                        endDate = courseEndDate[r];
                    }
                    else
                    {
                        endDate = Convert.ToDateTime(date2);
                    }
                   

                } while (endDate <= startDate);
            }//end try

            catch (Exception e)
            {
                Console.WriteLine(e);
            }

        } 
        public void Output()
        {
            Console.WriteLine("  Title: "+Title + " || Stream: " + Stream + " || Type: " + Type + " || Start Date: " + startDate + " || End Date: "+ endDate);
        }
    }
}
