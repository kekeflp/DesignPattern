using System;

namespace SimpleFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Foods food1 = FoodSimpleFactory.CreateFood("西红柿炒鸡蛋");
            food1.Print();
            Foods food2 = FoodSimpleFactory.CreateFood("土豆炖肉");
            food2.Print();
        }
    }
}
