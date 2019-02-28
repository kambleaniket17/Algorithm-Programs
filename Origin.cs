// -------------------------------------------------------------------------------------------------------------------------
// <copyright file="Origin.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Aniket Kamble"/>
// ---------------------------------------------------------------------------------------------------------------------------
namespace Algorithm_Programs
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// main class for choose the programs
    /// </summary>
    public class Origin
    {
        /// <summary>
        /// Mains the specified arguments.
        /// </summary>
        /// <param name="args">The arguments.</param>
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter Your Choice");
            int choice = int.Parse(Console.ReadLine());
            do
            {
                switch (choice)
                {
                    case 1:
                        Utility.CheckAnagram();
                        Console.ReadKey();
                        break;
                    case 2:
                        ArrayList list = Utility.PrimeNumbersbet1000();
                        Utility.ShowList(list);
                        Console.ReadKey();
                        break;
                    case 3:
                        Utility.PrimePalindrome();
                        break;
                    case 4:
                        Utility.PrimeAnagram();
                        Console.ReadKey();
                        break;
                    case 5:
                        Input.InputBinaryforInt();
                        Console.ReadKey();
                        break;
                    case 6:
                        Input.InputBinaryforString();
                        Console.ReadKey();
                        break;
                    case 7:
                        Input.InputInsertionforString();
                        Console.ReadKey();
                        break;
                    case 8:
                        Input.InputInsertionforInt();
                        Console.ReadKey();
                        break;
                    case 9:
                        Utility.DayOfWeek();
                        Console.ReadKey();
                        break;
                    case 10:
                        Utility.TemperaturConversion();
                        Console.ReadKey();
                        break;
                    case 11:
                        Utility.MonthlyPayment();
                        Console.ReadKey();
                        break;
                    case 12:
                        Utility.Sqrt();
                        Console.ReadKey();
                        break;
                    case 13:
                        Input.PrintBinaryDigit();
                        Console.ReadKey();
                        break;
                    case 14:
                        Input.InputBubbleSortforInt();
                        Console.ReadKey();
                        break;
                    case 15:
                        Input.InputBubbleSortforString();
                        Console.ReadKey();
                        break;
                    case 16:
                        Input.BinarySearchUsingFile();
                        Console.ReadKey();
                        break;
                    case 17:
                        Input.BubbleSortUsingFile();
                        Console.ReadKey();
                        break;
                    case 18:
                        VendingMachine.CalculateNotes();
                        Console.ReadKey();
                        break;
                    case 19:
                        Binary.SwapNibbles();
                        Console.ReadKey();
                        break;
                }
            }
            while (choice != 0);
        }
    }
}
