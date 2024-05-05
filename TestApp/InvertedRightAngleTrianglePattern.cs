using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp
{
    public class InvertedRightAngleTrianglePattern
    {
        public InvertedRightAngleTrianglePattern()
        {
            for(int row = 10; row >=1; --row)
            {
                for(int col = 1; col <=row; ++col)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

        }
    }
}
