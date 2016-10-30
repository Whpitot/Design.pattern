using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CsharpPattern    //工厂方法，不用去修改工厂里面的方法；
{
    static class Program
    {
        static void Main()
        {
            UserManager manager = new UserManager();
            manager.User = null;
            manager.User.Login();
            if (manager.User.IsNull)
            {
                Console.WriteLine("用户不存在，请检查。");
            }
            Console.ReadKey();
        }
    }

    public interface IUser
    {
        bool IsNull{get;}
        void Login();
        void GetInfo();
    }

    public class User:IUser
    {
        public void Login()
        {
            Console.WriteLine("User login now");
        }
        public void GetInfo()
        {
            Console.WriteLine("User login out");
        }
        public Boolean IsNull
        {
            get { return false; }
        }
    }

    public class NullUser:IUser
    {
        public void Login() { }
        public void GetInfo() { }
        public Boolean IsNull
        {
            get { return true; }
        }    
    }

    //把两种各方法统一管理起来
    public class UserManager
    {
        private IUser user = new User();
        public IUser User
        {
            get {return user; }
            set
            {
                user = value ?? new NullUser();
            }
        }
    }
}
