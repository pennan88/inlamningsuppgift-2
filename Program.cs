using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;


namespace Uppgift2
{
    public class Program
    {
        public static Energy Daily = new Energy();
        public static BankAccount BankOptions = new BankAccount();
        public static string date = DateTime.Now.ToString("yyyy-MMMM-dd" + " HH:mm:ss tt\n");

        static void Main(string[] args)
        {


            bool showMenu = true;
            while (showMenu)
            {

                showMenu = MainMenu();
            }

        }
        public static bool MainMenu()
        {


            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;

            Carinfo car01 = new Carinfo("Audi", "R8", "V10", "Black", 570000);
            Carinfo car02 = new Carinfo("BMW", "I6", "V8", "Red", 87900);
            Carinfo car03 = new Carinfo("Honda", "Civic", "V8", "Black", 13400);



            Console.Write(date);
            Console.WriteLine("Daily Energy: " + Energy.Workenergy + "\n");
            Console.WriteLine("1. Go to the car dealer. ");
            Console.WriteLine("2. Go to the bank. ");
            Console.WriteLine("3. Go to work. ");
            Console.WriteLine("4. Go to sleep. ");
            Console.WriteLine("5. Remove yourself from existence. ");


            string MenuChange = Console.ReadLine();


            switch (MenuChange)
            {
                case "1":
                    Console.Clear();
                    Console.WriteLine("Hello! Welcome to your local car dealer.\n");
                    Console.WriteLine("These are the cars we have in store. \n");
                    Console.ForegroundColor = ConsoleColor.DarkRed;

                    car01.CarInfo();
                    car02.CarInfo();
                    car03.CarInfo();

                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.DarkGray;

                    Console.WriteLine("Are you interested in any of these cars? \n");
                    Console.WriteLine("Yes. ");
                    Console.WriteLine("No. ");
                    string CarList = Console.ReadLine();
                    Console.Clear();

                    switch (CarList)
                    {

                        case "y":
                            Console.WriteLine("Which of the cars would you like to buy? ");
                            Console.WriteLine("1. The Audi R8. 570000$");
                            Console.WriteLine("2. The BMW I6. 87900$ ");
                            Console.WriteLine("3. The Honda Civic. 13400$ ");
                            string BuyCar = Console.ReadLine();
                            Console.Clear();

                            switch (BuyCar)
                            {
                                case "1":
                                    car01.CarAuction();
                                    return true;

                                case "2":
                                    car02.CarAuction();
                                    return true;

                                case "3":

                                    car03.CarAuction();

                                    return true;

                            }
                            break;

                        case "n":
                            Console.WriteLine("Okey, have a nice day! ");
                            Console.ReadLine();
                            break;

                    }

                    return true;

                case "2":
                    Console.Clear();
                    Console.WriteLine("Welcome to the bank\n");
                    Console.WriteLine("1. Checkings: ");
                    Console.WriteLine("2. Deposit money to the bank: ");
                    Console.WriteLine("3. Withdraw money from the bank: ");
                    Console.WriteLine("4. Go back home.");
                    string Bank = Console.ReadLine();

                    switch (Bank)
                    {
                        case "1":

                            Console.Clear();
                            BankAccount.Card_Balance._Card_Balance();
                            BankAccount.account01.Bank_Balance();

                            Console.ReadLine();
                            break;

                        case "2":
                            BankOptions.Bank_Deposit();
                            Console.ReadLine();

                            break;

                        case "3":
                            Console.Clear();
                            Console.WriteLine("How much would you like to withdaw? ");
                            Console.WriteLine("1. 1000$");
                            Console.WriteLine("2. 3000$");
                            Console.WriteLine("3. 5000$");
                            Console.WriteLine("4. 10000$");
                            Console.WriteLine("5. Everything");

                            switch (Console.ReadLine())
                            {
                                case "1":
                                    Console.Clear();
                                    BankOptions.Bank_Withdraw(1000);
                                    Console.ReadLine();
                                    break;

                                case "2":
                                    Console.Clear();
                                    BankOptions.Bank_Withdraw(3000);
                                    Console.ReadLine();
                                    break;

                                case "3":
                                    Console.Clear();
                                    BankOptions.Bank_Withdraw(5000);
                                    Console.ReadLine();
                                    break;

                                case "4":
                                    Console.Clear();
                                    BankOptions.Bank_Withdraw(10000);
                                    Console.ReadLine();
                                    break;
                                case "5":
                                    Console.Clear();
                                    Console.WriteLine("You transfered " + BankAccount.account01.Balance + "$ \n");
                                    BankAccount.Card_Balance.CardBalance += BankAccount.account01.Balance;
                                    BankAccount.account01.Balance -= BankAccount.account01.Balance;
                                    Console.ReadLine();
                                    break;

                            }

                            break;

                        case "4":
                            return true;

                        default:
                            Console.WriteLine("Unknow input");
                            Console.ReadLine();
                            return true;
                    }
                    return true;

                case "3":

                    {
                        Daily.Work();
                    }

                    return true;

                case "4":
                    {
                        Daily.Sleep();
                    }

                    return true;

                case "5":
                    return false;

                default:
                    Console.WriteLine("Unknow input");
                    Console.ReadLine();
                    return true;
            }
        }
    }
}
