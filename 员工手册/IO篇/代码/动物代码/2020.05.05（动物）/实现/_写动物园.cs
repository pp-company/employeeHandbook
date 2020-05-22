using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using LitJson;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace _2020._05._05_动物_
{
    [Serializable]
    class _写动物园 : _动物园,可以将动物写入到动物园的
    {
        IEnumerable<会叫的> _动物们;
        public _写动物园(IEnumerable<会叫的> 动物们) : base(动物们)
        {
            _动物们 = 动物们;
        }
        public void 写()
        {
          
        }
    }
}
