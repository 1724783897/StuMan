using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StuMan_Console
{
    class ControlClass
    {
        public StuManClass smc = new StuManClass();
        public void Run()
        {
            smc.GetMathAverage();
            int selectedFun = -1;
            while (selectedFun != 0)
            {
                Console.Clear();
                Console.WriteLine("学生信息管理系统");
                Console.WriteLine("1------显示所有学生");
                Console.WriteLine("2------增加学生");
                Console.WriteLine("3------删除学生");
                Console.WriteLine("4------修改学生信息");
                Console.WriteLine("5------数学平均成绩");
                Console.WriteLine("6------语文平均成绩");
                Console.WriteLine("7------查找学生信息(学号)");
                Console.WriteLine("8------查找学生信息(姓名)");
                Console.WriteLine("0------退出");
                Console.Write("请输入操作编号并按回车键：");
                try{
                    selectedFun = int.Parse(Console.ReadLine());
                }
                catch(FormatException)
                {
                    Console.WriteLine("输 入的编号有误:");
                    Console.WriteLine("请重新输入......");
                    Console.ReadKey();
                }

                switch (selectedFun)
                {
                    case 0: return;
                    case 1: DispalyAll(); break;
                    case 2: AddStu(); break;
                    case 3: DeleteStu(); break;
                    case 4: ModifyStu(); break;
                    case 5: GetMathAverage(); break;
                    case 6: GetLangAverage(); break;
                    case 7: GetFindStuInfoBySno(); break;
                    case 8: GetFindStuInfoByName(); break;
                }
            }
        }
        private void DispalyAll()
        {
            smc.OutAll();
            Console.Write(smc.OutString);
            Console.WriteLine("按任意键继续......");
            Console.ReadKey();
        }
        private void AddStu()
        {
            Console.Write("学号：");
            int _sno = int.Parse(Console.ReadLine());
            Console.Write("姓名：");
            string _name = Console.ReadLine();
            Console.Write("数学成绩：");
            float _math = float.Parse(Console.ReadLine());
            Console.Write("语文成绩：");
            float _lang = float.Parse(Console.ReadLine());
            StuBaseClass ts = new StuBaseClass(_sno, _name, _math, _lang);
            bool Status = smc.AddStu(ts);
            if (Status) { Console.WriteLine("增加完成，按任意键继续......"); }else { Console.WriteLine("学号已经存在，增加失败，按任意键继续......"); }
            Console.ReadKey();
        }
        private void DeleteStu()
        {
            Console.Write("输入将要删除的学号：");
            int _sno = int.Parse(Console.ReadLine());
            smc.DeleteStu(_sno);
            Console.WriteLine("删除完成，按任意键继续......");
            Console.ReadKey();
        }
        private void ModifyStu()
        {
            Console.Write("输入将要修改的学号：");
            int _sno = int.Parse(Console.ReadLine());
            Console.Write("姓名：");
            string _name = Console.ReadLine();
            Console.Write("数学成绩：");
            float _math = float.Parse(Console.ReadLine());
            Console.Write("语文成绩：");
            float _lang = float.Parse(Console.ReadLine());
            smc.ModiFyStu(_sno, _name, _math, _lang);
            Console.WriteLine("修改完成，按任意键继续......");
            Console.ReadKey();
        }

        private void GetMathAverage()
        {
            float MathAverage = smc.GetMathAverage();
            Console.WriteLine("数学平均成绩:{0}", MathAverage);
            Console.ReadKey();
        }


        private void GetLangAverage()
        {
            float LangAverage = smc.GetLangAverage();
            Console.WriteLine("数学平均成绩:{0}", LangAverage);
            Console.ReadKey();
        }


        private void GetFindStuInfoBySno()
        {
            Console.Write("请输入要查找学生信息的学号:");
            int sno = int.Parse(Console.ReadLine());
            String  str = smc.FindStuInfoBySno(sno);
            Console.WriteLine(str);
            Console.WriteLine("查找完成，按任意键继续......");

            Console.ReadKey();
        }


        private void GetFindStuInfoByName()
        {
            Console.Write("请输入要查找学生信息的姓名:");
            String name = Console.ReadLine();
            String str = smc.FindStuInfoByName(name);
            Console.WriteLine(str);
            Console.WriteLine("查找完成，按任意键继续......");
            Console.ReadKey();
        }

    }
}
