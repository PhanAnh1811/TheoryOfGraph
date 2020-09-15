using System;
using System.IO;
using System.Collections.Generic;
namespace Graph
{
    class Program
    {
        static int[,] a;
        static int n;
        static void ReadData(string filePath)
        {
            using(StreamReader reader = new StreamReader(filePath))
            {
                n = int.Parse(reader.ReadLine());
                a = new int[n, n];
                for(int i = 0; i < n; i++)
                {
                    string[] s = reader.ReadLine().Split();
                    
                    for (int j = 0; j < n; j++)
                        a[i, j] = int.Parse(s[j]);
                }
            }
        }
        static void WriteData()
        {
            for(int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                    Console.Write(a[i, j] + " ");
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            string path = "D:\\Lý thuyết đồ thị\\Graph\\bin\\Debug\\netcoreapp3.1\\DATA.txt";
            string pathTemp = "DATA.txt";
            ReadData(pathTemp);
            WriteData();

        }
    }
}
