using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Text;

namespace _2020._05._05_动物_
{
    class _使用BinarySerialize读动物园:_动物园,可以从动物园读取动物的
    {
        protected IFormatter _binayFormat;
        
        public _使用BinarySerialize读动物园(IEnumerable<会叫的> 动物们, IFormatter binayFormat) : base(动物们)
        {
            _binayFormat = binayFormat;
            读();
        }
        public void 读()
        {
            FileStream fs = new FileStream("C:\\Users\\pp\\Desktop\\pp.txt", FileMode.Open, FileAccess.ReadWrite);
            //_动物们 = (IEnumerable<会叫的>)_binayFormat.Deserialize(_可以创建文件的);
            fs.Close();

        }
    }
}
