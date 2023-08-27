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

            for (int i = 0; i < numberOfDatas; i++)
            {
                var goodsCount = Console.ReadLine();

                var prices = Console.ReadLine().Split(' ');
                List<ushort> _units = new List<ushort>();

                for (int j = 0; j < prices.Length; j++)
                {
                    _units.Add(Convert.ToUInt16(prices[j]));

                }
                _units.Sort();

                Console.WriteLine(Program.GetCountResult(_units, prices.Length));
            }
        }

        private static string GetCountResult(List<ushort> sortedData, int goodsCount)
        {
            int sum = 0;
            int counter = 0;

            while(sortedData.Count > 0)
            {
                ushort firstCurrentPriceUnit = sortedData.First();
                sortedData.RemoveAt(0);
                sum += firstCurrentPriceUnit;

                counter++;

                foreach (ushort data in sortedData.ToList())
                {
                    if (data == firstCurrentPriceUnit)
                    {
                        sum += data;
                        sortedData.Remove(data);
                        counter++;
                    }
                    else break;
                }
                sum -= (int)(firstCurrentPriceUnit * (int)(counter / 3));


                counter = 0;
            }
            return $"{sum}";
        }
    }
}
