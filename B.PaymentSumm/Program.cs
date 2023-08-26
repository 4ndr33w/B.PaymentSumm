using System;
using System.Collections.Generic;
using System.Linq;

namespace B.PaymentSumm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ushort numberOfDatas = Convert.ToUInt16(Console.ReadLine());

            //string[,] array = new string[numberOfDatas, 2];

            for (int i = 0; i < numberOfDatas; i++)
            {
                var goodsCount = Console.ReadLine();

                var prices = Console.ReadLine().Split(' ');
                //ushort[] units = new ushort[Convert.ToUInt16(goodsCount)];
                List<ushort> _units = new List<ushort>();

                for (int j = 0; j < prices.Length; j++)
                {
                    //units[j] = Convert.ToUInt16(prices[j]);
                    _units.Add(Convert.ToUInt16(prices[j]));

                }

                _units.Sort();

                Console.WriteLine(Program.GetCountResult(_units, prices.Length));


                Console.ReadKey();
                //Console.WriteLine("Hello World!");
            }
        }

        private static string GetCountResult(List<ushort> sortedData, int goodsCount)
        {
            string result = "test";



            return result;
        }
    }
}
