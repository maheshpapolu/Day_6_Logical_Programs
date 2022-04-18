using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Programing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Day 6 Assignments Problems");
            Console.WriteLine("\nProblem 1 : Fiboacci Series\nProblem 2 : Perfect Number\nProblem 3 : Prime Number");
            Console.WriteLine("Problem 4 : Reverse a Number\nProblem 5 : Coupon Number Number");
            Console.WriteLine("\nProblem 6 : Vending Machine\nProblem 7 : Find week day of any date");
            Console.WriteLine("Problem 8 : Temprature Conversion\nProblem 9 : Monthly Payment Calculation\nProblem 10 : Find SquareRoot pf any number ");
            Console.WriteLine("Problem 11 : Decimal to Binary Conversion\nProblem 12 : Binary to Decimal Conversion\n");

            Console.WriteLine("Enter your choice : ");
            int a = Convert.ToInt32(Console.ReadLine());
            //Use switch case to run any particular program which user wants
            switch (a)
            {
                case 1:
                    Fibonacci_Series series = new Fibonacci_Series();
                    series.Fibonacci();
                    break;
                case 2:
                    Perfect_Number perfectNumber = new Perfect_Number();
                    perfectNumber.Perfect();
                    break;
                case 3:
                    PrimeNumber primeNumber = new PrimeNumber();
                    primeNumber.Prime();
                    break;
                case 4:
                    Reverse_a_Number reverseNumber = new Reverse_a_Number();
                    reverseNumber.Reverse();
                    break;
                case 5:
                    CouponNumbers couponNumber = new CouponNumbers();
                    couponNumber.Coupon();
                    break;
                
                case 6:
                    VendingMachine vendingMachine = new VendingMachine();
                    vendingMachine.ChangeMoney();
                    break;
                case 7:
                    DayOfWeek dayOfWeek = new DayOfWeek();
                    dayOfWeek.day();
                    break;
                case 8:
                    TempratureConversion temperatureConversion = new TempratureConversion();
                    temperatureConversion.Conversion();
                    break;
                case 9:
                    MonthlyPayment monthlyPayment = new MonthlyPayment();
                    monthlyPayment.Payment();
                    break;
                case 10:
                    SQRT squareRoot = new SQRT();
                    squareRoot.FindSqrt();
                    break;
                case 11:
                    ToBinary decimalToBinary = new ToBinary();
                    decimalToBinary.BToDConversion();
                    break;
                case 12:
                    ToDecimal binaryToDecimal = new ToDecimal();
                    binaryToDecimal.DToBConversion();
                    break;
            }
            Console.ReadLine();
        }
    }
}
