using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ_18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Random rnd = new Random();
            

            DateTime EndData = new DateTime(rnd.Next(2024,2026), rnd.Next(3,12), rnd.Next(1,30));
            Ticket ticket = new Ticket(TicketCategory.Business, 5, 18, "Иванов Иван Иванович", EndData);
            Console.WriteLine();
            DateTime EndData2 = new DateTime(rnd.Next(2024, 2026), rnd.Next(1, 12), rnd.Next(1, 30));
            Ticket ticket2 = new Ticket(TicketCategory.Economy, 7, 1, "", EndData2);
            Console.WriteLine();
            DateTime EndData3 = new DateTime(rnd.Next(2024, 2026), rnd.Next(1, 12), rnd.Next(1, 30));
            Ticket ticket3 = new Ticket(TicketCategory.Business, 35, 31, "Петрова Наталья Евгеньевна", EndData3);
            Console.WriteLine();
            DateTime EndData4 = new DateTime(rnd.Next(2024, 2026), rnd.Next(1, 12), rnd.Next(1, 30));
            Ticket ticket4 = new Ticket(TicketCategory.Economy, 2, 90, "Петров Петр Петрович", EndData4);
            Console.WriteLine();
            DateTime EndData5 = new DateTime(rnd.Next(2024, 2026), rnd.Next(1, 12), rnd.Next(1, 30));
            Ticket ticket5 = new Ticket(TicketCategory.Economy, 9, 78, "Алексеев Алексей Алексеевич", EndData5);
            Console.WriteLine();
            DateTime EndData6 = new DateTime(rnd.Next(2024, 2026), rnd.Next(1, 12), rnd.Next(1, 30));
            Ticket ticket6 = new Ticket(TicketCategory.Economy, 11, 56, "Антонов Антон Антонович", EndData6);
            Console.WriteLine();
            DateTime EndData7 = new DateTime(rnd.Next(2024, 2026), rnd.Next(1, 12), rnd.Next(1, 30));
            Ticket ticket7 = new Ticket(TicketCategory.Economy, 16, 24, "Александрова Александра Александровна", EndData7);
            Console.WriteLine();
            DateTime EndData8 = new DateTime(rnd.Next(2024, 2026), rnd.Next(1, 12), rnd.Next(1, 30));
            Ticket ticket8 = new Ticket(TicketCategory.Business, 19, 2, "Сидоров Олег Александрович", EndData8);
            Console.WriteLine();
            DateTime EndData9 = new DateTime(rnd.Next(2024, 2026), rnd.Next(1, 12), rnd.Next(1, 30));
            Ticket ticket9 = new Ticket(TicketCategory.Economy, 24, 13, "Карасев Артем Германович", EndData9);
            Console.WriteLine();
            DateTime EndData10 = new DateTime(rnd.Next(2024, 2026), rnd.Next(1, 12), rnd.Next(1, 30));
            Ticket ticket10 = new Ticket(TicketCategory.Business, 29, 5, "", EndData10);
            



        }
    }
}
