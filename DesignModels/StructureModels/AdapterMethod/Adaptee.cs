using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignModels.StructureModels.AdapterMethod
{
    /// <summary>
    /// 适配器需要适配的类型（适配三孔充电的头）
    /// </summary>
    public class Adaptee
    {
        /// <summary>
        /// 这是一个特殊接口请求
        /// </summary>
        public void SpecialRequest()
        {
            Console.WriteLine("这是一个特殊的请求（三孔充电器可以充电）！");
        }
    }
}
