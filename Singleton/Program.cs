using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            SingletonClass sc = SingletonClass.GetInstance();
            //SingletonClass sc1 =new SingletonClass();
        }
    }
}
