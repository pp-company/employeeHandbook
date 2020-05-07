using System;
using System.Collections.Generic;
using System.Text;

namespace 代码
{
    class 铅笔
    {
        protected int 木头;
        protected int 笔芯;
        public 铅笔()
        {
            木头 = 100;
            笔芯 = 100;
        }
        public void 削木头()
        {
            木头 = 木头 - 2;
        }
        public void 削笔芯()
        {
            笔芯--;
        }

    }
}
