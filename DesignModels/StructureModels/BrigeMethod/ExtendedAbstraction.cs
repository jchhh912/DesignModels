using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignModels.StructureModels.BrigeMethod
{
    /// <summary>
    /// 你可以在不改变实现的情况下扩展抽象的类,相当于RefinedAbstraction类型
    /// </summary>
    class ExtendedAbstraction :Abstraction
    {
        public ExtendedAbstraction(IImplementation implementation) : base(implementation) {
        }
        public override string Opration()
        {
            return  "ExtendedAbstraction:扩展操作与:" + base._implementation.OperationImplementation();
        }
    }
}
