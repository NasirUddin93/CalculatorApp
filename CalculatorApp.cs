using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivisionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            double result;
            int remain;
            int choice;
            initiateAgain:
            Console.WriteLine("Enter you choice\n1.Addition\n2.Substruction\n3.Multiplication\n4.Division\n5.Exit\n0.Main Menu");
            choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 0:
                    {
                        Console.WriteLine("You are already in main menu");
                        goto initiateAgain;
                    }
                case 1:
                    {
                        while (true)
                        {
                            Console.WriteLine("Enter Number : ");
                            num1 = Convert.ToInt32(Console.ReadLine());
                            if (num1==0)
                            {
                                goto initiateAgain; 
                            }
                            Console.WriteLine("Enter Number : ");
                            num2 = Convert.ToInt32(Console.ReadLine());
                            result = num1 + num2;
                            Console.WriteLine("Addition Result = " + result);
                        }
                    }

                case 2:
                    {
                        while (true)
                        {
                            Console.WriteLine("Enter Larger Number : ");
                            num1 = Convert.ToInt32(Console.ReadLine());
                            if (num1 == 0)
                            {
                                goto initiateAgain;
                            }
                            Console.WriteLine("Enter Smaller Number : ");
                            num2 = Convert.ToInt32(Console.ReadLine());
                            result = num1 - num2;
                            Console.WriteLine("Substruction Result = " + result);
                        }
                        
                    }
                case 3:
                    {
                        while (true)
                        {
                            Console.WriteLine("Enter Number : ");
                            num1 = Convert.ToInt32(Console.ReadLine());
                            if (num1 == 0)
                            {
                                goto initiateAgain;
                            }
                            Console.WriteLine("Enter Number : ");
                            num2 = Convert.ToInt32(Console.ReadLine());
                            result = num1 * num2;
                            Console.WriteLine("Multiplication Result = " + result);
                        }
                    }
               case 4:
                    {
                        while (true)
                        {
                            Console.WriteLine("Enter Divisible Number : ");
                            num1 = Convert.ToInt32(Console.ReadLine());
                            if (num1 == 0)
                            {
                                goto initiateAgain;
                            }
                            Console.WriteLine("Enter Divisor Number : ");
                            num2 = Convert.ToInt32(Console.ReadLine());
                            result = num1 / num2;
                            remain = num1 % num2;
                            Console.WriteLine("Quetion = " + result + ",   Remainder = " + remain);
                        }
                    }
                case 5:
                    {
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Invalied Input\nEnter yes to continue\nEnter anything to exit");
                        string conExit;
                        conExit = Console.ReadLine();
                        if (conExit == "yes" || conExit== "Yes")
                        {
                            goto initiateAgain;
                        }
                        break;
                    }


            }
        }
    }
}
