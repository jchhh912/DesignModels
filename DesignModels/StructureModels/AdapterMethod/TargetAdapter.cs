using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignModels.StructureModels.AdapterMethod
{
    /// <summary>
    /// 创建特殊类型接口和标准化接口的适配器（转接头）
    /// </summary>
    public class TargetAdapter:Target
    {
        private readonly Adaptee _adaptee = new Adaptee();
        /// <summary>
        /// 将特殊类型适配到标准类型（转接头）
        /// </summary>
        public override void Request()
        {
            _adaptee.SpecialRequest();
        }
    }
}
