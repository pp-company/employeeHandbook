using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace _2020._05._05_动物_
{
    [Serializable]
    class _动物 : 会叫的
    {
       
        //public abstract string 叫();正常开发的时候我们应该这么写，因为动物没有确定的叫法
        //但是今天我们为了演示其他的东西不得不改一下
        public virtual String 叫()
        {
            return "不知道怎么叫";
        }
    }
}
