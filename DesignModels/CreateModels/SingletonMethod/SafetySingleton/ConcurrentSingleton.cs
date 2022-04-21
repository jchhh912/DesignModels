using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignModels.CreateModels.SingletonMethod.SafetySingleton
{
    /// <summary>
    /// 并发字典型（懒汉模式） 用到的时候再去实例化 类似于第一种 使用集合并发代替了双重判断和lock
    /// </summary>
    public class ConcurrentSingleton
    {
        private static readonly ConcurrentDictionary<int, ConcurrentSingleton> Instances = new ConcurrentDictionary<int, ConcurrentSingleton>();
        private ConcurrentSingleton() { }
        public static ConcurrentSingleton GetSingleton()
        {
          return  Instances.GetOrAdd(1,v=>new ConcurrentSingleton());
        }
    }
}
