using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignModels.CreateModels.BuilderMethod
{
    //房子的各个组件
    public class House
    {
        public string Type { get; set; }
        public House(string type) 
        {
            Type = type;
        }
    }
}
