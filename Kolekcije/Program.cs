using System;
using System.Collections.Generic;

namespace Kolekcije
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] polje = new int[2];
            //int[] polje = new int[2] {1,2};
            //int[] polje = {1,2};

            //int[,] polje = new int[2, 3];
            //for (int i = 0; i < 2; i++)
            //{
            //    for (int j = 0; j < 2; j++)
            //    {
            //        polje[i, j] = new Random().Next(1, 10);
            //        Console.WriteLine(polje[i, j]);
            //    }
            //}

            List<int> lista = new List<int>();
            List<int> lista2= new List<int>() {1,2,3};
            List<int> lista3 = new () { 1, 2, 3 };

            

            Dictionary<string, List<int>> keyValuePairs = new Dictionary<string, List<int>>();
            foreach (var item in keyValuePairs)
            {
                if (item.Key=="1")
                {
                    foreach (var items in item.Value)
                    {
                        Console.WriteLine(items);
                    }
                }
            }
            keyValuePairs.Add("Zadar", new List<int>());
           
            if (keyValuePairs.ContainsKey("Zadar"))
            {
                keyValuePairs["Zadar"].Add(1);
            }

            if (keyValuePairs["Zadar"]!=null)
            {
                keyValuePairs["Zadar"].Add(2);
            }

            foreach (var item in keyValuePairs)
            {
                
                    foreach (var items in item.Value)
                    {
                        Console.WriteLine(items);
                    }
                
            }
            

            //List<int> listaIntova = keyValuePairs["Grad Zagreb"];

        }
    }
}
