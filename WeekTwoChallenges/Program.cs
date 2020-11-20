using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeekTwoChallenges
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Joshua";
            Greeter Joshua = new Greeter();
            Joshua.TakeInName(name);
            Console.ReadLine();

            Joshua.GivenName(name);
            Console.ReadLine();

            Joshua.TimeGreeting();
            Console.ReadLine();
        }
    }
    public class Greeter
    {
        public void TakeInName(string name)
        {
            Console.WriteLine("Greetings " + name);
        }
        public void GivenName(string name)
        {
            Console.WriteLine("Farewell " + name);
        }

        public void TimeGreeting()
        {
            var time = DateTime.Now.TimeOfDay;
            Console.WriteLine(time);

            TimeSpan morning = new TimeSpan(04, 00, 00);
            TimeSpan noon = new TimeSpan(11, 59, 59);
            TimeSpan evening = new TimeSpan(16, 59, 59);
            TimeSpan night = new TimeSpan(19, 59, 59);

            if (time > morning && time <= noon)
            {
                Console.WriteLine("Good Morning!");
            }
            else if (time > noon && time <= evening)
            {
                Console.WriteLine("Good Afernoon!");
            }
            else if (time > evening && time <= night)
            {
                Console.WriteLine("Good Evening!");
            }
            else
            {
                Console.WriteLine("Good Night!");
            }

        }
    }
}
