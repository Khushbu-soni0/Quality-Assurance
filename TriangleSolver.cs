using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment02
{
    public static class TriangleSolver
    {
       
        public static string Analyze(int side1, int side2, int side3)
        {
            String typeOfTriangle = "Not Recognized";


            if (side1 <= 0 || side2 <= 0 || side3 <= 0)
            {
                Console.WriteLine("inputs can't produce a triangle");
            }

            if (side1 > 0 && side2 > 0 && side3 > 0)
            {
                if (((side1 + side2) > side3) && (side2 + side3) > side1 && (side1 + side3) > side2)
                {

                    if (side1 == side2 && side2 == side3)
                    {
                        typeOfTriangle = "Equilateral";
                    }

                    else if (side1 == side2 || side2 == side3 || side3 == side1)
                    {
                        typeOfTriangle = "Isosceles";
                    }
                    else
                    {
                        typeOfTriangle = "Scalene";
                    }
                }
            }

            return typeOfTriangle;
        }

    }
}
