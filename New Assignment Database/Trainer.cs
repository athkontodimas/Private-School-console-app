using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Part_A
{
    class Trainer
    {
        
        public string FirstName { set; get; }
        public string LastName { set; get; }
        public string Subject { set; get; }
        public Course course;

        string[] firstNames = new string[5] { "Sotiris", "Maria", "Giannis", "Kyriakh", "Giwrgos" };
        string[] lastNames = new string[5] { "Karagiannis", "Lelanh", "Pitsakis", "Skontou", "Tzikis" };
        string[] subject = new string[5] { "Communication","Databases", "Testing", "Security","ICDL"};

        // ---------------------------------- constructor -------------------------------

        public Trainer() { }   // parameterless constructor

        public Trainer(string firstName, string lastName, string subject)
        {
            FirstName = firstName;
            LastName = lastName;
            Subject = subject;
        }

        //========================   SET TRAINER INFO =====================================
        public void setTrainerInfo()  
        {
            Random random = new Random(); //τυχαια μεταβλητη για επιλογη ονοματος σε περιπτωση που δεν δωσει ο χρηστης
            int r = random.Next(0, 5); // για την τυχαία επιλογή ονόματος
            Console.WriteLine("Please give trainer's first name");
            string inputName = Console.ReadLine();
            if (inputName == " " || inputName == "")
            {
                FirstName = firstNames[r];
            }
            else
            {
                this.FirstName = inputName;
            }

            Console.WriteLine("Please give trainers's last name");
            string inputLastName = Console.ReadLine();
            if (inputLastName == " " || inputLastName == "")
            {
                LastName = lastNames[r];
            }
            else
            {
                this.LastName = inputLastName;
            }
            Console.WriteLine("Please give trainers's subject");
            string inputSubject = Console.ReadLine();
            
            if (inputSubject == " " || inputSubject == "")
            {
                Random rand = new Random();
                Subject = subject[rand.Next(0,5)];
            }
            else
            {
                Subject = inputSubject;
            }

        } //end setTrainerInfo
        public void Output()
        {
            Console.WriteLine("  "+FirstName + " " + LastName + ", Subject: " + Subject);
        }
    }
}
