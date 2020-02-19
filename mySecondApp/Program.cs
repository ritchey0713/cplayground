using System;

namespace mySecondApp
{
    class Program
    {
        //constants/fields they are immutable(unchangable)
        const double PI = 3.14159265359;
        const int weeks = 54, months = 12;
        const string birthday = "April 7th 2077";

				//file global variables, must use static before declaring
				static string userName = "";
				static string password = "";
				static string userNameValidated = "";
				static string passwordValidated = "";
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

            // relational and type ops
            bool isLower;
            isLower = num13 < num14;
            System.Console.WriteLine(isLower);

            bool isEqual;

            isEqual = num1 == num2;
            System.Console.WriteLine(isEqual);

            isEqual = num1 != num2;
            System.Console.WriteLine(isEqual);

            //conditionals
            bool isLowerAndSunny;

            isLowerAndSunny = isLower && isEqual;
            System.Console.WriteLine(isLowerAndSunny);

            // isLowerAndSunny = true || isEqual;
            // System.Console.WriteLine(isLowerAndSunny);

            // System.Console.WriteLine("Whats the temp?");
            // string temp = Console.ReadLine();
            
            // int tempNum;
            // int number;

            // bool userTempConversion = int.TryParse(temp, out number);

            // if(userTempConversion){
            //     tempNum = number;
            // } else {
            //     System.Console.WriteLine("Must be a number! 0 set as the temp!");
            //     tempNum = 0;
            // }

            // if(tempNum < 50){
            //     System.Console.WriteLine("Put on a coat!");
            // } else if(tempNum == 10) {
            //     System.Console.WriteLine("Its 10 degrees out!");
            // }else {
            //     System.Console.WriteLine("its nice out!");
            // }


            //try parse 
            //bool isTemp = int.TryParse(temp, out tempNum);
            
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


            // bool isAdmin = true;
            // bool isRegistered = true;
            // string userName = "";
						// System.Console.WriteLine("Whats your userName?");
						// userName = Console.ReadLine();
						

						// if(isRegistered && userName != "" && userName.Equals("admin")) {
						// 	System.Console.WriteLine("Hi registered user!");
						// 	System.Console.WriteLine("Hi there! {0}", userName);
						// 	System.Console.WriteLine("Hello admin!");
						
						// }

						// if(isAdmin || isRegistered){
						// 	System.Console.WriteLine("You are logged in!");
						// }
			

					Register();
					Login();

            
        }

				public static void Register() {
						System.Console.WriteLine("Please enter a username");
						userName = Console.ReadLine();
						System.Console.WriteLine("Please enter a password");
						password = Console.ReadLine();
						
						if(userName != "" && password != "") {
							System.Console.WriteLine("user created");
						} else {
							System.Console.WriteLine("Please try again!");
						}

					
				}

				public static void Login() {
						System.Console.WriteLine("Please log in:");
						userNameValidated = Console.ReadLine();
						System.Console.WriteLine("Please enter your password:");
						passwordValidated = Console.ReadLine();
						
						if(userName.Equals(userNameValidated) && password.Equals(passwordValidated)){
							System.Console.WriteLine("Thank you for logging in {0}", userName);
						} else {
							System.Console.WriteLine("Your username and password don't match");
						}
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
