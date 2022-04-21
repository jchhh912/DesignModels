using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignModels.CreateModels.AbstractFactory
{
    /// <summary>
    /// 产品抽象方法
    /// </summary>
    public interface IUserRepo
    {
        void Insert(User user);
        User GetUser(int userId);
    }
    /// <summary>
    /// 产品的具体使用方法
    /// </summary>
    internal class SqlserverUserRepo : IUserRepo
    {
        public void Insert(User user) 
        {
            Console.WriteLine("使用sqlserver生成");
        }
        public User GetUser(int userId) 
        {
            Console.WriteLine($"获取到当前Sqlserver用户id：{userId}");
            return null;
        }
    }
    internal class MysqlUserRepo : IUserRepo
    {
        public void Insert(User user)
        {
            Console.WriteLine("使用Mysql生成");
        }
        public User GetUser(int userId)
        {
            Console.WriteLine($"获取到当前Mysql用户id：{userId}");
            return null;
        }
    }
}
