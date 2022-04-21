using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignModels.StructureModels.BrigeMethod
{
    /// <summary>
    /// 抽象类--实现接口的定义，该类型相当于Implementor类型 实现化角色
    /// </summary>
    public interface IImplementation
    {
        string OperationImplementation();
    }
}
