using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace _2020._05._05_动物_
{
    [Serializable]
    class _狗 : _动物
    {
        
        public override string 叫()
        {
            return "汪";
        }
    }
}
