using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_CSharpGund
{
    class Program
    {

        private static void RunExerciseOne()
        {
            string firstName = "razuk";
            string lastName = "elias";
            Console.WriteLine("Hello {0} {1}! i'am glad to inform you that you are the test subject of my very first assignment!", firstName, lastName);
        }

        private static void RunExerciseTwo()
        {
            var today = DateTime.Now.ToShortDateString();
            var tomorrow = DateTime.Now.AddDays(1).ToShortDateString();
            var yerterday = DateTime.Now.AddDays(-1).ToShortDateString();

            Console.WriteLine("Todays DateTime is {0}", today);
            Console.WriteLine("Tomorrows DateTime is {0}", tomorrow);
            Console.WriteLine("Yesterdays DateTime is {0}", yerterday);
        }

        private static void RunExerciseThree() 
        {
            Console.Write("Enter your first name  ");
            string firstName= Console.ReadLine();
            Console.Write("Enter your last name   ");
            string lastName = Console.ReadLine();
            Console.WriteLine("{0} {1}", firstName, lastName);

        }

        private static void RunExerciseFour() 
        {
            string str = "The quick fox Jumped Over the DOG";
            str = str.Substring(0, 1) + str.Substring(1).ToLower();
            str = str.Replace("quick", "brown");
            str = str.Insert(str.IndexOf("dog"), "lazy ");
            Console.WriteLine(str);

        }


        private static void RunExerciseFive()
        {
            String str = "Arrays are very common in programmin, they look someting like: [1,2,3,4,5]";
            str = str.Substring(str.IndexOf("["), 11);
            str = str.Insert(str.Length - 1, ",6,7,8,9,10");
            str = str.Replace("2,3,", string.Empty);

            Console.WriteLine(str);
        }

        private static void RunExerciseSix() 
        {
            Console.WriteLine("Enter two numbers");
            Console.WriteLine("Enter First Number");
            int firstNum = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second Number");
            int secondNum = int.Parse(Console.ReadLine());
            int maxNum = Math.Max(firstNum, secondNum);
            int minNum = Math.Min(firstNum, secondNum);
            Console.WriteLine("The biggest Number is {0} \r\n", maxNum);
            Console.WriteLine("The smallest Number is {0} \r\n", minNum);
            Console.WriteLine("The difference is {0} \r\n", (maxNum - minNum));
            Console.WriteLine("Sum of the numbers is {0} \r\n", (firstNum + secondNum));
            Console.WriteLine("Product of the numbers is {0} \r\n", (firstNum * secondNum));
            if (secondNum != 0)
            {
                Console.Write("quotient is " + (firstNum / secondNum).ToString());
                Console.WriteLine("   and remainder is " + (firstNum % secondNum).ToString());
                Console.WriteLine("");
            }
            else
                Console.WriteLine("Invalid numbers for calculating division \r\n");


            int numerator = firstNum;
            int denominator = secondNum;

            int gcd = Gcd(numerator, denominator);
            Console.WriteLine("Ratio is " + numerator + ":" + denominator + " = " + numerator / gcd + ":" + denominator / gcd);
            //Console.WriteLine(GetRatio(numerator, denominator));

            Console.ReadLine();
        }
        private static int Gcd(int a, int b)
        {
            if (a == 0)
                return b;
            else
                return Gcd(b % a, a);
        }

        private static string GetRatio(int a, int b)
        {
            int gcd = Gcd(a, b);
            return (a / gcd).ToString() + ":" + (b / gcd).ToString();
        }

        private static void RunExerciseSeven()
        {
            Console.WriteLine("Enter radius to calculate area and volume of circle  \r\n ");
            double radius = Double.Parse(Console.ReadLine());

            double area = Math.PI * Math.Pow(radius, 2);
            double volume = (4 * Math.PI * Math.Pow(radius, 3)) / 3;
            Console.WriteLine("Area is {0} Volumme of sphere is {1} \r\n", area, volume);
        }




        private static void RunExerciseEight() 
        {
            Console.WriteLine("Enter a decimal number to calculate sqaure root, sqaure and to the power 10");
            var number = double.Parse(Console.ReadLine());
            var sqrt = Math.Sqrt(number);
            var pow2 = Math.Pow(number, 2);
            var pow10 = Math.Pow(number, 10);

            Console.WriteLine("Square root: {0}  power 2 : {1}  power 10: {2} \r\n", sqrt, pow2, pow10);
        }


        private static bool CustomerWantsToOrder(string item)
        {
            Console.WriteLine("Would you like to order {0}?", item);
            string answer = Console.ReadLine();
            return answer.Equals("y", StringComparison.CurrentCultureIgnoreCase);
        }

        private static void RunExerciseNine()
        {
            Console.Write("What is your name?: ");
            string name = Console.ReadLine();

            Console.Write("Hi, {0}! Which year(YYYY) where you born?: ", name);
            int birthYear = int.Parse(Console.ReadLine());

            int age = DateTime.Now.Year - birthYear;

            if (age >= 18)
            {
                if (CustomerWantsToOrder("beer"))
                {
                    Console.WriteLine("You beer is served!");
                }
                else
                {
                    if (CustomerWantsToOrder("coke"))
                    {
                        Console.WriteLine("You coke is served!");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, we do not have anything else to serve!");
                    }
                }
            }
            else
            {
                if (CustomerWantsToOrder("coke"))
                {
                    Console.WriteLine("You coke is served!");
                }
                else
                {
                    Console.WriteLine("Sorry, we do not have anything else to serve!");
                }
            }
        
        }


        private static void divisionNumber()
        {
            Console.WriteLine("Enter two numbers");
            Console.WriteLine("Enter First Number");
            int firstNum = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second Number");
            int secondNum = int.Parse(Console.ReadLine());

            if (secondNum != 0)
            {
                Console.Write("quotient is " + (firstNum / secondNum).ToString());
                Console.WriteLine("   and remainder is " + (firstNum % secondNum).ToString());
                Console.WriteLine("");
            }
            else
                Console.WriteLine("Invalid numbers for calculating division \r\n");
        }


        private static void changeConsoleColour()
        {
            int count = 0;
            while (count != 3)
            {
                if (Console.ForegroundColor == ConsoleColor.Green)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Here you see a change in colour.");
                }
                else if (Console.ForegroundColor == ConsoleColor.Red)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Here you see a change in colour.");
                }
                else 
                { 
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Here you see a change in colour.");
                }
                count++;
                Console.WriteLine("press any key to continue");
                Console.ReadLine();
                    
            }
            
           
        }

        private static void RunExerciseTen()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Enter 1: division  2: exercise 4  3: Change console colour ");
            int value = int.Parse(Console.ReadLine());

            switch (value)
            {
                case 1: divisionNumber();
                    break;
                case 2:
                    RunExerciseFour();
                    break;
                case 3: changeConsoleColour();
                    break;
                default:
                    Console.WriteLine("Thanks for trying this");
                    break;
            }
            Console.ReadLine();
        }



        private static void RunExerciseEleven()
        {
            Console.WriteLine("Enter any integer number between 1 to 25");
            var number = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            if (number > 0 && number <= 25)
            {
                for (int i = 1; i <= number; i++)
                {
                    if ((i % 2) == 0)
                        Console.ForegroundColor = ConsoleColor.Red;
                    else
                        Console.ForegroundColor = ConsoleColor.Green;

                    Console.WriteLine(i);

                }
                Console.WriteLine("");
                for (int i = number; i > 0; i--)
                {
                    if ((i % 2) == 0)
                        Console.ForegroundColor = ConsoleColor.Red;
                    else
                        Console.ForegroundColor = ConsoleColor.Green;

                    Console.WriteLine(i);

                }

            }
            else
                Console.WriteLine("You have entered a number outside range");
        }


        private static void RunExerciseTwelve()
        {
            for (int i = 1; i <= 10; i++)
            {
                int length = 10;
                for (int j = 1; j <= length; j++)
                {
                    Console.Write((i * j) + "\t");
                }

                Console.WriteLine("");

            }
            Console.ReadLine();
        }

        private static void RunExerciseThirteen() 
        {
            Console.WriteLine("Program to guess a number between 1 and 500");

            int numberOfGuess = 0;
            int guessedNum = 0;
            int randNumber = new Random().Next(1, 501);

            do
            {
                Console.WriteLine("Enter a guess:");
                guessedNum = int.Parse(Console.ReadLine());
                numberOfGuess++;

                if (guessedNum == randNumber)
                {
                    Console.WriteLine("That's the number! You guessed it right in {0} chances", numberOfGuess);
                }
                else if (guessedNum > randNumber)
                    Console.WriteLine("You guessed a higher number");
                else if (guessedNum < randNumber)
                    Console.WriteLine("You guessed a lower number");

            } while (guessedNum != randNumber);

            Console.ReadLine();
        }

        private static void RunExerciseFourteen() 
        {
            double number = 0;
            double sum = 0;
            int count = 0;

            while (number != -1)
            {
                Console.Write("Enter a number: ");
                number = double.Parse(Console.ReadLine());
                if (number == -1)
                    break;

                count++;
                sum += number;
            }
            double average = sum / (double)count;

            Console.WriteLine("Sum: {0}\nAverage: {1:F2}", sum, average);
            Console.ReadLine();
           
        }




        private static void PrintPerfectNumbers(int n)
        {
            if (n < 1)
                return;

            Console.WriteLine("----------- First {0} perfect numbers! ----------", n);

            int count = 0;
            int num = 2;

            while (count < n)
            {
                var sum = 0;
                for (int i = num - 1; i >= 1; i--)
                {
                    if (num % i == 0)
                        sum += i;
                }
                if (sum == num)
                {
                    Console.WriteLine(sum);
                    count++;
                }
                num++;
            }
        }

        private static void PrintDivisors(int number)
        {
            for (int i = number - 1; i >= 1; i--)
            {
                if (number % i == 0)
                    Console.WriteLine(i);
            }
        }

        private static void RunExerciseFifteen() 
        {
            Console.Write("Enter a number: ");
            PrintDivisors(int.Parse(Console.ReadLine()));
            Console.WriteLine("------------------");
            PrintPerfectNumbers(5);

            Console.ReadLine();
        }

        private static void RunExerciseSixteen() 
        {
            int previous = -1;
            int current = 0;
            int next = 1;

            Console.WriteLine(current);
            Console.WriteLine(next);
            for (int i = 0; i <= 25; i++)
            {
                previous = current;
                current = next;
                next = previous + current;

                Console.WriteLine(next);

            }
            Console.ReadLine();
        }

        public static bool IsPalindrome(string sentence)
        {
            sentence = sentence.Replace(" ", String.Empty).ToLower();
            for (int i = 0, j = sentence.Length - 1; i <( j/2)+1; i++, j--)
            {
                if (sentence[i] != sentence[j])
                    return false;

            }
            return true;
        }

        private static void RunExerciseSeventeen()
        {
            Console.WriteLine("Program to check whether the entered string is palindrome or not \n ");

            string answer = "";

            do
            {
                Console.Write("Enter a sentence to palindromecheck: ");
                string sentence = Console.ReadLine();

                if (IsPalindrome(sentence))
                    Console.WriteLine("\"{0}\" is a palindrome!\n", sentence);
                else
                    Console.WriteLine("\"{0}\" is not a palindrome!\n", sentence);

                Console.WriteLine("Would you like to try it again?  if yes: press y/Y");
                answer = Console.ReadLine().ToUpper();

            } while (answer == "Y");
        }

        private static void RunExerciseEighteen()
        {
            Random rnd = new Random();
            int[] arr = new int[10];
            double[] dArr = new double[arr.Length];

            for (int i = 0; i < arr.Length; i++)
                arr[i] = rnd.Next(1, 251);

            for (int i = 0; i < dArr.Length; i++)
                dArr[i] = 1.0 / arr[i];

            foreach (var val in arr)
                Console.WriteLine(val);
            Console.WriteLine("");

            foreach (var val in dArr)
                Console.WriteLine(val);

            Console.ReadLine();
        }

        private static void RunExerciseNineteen() 
        {
            int val = new Random().Next(0, 5001);
            Console.WriteLine("You have to pay {0}!", val);
            Console.WriteLine("Enter sum to pay: ");
            int paid = int.Parse(Console.ReadLine());
            int sumReturn = 0;
            int amount = 0;
            int remainingChange = paid - val;
            if (remainingChange < 1)
                Console.WriteLine("Sorry, you did not pay enough.");

            int[] coins = new int[] { 1000, 500, 100, 50, 20, 10, 5, 1 };
            int[] change = new int[coins.Length];

            Console.WriteLine("\nYou will get back: " + "\n");
            for (int i = 0; i < coins.Length; i++)
            {
                change[i] = remainingChange / coins[i];
                remainingChange = remainingChange % coins[i];
                if (change[i] > 0)
                {
                    Console.WriteLine(coins[i] + "x" + change[i]);
                    amount = coins[i] * change[i];
                    sumReturn = sumReturn + amount;
                }


            }
            Console.WriteLine("\nTotal:  " + sumReturn);
            Console.ReadLine();
        }


        private static int[] FillRandomIntegerArray(int elements = 10)
        {
            Random rnd = new Random();
            int[] arr = new int[elements];
            for (int i = 0; i < arr.Length; i++)
                arr[i] = rnd.Next(1, 201);

            return arr;
        }

        private static void RunExerciseTwenty()
        {
            var arr = FillRandomIntegerArray(new Random().Next(5, 15));
            int[] arrayTarget = new int[arr.Length];
            int length = arr.Length;
            int indexFront = 0;
            int indexRear = length - 1;

            for (int i = 0; i < length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    arrayTarget[indexRear] = arr[i];
                    indexRear--;
                }
                else
                {
                    arrayTarget[indexFront] = arr[i];
                    indexFront++;
                }

            }

            foreach (var value in arr)
            {
                Console.Write("{0} | ", value);
            }
            Console.WriteLine("");
            Console.WriteLine("");
            foreach (var item in arrayTarget)
            {
                Console.Write("{0} | ", item);
            }

            Console.ReadLine();
        }

        private static void RunExerciseTwentyOne() 
        {
            Console.WriteLine("Enter a string of numbers (1,2,3,4,5) to find min, max and average \n");
            string numString = Console.ReadLine();

            string[] arrChar = numString.Split(',');

            int min = int.MaxValue;
            int max = int.MinValue;
            int sum = 0;
            int number;
            Console.WriteLine("");
            foreach (var num in arrChar)
            {
                number = int.Parse(num);
                sum = sum + number;
                min = Math.Min(min, number);
                max = Math.Max(max, number);
            }

            Console.WriteLine("Min: {0} \n", min);
            Console.WriteLine("Max: {0} \n", max);
            Console.WriteLine("Average: {0} \n", sum / (double)arrChar.Length);
            Console.ReadLine();
        }

        private static void RunExerciseTwentyTwo()
        {
            string[] targetSwearwords = { "shit", "ballocks", "damn", "shut up", "lemon" };
            Console.Write("Enter a sentence to check: ");
            string input = Console.ReadLine();

            foreach (var targetWord in targetSwearwords)
            {
                if (input.Contains(targetWord))
                    input = input.Replace(targetWord, "?#¤!%¤");
            }

            Console.WriteLine(input);
        }

        private static void RunExerciseTwentyThree()
        {
            Random rnd = new Random();
            int[] arr = new int[7];
            int[] testArray = new int[20];
            int randNumber = 0;
            //int j = 0;
            for (int i = 0, j = 0; j < 7; i++)
            {
                randNumber = rnd.Next(1, 41);

                if (!arr.Contains(randNumber))
                {
                    arr[j] = randNumber;
                    j++;
                }

            }

            foreach (var uniqVal in arr)
            {
                Console.Write("{0} | ", uniqVal);
            }
            Console.ReadLine();
        }


        private static int DrawCard(ref int[] deck)
        {
            if (deck.Length == 0)
                return -1;

            int card = deck[deck.Length - 1];
            Array.Resize(ref deck, deck.Length - 1);
            return card;
        }

        private static void ShuffleCard(ref int[] deck)
        {
            Random rnd = new Random(DateTime.Now.Millisecond);
            for (int i = 0; i < deck.Length; i++)
            {
                int elementIndexToSwap = rnd.Next(0, deck.Length);
                while (elementIndexToSwap == i)
                    elementIndexToSwap = rnd.Next(0, deck.Length);

                int temp = deck[i];
                deck[i] = deck[elementIndexToSwap];
                deck[elementIndexToSwap] = temp;
            }
        }

        private static void RunExerciseTwentyFour()
        {
            int[] cards = { 
                    1,1,1,1,
                    2,2,2,2,
                    3,3,3,3,
                    4,4,4,4,
                    5,5,5,5,
                    6,6,6,6,
                    7,7,7,7,
                    8,8,8,8,
                    9,9,9,9,
                    10,10,10,10,
                    11,11,11,11,
                    12,12,12,12,
                    13,13,13,13 };

            int[] drawnCards = new int[cards.Length];


            ShuffleCard(ref cards);
            drawnCards[0] = DrawCard(ref cards);
            drawnCards[1] = DrawCard(ref cards);
            drawnCards[2] = DrawCard(ref cards);
            drawnCards[3] = DrawCard(ref cards);
            drawnCards[4] = DrawCard(ref cards);

        }


        private static void RunExerciseTwentyFive()
        {
            try
            {
                int num1 = getNumber();
                int num2 = getNumber();
                int result = num1 / num2;

                Console.WriteLine(result);
                Console.ReadLine();
            }
            catch (DivideByZeroException)
            {

                Console.WriteLine("\nYou can not divide by zero, try other number\n");
            }
        }

        private static int getNumber()
        {
            while (true)
            {
                try{
                    Console.WriteLine("Enter any valid integer for division");
                    return int.Parse(Console.ReadLine());
                    
                }
                catch(DivideByZeroException)
                {

                    Console.WriteLine("\nYou can not divide by zero, try other number\n");
                }

                catch(FormatException e)
                {

                    Console.WriteLine("\nEnter integer number\n");
                }
                catch(ArgumentNullException e)
                {

                    Console.WriteLine("\nEnter a number\n");
                }
                catch(OverflowException e)
                {
                    Console.WriteLine("Too big value, try again.");
                }
                catch(Exception e)
                {
                    Console.WriteLine("Unknown error occured. Try again.");
                }
            }
        }

        private static void RunExerciseTwentySix()
        {
            Console.WriteLine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments));
            Console.WriteLine(Environment.GetFolderPath(Environment.SpecialFolder.MyPictures));
            Console.WriteLine(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86));
            Console.WriteLine(Environment.GetFolderPath(Environment.SpecialFolder.Cookies));
            Console.WriteLine(Environment.CurrentDirectory);

            System.IO.File.Create(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "/MyFile.txt").Close();
        }

        private static void RunExerciseTwentySeven()
        {
            try
            {
                using (StreamReader reader = new StreamReader("MyFile.txt"))
                {
                    string line = reader.ReadLine();
                    while (line != null)
                    {
                        Console.WriteLine(line);
                        line = reader.ReadLine();
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private static void WriteArrayTo(string filePath, string[] arr, bool append = false)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(filePath, append))
                {
                    foreach (var element in arr)
                    {
                        writer.WriteLine(element);

                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private static void RunExerciseTwentyEight()
        {
            string[] nameArr1 = { "Karl", "David", "Samuel", "Elin", "Sebastian" };
            string[] nameArr2 = { "Sarah", "Jakob", "Emma", "Ronald", "Miranda" };

            var filePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "/MyFile.txt";

            WriteArrayTo(filePath: filePath, arr: nameArr1, append: false);
            WriteArrayTo(filePath: filePath, arr: nameArr2, append: true);



        }
        static void Main(string[] args)
        {

            bool keepAlive = true;
            while (keepAlive)
            {
                try
                {
                    Console.Write("Enter assignment number (or -1 to exit): ");
                    var assignmentChoice = int.Parse(Console.ReadLine() ?? "");
                    Console.ForegroundColor = ConsoleColor.Green;
                    switch (assignmentChoice)
                    {
                        case 1:
                            RunExerciseOne();
                            break;
                        case 2:
                            RunExerciseTwo();
                            break;
                        case 3:
                            RunExerciseThree();
                            break;
                        case 4:
                            RunExerciseFour();
                            break;
                        case 5:
                            RunExerciseFive();
                            break;
                        case 9:
                            RunExerciseNine();
                            break;
                        case 10:
                            RunExerciseTen();
                            break;
                        case 11:
                            RunExerciseEleven();
                            break;
                        case 12:
                            RunExerciseTwelve();
                            break;
                        case 13:
                            RunExerciseThirteen();
                            break;
                        case 14:
                            RunExerciseFourteen();
                            break;
                        case 15:
                            RunExerciseFifteen();
                            break;
                        case 16:
                            RunExerciseSixteen();
                            break;
                        case 17:
                            RunExerciseSeventeen();
                            break;
                        case 18:
                            RunExerciseEighteen();
                            break;
                        case 19:
                            RunExerciseNineteen();
                            break;
                        case 20:
                            RunExerciseTwenty();
                            break;
                        case 21:
                            RunExerciseTwentyOne();
                            break;
                        case 22:
                            RunExerciseTwentyTwo();
                            break;
                        case 23:
                            RunExerciseTwentyThree();
                            break;
                        case 24:
                            RunExerciseTwentyFour();
                            break;
                        case 25:
                            RunExerciseTwentyFive();
                            break;
                        case 26:
                            RunExerciseTwentySix();
                            break;
                        case 27:
                            RunExerciseTwentySeven();
                            break;
                        case 28:
                            RunExerciseTwentyEight();
                            break;
                        case -1:
                            keepAlive = false;
                            break;
                        default:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("That is not a valid assignment number!");
                            break;
                    }
                    Console.ResetColor();
                    Console.WriteLine("Hit any key to continue..");
                    Console.ReadKey();
                    Console.Clear();
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("That is not a valid assignment number!");
                    Console.ResetColor();
                }
            }


            


           /* 
            String part = "if you're doing your";
            Console.WriteLine(part);
            part = part + " best,\tyou won't have any";
            Console.WriteLine(part);
            String quote = part + " time to worry about failure.";
            Console.WriteLine(quote);
            
            */

           /* 
            
            int a = 8;
            int b = 1;
            double average =  Convert.ToDouble(a + b) / 2;
            Console.WriteLine(average);
            
            */

           
        }
       
    }
}
