using System;

namespace Chicken
{
    class Program
    {
        static void Main(string[] args)
        {
            int go = 0;//公鸡的数量公鸡5元一只

            int mu = 0;//母鸡的数量母鸡3元一只

            int chick = 0;//小鸡的数量小鸡1元三只

            int num = 1;//方案

            for (go = 0; go <= 20; go++)//100块最多买20只公鸡

            {

                for (mu = 0; mu <= 33; mu++)//100块最多买33只母鸡

                {

                    chick = 100 - go - mu;

                    if (3 * mu + 5 * go + chick / 3.0 == 100)

                    {

                        Console.WriteLine("第{0}中方案：", num++);

                        Console.WriteLine("公鸡的数量为:" + go);

                        Console.WriteLine("母鸡的数量为:" + mu);

                        Console.WriteLine("小鸡的数量为:" + chick);

                    }

                }

            }

            Console.ReadKey();//小鸡鸡
        }
    }
  }

