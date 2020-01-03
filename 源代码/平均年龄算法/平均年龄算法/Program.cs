using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 平均年龄算法.NewFolder1;

namespace 平均年龄算法
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "关于 IList<T> 实现的说明";
            Repositonry list = new Repositonry();
            var persons = Repositonry.InitialPersonList();

            var a = Repositonry.AverageAge(persons);
            Console.WriteLine(a);
            Console.WriteLine("-------------------------------------"); var w = Repositonry.InitialPersonList();
            pgdoj(w);
            Console.ReadKey();



        }
        public static void pgdoj(Calculatedaverage per)
        {
            var b = from a in per
                    where !a.Name.Contains("欧阳")
                    group a by a.Name.Substring(0, 1)
                  into box
                    select new { box.Key, sum = box.Count() };

            foreach (var i in b)
            {
                Console.WriteLine("姓：{0}，人数：{1}", i.Key, i.sum);
            }



            var name = from a in per
                       where a.Name.Contains("欧阳")
                       group a by a.Name.Substring(0, 2)
                  into box
                       select new { box.Key, sum = box.Count() };

            foreach (var i in name)
            {
                Console.WriteLine("姓：{0}，人数：{1}", i.Key, i.sum);
            }
            Console.Read();
        }

    }
}

