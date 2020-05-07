using System;
using System.Collections.Generic;
using System.Text;

namespace 代码
{
    class 写短文 : 写东西
    {
        
        public 写短文(削好的铅笔 铅笔) : base(铅笔)//我们假设这是耐久的铅笔，削一次就够用了
        {
           
        }

        public void 写短篇()
        {
            写("第一段");
        }

        
    }
}
