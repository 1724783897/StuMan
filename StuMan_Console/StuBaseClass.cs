using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StuMan_Console
{
    class StuBaseClass
    {
        public int Sno { get; set; }
        public string SName { get; set; }
        public float MathScore { get; set; }
        public float LangScore { get; set; }

        public StuBaseClass(int _sno, string _name, float _math, float _lang)
        {
            Sno = _sno; SName = _name; MathScore = _math; LangScore = _lang;
        }
        public override string ToString()//将学生信息输出为单行字符串
        {
            return Sno.ToString() + "\t"
                + SName + "\t"
                + MathScore.ToString("f2") + "\t"
                + LangScore.ToString("f2");
        }
        public float SumScore
        {
            get { return MathScore + LangScore; }
        }
        public float AverageScore
        {
            get { return SumScore / 2; }
        }

    }
}
