using System;
using System.Collections.Generic;
using System.Linq;

namespace B.PaymentSumm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ushort countOfInputData = Convert.ToUInt16(Console.ReadLine());

            string[,] array = new string[countOfInputData, 2];

            for (int i = 0; i < countOfInputData; i++)
            {
                string goodsCount = Console.ReadLine();
                var prices = Console.ReadLine().Split(' ');
                //char[] chars = prices.ToCharArray().OrderBy(c => c.GetHashCode()).ToString().ToCharArray();
                ushort[] units = new ushort[Convert.ToInt32(goodsCount)];
                List<ushort> _units = new List<ushort>();

                for (int j = 0; j < prices.Length; j++)
                {
                    //units[j] = Convert.ToUInt16(prices[j]);
                    _units.Add(Convert.ToUInt16(prices[j]));
                }

                _units.Sort();

                int sum = 0;
                for (int k = 0; k < _units.Count; k++)
                {
                    int counter = 0;
                    
                    while (counter < 3) 
                    {
                        if (_units[k] == _units[k + 1])
                        {
                            counter++;
                            sum += _units[k];
                            k++;
                        }
                        else
                        {
                            k++;
                            break;
                        }
                        
                    }
                    if (counter == 3)
                    {
                        sum -= _units[k];
                        counter = 0;
                    }
                   
                }
                Console.WriteLine(sum);
                //foreach (ushort unit in _units)
                //{
                //    Console.Write(sum);
                //}

                //    array[i, 0] = goodsCount;
                //    //array[i, 1] = chars.ToString();
                //    prices = "";

                //    for (int j = 0; j < chars.Length; j++)
                //    {
                //        prices += chars[j].ToString();
                //    }

                //    array[i, 1] = prices;
                //}

                //for (int i = 0; i < countOfInputData; i++)
                //{
                //    Console.WriteLine($"{array[i, 0]} / {array[i,1]}");
                //}

                Console.ReadKey();
                //Console.WriteLine("Hello World!");
            }
        }
    }
}
