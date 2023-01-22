using System;

namespace _08.Cinema_Ticket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string dayOfWeek = Console.ReadLine();
            int ticketPrice = 0;
            if (dayOfWeek == "Monday" || dayOfWeek == "Tuesday" || dayOfWeek == "Friday")
            {
                ticketPrice = 12;
            }


            else if (dayOfWeek == "Wednesday" || dayOfWeek == "Thursday")
            {
                ticketPrice = 14;
            }
            else if (dayOfWeek == "Saturday" || dayOfWeek == "Sunday")
            {
                ticketPrice = 16;
            }
            Console.WriteLine(ticketPrice);
        }
    }
}
