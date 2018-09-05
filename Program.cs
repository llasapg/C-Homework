using System;
using System.Threading;

namespace Presentations_syntax
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Presentations_syntax");
            Thread.Sleep(1000);
            Radius_Calculator();
            Console.WriteLine("________________________________________");
            Time_Handler();
            Thread.Sleep(1000);
            Console.WriteLine("________________________________________");
            Colors Mycolor = new Colors();
            Mycolor = Colors.Red;
            Console.WriteLine($"My favourite color is - {Mycolor}");
            Console.WriteLine("________________________________________");
            Thread.Sleep(1000);
            Date date = new Date();
            date = DateTime.Today;
            Console.WriteLine($"Todays day is - {date.day}, todays months is - {date.month} and todays year is - {date.year}");
            Console.WriteLine("________________________________________");
            Thread.Sleep(1000);
            Interval();
            Console.WriteLine("________________________________________");
            User_Input();
            Console.WriteLine("________________________________________");
            Calcuter();

        }
        static void Radius_Calculator()
        {
            Console.WriteLine("Please, enter radius : ");
            string text = Console.ReadLine();
            double radius = Convert.ToDouble(text);
            double length = 2 * 3.14 * radius;
            double area = 3.14 * radius * radius;
            double volume = 4 / 3 * 3.14 * radius * radius * radius;
            Console.WriteLine($"Length of a circle - {length}, area of ​​a circle - {area}, volume of a sphere - {volume}");
        }
        static void Time_Handler()
        {
            int hour = 0;int minuts = 0;
            Console.WriteLine("Please, enter time : //hours and then minuts");
            string text = Console.ReadLine();
            hour = Convert.ToInt32(text);
            text = Console.ReadLine();
            minuts = Convert.ToInt32(text);
            if(minuts > 60)
                hour += minuts / 60;
            else if(hour >= 20 || hour < 6)
                Console.WriteLine("Good night!");
            else if(hour >= 16 || (hour < 20 && hour > 16))
                Console.WriteLine("Good evening!");
            else if(hour >= 12 && hour < 24)
                Console.WriteLine("Good afternoon!");
            else if(hour < 12 && hour > 6 )
                Console.WriteLine("Good morning!");
            else
                Console.WriteLine("Invalid input!!!");
        }
        static void Interval()
        {
            int a= 0;int b = 0;
            Console.WriteLine("Please, enter bourders of the interval :");
            string text = Console.ReadLine();
            a = Convert.ToInt32(text);
            text = Console.ReadLine();
            b = Convert.ToInt32(text);
            int base_value = a;
            int counter = 0;
            int[] arr = new int[b - a + 1];
            for(int i = 0; i < arr.Length;i++)
            {
                arr[i] = a;
                a++;
                if(arr[i] % 3 == 0)
                    counter++;
            }
            Console.WriteLine($"In interval of [{base_value} - {b}] there were {counter} number wich division by 3");
        }
        static void User_Input()
        {
            Console.WriteLine("Please, enter numbers : ");
            bool IsNegative = false;
            int average = 0;int sum = 0;
            for(int i = 0;IsNegative == false;i++)
            {
                string text = Console.ReadLine();
                int x = Convert.ToInt32(text);
                if(x < 0)
                    IsNegative = true;
                else
                {
                    average++;
                    sum += x;
                }
            }
            double result = sum / average;
            Console.WriteLine($"You entered {average} positive numbers and their average is - {result}");
        }
        static void Calcuter()
        {
            Console.WriteLine("Please, enter 10 integer numbers :");
            int[] arr = new int[10];
            int sum = 0;
            int product = 0;
            int counter = 0;
            int positive = 0;
            for(int i = 0; i < arr.Length;i++)
            {
                string text = Console.ReadLine();
                arr[i] = Convert.ToInt32(text);
                if(arr[i] > 0 && counter < 5)
                {
                    sum += arr[i];
                    counter++;
                    positive++;
                }
                else if(arr[i] < 0)
                {
                    counter++;
                    if(counter > 5)
                        product += arr[i];
                }
                
            }
            if(positive >= 5) 
                Console.WriteLine($"Total sum of 5 first elements (positive) - {sum}");
            else if(positive < 5)
                Console.WriteLine($"Total product of 5 last elements - {product}");
        }

    }
    enum Colors{
        Red = 1,
        Blue,
        Green,
        Yellow
    }
    struct Date{
        public int day;
        public int month;
        public int year;
        public static implicit operator Date(DateTime time)
        {
            return new Date(){day = time.Day, month = time.Month, year = time.Year};
        }
    }
}
/*Create a function with argument radius r that calculates and prints circle circumference, circle area and the sphere volume of this radius
Create a function with integer numbers h and m as arguments, representing the time (hour and minute). 
Depending on the time, output the greeting (“Good morning!”, “Good afternoon!”, “Good evening!”, “Good night!”)
Define the enum Colors (red, blue, green, yellow). Assign the myColor variable the value of your favourite colour 
output this value to the console.
Define the structure Date with the fields: day, month, year. Define a variable of this type and input the current date. 
Output to the console.
Define a function with input a and b – two integer numbers. Count how many integer numbers from the interval [a..b] are divisible 
by 3 without reminder.
Define a function that reads user input from console as a sequence of positive integer numbers (till the first negative one). 
Calculate the average value of those numbers
Define a function that accepts an array of 10 integer numbers as argument. 
Culculate the sum of first 5 elements if all of them are posetive or product of last 5 element in the other case. */
