using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Owoda
{
    public class NutOfficer
    {
        double DailyAmount = 100;
        

        public int MonthlyTicket { get; set; }

        public int DailyTicket { get; set; }

        public double DailyTicketAmount { get; set; }

        public double MonthlyTicketAmount{get; set;}

        public double TotalExpenses { get; set; }

        public int RandomStrings { get; set; }


        double Amount = 0;
      


        public void Menu()
        {
            GenerateRandomNumber();
            Console.WriteLine("Please what type of ticket do you want to purchase \n Choose the following options: \n 1. Daily \n 2. Monthly \n 3. Generate Total Sales");

            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                
                DailyTicket++;
                // Console.WriteLine("Your ticket count is" + DailyTicket);
                DayAmount();
             //  GenerateReceipt(choice);
                
                
            }
            else if (choice == 2)
            {
                MonthlyTicket++;
                MonthAmount();

            }
            else if(choice == 3)
            {
                TotalSales();
            }
           

        } 

        public void DayAmount()
        {
          DailyTicketAmount =  DailyTicket * DailyAmount;
            Console.WriteLine  ("Your daily ticket count is " + DailyTicket + " and your total daily ticket sales is " + DailyTicketAmount);
            Console.WriteLine("Ticket unique id is " + RandomStrings);
            Menu();

        }

        public void MonthAmount()
        {
            MonthlyTicketAmount = ((DailyAmount * 30) / 2) * MonthlyTicket;
            Console.WriteLine("Your monthly  ticket count is " + MonthlyTicket + " and your total monthly ticket sales is " + MonthlyTicketAmount);
            Console.WriteLine("Ticket unique id is " + RandomStrings);
            Menu();
        }

        public void TotalSales()
        {
            var Total = (DailyTicketAmount + MonthlyTicketAmount);
            Amount = Total - (Total * 0.65);
            TotalExpenses = Amount;
            Console.WriteLine("Your total sales amount is " + Total +  " The amount you remit to your chairman is " + Amount + " and your amount after returns is " + TotalExpenses);


        }

        public void GenerateRandomNumber()
        {
            Random random = new Random();
            for (int j  = 0; j < 4; j++)
            {
                
                RandomStrings =  random.Next();
            }
        }

        public void GenerateReceipt()
        {
          //while ()
          //  {
          //      Console.WriteLine("Your daily ticket count is " + DailyTicket + " and your total daily ticket sales is " + DailyTicketAmount);
          //        Console.WriteLine("Ticket unique id is " + RandomStrings);
          //  }
           
        }
    }

}
