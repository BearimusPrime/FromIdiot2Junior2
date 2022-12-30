using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FromIdiot2Junior2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Tables. A few tests.
            int[] tab = new int[365];
            for (int i =0; i < tab.Length; i++)
            {
                tab[i] = i+1;
            }
            Console.WriteLine(tab);
            for (int i = 0; i < tab.Length; i++)
            {
                Console.WriteLine(tab[i]);
            }
            //Multitable
            int[,] tab2 = new int[4,5];
            for (int i = 0; i < tab2.GetLength(0); i++)
            {
                for (int j = 0; j< tab2.GetLength(1); j++)
                {
                    tab2[i,j] = i + j;
                }
            } 
            Console.WriteLine(tab2);
            for (int i = 0; i < tab2.GetLength(0); i++)
            {
                for (int j = 0; j < tab2.GetLength(1); j++)
                {
                
                    Console.Write(tab2[i, j]+" ");
                }
                Console.WriteLine();
            }
            //Table of tables
            int[][] tab3 = new int[2][];
            tab3[0] = new int[3];
            tab3[1] = new int[5];
            Console.WriteLine("Table of tables - lengths:");
            Console.WriteLine("tab3.Length= {0}",tab3.Length);
            Console.WriteLine("tab3.GetLength(0)= {0}", tab3.GetLength(0));
            Console.WriteLine("tab3.GetLength(1)= wykrzacza");
            Console.WriteLine();
            Console.WriteLine("tab3[0].Length= {0}", tab3[0].Length);
            Console.WriteLine("tab3[1].Length= {0}", tab3[1].Length);
            Console.WriteLine("tab3[0].GetLength(0)= {0}", tab3[0].GetLength(0));
            Console.WriteLine("tab3[1].GetLength(0)= {0}", tab3[1].GetLength(0));
            Console.WriteLine("krzaki dla GetLength(x) gdzie x!=0");
            Console.WriteLine("czyli... petla");

            int count = 0;
            for (int i = 0; i < tab3.GetLength(0); i++) 
            {
                for (int j=0; j < tab3[i].GetLength(0); j++)
                {
                    tab3[i][j]= count;
                    Console.WriteLine(tab3[i][j]+" ");
                    count++;
                }
                Console.WriteLine();
            }
        }
    }
}
