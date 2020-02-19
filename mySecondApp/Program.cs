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
    }
}
