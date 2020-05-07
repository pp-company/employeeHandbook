using System;
using System.Collections.Generic;
using System.Text;

namespace 代码
{
    class 写文章
    {
        protected 铅笔 _铅笔;
        public 写文章(削好的铅笔 铅笔)//我们假设这是耐久的铅笔，削一次就够用了
        {
            _铅笔 = 铅笔;
        }
        public void 写第一段()
        {
            Console.WriteLine("第一段");

        }
        public void 写第二段()
        {
            Console.WriteLine("第二段");
        }
        public void 署名()
        {
            Console.WriteLine("名字");
            Console.WriteLine("盖章");
            Console.WriteLine("日期");
        }
    }
}
