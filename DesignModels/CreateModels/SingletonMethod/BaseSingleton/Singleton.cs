using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignModels.CreateModels.SingletonMethod.BaseSingleton
{
    //懒汉模式（线程不安全）
    public class Singleton
    {
        //保存单例实例
        private static Singleton _singleton;
        //私有构造函数
        private Singleton()
        { }
        //公有静态构建方法 用于获取单例
        public static  Singleton GetSingleton()
        {
            if (_singleton==null)
            {
                _singleton = new Singleton();
            }
            return _singleton;
        }
    }
}
