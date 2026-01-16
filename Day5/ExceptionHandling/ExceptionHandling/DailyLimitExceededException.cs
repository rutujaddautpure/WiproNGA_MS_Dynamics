using System;
using System.Collections.Generic;
using System.Text;

namespace ExceptionHandling
{
        public class DailyLimitExceededException : Exception
        {
            //Here I can define properties and methods specific to this exception. as well as constructors.
            //using ultimate base class System.Exception to derive my custom exception class.
            public DailyLimitExceededException(string message) : base(message)
            //calling base class constructor inside derived class constructor.
            {
             
            }
        }
    //Creating a account class that act as a busineslogic class for implementing user define exception 
    class BankAccount //business logic class
    {
        private decimal dailyLimit = 1000; //daily limit for transactions
        private decimal totalTransactionsToday = 0; //to keep track of total transactions made today
        public void MakeTransaction(decimal amount)
        {
            if (totalTransactionsToday + amount > dailyLimit)
            {
                //throwing user define exception when daily limit is exceeded.
                throw new DailyLimitExceededException("Daily transaction limit exceeded.");
            }
            totalTransactionsToday += amount;
            Console.WriteLine($"Transaction of {amount} completed successfully.");
        }
    }
}
