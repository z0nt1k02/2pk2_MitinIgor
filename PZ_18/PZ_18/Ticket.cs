using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ_18
{
    public enum TicketCategory
    {
        Business,
        Economy
    }

    public class Ticket
    {
        public TicketCategory Category { get; set; }
        public int SeatNumber { get; set; }
        public string PassengerName { get; set; }

        public DateTime DateDeparture { get; set; }
        
        public int DateOnly { get; set; }
        public double TicketPrice { get; private set; }

        private static int EconomyTicketsSold = 0;
        private static int BusinessTicketsSold = 0;

        public Ticket(TicketCategory Category, int seat, int date, string Name,DateTime data)
        {
            
                if (string.IsNullOrWhiteSpace(Name))
                {
                    Console.WriteLine("Введите корректные данные");
                    PassengerName = Console.ReadLine();
                }
                else
                    PassengerName = Name;

                if (Category == TicketCategory.Economy)
                {
                    TicketPrice = 5000;
                    EconomyTicketsSold++;
                    if(EconomyTicketsSold > 30) 
                        throw new InvalidOperationException("В выбранном классе мест нет");

                }
                else
                {
                    TicketPrice = 10000;
                    BusinessTicketsSold++;
                    if (BusinessTicketsSold >7)
                        throw new InvalidOperationException("В выбранном классе мест нет");
                }
                if (DateOnly < 10)
                    TicketPrice /= 2;
                DateDeparture = data;
                SeatNumber = seat;
                TicketInfo();
                TimeToDepart();
                SoldTickets();

        }

        public void TicketInfo()
        {
            Console.WriteLine($"ФИО: {PassengerName}");
            Console.WriteLine($"Место: {SeatNumber}");
            Console.WriteLine($"Дата и время вылета:{DateDeparture} ");
            Console.WriteLine($"Класс: {Category}");
            Console.WriteLine($"Стоимость билета: {TicketPrice}");
        }
        public void TimeToDepart()
        {
            Console.WriteLine($"Время до вылета: {DateDeparture - DateTime.Now}");
        }
        public static void SoldTickets()
        {
            Console.WriteLine($"Продано билетов Эконом класса: {EconomyTicketsSold}");
            Console.WriteLine($"Продано билетов Бизнес класса: {BusinessTicketsSold}");
        }
            

    }
    
}
