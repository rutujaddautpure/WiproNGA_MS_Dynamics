using ExceptionHandling;
using System;

class Program
{
    static void Main(string[] args)
    {
        BankAccount account = new BankAccount();

        try
        {
            Console.Write("Enter transaction amount: ");
            decimal amount = decimal.Parse(Console.ReadLine());

            account.MakeTransaction(amount);

        }
        catch (DailyLimitExceededException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}