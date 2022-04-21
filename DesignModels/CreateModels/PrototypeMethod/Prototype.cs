using System;

namespace DesignModels.CreateModels.PrototypeMethod
{
    /// <summary>
    /// 原类型 -- 需要被拷贝的类
    /// </summary>
    public class Prototype
    {
        // 多种类型数据，查看拷贝后的数据
        public int Age;
        public string Name;
        public IdInfo IdInfo;
        /// <summary>
        /// 浅拷贝
        /// MemberwiseClone -- 按成员拷贝(复制引用类型的地址，而不是new)
        /// </summary>
        /// <returns></returns>
        public Prototype ShallowCopy()
        {
            return (Prototype)this.MemberwiseClone();
        }

        /// <summary>
        /// 深拷贝
        /// </summary>
        /// <returns></returns>
        public Prototype DeepCopy()
        {
            Prototype clone = (Prototype)this.MemberwiseClone();
            // int Age 这种简单类型不需要管，在MemberwiseClone处理了
            // 引用类型
            clone.IdInfo = new IdInfo(IdInfo.IdNumber);
            return clone;
        }
    }
    /// 作为引用类型的数据
    public class IdInfo
    {
        public int IdNumber;

        public IdInfo(int idNumber)
        {
            this.IdNumber = idNumber;
        }
    }
}
