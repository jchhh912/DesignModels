using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignModels.CreateModels.SingletonMethod.SafetySingleton
{
    /// <summary>
    /// 使用Lazy延迟初始化 使用的时候在完成初始化
    /// </summary>
    public class LazySingleton
    {
        private static readonly Lazy<LazySingleton> lazySingleton = new Lazy<LazySingleton>(() => new LazySingleton());
        private LazySingleton() { }
        public static LazySingleton GetSingleton()
        {
            return lazySingleton.Value;
        }
    }
}
