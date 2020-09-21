using System;
using System.IO;
using System.Collections.Generic;
namespace Graph
{
    class Program
    {
        static int[,] a;
        static int n;
        static LinkedList<int>[] adj;
        static void ReadData_AdjencyMatrix(string filePath)
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

        static void ReadData_AdjencyList(string filePath)
        {
            StreamReader sr = new StreamReader(filePath);
            n = int.Parse(sr.ReadLine());
            adj = new LinkedList<int>[n];
            for(int i = 0; i < n; i++)
            {
                string[] s = sr.ReadLine().Split();
                adj[i] = new LinkedList<int>();
                for (int j = 0; j < s.Length; j++)
                    adj[i].AddLast(int.Parse(s[j]));
            }

            sr.Close();

        }
        static void PrintData()
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
            //string path = "D:\\Lý thuyết đồ thị\\Graph\\bin\\Debug\\netcoreapp3.1\\DATA.txt";
            //string pathTemp = "DATA.txt";
            //ReadData(pathTemp);
            //WriteData();
            //(int, double,string,char) vudang = (1,12.5,"connect with vudang",'c');

            //Console.WriteLine(vudang.Item3);


            ReadData_AdjencyList("hykhang.txt");
            PrintData();
                
        }
    }
}
