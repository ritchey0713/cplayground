using System;

namespace mySecondApp
{
    class Program
    {
        //constants/fields they are immutable(unchangable)
        const double PI = 3.14159265359;
        const int weeks = 54, months = 12;
        const string birthday = "April 7th 2077";
        static void Main(string[] args)
        {
            // interpolation
            //System.Console.WriteLine("my birthday is {1}", birthday);
            int num1 = 10;
            int num2 = 20;
            int num3, num4, num5;
            int sum = num1 + num2;
            
            double d1 = 3.5;
            double d2 = 1.5;
            double sum2 = d1 / d2;
            // when dividing use double cant convert floats to int or use Casting

            float f1 = 3.5f;
            float f2 = 10.5f;

            string myName = "DJ";
            string message = "My name is ";
            string shout = "hello world".ToUpper();
            string whisper = "HELLO WORLD".ToLower();

            // casting 
            double myDoub = 10.95;
            int myInt;
            // removes everything after .
            myInt = (int)myDoub;
            // implicet
            int newNum = 100000;
            long bigNum = newNum;

            float newF = 12.22222f;
            double newD = newF;

            // type conversion 
            string myString = myDoub.ToString();
            string myNewFloat = newF.ToString(); 
            bool sunIsOut = false;


            // str to int
            string newS = "15";
            string secondStr = "13";
            //string result = newS + secondStr;
            int numS = Int32.Parse(newS);
            int nemX = Int32.Parse(secondStr);
            int result = numS + nemX;

            //Console.WriteLine(result);

            WriteSomething();
            WriteSomethingNew("hello");
            System.Console.WriteLine(Add(5,5));
            int bigAdd = Add(1,Add(2,3));
            System.Console.WriteLine(bigAdd);
            System.Console.WriteLine(Multiply(2, 10));
            System.Console.WriteLine(Divide(22, 7));

            string brax = "Brax";
            string chris = "Chris";
            string adam = "Adam";
            GreetFriends(brax);
            GreetFriends(chris);
            GreetFriends(adam);

            // System.Console.WriteLine("Please input a number");
            // string input = Console.ReadLine();
            // System.Console.WriteLine("Please input a number");
            // string input2 = Console.ReadLine();
            // System.Console.WriteLine("Your total is:");
            // UserAdd(input, input2);
            //System.Console.WriteLine(input);
            // System.Console.WriteLine("Please enter a number");
            // string input = Console.ReadLine();
            // string input2 = Console.ReadLine();
            // int inputNum = Int32.Parse(input);
            // int inputNum2 = Int32.Parse(input2);
            // Divide(inputNum, inputNum2);

            num3 = 5;
            num4 = 0;
            try{
                int result0 = num3 / num4;
                System.Console.WriteLine(result0);
            }
            catch (DivideByZeroException) {
                
                System.Console.WriteLine("Cannot divide by 0!");
            }

            int new10 = 5;
            int new11 = -10;
            int new12;
            bool isTrue = false;

            new12 = -new11;
            System.Console.WriteLine(!isTrue);

            //increment 
            int num13 = 0;
            num13++;
            System.Console.WriteLine(num13);
            // pre increment
            System.Console.WriteLine(++num13);
            //post increment
            System.Console.WriteLine(++num13);

            //decrement 
            int num14 = 0;
            System.Console.WriteLine(num14);
            // pre dec
            System.Console.WriteLine(--num14);
            //post 
            System.Console.WriteLine(num14--);

        
            
            
            // try {
            //     int userInput = int.Parse(input);
                
            // }
            // catch (FormatException) {
            //     System.Console.WriteLine("Format exception, please check to make sure you entered a number");
                
            // }
            // catch(Exception) {
            //     System.Console.WriteLine("Something went wrong!");
            // } finally {
            //     System.Console.WriteLine("Its done!");
            // }
            
        }
        // must add static if calling from static method, i.e. Main()
        public static void WriteSomething() {
            System.Console.WriteLine("Hi im called from a method!");
        }

        public static void WriteSomethingNew(string myText) {
            System.Console.WriteLine(myText);
        }

        public static int Add(int num1, int num2){
            return num1 + num2;
        }

        public static int Multiply(int num1, int num2) {
            return num1 * num2;
        }

        // when dividing use same types, and use float or double
        public static float Divide(float num1, float num2) {
            return num1 / num2;
        }

        public static void GreetFriends(string name) {
            System.Console.WriteLine("Hello {0}! It's nice to see you!", name);
        }

        public static void UserAdd(string num1, string num2) {
            double newNum = Convert.ToDouble(num1);
            double newNum2 = Convert.ToDouble(num2);
            System.Console.WriteLine(newNum + newNum2);
        }
    }
}
