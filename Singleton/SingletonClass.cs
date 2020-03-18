
namespace Singleton
{
    public class SingletonClass
    {
        // 1、私有的构造函数（目的不能通过new来实例类）
        private SingletonClass() { }

        // 2、私有的变量来记录unniqueInstance的唯一实例
        private static SingletonClass unniqueInstance;

        // 3、定义公有方法来提供该类的唯一全局访问点
        public static SingletonClass GetInstance()
        {
            if (unniqueInstance == null)
            {
                unniqueInstance = new SingletonClass();
            }
            return unniqueInstance;
        }
    }
}