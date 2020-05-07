using System;
using System.Collections.Generic;
using System.Text;

namespace 代码
{
    class _写 : 可以写的
    {
        protected 铅笔 _铅笔;
        public _写(铅笔 铅笔)
        {
            _铅笔 = 铅笔;
        }
        public void 写(String 填写文字)
        {
            _铅笔.削木头();
            _铅笔.削笔芯();
            Console.WriteLine(填写文字);
        }
    }
}
