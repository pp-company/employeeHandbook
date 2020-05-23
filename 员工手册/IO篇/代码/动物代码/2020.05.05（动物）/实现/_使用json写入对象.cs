using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace _2020._05._05_动物_
{
    class _使用json写入对象 : 把一个东西写到一个路径, 可以保持json多态的
    {
        protected 可以保持json多态的 _可以保持json多态的;

        public _使用json写入对象(可以保持json多态的 可以保持json多态的)
        {
            _可以保持json多态的 = 可以保持json多态的;
        }

        public void 写入对象(object 对象, string 路径)
        {
            File.WriteAllText(路径, JsonConvert.SerializeObject(对象, 设置json保持多态()));
        }

        public JsonSerializerSettings 设置json保持多态()
        {
            return _可以保持json多态的.设置json保持多态();
        }
    }
}
