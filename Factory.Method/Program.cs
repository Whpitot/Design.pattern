using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
///////////////////////////////////////////////////
// Factory Method;
//厨房炒菜 鸡蛋，花菜，萝卜丝
//因为这是面向对象编程，而不是面向过程编程；
//////////////////////////////////////////////////

namespace Factory.Method   //不用去修改工厂类，直接在外部添加即可；设计模式之工厂方法模式
{
    class Program
    {
        static void Main(string[] args)
        {
            Cooker tomatoCooker = new TomatoCooker();
            Food tomato = tomatoCooker.CookDish();
            tomato.Print();
            Console.ReadKey();
        }
    }

    public abstract class Food
    {
        public abstract void Print();
    }

    public class Tomato:Food
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

    public abstract class Cooker   //所有厨房的抽象
    {
        public abstract Food CookDish();        
    }

    public class TomatoCooker : Cooker
    {
        public override Food CookDish()
        { 
            return new Tomato();
        }
    }

    public class PotatoCooler : Cooker
    {
        public override Food CookDish()
        {
            return new Tomato();
        }
    }
}
