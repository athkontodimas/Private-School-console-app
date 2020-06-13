using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Part_A
{

    class TrainersInCourse
    {
        public Course Course;

        public List<Trainer> trainersInCourse { set; get; } = new List<Trainer>();

        public TrainersInCourse(Course course, List<Trainer> trainersInCourse)
        {
            Course = course;
            this.trainersInCourse = trainersInCourse;
            course.trainersInCourse.AddRange(trainersInCourse);
            foreach (var trainer in trainersInCourse)
            {
                trainer.course = course;
            }
        }

        public void OutputTrainers()
        {
            int i = 1;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(Course.Title+" "+ Course.Type);
            Console.WriteLine(new string('~', (11 + Course.Title.Length + Course.Type.Length)));
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\tTrainers");
            foreach (var trainer in trainersInCourse)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;

                Console.Write(" " + i + ": ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(trainer.FirstName+" "+trainer.LastName);
               
                i++;
            }
        }
    }
}
