using System;
using System.Collections.Generic;
using System.Text;

namespace 代码
{
    class 写文章 : 写东西
    {
        public 写文章(削好的铅笔 铅笔) : base(铅笔)//我们假设这是耐久的铅笔，削一次就够用了
        {
           
        }

        public void 写第一段()
        {
            //写文章跟写短文的第一段看着是重复，实际上不是重复，实际写文章跟写短文的时候这里的内容肯定不是第一段，是别的内容
            //可想而知，如果贸然把这个当成重复解决了，我修改写文章的第一段会导致短文的第一段变了，而这两种文体不应该产生这种关联
            //所以不要仅仅从形式上去判断什么是重复
            写("第一段");

        }
        public void 写第二段()
        {
            写("第二段");
        }

    }
}
