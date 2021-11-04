using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Owoda
{
    public class NutOfficer
    {
        public int DailyTicket { get; set; }

        public int MonthlyTicket { get; set; }

        public int AccountType { get; set; }

        int Amount = 0;


        public void Menu()
        {
            NutOfficer officer = new NutOfficer();
            Console.WriteLine("Please what type of ticket do you want to purchase \n Choose the following options: \n 1. Daily \n 2. Monthly \n 3. Generate Total Sales");
            AccountType = Convert.ToInt32(Console.ReadLine());
            

            
            if (AccountType == 1)
            {
                // NutOfficer officer = new NutOfficer();
                officer.DailyAmount();
            }
            else if (AccountType == 2)
            {
                officer.MonthlyAmount();
            }
            else if (AccountType == 3)
            {

            }
            else
            {
                Console.WriteLine("You have entered an invalid selection");
                

            }


        }

        // public void Choice(int AccountType)
        // {

        //  }

        public void DailyAmount()
        {
           

            DailyTicket = 100;
            Amount += DailyTicket;
            Console.WriteLine("Your input has been acknowledged and it is " + Amount);
           

            Menu();
            
        }

        public void MonthlyAmount()
        {
            MonthlyTicket = 1500;
            Amount += MonthlyTicket;
            Console.WriteLine("Your input has been acknowledged and it is " + Amount);

            //return amount;
            Menu();
            
        }

        
    }

}
