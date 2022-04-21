using DesignModels.CreateModels.SimpleFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignModels.FactoryModels
{
   public class SimpleFactory
    {
        //创建型模式 简单工厂模式
        //根据不同传入数据创建不同类
        public static Operation CreatOperation(string operate) 
        {
            Operation operation = null;
            switch (operate)
            {
                case "+":
                    operation = new OperationAdd();
                    break;
                case "-":
                    operation = new OpertaionSub();
                    break;
                case "*":
                    operation = new OperationMul();
                    break;
                case "/":
                    operation = new OperationDiv();
                    break;
                default:
                    break;
            }
            return operation;
        }
    }
}
