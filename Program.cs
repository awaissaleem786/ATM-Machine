// See https://aka.ms/new-console-template for more information

using System.Security.Cryptography.X509Certificates;

using System;
class ATM
{
    float balance;
    int pin=9090;
    public void checkpin()
    {
        while (true)
        {
            Console.WriteLine("Enter the pin:");
            int inputpin = int.Parse(Console.ReadLine());
            if (inputpin == pin)
            {
                menu();
                break;
            }
            else
            {
                Console.WriteLine(" Enter the pin is incorrect.Try again");
                continue;
            }
        }
    }
    public void menu()
    {
        while (true)
        {
            Console.WriteLine("Enter Your Choice: ");
            Console.WriteLine("1. Check A/C Balance:");
            Console.WriteLine("2. Withdraw Money");
            Console.WriteLine("3. Deposit Money");
            Console.WriteLine("4. EXIT");
            int choice = int.Parse(Console.ReadLine());
            if (choice == 1)
            {
                BalanceChecker();
            }
            else if (choice == 2)
            {
                withdraw();
            }
            else if (choice == 3)
            {
                depositmoney();
            }
            else if (choice == 4)
            {
                break;
            }
            else
            {
                Console.WriteLine(" Enter a valid choice:");
            }
        }
    }
    public void BalanceChecker()
    {
        Console.WriteLine(" Current balance is: " + balance);
        
    }

    public void withdraw()
    {
        Console.WriteLine(" Enter the amount to withdraw:");
        int enteramount=int.Parse(Console.ReadLine());
        if(enteramount>balance)
        {
            Console.WriteLine(" Insuficent balance:");
        }
        else
        {
            balance = balance - enteramount;
            Console.WriteLine(" withDraw successfully: ");
        }
        
    }
    public void depositmoney()
    {
        Console.WriteLine(" Enter the money to deposit:");
        int enteramount = int.Parse(Console.ReadLine());
        balance = balance + enteramount;
        Console.WriteLine(" Deposit money successfully:");
       
    }
}

class ATMachine
{
    public static void Main(string[] args)
    {
        ATM aTM = new ATM();
        aTM.checkpin();
    }
}
