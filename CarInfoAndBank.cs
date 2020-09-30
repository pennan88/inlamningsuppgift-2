using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.Encodings.Web;
using System.Threading;
using Uppgift2;

namespace Uppgift2
{


    //-----------------------------------------------------------------------------------------------------
    // Bil klass.
    //-----------------------------------------------------------------------------------------------------

    public class Carinfo
    {
        public string Color = "";
        public string Type = "";
        public string Engine = "";
        public string Model = "";
        public int Cost;

        //-----------------------------------------------------------------------------------------------------
        // En constructor så man kan definera exempelvis vilken sorts bil.
        //-----------------------------------------------------------------------------------------------------
        public Carinfo(string _Type, string _Model, string _Engine, string _Color, int _Cost)
        {
            Engine = _Engine;
            Type = _Type;
            Model = _Model;
            Color = _Color;
            Cost = _Cost;
        }

        //-----------------------------------------------------------------------------------------------------
        // En metod för att skapa bil där jag kallar på constuctorn.
        //-----------------------------------------------------------------------------------------------------

        public void CarInfo()
        {
            Console.WriteLine(Type + "_" + Model + " with a " + Engine + " engine, it comes with the color " + Color + " at the price of " + Cost + "$\n");
        }

        //-----------------------------------------------------------------------------------------------------
        // Metod när ett köp körs
        //-----------------------------------------------------------------------------------------------------

        public void CarAuction()
        {

            if (BankAccount.Card_Balance.CardBalance < Cost)
            {
                Console.WriteLine("You cant afford that");
                Console.ReadLine();

            }
            else
            {
                Console.WriteLine("You bought the " + Type + " " + Model + " for " + Cost + "$\n");

                Console.WriteLine(Cost + "$ was charged from your account");
                BankAccount.Card_Balance.CardBalance -= Cost;

                Console.ReadLine();
            }
        }

    }

    //-----------------------------------------------------------------------------------------------------
    // Klass för Bankkontot
    //-----------------------------------------------------------------------------------------------------

    public class BankAccount
    {
        public double Balance;
        public double CardBalance;
        public static BankAccount Card_Balance = new BankAccount();
        public static BankAccount account01 = new BankAccount();

        //-----------------------------------------------------------------------------------------------------
        // Meoter för att kolla Pengarna man har på banken och sen på "Kortet" 
        //-----------------------------------------------------------------------------------------------------

        public void _Card_Balance()
        {
            Console.WriteLine("Balance card: " + Card_Balance.CardBalance + "$");
        }
        public void Bank_Balance()
        {
            Console.WriteLine("Balance bank: " + account01.Balance + "$");
        }

        //-----------------------------------------------------------------------------------------------------
        // Här kan man lägga in pengar på banken från sitt kort
        //-----------------------------------------------------------------------------------------------------

        public void Bank_Deposit()
        {
            Console.WriteLine($"You deposited {Card_Balance.CardBalance}$ to your bank account.");
            account01.Balance += Card_Balance.CardBalance;
            Card_Balance.CardBalance -= Card_Balance.CardBalance;
        }

        //-----------------------------------------------------------------------------------------------------
        // Här kan man ta ut pengar från banken till sit kort -- kort
        //-----------------------------------------------------------------------------------------------------

        public void Bank_Withdraw(int _ammount)
        {
            if (account01.Balance < _ammount)
            {
                Console.WriteLine("You dont have enough money to withdraw.");
            }
            else
            {
                int num1 = _ammount;
                Console.WriteLine("You withdrew " + _ammount + "$ from your bank account.");
                account01.Balance -= num1;
                Card_Balance.CardBalance += num1;
            }
        }
    }

    //-----------------------------------------------------------------------------------------------------
    // Här en är en klass Job som även ärver från BankAccount
    //-----------------------------------------------------------------------------------------------------

    public class Job : BankAccount
    {
        public static Job PaymentJob = new Job();
        public static double JobPay;
        public Random Income = new Random();

        public double Job_Pay()
        {
            JobPay = Income.Next(500, 2500);
            return JobPay;
        }

    }

    //-----------------------------------------------------------------------------------------------------
    // Klass som heter "Energy" ärver från job och här har man metoder så som "Work" och "Sleep"
    //-----------------------------------------------------------------------------------------------------

    public class Energy : Job
    {
        public static int Workenergy = 2;


        public void Work()
        {
            if (Workenergy <= 0)
            {
                Console.WriteLine("You are too tired");

                Console.ReadLine();

            }

            else
            {
                Console.WriteLine("You went to work....\n");
                Console.WriteLine("You earned " + PaymentJob.Job_Pay() + "$");
                account01.Balance += JobPay;

                Workenergy--;
                Console.ReadLine();
            }

        }
        public void Sleep()
        {
            if (Workenergy == 2)
            {
                Console.Clear();
                Console.WriteLine("Can't sleep now, you are not tired.");
                Console.ReadLine();
            }
            else if (Workenergy == 1)
            {
                Console.Clear();
                Console.WriteLine("You went home and took a quick nap.");
                Console.WriteLine("+ 1 energy");
                Workenergy++;
                Console.ReadLine();
            }

            else
            {
                Console.Clear();
                Console.WriteLine("You called it the day and went to sleep");
                Console.WriteLine("+ 2 energy");
                Workenergy += 2;
                Console.ReadLine();
            }
        }
    }

    public class CalcException
    {
        public static double num1;
        public string op;
        public static double num2;
        public void Exception01()
        {
            try
            {

                Console.Write("Enter your first number! ");
                num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter your Operator! ");
                op = Console.ReadLine();

                Console.Write("Enter your second number! ");
                num2 = Convert.ToDouble(Console.ReadLine());


                if (op == "+")
                {
                    Console.WriteLine($"Your answer is {num1} + {num2} = " + (num1 + num2));
                }

                else if (op == "-")
                {
                    Console.WriteLine($"Your answer is {num1} - {num2} = " + (num1 - num2));
                }

                else if (op == "*")
                {
                    Console.WriteLine($"Your answer is {num1} * {num2} = " + (num1 * num2));
                }

                else if (op == "/")
                {
                    Console.WriteLine($"Your answer is {num1} / {num2} = " + (num1 * num2));
                }

                else
                {
                    Console.WriteLine("Unknown Operator!");
                }
                Console.WriteLine("Press any key to quit: ");
            }
            catch
            {
                Console.WriteLine("Error");
            }
        }
    }
    public static class CTest
    {
        public static double Add(double x, double y)
        {
            return x + y;
        }
        public static double Subtract(double x, double y)
        {
            return x - y;
        }
        public static double Multiply(double x, double y)
        {
            return x * y;
        }
    }

}






