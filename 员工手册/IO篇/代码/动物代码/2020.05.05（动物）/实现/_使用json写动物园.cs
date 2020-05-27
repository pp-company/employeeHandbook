using _2020._05._05_动物_.接口;
using System;
using System.Collections.Generic;
using System.Text;

namespace _2020._05._05_动物_
{
    class _使用json写动物园 : _写动物园, 把一个东西写到一个路径,可以将对象写入到地方的
    {
        protected IEnumerable<会叫的> _动物们;
        protected 把一个东西写到一个路径 _把一个东西写到一个路径;
        protected string _路径;
        public _使用json写动物园(IEnumerable<会叫的> 动物们, 把一个东西写到一个路径 把一个东西写到一个路径, string 路径, 可以显示的 可以显示的) : base(动物们, 可以显示的)
        {
            _动物们 = 动物们;
            _把一个东西写到一个路径 = 把一个东西写到一个路径;
            _路径 = 路径;
        }
        public override void 写()
        {
            写入对象(_动物们, _路径);
        }
        public void 写入对象(object 对象, string 路径)
        {
            _把一个东西写到一个路径.写入对象(对象, 路径);
        }
    }
}
