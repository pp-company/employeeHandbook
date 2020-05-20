using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace _2020._05._05_动物_
{
    class _序列化 : 可以序列化的
    {
        public IFormatter 获得序列化()
        {
            return new BinaryFormatter();
        }
    }
}
