using Autofac;
using DesignModels.CreateModels.AbstractFactory;
using DesignModels.CreateModels.BuilderMethod;
using DesignModels.CreateModels.FactoryMethod;
using DesignModels.CreateModels.PrototypeMethod;
using DesignModels.CreateModels.SingletonMethod.BaseSingleton;
using DesignModels.CreateModels.SingletonMethod.SafetySingleton;
using DesignModels.FactoryModels;
using DesignModels.StructureModels.AdapterMethod;
using DesignModels.StructureModels.BrigeMethod;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace DesignModels
{
    class Program
    {
        static void Main(string[] args)
        {
            #region FactoryMethod 工厂模式
            ////***简单工厂由一个工厂对象决定创建出哪一种产品类的实例。
            //var oper = SimpleFactory.CreatOperation("+");
            //oper.NumberA = 22.33;
            //oper.NumberB = 22.31;
            //Console.WriteLine($"{oper.NumberA}+{oper.NumberB}={oper.GetResult()}");
            ////---------------------------------------------
            ////***工厂方法 调用
            //IWrokingFactory factory = new UndergraduteFactory();
            //var stuentWorking = factory.CreateWroking();
            //stuentWorking.Sweep();
            //factory = new VolunteerFactory();
            //factory.CreateWroking().BuyRice();
            ////使用依赖注入
            //var builder = new ContainerBuilder();
            //builder.RegisterType<VolunteerFactory>().As<IWrokingFactory>();

            //var container = builder.Build();
            //var Workingfactory = container.Resolve<IWrokingFactory>();
            //var volunteer = Workingfactory.CreateWroking();
            //volunteer.Sweep();
            ////---------------------------------------------
            #endregion
            #region AbstractFactory 抽象工厂
            //IDbFactory dbFactory = new MysqlFactory();
            //var repo = dbFactory.CreateUserRepo();
            //repo.Insert(null);
            //dbFactory = new SqlServerFactory();
            //repo = dbFactory.CreateUserRepo();
            //repo.Insert(null);
            ////使用依赖注入
            //builder.RegisterType<MysqlFactory>().As<IDbFactory>();
            ////var container = builder.Build();
            //var useMysql = container.Resolve<IDbFactory>();
            //useMysql.CreateUserRepo().Insert(null);
            #endregion
            #region SingletonMethod 单例模式
            ////基础简单单例 不安全
            //Console.WriteLine($"---------------------baseSingleton-----------------------");
            //List<Task> taskList = new List<Task>();
            //for (int i = 0; i < 1000; i++)
            //{
            //    taskList.Add(Task.Factory.StartNew(() =>
            //    {
            //        Singleton s1 = Singleton.GetSingleton();
            //        Console.WriteLine($"child task #{Task.CurrentId} run.");
            //        Console.WriteLine($"{s1.GetHashCode()}");
            //    }));
            //}
            //TaskFactory taskFactory = new TaskFactory();
            //taskList.Add(taskFactory.ContinueWhenAll(taskList.ToArray(), tArray =>
            //{
            //    Console.WriteLine("线程：" + Thread.CurrentThread.ManagedThreadId);
            //    Thread.Sleep(200);
            //    Console.WriteLine("等待这些完成后执行");
            //}));
            ////---------------------------多线程-----------------------------
            //Console.WriteLine("线程：" + Thread.CurrentThread.ManagedThreadId);
            //for (int i = 0; i < 1000; i++)
            //{
            //    var t = Task.Factory.StartNew(() =>
            //     {
            //         Singleton s1 = Singleton.GetSingleton();
            //         Console.WriteLine($"child task #{Task.CurrentId} run.");
            //         Console.WriteLine(s1.GetHashCode());

            //     });
            //}
            ////--------------------------------------------
            ////线程安全单例 双重锁定(double-check locking)（懒汉模式）
            //Console.WriteLine($"---------------------SafetySingleton-----------------------");
            //for (int i = 0; i < 100; i++)
            //{
            //    Task.Run(() =>
            //    {
            //        Console.WriteLine($"child task #{Task.CurrentId} run.");
            //        TestSafetySingleton("Test1");
            //        TestSafetySingleton("Test2");
            //    });
            //}
            ////---------------------------------------------
            ////饿汉模式 担心饿死。类加载就给准备好
            //Console.WriteLine($"---------------------InitializeSingleton-----------------------");
            //for (int i = 0; i < 100; i++)
            //{
            //    Task.Run(() =>
            //    {
            //        Console.WriteLine($"child task #{Task.CurrentId} run.");
            //        Console.WriteLine($"{InitializeSingleton.GetSingleton().GetHashCode()}");
            //    });
            //}
            ////---------------------------------------------
            ////并发字典型 使用时加载 懒汉模式
            //Console.WriteLine($"---------------------ConcurrentSingleton-----------------------");
            //for (int i = 0; i < 100; i++)
            //{
            //    Task.Run(() =>
            //    {
            //        Console.WriteLine($"child task #{Task.CurrentId} run.");
            //        Console.WriteLine($"{ConcurrentSingleton.GetSingleton().GetHashCode()}");
            //    });
            //}
            ////--------------------------------------
            //// 延迟加载 使用时才加载 懒汉 安全
            //Console.WriteLine($"-------------------LazySingleton---------------------");
            //for (int i = 0; i < 100; i++)
            //{
            //    Task.Run(() =>
            //    {
            //        Console.WriteLine($"child task #{Task.CurrentId} run.");
            //        Console.WriteLine($"{LazySingleton.GetSingleton().GetHashCode()}");
            //    });
            //}
            #endregion
            #region BuilderMethod 建造者模式
            //// 客户端代码创建一个构建器对象，将其传递给导演，然后启动构建过程。最终结果从构建器对象中获取。
            //IHouseBuilder Pingbuilder = new PingHouseBuilder();
            //Director director = new Director(Pingbuilder);
            //director.Construct();
            //var house = Pingbuilder.GetHouse();
            #endregion
            #region PrototypeMethod 原型模式
            //Console.WriteLine("-------------原型模式（深拷贝-浅拷贝）-------------------");
            //Prototype prototype = new Prototype();
            //prototype.Age = 18;
            //prototype.Name = "原型本体";
            //prototype.IdInfo = new IdInfo(888);
            //Prototype shallowCopy = prototype.ShallowCopy();
            //Prototype DeepCopy = prototype.DeepCopy();
            //Console.WriteLine($"原始值：{prototype.Age}\r\n{prototype.Name}\r\n{prototype.IdInfo.IdNumber}");
            //Console.WriteLine("----------------------------------------------");
            //Console.WriteLine($"浅拷贝：{shallowCopy.Age}\r\n{shallowCopy.Name}\r\n{shallowCopy.IdInfo.IdNumber}");
            //Console.WriteLine("----------------------------------------------");
            //Console.WriteLine($"深拷贝：{DeepCopy.Age}\r\n{DeepCopy.Name}\r\n{DeepCopy.IdInfo.IdNumber}");
            //Console.WriteLine("--------------------修改原始值------------------------");
            //prototype.Age = 28;
            //prototype.Name = "修改后的本体";
            //prototype.IdInfo.IdNumber = 666;
            //Console.WriteLine($"原始值：{prototype.Age}\r\n{prototype.Name}\r\n{prototype.IdInfo.IdNumber}");
            //Console.WriteLine("----------------------------------------------");
            //Console.WriteLine($"浅拷贝：{shallowCopy.Age}\r\n{shallowCopy.Name}\r\n{shallowCopy.IdInfo.IdNumber}");
            //Console.WriteLine("----------------------------------------------");
            //Console.WriteLine($"深拷贝：{DeepCopy.Age}\r\n{DeepCopy.Name}\r\n{DeepCopy.IdInfo.IdNumber}");
            #endregion
            #region AdapterMethod 适配器模式
            //Target target = new TargetAdapter();
            //target.Request();
            #endregion
            #region BrigeMethod 桥接模式
            //Abstraction abstraction = new Abstraction(new ConcreteImplementationA());
            //Console.WriteLine(abstraction.Opration());
            //Console.WriteLine("------------------");
            //abstraction = new ExtendedAbstraction(new ConcreteImplementationB());
            //Console.WriteLine(abstraction.Opration());
            #endregion
            Console.ReadKey();
        }
        public static void TestSafetySingleton(string value)
        {
            SafetySingleton singleton = SafetySingleton.GetSingleton(value);
            Console.WriteLine(singleton.Value);
        }
    }
}
