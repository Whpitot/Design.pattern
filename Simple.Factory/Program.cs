using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
///////////////////////////////
//1、是不是一定重写父类中的抽象方法，不重写会出现什么样的结果；
//
//////////////////////////////
namespace Simple.Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            Food food = FoodSimpleFactory.CookFood("Tomato");
            food.Print();
            Console.ReadKey();
        }
    }

    public abstract class Food
    {
        public abstract void Print();
    }

    public class Tomato : Food
    {
        public override void Print()
        {
            Console.WriteLine("番茄炒好了");
        }
    }

    public class Potato : Food
    {
        public override void Print()
        {
            Console.WriteLine("土豆炒好了");
        }
    }

    public class FoodSimpleFactory
    {
        public static Food CookFood(string foodName)
        {
            Food food = null;            
            switch (foodName)
            {
                case "Tomato":
                    food = new Tomato();
                    break;
                case "Potato":
                    food = new Potato();
                    break;
                default:
                    throw new Exception("这个菜现在还不能做");
            }                
            return food;
        }
    }
}
