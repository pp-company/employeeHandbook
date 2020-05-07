using System;
using System.Collections.Generic;
using System.Text;

namespace 代码
{
    class 写短文
    {
        protected 铅笔 _铅笔;
        public 写短文(削好的铅笔 铅笔)//我们假设这是耐久的铅笔，削一次就够用了
        {
            _铅笔 = 铅笔;
        }
        public void 写短篇()
        {
           
            Console.WriteLine("第一段");
        }
        public void 署名()
        {
            Console.WriteLine("名字");
            Console.WriteLine("盖章");
            Console.WriteLine("日期");
        }
    }
}
