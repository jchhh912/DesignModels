using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignModels.CreateModels.SingletonMethod.SafetySingleton
{
    /// <summary>
    /// 双重判空加锁，饱汉模式（懒汉式），用到的时候再去实例化 安全
    /// 这种方式的执行过程会先检查是否完成了实例化，如果已经实例化则直接返回实例，如果没有就尝试获取锁，获得锁之后再判断一下是否已经实例化，如果已经实例化则返回实例，如果没有就进行实例化
    /// </summary>
    class SafetySingleton
    {
        private SafetySingleton() { }
        private static SafetySingleton _safetySingleton;
        private static readonly object _lock = new object();
        public string Value { get; set; }
        public static SafetySingleton GetSingleton(string value) 
        {
            if (_safetySingleton==null)
            {
                lock (_lock)
                {
                    if (_safetySingleton==null)
                    {
                        _safetySingleton = new SafetySingleton();
                        _safetySingleton.Value = value;
                    }
                }
            }
            return _safetySingleton;
        }
    }
}
