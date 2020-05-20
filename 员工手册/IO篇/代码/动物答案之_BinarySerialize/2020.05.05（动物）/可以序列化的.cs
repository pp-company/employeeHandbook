using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace _2020._05._05_动物_
{
    interface 可以序列化的
    {
        IFormatter 获得序列化();
    }
}
