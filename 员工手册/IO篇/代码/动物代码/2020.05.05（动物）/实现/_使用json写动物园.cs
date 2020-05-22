using System;
using System.Collections.Generic;
using System.Text;

namespace _2020._05._05_动物_
{
    class _使用json写动物园 : _动物园, 可以写的,可以将动物写入到动物园的
    {
        protected IEnumerable<会叫的> _动物们;
        protected 可以写的 _可以写的;
        protected string _路径;
        public _使用json写动物园(IEnumerable<会叫的> 动物们, 可以写的 可以写的, string 路径) : base(动物们)
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
