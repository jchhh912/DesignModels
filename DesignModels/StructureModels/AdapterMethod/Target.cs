using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignModels.StructureModels.AdapterMethod
{
    /// <summary>
    /// 标准化接口类
    /// </summary>
    public class Target
    {
        /// <summary>
        /// 一个标准的常用接口请求
        /// </summary>
        public virtual void Request()
        {
            Console.WriteLine("这是一个接口的请求（两孔的充电器可以充电）！");
        }
    }
}
