
namespace SimpleFactory
{
    /// <summary>
    /// 客户自己做饭
    /// </summary>
    public class Customer
    {
        /// <summary>
        /// 炒菜的方法
        /// </summary>
        /// <param name="type">想吃的菜</param>
        public static Foods Cook(string type)
        {
            Foods foods = null;
            if (type.Equals("西红柿炒鸡蛋"))
            {
                foods = new TomatoScrambledEggs();
            }
            else if (type.Equals("土豆炖肉"))
            {
                foods = new ShreddedPorkWithPotatoes();
            }
            return foods;
        }
    }
}