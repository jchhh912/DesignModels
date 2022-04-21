using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignModels.CreateModels.SingletonMethod.BaseSingleton
{
    /// <summary>
    /// 饿汉模式 类加载时就准备好 没有线程安全问题
    /// 适用于被频繁使用或者这个类比较小
    /// </summary>
     public sealed  class InitializeSingleton
    {
        private static readonly InitializeSingleton _initializeSingleton = new InitializeSingleton();
        private InitializeSingleton() { }
        public static InitializeSingleton GetSingleton() => _initializeSingleton;
    }
}
