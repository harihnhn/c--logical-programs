using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace two_dimensional_array_operations_p_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int c1, r1, c2, r2, i, j;
            string choice;

            label2:
            Console.WriteLine("\nEnter the No. of Rows for matrix 1:");
            r1 = int.Parse(Console.ReadLine());
            Console.WriteLine("\nEnter the No.of Column for matrix 1:");
            c1 = int.Parse(Console.ReadLine());           
            int[,] arr1 = new int[ r1, c1 ];
            
            Console.WriteLine("\n\nEnter the first matrix elements");
            for (i = 0; i < r1; i++)
            {
                for (j = 0; j < c1; j++)
                {
                    Console.WriteLine("\nElement[" + i + ", " + j + "] :");
                    arr1[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("\nEnter the No. of Rows for matrix 2:");
            r2 = int.Parse(Console.ReadLine());
            Console.WriteLine("\nEnter the No.of Column for matrix 2:");
            c2 = int.Parse(Console.ReadLine());
            int[,] arr2 = new int[r2, c2];

            Console.WriteLine("\n\nEnter the Second matrix elements");
            for (i = 0; i < r2; i++)
            {
                for (j = 0; j < c2; j++)
                {
                    Console.WriteLine("\nElement[" + i + ", " + j + "] :");
                    arr2[i, j] = int.Parse(Console.ReadLine());
                }
            }

            //Console.WriteLine("[r1, c1] = [" + r1 + ", " + c1 + "]\n" + "[r2, c2] = [" + r2 + ", " + c2 + "]");

            label1:
            Console.WriteLine("\nChoose the number to continue:");
            Console.WriteLine("\n(1). Matrix addition \n(2). Matrix Subtraction \n(3). Matrix Multiplication");
            choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    if(r1==r2 && c1 == c2)
                    {
                        int[,] sum_arr = new int[r1, c1];
                        Console.WriteLine("\nMATRIX ADDITION:\n");
                        for (i = 0; i < r2; i++)
                        {
                            for (j = 0; j < c2; j++)
                            {
                                sum_arr[i, j] = arr1[i, j] + arr2[i, j];
                                Console.Write(sum_arr[i, j] + "\t");
                            }
                            Console.WriteLine("\n");
                        }
                    }

                    else
                        Console.WriteLine("\nCan't calculate matrix addition because of size of the matrix not equal");
                    
                    break;

                case "2":
                    {
                        if (r1 == r2 && c1 == c2)
                        {
                            int[,] sub_arr = new int[r1, c1];
                            Console.WriteLine("\nMATRIX SUBTRACTION:\n");
                            for (i = 0; i < r2; i++)
                            {
                                for (j = 0; j < c2; j++)
                                {
                                    sub_arr[i, j] = arr1[i, j] - arr2[i, j];
                                    Console.Write(sub_arr[i, j] + "\t");
                                }
                                Console.WriteLine("\n");
                            }
                        }

                        else
                            Console.WriteLine("\nCan't calculate matrix Subtraction because of size of the matrix not equal");

                        break;
                    }

                case "3": 
                    {

                        if (arr1.Length == 1)
                        {
                            int[,] mul_arr = new int[r2, c2];
                            Console.WriteLine("\nMATRIX MULTIPLICATION:\n");
                            for (i = 0; i < r2; i++)
                            {
                                for (j = 0; j < c2; j++)
                                {
                                    mul_arr[i, j] = arr1[0, 0] * arr2[i, j];
                                    Console.Write(mul_arr[i, j] + "\t");
                                }
                                Console.WriteLine("\n");
                            }
                        }

                        else if (arr2.Length == 1)
                        {
                            int[,] mul_arr = new int[r1, c1];
                            Console.WriteLine("\nMATRIX MULTIPLICATION:\n");
                            for (i = 0; i < r2; i++)
                            {
                                for (j = 0; j < c2; j++)
                                {
                                    mul_arr[i, j] = arr2[0, 0] * arr1[i, j];
                                    Console.Write(mul_arr[i, j] + "\t");
                                }
                                Console.WriteLine("\n");
                            }
                        }

                        else
                        {
                            int sum,k;
                            int[,] mul_arr = new int[r1, c2];
                            //Console.WriteLine(c1 + "," + r1);
                            if(c1 == r2)
                            {
                                for (i = 0; i < r1; i++)
                                {
                                    for (j = 0; j < c1; j++)
                                    {
                                        sum = 0;
                                        for (k = 0; k < r2; k++)
                                        {
                                            sum = sum + (arr1[i, k] * arr2[k, j]);
                                        }
                                        mul_arr[i, j] = sum;
                                        Console.Write(mul_arr[i, j] + "\t");
                                    }
                                    Console.WriteLine("\n\n");
                                }
                            }
                            else
                            {
                                Console.WriteLine("\nCan't multiple these matrixes because of matrix 1 columns and matrix 2 rows are not equal");
                            }
                        }

                        break;
                    }

                default:
                    Console.WriteLine("\n****INVALID INPUT****\n");
                    goto label1;
            }
            Console.WriteLine("\nChoose the number to continue: \n(1). Go to main menu \n(2). Re-enter the input \n(3). Exit");
            choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    goto label1;

                case "2":
                    goto label2;

                case "3":
                    break;

                default:
                    break;
            }
        }
    }
}
