using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALevelLessons
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "A-Level Lessons";
            ////////////////////////////////////////////////////////////////////Lesson1
            //Console.WriteLine("What is you name?");
            //string name = Console.ReadLine();
            //Console.WriteLine($"You name is {name}");

            //bool booleanVariable = true;
            //string stringVariable = "String variable";
            //int intVariable = 100;
            //double doubleVariable = 100.5;

            //Console.WriteLine(booleanVariable);
            //Console.WriteLine(stringVariable);
            //Console.WriteLine(intVariable);
            //Console.WriteLine(doubleVariable);

            //int number = Convert.ToInt32(Console.ReadLine());

            //for (int i=0; i <= number; i+=2)
            //{
            //    Console.WriteLine(i);
            //}

            //if (number > 8)
            //{
            //}
            //else
            //{
            //}
            ////////////////////////////////////////////////////////////////////
            ////////////////////////////////////////////////////////////////////HW1
            //for (int i=1; i <= 100; i++)
            //{
            //    string r = "";
            //    if (i % 3 == 0) r = r + "Fizz";
            //    if (i % 5 == 0) r = r + "Buzz";
            //    if (r != "") Console.WriteLine(i +":" + r);
            //}

            //string res = "";
            //short exp = 1;
            //for (int i = 1; i <= 50; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        exp = 2;
            //    }
            //    else
            //    {
            //        exp = 3;
            //    }
            //    res = (i + "^" + exp + "=" + Convert.ToString(Math.Pow(i, exp)));
            //    Console.WriteLine(res);               
            //}
            ////////////////////////////////////////////////////////////////////
            ////////////////////////////////////////////////////////////////////Lesson2
            Random rand = new Random();
            string arrall = "";
            int arrlen = 64;
            string[] arr = new string[arrlen];
            string[] arrres = new string[arrlen];


            for (int i = 0; i <= arrlen - 1; i++)
            {
                char rndval1 = (char)rand.Next(0x0041, 0x0049);
                int rndval2 = rand.Next(10);
                string arrval = rndval1.ToString() + rndval2.ToString();
                arr[i] = arrval;
                arrall = i < arrlen - 1 ? arrall + arr[i] + "," : arrall = arrall + arr[i];
            }

            //arr[2] = "asd";
            //arr[4] = "asd";
            //arr[10] = "asd";

            Console.WriteLine("Array length: " + arrlen + "\r\nArray: " + arrall + "\r\n");

            for (int i = 0; i < arrlen; i++)
            {
                for (int j = i + 1; j < arrlen; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        arrres[i] = arr[i];
                        Console.WriteLine(i + ":" + j + " = " + arr[i]);
                    }
                }
            }

            Console.WriteLine("\r\nSorted array: ");
            Array.Sort(arrres);
            for (int i = 0; i < arrlen; i++)
            {
                if (arrres[i] != null)
                {
                    //Console.WriteLine(i + ": " + arrres[i]);
                    Console.WriteLine(arrres[i]);
                }
            }            

            Console.WriteLine("\r\nPress any key to next task...");
            Console.ReadKey();
            Console.Clear();           

            ////////////////////////////////////////////////////////////////////HW2
            double dailycoeff = 1.1; //10%
            double total = 10;
            int reqdist = 100;
            int finish = 0;
            for (int i = 1; total <= reqdist; i += 2)
            {
                total *= dailycoeff;
                finish = i;
            }
            Console.WriteLine("Total days (to overcome 100km): " + finish);

            ////////////////////////////////////////////////////////////////////
            ///




            ////////////////////////////////////////////////////////////////////
            Console.Beep();
            Console.WriteLine("\r\nPress any key to exit");
            Console.ReadKey();


        }
    }
}
