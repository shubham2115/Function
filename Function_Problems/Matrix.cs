using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Function_Problems
{
    public class Matrix
    {
        
        
            public void Array()
            {
                int row, coloumn;
                Console.WriteLine("Enter number of rows");
                row = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter number of coloumn");
                coloumn = Convert.ToInt32(Console.ReadLine());
                int[,] elements = new int[row, coloumn];
                for (int i = 0; i < row; i++)
                {
                    for (int j = 0; j < coloumn; j++)
                    {
                        Console.WriteLine("Enter element" + i + j);

                        elements[i, j] = Convert.ToInt32(Console.ReadLine());
                    }
                }
                for (int i = 0; i < row; i++)
                {

                    for (int j = 0; j < coloumn; j++)
                    {
                        Console.Write(elements[i, j]);
                        Console.Write("\t");

                    }
                    Console.WriteLine("\n");
                }

            }

        
    }

}