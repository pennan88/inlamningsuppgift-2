using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Threading;


namespace Uppgift2
{

    public class Program
    {

        public static Worker Daily = new Worker();
        public static BankAccount BankOptions = new BankAccount();
        public static CalcException Calculator = new CalcException();
        public static string date = DateTime.Now.ToString("dd-MMMM-yyyy");

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

            CarSpecs car01 = new CarSpecs("Audi", "R8", "V10", "Black", 162433);
            CarSpecs car02 = new CarSpecs("BMW", "I8", "1.5-liter three-Cylinder gas engine", "Red", 149900);
            CarSpecs car03 = new CarSpecs("Honda", "Civic-Type R", "2.0 VTEC Turbo", "Black", 52908);
            CarSpecs car04 = new CarSpecs("Volvo", "V60", "B3 Four-cylinder turbo petrol engine", "White", 39718);
            CarSpecs car05 = new CarSpecs("Volvo", "740", "B19 I4", "Grey", 1334);

            Console.WriteLine(date);

            Console.WriteLine("Daily Energy: " + Worker.Workenergy + "\n");
            Console.WriteLine("1. Go to the car dealer. ");
            Console.WriteLine("2. Go to the bank. ");
            Console.WriteLine("3. Go to work. ");
            Console.WriteLine("4. Go to sleep. ");
            Console.WriteLine("5. Calculator. ");
            Console.WriteLine("6. Remove yourself from existence. ");

            string MenuChange = Console.ReadLine();


            switch (MenuChange)
            {
                case "1":
                    Console.Clear();
                    Console.WriteLine("Hello! Welcome to your local car dealer.\n");
                    Console.WriteLine("These are the cars we have in store. \n");
                    Console.ForegroundColor = ConsoleColor.White;

                    car01.CarInfo();
                    car02.CarInfo();
                    car03.CarInfo();
                    car04.CarInfo();
                    car05.CarInfo();

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
                            Console.WriteLine("Available ammount: " + BankAccount.Card_Balance.CardBalance + "$\n");
                            Console.WriteLine("1. Audi R8. 162433$");
                            Console.WriteLine("2. BMW I6. 149900$ ");
                            Console.WriteLine("3. Honda Civic Type R. 52908$ ");
                            Console.WriteLine("4. Volvo V60. 39718$ ");
                            Console.WriteLine("5. Volvo 740. 1334$ ");
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

                                case "4":
                                    car04.CarAuction();
                                    return true;

                                case "5":
                                    car05.CarAuction();
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
                            Console.WriteLine("Available ammount: " + BankAccount.account01.BankBalance + "$\n");
                            Console.WriteLine("1. 1000$");
                            Console.WriteLine("2. 3000$");
                            Console.WriteLine("3. 5000$");
                            Console.WriteLine("4. 10000$");
                            Console.WriteLine("5. Everything ");

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
                                    Console.WriteLine("You withdrew " + BankAccount.account01.BankBalance + "$ from your bank account\n");
                                    BankAccount.Card_Balance.CardBalance += BankAccount.account01.BankBalance;
                                    BankAccount.account01.BankBalance -= BankAccount.account01.BankBalance;
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
                    {
                        Console.Clear();
                        Calculator.Exception01();
                        Console.ReadLine();
                    }
                    return true;

                case "6":
                   

                    return false;

                default:
                    Console.WriteLine("Unknow input");
                    Console.ReadLine();
                    return true;
            }



        }
    }
}
