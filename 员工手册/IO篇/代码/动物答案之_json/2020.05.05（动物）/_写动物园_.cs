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
    class _写动物园_ : _动物园,可以写的
    {
        protected IEnumerable<会叫的> _动物们;
        protected 可以写的 _可以写的;
        protected string _路径;
        public _写动物园_(IEnumerable<会叫的> 动物们, 可以写的 可以写的, string 路径) : base(动物们)
        {
            _动物们 = 动物们;
            _可以写的 = 可以写的;
            _路径 = 路径;
        }
        public void 写()
        {
            写入对象(_动物们, _路径);
        }
        public void 写入对象(object 对象, string 路径)
        {
            _可以写的.写入对象(对象, 路径);
        }
    }
}
