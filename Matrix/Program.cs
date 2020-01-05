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

            //MATRIX MIT ZUFALLSZAHLEN BEFÜLLEN
            for(int i = 0; i < height; i++)
            {
                for(int j = 0; j < width; j++)
                {
                    matrix[i, j] = rand.Next(1,10);
                    Console.Write(matrix[i, j]);
                }
                Console.WriteLine();
            }

            //SCHLEIFEN DOPPELT SO GROSS WIE MATRIX, unten und rechts um 1 beschnitten
            for (int k = 0; k < (height*2)-1; k++)
            {
                for (int m = 0; m < (width*2)-1; m++)
                {
                    if (k % 2 ==0)//VERGLEICH AUF ZEILENEBENE
                    {
                        if (m % 2 == 0)
                        {
                            Console.Write(matrix[k / 2, m / 2]);
                        }
                        else
                        {
                            if(matrix[k/ 2, (m-1) / 2] > matrix[k / 2, (m + 1) / 2])//ZEILENVORGÄNGER > ZEILENNACHFOLGER
                            {
                                Console.Write(">");
                            }
                            else if (matrix[k  / 2, (m-1) / 2] < matrix[k / 2, (m + 1) / 2])
                            {
                                Console.Write("<");
                            }
                            else
                            {
                                Console.Write("=");
                            }                            
                        }
                    }
                    else//VERGLEICH AUF SPALTENEBENE
                    {
                        if (m % 2 == 0)
                        {
                            if (matrix[(k-1) / 2, m/2] > matrix[(k+1) / 2, m / 2])//SPALTENVORGÄNGER > SPALTENNACHFOLGER
                            {
                                Console.Write("V");
                            }
                            else if (matrix[(k-1) / 2, m  / 2] < matrix[(k+1) / 2, m/2])
                            {
                                Console.Write("A");
                            }
                            else
                            {
                                Console.Write("=");
                            }
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
