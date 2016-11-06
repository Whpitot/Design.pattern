using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/////////////////////////////
//1、一个工厂可以创建多个产品
//OOP的思维模式，对象的观念
//具体的方法概念还是要有的
/////////////////////////////
namespace Abstract.Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractFactory nanchangFactory = new NanchangFactory();
            Yabo nanchangYabo = nanchangFactory.CreateYabo();
            Yajia nanchangYajia = nanchangFactory.CreateYajia();
            nanchangYabo.Print();
            nanchangYajia.Print();
            Console.ReadKey();
        }
    }

    public abstract class AbstractFactory
    {
        public abstract Yabo CreateYabo();
        public abstract Yajia CreateYajia();        
    }

    public class ShanghaiFactory:AbstractFactory
    {
        public override Yabo CreateYabo()
        {
            return new ShanghaiYabo();  
        }

        public override Yajia CreateYajia()
        {
            return new ShanghaiYajia();
        }        
    }

    public class NanchangFactory : AbstractFactory
    {
        public override Yabo CreateYabo()
        {
            return new NanchangYabo();
        }

        public override Yajia CreateYajia()
        {
            return new NanchangYajia();
        }
    }

    public abstract class Yabo
    {
        public abstract void Print();
    }

    public abstract class Yajia
    {
        public abstract void Print();
    }

    public class ShanghaiYabo:Yabo
    {
        public override void Print()
        {
            Console.WriteLine("上海鸭脖做好了");
        }
    }

    public class ShanghaiYajia : Yajia
    {
        public override void Print()
        {
            Console.WriteLine("上海鸭架做好了");
        }
    }

    public  class NanchangYabo : Yabo
    {
        public override void Print()
        {
            Console.WriteLine("南昌鸭脖做好了");
        }
    }

    public class NanchangYajia : Yajia
    {
        public override void Print()
        {
            Console.WriteLine("南昌鸭架做好了");
        }
    }

}
