using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignModels.CreateModels.BuilderMethod
{
    /// <summary>
    /// 抽象创建者接口
    /// </summary>
    interface IHouseBuilder
    {
        void CreateWall();
        void CreateRoom();
        void CreateWindow();
        void CreateDoor();
        House GetHouse();
    }
}
