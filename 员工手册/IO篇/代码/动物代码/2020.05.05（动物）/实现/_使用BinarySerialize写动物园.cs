using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace _2020._05._05_动物_
{
    class _使用BinarySerialize写动物园:_动物园,可以将动物写入到动物园的
    {

        IEnumerable<会叫的> _动物们;
        public _使用BinarySerialize写动物园(IEnumerable<会叫的> 动物们) : base(动物们)
        {
            _动物们 = 动物们;
        }
        public void 写()
        {
            //把动物写到硬盘上
            FileStream fstream = new FileStream("C:\\Users\\pp\\Desktop\\pp.txt", FileMode.Create, FileAccess.Write);
            IFormatter binFormat = new BinaryFormatter();
            binFormat.Serialize(fstream, _动物们);
            fstream.Close();
        }
    }
}
