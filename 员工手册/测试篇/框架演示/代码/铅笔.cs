using System;
using System.Collections.Generic;
using System.Text;

namespace 代码
{
    class 铅笔
    {
        private int _木头;
        protected int _笔芯;

        public int 木头 { get => _木头; set => _木头 = value; }

        public 铅笔()
        {
            _木头 = 100;
            _笔芯 = 100;
        }
        public void 削木头()
        {
            _木头 = 木头 - 2;
        }
        public void 削笔芯()
        {
            _笔芯--;
        }

    }
}
