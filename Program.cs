using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            #region basic c# concepts
            ////Variables, Datatypes
            //string name = "Padmavathi";
            //int age;
            //age = 33;
            //char grade = 'A';
            //double gpa = 5.2;
            //Console.WriteLine("Hello " + name + "!");
            //Console.WriteLine("My name is " + name);
            //Console.WriteLine("Age is " + age);
            //Console.WriteLine($"My Grade is {grade} and gpa is {gpa}");

            ////Strings
            //string firstString = " I love my baby ";
            //string secondString = " Her name is Pragati Sivakumar ";
            //Console.WriteLine(firstString.Length);
            //Console.WriteLine(firstString + secondString);
            //Console.WriteLine(firstString.ToUpper());
            //Console.WriteLine(secondString.ToLower());
            //Console.WriteLine(secondString.Trim());
            //Console.WriteLine(secondString.TrimStart());
            //Console.WriteLine(secondString.TrimEnd());
            //Console.WriteLine(firstString.Contains("love"));
            //Console.WriteLine(firstString.Replace("baby", "daughter"));

            ////Numbers
            //int num1 = 10;
            //int num2 = 5;
            //Console.WriteLine(num1 + num2);
            //Console.WriteLine(num1 - num2);
            //Console.WriteLine(num1 * num2);
            //Console.WriteLine(num1 / num2);
            //Console.WriteLine(num1+ num2 * num1);
            //Console.WriteLine(Math.Abs(num1));

            ////Getting Input
            //Console.WriteLine("Enter Numbers to add:");
            //int a = int.Parse(Console.ReadLine());
            //int b = int.Parse(Console.ReadLine());
            //Console.WriteLine(a+b);          

            ////Calculator Program
            //Console.Write("Enter two numbers: ");
            //double cnum1 = Convert.ToDouble(Console.ReadLine());
            //double cnum2 = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine(cnum2 + cnum1);

            ////MadLibs Game
            //string color, noun, verb;
            //Console.Write("Enter the color: ");
            //color = Console.ReadLine();
            //Console.Write("Enter the noun: ");
            //noun = Console.ReadLine();
            //Console.Write("Enter the verb: ");
            //verb = Console.ReadLine();
            //Console.WriteLine("Roses are "+ color);
            //Console.WriteLine(noun + " are Blue");
            //Console.WriteLine("I love " + verb);
            #endregion

            #region array
            //int[] rollNum = { 101, 102, 103, 104, 105 };
            //string[] names = new string[3];
            //names[0] = "Padma";
            //names[1] = "Siva";
            //names[2] = "Pragati";
            //Console.WriteLine(rollNum[2]);
            //Console.WriteLine(names[1]);
            //var values = new List<string> { "Mano" };
            //values.Add("Natraj");
            //values.Remove("Mano");
            //Console.WriteLine(values[0]);
            #endregion

            #region Methods
            //Console.Write("Enter the Name to say Hi: ");
            //string pass = Console.ReadLine();
            //SayHi(pass);
            #endregion

            #region Return Statement
            //int num = 5;
            //int cuberesult = cube(num);
            //Console.WriteLine(cuberesult);
            #endregion

            #region if Statements
            //bool isMale = Convert.ToBoolean(Console.ReadLine());
            //bool isTall = Convert.ToBoolean(Console.ReadLine());
            //if (isMale && isTall)
            //{
            //    Console.WriteLine("You are male and tall");
            //}
            //else if (isMale && !isTall)
            //{
            //    Console.WriteLine("You are short male");
            //}
            //else if (!isMale && isTall)
            //{
            //    Console.WriteLine("You are not male but tall");
            //}
            //else
            //{
            //    Console.WriteLine("You are not male and tall");
            //}
            #endregion

            #region MoreIfStatements
            //int number1 = Convert.ToInt32(Console.ReadLine());
            //int number2 = Convert.ToInt32(Console.ReadLine());
            //int resValue = GetMaxNum(number1, number2);
            //Console.WriteLine(resValue);
            #endregion

            #region switch statements
            //Console.WriteLine(GetDay(6));
            #endregion

            #region WhileLoops
            //int indexVal = 1;
            //while (indexVal <= 5)
            //{
            //    Console.WriteLine(indexVal);
            //    indexVal++;
            //}
            #endregion

            #region DoWhileLoops
            //int indexVal = 6;
            //do
            //{
            //    Console.WriteLine(indexVal);
            //    indexVal++;
            //} while (indexVal <= 5);
            #endregion

            #region MindGame
            //string secWord = "Girl";
            //string guessWord = "";
            //int guessLimit = 3;
            //int guessCount = 0;
            //bool outofgues = false;
            //while (guessWord != secWord && !outofgues)
            //{
            //    if (guessCount < guessLimit)
            //    {
            //        Console.Write("Enter guess word: ");
            //        guessWord = Console.ReadLine();
            //        guessCount++;
            //    }
            //    else
            //    {
            //        outofgues = true;
            //    }
            //}
            //if (outofgues)
            //{
            //    Console.Write("You Lose!");
            //}
            //else
            //{
            //    Console.Write("You Win!");
            //}
            #endregion

            #region ForLoop
            //for (int i=1; i<=5; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //int[] arrloop = { 5, 10, 15, 20, 25, 30 };
            //for (int i=0; i<arrloop.Length; i++)
            //{
            //    Console.WriteLine(arrloop[i]);
            //}
            #endregion

            #region 2DArrays and Multiline Comment
            /*int[,] matrix =
            {
                {1, 2 },
                {3, 4 },
                {5, 6 }
            };
            Console.WriteLine(matrix[2, 1]);*/
            #endregion

            #region ExceptionHandling
            /*try
            {
                int result = 1, powno = 2, baseno = 3;
                for (int i = 0; i < powno; i++)
                {
                    result = result * baseno;
                }
                Console.WriteLine(result);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }*/
            #endregion

            #region OOPS
            //class&objects/Constructors
            Book book1 = new Book("The Hobbit", "Kolin", 560);
            Book book = new Book();
            book.title = "Lord of the Rings";
            book.author = "J.R.R. Tolkien";
            book.pages = 450;
            Console.WriteLine(book.title);
            Console.WriteLine(book1.title);

            // ObjectMethods
            Student stud1 = new Student("Padma", "Maths", 2.5);
            Student stud2 = new Student("Siva", "Science", 3.2);

            Console.WriteLine(stud1.Honors());
            Console.WriteLine(stud2.Honors());

            // Getters & Setters Attributes
            Movie movie = new Movie("PS2", "Manirathnam", "R");
            Console.WriteLine(movie.Rating);

            // Static Attribute
            Song s = new Song("Munbaevaa", "5min");
            Console.WriteLine(Song.count);
            Console.WriteLine(s.getCount());

            // Static class and method
            UsefullTool.Print("Hello Padmavathi!");  // without creating obj method accessed

            // Inheritance
            Chef chef = new Chef();
            chef.MakeVarityRice();
            chef.MakeSpecialDish();
            ItalianChef italianChef = new ItalianChef();
            italianChef.MakeVarityRice();
            italianChef.MakeSpecialDish();
            #endregion

            Console.ReadLine();
        }

        #region Methods
        //public static void SayHi(string pass)
        //{
        //    Console.WriteLine("Hello User " + pass);
        //}
        #endregion

        #region Return Statements
        //public static int cube(int num)
        //{
        //    int result = num * num * num;
        //    return result;
        //}
        #endregion

        #region MoreIfStatements
        //public static int GetMaxNum(int number1, int number2)
        //{
        //    int result;
        //    if (number1 > number2)
        //    {
        //        result = number1;
        //    }
        //    else
        //    {
        //        result=number2;
        //    }
        //    return result;
        //}
        #endregion

        #region switch statements
        //public static string GetDay(int dayType)
        //{
        //    string dayName;
        //    switch(dayType)
        //    {
        //        case 0:
        //            dayName = "Sunday";
        //            break;
        //        case 1:
        //            dayName = "Monday";
        //            break;
        //        case 2:
        //            dayName = "Tuesday";
        //            break;
        //        case 3:
        //            dayName = "Wednesday";
        //            break;
        //        case 4:
        //            dayName = "Thursday";
        //            break;
        //        case 5:
        //            dayName = "Friday";
        //            break;
        //        case 6:
        //            dayName = "Saturday";
        //            break;
        //        default:
        //            dayName = "Invalid";
        //            break;
        //    }
        //    return dayName;
        //}

        #endregion
    }
}
