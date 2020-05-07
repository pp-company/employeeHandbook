using System;
using System.Collections.Generic;
using System.Text;

namespace 代码
{
    class 写东西:有署名的
    {
        protected 铅笔 _铅笔;
        public 写东西(削好的铅笔 铅笔)
        {
            _铅笔 = 铅笔;
        }


        protected virtual void 写(String 填充文字)
        {
            Console.WriteLine(填充文字);
            //Console.WriteLine(""); 可以O，如果我想要用这种更宽的格式来写文档，写一行空一行、或者用其他的颜色来写、或者用其他的字体来写、或者我本身什么都不改变，
            //但是给子类留出修改的余地,子类可以通过重写这个方法随意的修改格式
            //但是如果我不这么做，直接在上面写console.writeLine(....),我的子类怎么去console.writeLine(....),
            //我要去改个颜色改个空行都要每一个console.writeLine(....)做修改，不O
            //这就是为什么一行的重复也算重复，也要抽离出去，目的就是为了O
        }
        public void 署名()
        {
            写("名字");
            写("盖章");
            写("日期");
        }

    }
}
