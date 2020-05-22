using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace _2020._05._05_动物_
{
    class _读动物园: _动物园,可以从动物园读取动物的
    {
        //为什么注释掉？正常开发的时候这么写也没错，但是今天为了突出读的功能，把它改一下
        //public _读动物园(IEnumerable<会叫的> 动物们) : base(动物们)
        //{
        //}
        public _读动物园(IEnumerable<会叫的> 动物们) : base(动物们)
        {
            //读();//我们不注入动物，而是改成从硬盘上读动物。正常开发的时候应该先把动物从硬盘上读出来再注入进来，不过今天的演示就不弄那么麻烦了
        }
        public void 读()
        {
        }
    }
}
