using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignModels.CreateModels.BuilderMethod
{
    /// <summary>
    /// 具体的创建者实现
    /// </summary>
    class PingHouseBuilder : IHouseBuilder 
    {
        public void CreateDoor() 
        {
            Console.WriteLine("Ping:创建一个门");
        }
        public void CreateRoom()
        {
            Console.WriteLine("Ping:创建一个房间");
        }
        public void CreateWall()
        {
            Console.WriteLine("Ping:创建一堵墙");
        }
        public void CreateWindow() 
        {
            Console.WriteLine("Ping:创建一个窗户");
        }
        public House GetHouse() 
        {
            return new House("ping");
        }
    }

}
