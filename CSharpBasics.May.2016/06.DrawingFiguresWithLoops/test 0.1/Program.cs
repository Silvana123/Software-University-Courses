using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_0._1
{
    class Program
    {
        static void Main(string[] args)
        {

            int hourExam = int.Parse(Console.ReadLine());
            int minuteExam = int.Parse(Console.ReadLine());
            int hourArive = int.Parse(Console.ReadLine());
            int minuteArive = int.Parse(Console.ReadLine());


            int totalExamMinutes = hourExam * 60 + minuteExam;
            int totalAriveMinutes = hourArive * 60 + minuteArive;

            int diffminute = Math.Abs(totalExamMinutes - totalAriveMinutes);
            int diffminutes = Math.Abs(minuteArive - minuteExam);
            int hourDiff = hourArive - hourExam;
            if (hourExam==hourArive && minuteExam<minuteArive)
            {
                Console.WriteLine("Late");
                Console.WriteLine($"{diffminutes} minutes after the start");
            }
            
            else if (hourExam<hourArive&& minuteExam<minuteArive && hourDiff>0)
            {
                
                Console.WriteLine("Late");
                Console.WriteLine("{0}:{1} hours after the start",
                    hourDiff,diffminutes);
            }
            else if (hourExam==hourArive&& minuteArive==minuteExam)
            {
                Console.WriteLine("On time");
            }
            else if (hourExam>hourArive&&minuteArive>minuteExam)
            {
                Console.WriteLine("On time");
                Console.WriteLine($"{diffminute} minutes before the start");

            }
            
            else if (hourExam>hourArive && minuteArive>minuteExam)
            {
               
                Console.WriteLine("Early");
                Console.WriteLine($"{diffminute} minutes before the start");
            }
            else if (hourExam>hourArive && minuteExam==minuteArive)
            {
                 hourDiff = Math.Abs(hourArive - hourExam);
                Console.WriteLine("Early");
                Console.WriteLine($"{hourDiff}:00 hours before the start");
            }
            else if (hourExam>hourArive&&minuteExam>minuteArive)
            {
                 hourDiff = Math.Abs(hourArive - hourExam);
                Console.WriteLine("Early");
                Console.WriteLine($"{hourDiff}:{diffminutes} hours before the start");
            }
            else if (hourExam<hourArive && minuteExam<minuteArive)
            {
                Console.WriteLine("Late");
                Console.WriteLine($"{diffminute} minutes after the start" );
            }
        }
    }
}
