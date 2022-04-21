using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignModels.CreateModels.SimpleFactory
{
    //模型基本数据 和虚方法
   public class Operation
    {
        public double NumberA { get; set; }
        public double NumberB { get; set; }
        //虚方法
        public virtual double GetResult() {
            return 0;
        }
    }
    /// <summary>
    /// 重写虚方法 
    /// </summary>
    public class OperationAdd : Operation 
    {
        public override double GetResult()
        {
            return NumberA + NumberB;
        }
    }
    public class OpertaionSub : Operation
    {
        public override double GetResult()
        {
            return NumberA - NumberB;
        }
    }
    public class OperationMul : Operation
    {
        public override double GetResult()
        {
            return NumberA * NumberB;
        }
    }
    public class OperationDiv : Operation
    {
        public override double GetResult()
        {
            if (NumberB == 0)
            {
                throw new Exception("除数不能为0");
            }
            return NumberA / NumberB;
        }
    }
}
