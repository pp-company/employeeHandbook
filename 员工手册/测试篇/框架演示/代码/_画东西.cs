using System;
using System.Collections.Generic;
using System.Text;

namespace 代码
{
    class _画东西:锋利的
    {
        protected 锋利的 _削笔刀;
        public _画东西(锋利的 削笔刀)
        {

        }

        public void 削()
        {
            _削笔刀.削();
        }
        public void 画(String 内容)
        {
            Console.WriteLine(内容);
        }
    }
}
