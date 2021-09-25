using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StuMan_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            ControlClass cc = new ControlClass();
            //以下注释代码为测试管理类的功能
            StuBaseClass s1 = new StuBaseClass(1, "张三", 50, 50);
            StuBaseClass s2 = new StuBaseClass(2, "李四", 10, 60);
            StuBaseClass s3 = new StuBaseClass(3, "李四", 100, 100);
            cc.smc.AddStu(s1);
            cc.smc.AddStu(s2);
            cc.smc.AddStu(s3);
            //sm.DeleteStu(1);
            //cc.smc.OutAll();
            //Console.Write(cc.smc.OutString);
            cc.Run();

        }
    }
}
