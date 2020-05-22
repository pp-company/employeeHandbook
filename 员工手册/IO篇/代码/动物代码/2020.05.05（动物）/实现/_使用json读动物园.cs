using System;
using System.Collections.Generic;
using System.Text;

namespace _2020._05._05_动物_
{
    class _使用json读动物园: _动物园, 可以读的,可以从动物园读取动物的
    {
        protected 可以读的 _可以读的;
        protected string _路径;
        public _使用json读动物园(IEnumerable<会叫的> 动物们, 可以读的 可以读的, string 路径) : base(动物们)
        {
            _可以读的 = 可以读的;
            _路径 = 路径;
            读();
        }
        public void 读()
        {
            _动物们 = (IEnumerable<会叫的>)读取对象(_路径);

        }

        public object 读取对象(string 路径)
        {
            return _可以读的.读取对象(路径);
        }
    }
}
