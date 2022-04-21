using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignModels.CreateModels.AbstractFactory
{
    /// <summary>
    /// DB抽象工厂接口
    /// </summary>
    public interface IDbFactory
    {
        IUserRepo CreateUserRepo();
    }
    /// <summary>
    /// 抽象产品的构建方法
    /// </summary>
    internal class SqlServerFactory : IDbFactory
    {
        public IUserRepo CreateUserRepo()
        {
            return new SqlserverUserRepo();
        }
    }
    internal class MysqlFactory : IDbFactory
    {
        public IUserRepo CreateUserRepo()
        {
            return new MysqlUserRepo();
        }
    }
}
