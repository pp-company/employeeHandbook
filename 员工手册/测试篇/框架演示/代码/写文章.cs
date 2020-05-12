using System;
using System.Collections.Generic;
using System.Text;

namespace 代码
{
    class 写文章 : 写东西
    {
        public 写文章(铅笔 铅笔, 锋利的 削笔刀) : base(铅笔, 削笔刀)//我们假设这是不耐久的铅笔，每写一段落都得提前削一遍，但是写一两个字不用削
        {
           
        }

        public void 写第一段()
        {
            削();
            写("第一段");

        }
        public void 写第二段()
        {
            削();
            写("第二段");
        }

    }
}
