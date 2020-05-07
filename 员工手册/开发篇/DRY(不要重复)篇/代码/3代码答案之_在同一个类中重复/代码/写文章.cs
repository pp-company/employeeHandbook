using System;
using System.Collections.Generic;
using System.Text;

namespace 代码
{
    class 写文章 //现在同一个类已经没有重复了，但是写短文和写文章之间有重复，在下一个文件夹下去掉重复，这里我们为了演示分布一层一层的去掉重复，实际操作中没必要这么死板的按照顺序来
    {
        protected 铅笔 _铅笔;
        public 写文章(削好的铅笔 铅笔)//我们假设这是耐久的铅笔，削一次就够用了
        {
            _铅笔 = 铅笔;
        }
        public void 写第一段()
        {
            //Console.WriteLine("第一段");为什么不写这一行代码而要通过下面的方法去实现这个功能
            //因为一行的重复也算重复
            写("第一段");

        }
        public void 写第二段()
        {
            写("第二段");
        }
        public void 署名()
        {
            写("名字");
            写("盖章");
            写("日期");
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
    }
}
