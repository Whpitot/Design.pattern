using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Director director = new Director();
            Builder xiaowan = new XiaowangBuiler();
            director.Assign(xiaowan);
            Computer computer = xiaowan.GetComputer();
            computer.Show();
            Console.ReadKey();
        }
    }

    public class Director
    {
        public void Assign(Builder builder)
        {
            builder.BuilderCpu();
            builder.BuilerMainBoard();
        }
    }

    public class Computer
    {
        IList<string> parts = new List<string>();
        public void Add(string part)
        {
            parts.Add(part);
        }

        public void Show()
        {
            Console.WriteLine("电脑开始组装.......");
            foreach (string part in parts)
            {
                Console.WriteLine("组件包含{0}",part);
            }
            Console.WriteLine("电脑组装好了.-.");
        }
    }

    public abstract class Builder
    {
        public abstract void BuilderCpu();

        public abstract void BuilerMainBoard();

        public abstract Computer GetComputer();
    }

    //具体两个装机对象
    public class XiaowangBuiler : Builder
    {
        Computer computer = new Computer();
        public override void BuilderCpu()
        {
            computer.Add("Cpu1");
        }

        public override void BuilerMainBoard()
        {
            computer.Add("MainBoard1");
        }

        public override Computer GetComputer()
        {
            return computer;
        }
    }

    public class XiaoliBuiler : Builder
    {
        Computer computer = new Computer();
        public override void BuilderCpu()
        {
            computer.Add("Cpu2");
        }

        public override void BuilerMainBoard()
        {
            computer.Add("MainBoard2");
        }

        public override Computer GetComputer()
        {
            return computer;
        }
    }
}
