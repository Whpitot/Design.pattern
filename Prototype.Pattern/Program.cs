using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//////////////////////////////////
//1、关于浅拷贝
//2、这是一种设计模式；
//3、针对创建一些列的相同的实例的情况下使用的
/////////////////////////////////
namespace Prototype.Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            MonkeyKingPrototype monkeyKingA = new ConcreateMonkeyKing("WINDY");
            MonkeyKingPrototype monkeyKingB = monkeyKingA.Clone();
            Console.WriteLine(monkeyKingB.Name);
            Console.ReadKey();
        }
    }

    public abstract class MonkeyKingPrototype
    {
        public string Name { get; set; }
        public MonkeyKingPrototype(string name)
        {
            this.Name = name;
        }

        public abstract MonkeyKingPrototype Clone();        
    }

    public class ConcreateMonkeyKing:MonkeyKingPrototype
    { 
        public ConcreateMonkeyKing(string name)
            :base(name)
        {
        }
        public override MonkeyKingPrototype Clone()
        {
            return (MonkeyKingPrototype)this.MemberwiseClone();
        }
    }
}
