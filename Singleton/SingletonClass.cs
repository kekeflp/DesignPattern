using System;
using System.Threading;

/// <summary>
/// 单例模式
/// </summary>
namespace Singleton
{
    public class SingletonClass
    {
        // 1、定义私有构造函数（目的不能通过new来实例类）
        private SingletonClass() { }

        // 2、定义私有的变量来记录unniqueInstance的唯一实例
        private static SingletonClass unniqueInstance;

        /// <summary>
        /// 3、定义公有方法来提供该类的唯一全局访问点
        /// </summary>
        /// <returns></returns>
        public static SingletonClass GetInstance()
        {
            // 当第一个线程运行到这里时，此时会对locker对象 "加锁"，
            // 当第二个线程运行该方法时，首先检测到locker对象为"加锁"状态，该线程就会挂起等待第一个线程解锁
            // lock语句运行完之后（即线程运行完之后）会对该对象"解锁"
            // 双重锁定只需要一句判断就可以了
            if (unniqueInstance == null)
            {
                lock (locker)
                {
                    // 如果类的实例不存在则创建，否则直接返回
                    if (unniqueInstance == null)
                    {
                        unniqueInstance = new SingletonClass();
                    }
                }
            }
            return unniqueInstance;
        }

        // 定义一个标识确保线程同步(双重锁定)
        private static readonly object locker = new object();
    }
}