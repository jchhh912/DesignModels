using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignModels.CreateModels.BuilderMethod
{
    /// <summary>
    /// 通过构建方法固定调用各个步骤，指挥者
    /// </summary>
    class Director
    {
        IHouseBuilder _builder;
        public Director(IHouseBuilder builder) { this._builder = builder; }
        public void Construct() 
        {
            _builder.CreateDoor();
            _builder.CreateRoom();
            _builder.CreateWall();
            _builder.CreateWindow();
        }
    }
}
