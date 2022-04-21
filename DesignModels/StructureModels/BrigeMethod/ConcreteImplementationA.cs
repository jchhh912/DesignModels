using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignModels.StructureModels.BrigeMethod
{
    /// <summary>
    /// 不同平台的具体的实现
    /// </summary>
    class ConcreteImplementationA : IImplementation
    {
        public string OperationImplementation()
        {
            return "具体实现：在平台A中的结果";
        }
    }
}
