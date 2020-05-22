using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace _2020._05._05_动物_
{
    class _使用json读取对象 : 可以读的,可以保持json多态的
    {
        protected 可以保持json多态的 _可以保持json多态的;

        public _使用json读取对象(可以保持json多态的 可以保持json多态的)
        {
            _可以保持json多态的 = 可以保持json多态的;
        }

        public JsonSerializerSettings 设置json保持多态()
        {
            return _可以保持json多态的.设置json保持多态();
        }

        public object 读取对象(string 路径)
        {
            return JsonConvert.DeserializeObject<IEnumerable<会叫的>>(File.ReadAllText(路径), 设置json保持多态());
        }
    }
}
