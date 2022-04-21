using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignModels.StructureModels.BrigeMethod
{
    /// <summary>
    /// 不同平台具体的实现
    /// </summary>
    class ConcreteImplementationB : IImplementation
    {
        public string OperationImplementation()
        {
            return "具体实现：在平台B中的结果";
        }
    }
}
