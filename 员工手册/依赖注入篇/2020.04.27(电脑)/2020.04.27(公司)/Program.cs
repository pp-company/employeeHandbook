using System;
using _2020._04._27_公司_.接口;
using _2020._04._27_公司_.类实现;

namespace _2020._04._27_公司_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            电脑 d1 = new _电脑();
            带触摸板的电脑 d2 = new _带触摸板的电脑();
            带键盘的电脑 d3 = new _带键盘的电脑();
            笔记本电脑 d4 = new _笔记本电脑(d2,d3);
        }
    }
}
