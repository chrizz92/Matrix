using System;

namespace Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int height = 10;
            int width = 14;

            Random rand = new Random();
            int[,] matrix = new int[height, width];

           for(int i = 0; i < height; i++)
            {
                for(int j = 0; j < width; j++)
                {
                    matrix[i, j] = rand.Next(1,10);
                    Console.Write(matrix[i, j]);
                }
                Console.WriteLine();
            }

            for (int k = 0; k < (height*2)-1; k++)
            {
                for (int m = 0; m < (width*2)-1; m++)
                {
                    if (k % 2 ==0)
                    {
                        if (m % 2 == 0)
                        {
                            Console.Write(matrix[k / 2, m / 2]);
                        }
                        else
                        {
                            Console.Write("+");
                        }
                    }
                    else
                    {
                        if (m % 2 == 0)
                        {
                            Console.Write("+");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }

                }
                Console.WriteLine();
                
            }




        }
    }
}
