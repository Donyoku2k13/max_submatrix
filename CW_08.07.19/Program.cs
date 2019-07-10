using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW_08._07._19
{
    public class Pair
    {

    }
    class Program
    {
        static void Main(string[] args)
        {
            int m, n;
            Random rnd = new Random();
            m = int.Parse(Console.ReadLine());
            n = int.Parse(Console.ReadLine());


            int[,] a = new int[m, n];
            for (int i = 0; i < m; i++)
                for (int j = 0; j < n; j++)
                    a[i, j] = rnd.Next(0, 100);
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                    Console.Write(a[i, j] + " ");
                Console.WriteLine();
            }
            int max1 = 0;
            int max_x = 0;
            int max_y = 0;
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (max1 < a[i, j])
                    {
                        max1 = a[i, j];
                        max_x = i;
                        max_y = j;
                    }
                }
            }
            KeyValuePair<int, int> pair1 = new KeyValuePair<int, int>(max_x, max_y);
            Console.WriteLine($"{pair1}");

            int max2 = 0;
            int max_x2 = 0;
            int max_y2 = 0;
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    
                        if (max2 < a[i,j]&& a[i,j]<max1)
                        {
                            max2 = a[i, j];
                            max_x2 = i;
                            max_y2 = j;
                        }
                                  
                }
            }
            KeyValuePair<int, int> pair2 = new KeyValuePair<int, int>(max_x2, max_y2);
            Console.WriteLine($"{pair2}");
            int x_min, x_max, y_min, y_max;
            if (pair1.Key > pair2.Key)
            {
                x_max = pair1.Key;
                x_min = pair2.Key;
            }
            else
            {
                x_max = pair2.Key;
                x_min = pair1.Key;
            }
            if (pair1.Value > pair2.Value)
            {
                y_max = pair1.Value;
                y_min = pair2.Value;
            }
            else
            {
                y_max = pair2.Value;
                y_min = pair1.Value;
            }

            int sum = 0;
            for (int i = x_min; i < x_max+1; i++)
            {
                for (int j = y_min; j < y_max+1; j++)
                {
                    sum += a[i, j];
                }
            }
            Console.WriteLine($"sum ={sum} ");


            int max3 = 0;
            int max_x3 = 0;
            int max_y3 = 0;
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {

                    if (max3 < a[i, j] && a[i, j] < max2)
                    {
                        max3 = a[i, j];
                        max_x3 = i;
                        max_y3 = j;
                    }

                }
            }
            KeyValuePair<int, int> pair3 = new KeyValuePair<int, int>(max_x3, max_y3);
            Console.WriteLine($"{pair3}");

            int max4 = 0;
            int max_x4 = 0;
            int max_y4 = 0;
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {

                    if (max4 < a[i, j] && a[i, j] < max3)
                    {
                        max4 = a[i, j];
                        max_x4 = i;
                        max_y4 = j;
                    }

                }
            }
            KeyValuePair<int, int> pair4 = new KeyValuePair<int, int>(max_x4, max_y4);
            Console.WriteLine($"{pair4}");
            int x_min2, x_max2, y_min2, y_max2;
            if (pair3.Key > pair4.Key)
            {
                x_max2 = pair3.Key;
                x_min2 = pair4.Key;
            }
            else
            {
                x_max2 = pair4.Key;
                x_min2 = pair3.Key;
            }
            if (pair3.Value > pair4.Value)
            {
                y_max2 = pair3.Value;
                y_min2 = pair4.Value;
            }
            else
            {
                y_max2 = pair4.Value;
                y_min2 = pair3.Value;
            }

            int sum2 = 0;
            for (int i = x_min2; i < x_max2 + 1; i++)
            {
                for (int j = y_min2; j < y_max2 + 1; j++)
                {
                    sum2 += a[i, j];
                }
            }
            Console.WriteLine($"sum2 ={sum2} ");
            

            int maxSum =0;
            if (sum > sum2)
            {
                maxSum = sum;
            }
            else { maxSum = sum2; }
            Console.WriteLine($"maxSum ={maxSum} ");

            Console.ReadLine();
        }

          
    }
}
