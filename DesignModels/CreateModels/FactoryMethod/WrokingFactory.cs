using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignModels.CreateModels.FactoryMethod
{
    /// <summary>
    /// 使用接口来实现
    /// </summary>
    internal interface IWrokingFactory
    {
      Wroking CreateWroking();
    }
    /// <summary>
    /// 实例UndergraduteFactory对象
    /// </summary>
    internal class UndergraduteFactory : IWrokingFactory
    {
        public Wroking CreateWroking() {
            return new Undergradute();
        }
    }
    /// <summary>
    /// 实例VolunteerFactory对象
    /// </summary>
    internal class VolunteerFactory : IWrokingFactory 
    {
        public Wroking CreateWroking() {
            return new Volunteer();
        }
    }

}
