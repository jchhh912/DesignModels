using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignModels.StructureModels.BrigeMethod
{
    /// <summary>
    /// 这个抽象类是抽象接口的定义，相当于Abstraction类型 抽象化角色
    /// </summary>
    class Abstraction
    {
        protected IImplementation _implementation;
        //构造器注入
        public Abstraction(IImplementation implementation) 
        {
            this._implementation = implementation;
        }
        /// <summary>
        /// Abstraction类型操作方法  
        /// </summary>
        /// <returns></returns>
        public virtual string Opration() {
            return "Abstraction：基础操作\n" + _implementation.OperationImplementation();
        }
    }
}
