using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Food.Instace.Print();
            Console.ReadKey();
        }
    }

    public class Food
    {
        //注意都是静态变量；
        private static Food instance;
        private Food()
        {}

        public static Food Instace  //也可以这样去，完全没有问题；
        {
            get
            {
                if (instance == null)
                    instance = new Food();
                return instance;
            }
        }

        //public static Food Create()
        //{
        //    if (instance == null)
        //    {
        //        instance = new Food();
        //    }
        //    return instance;
        //}

        public void Print()
        {
            Console.WriteLine("美味的食物");
        }
    }
}
