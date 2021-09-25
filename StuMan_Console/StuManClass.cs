using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StuMan_Console
{
    class StuManClass
    {
        private List<StuBaseClass> stuList = new List<StuBaseClass>();//学生对象列表
        public StringBuilder OutString = new StringBuilder(1024);//保存输出结果

        public void OutAll()//输出所有学生信息到OutString
        {
            OutString.Clear();
            string str = "学号" + "\t" + "姓名" + "\t" + "数学" + "\t" + "语文";
            OutString.AppendLine(str);
            foreach (StuBaseClass s in stuList)
            {
                OutString.AppendLine(s.ToString());
            }
        }
        /*
        public void AddStu(StuBaseClass s)//增加学生
        {
            stuList.Add(s);
        }
        */
        public bool AddStu(StuBaseClass s)//增加学生
        {
            bool flag = true;
            foreach(StuBaseClass item in stuList)
            {
                if(item.Sno == s.Sno)
                {
                    flag = false;
                }
            }
            if (flag) {
               stuList.Add(s);
               return flag;
            }
            else
            {
                return flag;
            }
        }
        public bool DeleteStu(int _sno)//按学号删除学生
        {
            bool flag = false;
            for (int i = 0; i < stuList.Count; i++)
            {
                StuBaseClass ts = stuList[i];
                if (ts.Sno == _sno)
                {
                    stuList.RemoveAt(i);
                    flag = true;
                    break;
                }
            }
            return flag;
        }
        public void ModiFyStu(int _sno, string _name, float _math, float _lang)//修改学生信息
        {//按学号修改，学号不能改
            for (int i = 0; i < stuList.Count; i++)
            {
                StuBaseClass ts = stuList[i];
                if (ts.Sno == _sno)
                {
                    ts.SName = _name; ts.MathScore = _math; ts.LangScore = _lang;
                    break;
                }
            }
        }

        // 按学号查找学生信息
        public String FindStuInfoBySno(int _sno)
        {
            foreach(StuBaseClass s in stuList)
            {
                if(s.Sno == _sno)
                {
                    return s.ToString();
                }
            }
            return "用户未找到";
        }

        // 按姓名查找学生信息，如有重名则显示多个
        public String FindStuInfoByName(String _name)
        {
            String StuInfo = "";
            bool flag = false;
            foreach (StuBaseClass s in stuList)
            {
                if (s.SName == _name)
                {
                    flag = true;
                    StuInfo += s.ToString() + "\n";
                }
            }
            if (flag)
            {
                return StuInfo;
            }
            else
            {
                return "用户未找到";
            }

        }


        //GetMathAverage()//计算所有学生的数学平均成绩
        public float GetMathAverage()
        {
            int count = 0;
            float score = 0f;
            foreach(StuBaseClass s in stuList)
            {
                count++;
                score += s.MathScore;
            }
            return score / count;
        }
        //GetLangAverage//计算所有学生的语文平均成绩
        public float GetLangAverage()
        {
            int count = 0;
            float score = 0f;
            foreach (StuBaseClass s in stuList)
            {
                count++;
                score += s.LangScore;
            }
            return score / count;
        }
        //GetAverage()//计算所有学生的总平均成绩

        //GetSum()//计算所有学生总分

    }
}
