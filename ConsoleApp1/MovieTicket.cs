using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class MovieTicket
    {
        private int movieid;
        private string name;
        private int price;
        private int numoftickets;
        private string Type;
        private int AvailableTicket;
      
        public MovieTicket(int movieid, string name, int ticketprice, int numoftickets)
        {
            this.movieid = movieid;
            this.name = name;
            this.price = price;
            this.numoftickets = numoftickets;
            this.Type = Type;
        }
        public void DisplayMovie()
        {
            Console.WriteLine($"Movieid , MovieName , TicketPrice , Numoftickets ,TicketType");
        }
        public void FindAvailableTickets()
        {
            Console.WriteLine("Enter num of tickets to book");
            int num = int.Parse(Console.ReadLine());
            if (numoftickets > num)
            {
                AvailableTicket = numoftickets - num;
                this.CalculateTicketCost();
            }
            else
            {
                Console.WriteLine("Insufficient Tickets");
            }
            
        }
        public void CalculateTicketCost()
        {
            Console.WriteLine("1.Silver-100RS , 2.Gold-200RS , 3.Platinum-300RS");
            Console.WriteLine("Enter Type");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                Type = "Silver";
                  price = 100;
                    break;

                case 2:
                 Type = "Gold";
                   price = 200;
                    break;

                case 3:
                Type="Platinum";
                    price = 300;
                    break;
            }
            price = numoftickets * price;

        }



    }
}
