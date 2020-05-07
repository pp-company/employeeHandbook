using System;
using System.Collections.Generic;
using System.Text;

namespace 代码
{
    class 写文章
    {
        protected 铅笔 _铅笔;
        public 写文章(铅笔 铅笔)
        {
            _铅笔 = 铅笔;
        }
        public void 写第一段()
        {
            _铅笔.削木头();
            _铅笔.削笔芯();
            Console.WriteLine("第一段");

        }
        public void 写第二段()
        {
            _铅笔.削木头();
            _铅笔.削笔芯();
            Console.WriteLine("第二段");
        }
        public void 署名()
        {
            _铅笔.削木头();
            _铅笔.削笔芯();
            Console.WriteLine("名字");
            Console.WriteLine("盖章");
            Console.WriteLine("日期");
        }
    }
}
