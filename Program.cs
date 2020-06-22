using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment02
{
    class Program
    {
        static void Main(string[] args)
        {


            int side1, side2, side3;
            int input ;



            Console.WriteLine("1. Enter Tringle Dimension");
            Console.WriteLine("2. Exit");

            // int input = int.Parse(Console.ReadLine());

            do
            {
                Console.WriteLine("Choose the Menu from above");
               
            } while (!int.TryParse(Console.ReadLine(), out input) || input > 2 || input < 1);


            if (input == 1)
            {

                Console.Write("Input side 1 of triangle: ");
                side1 = Convert.ToInt32(Console.ReadLine());

                /* string side1 = Console.ReadLine();
                int number;
                if (!Int32.TryParse(side1, out number))
                {
                    Console.WriteLine("Please Select Side 1 value again ");
                    Console.ReadLine();
                }



                 while(side1 < 1)
                 {
                     Console.WriteLine("Incorect Input ");
                     Console.Write("Input side 1 of triangle: ");
                     string side1;
                     side1 = Convert.ToInt32(Console.ReadLine());

                 } */

                Console.Write("Input side 2 of triangle: ");
                side2 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Input side 3 of triangle: ");
                side3 = Convert.ToInt32(Console.ReadLine());

                /*if (side1 == side2 && side1 == side2)
                {
                    Console.Write("This is an equilateral triangle.\n");
                }
                else if (side1 == side2 || side1 == side2 || side1 == side2)
                {
                    Console.Write("This is an isosceles triangle.\n");
                }
                else
                {
                    Console.Write("This is a scalene triangle.\n");
                } */

                string typeOfTriangle = TriangleSolver.Analyze(side1, side2, side3);
                Console.WriteLine("\n\n The Triangle is {0} Type", typeOfTriangle);
                Console.ReadLine();
            }

            else
            {
                System.Environment.Exit(1);
            }

               // else
               // {
                //    Console.WriteLine("Incorrect Input");
               // }


                


               


            }
        }
    }


