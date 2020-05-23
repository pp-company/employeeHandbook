using _2020._05._05_动物_.接口;
using System;
using System.Collections.Generic;
using System.Text;

namespace _2020._05._05_动物_
{
    class _动物园:可以唱的,可以显示的
    {
        //IEnumerable可以增加扩展性和兼容性
        protected IEnumerable<会叫的>  _动物们;
        protected 可以显示的 _可以显示的;
        public _动物园(IEnumerable<会叫的> 动物们, 可以显示的 可以显示的)
        {
            _动物们 = 动物们;
            _可以显示的 = 可以显示的;
        }

        public void 大合唱()
        {
            //for(int i=0;i< _动物们.Length; i++)
            //{
            //Console.WriteLine(_动物们[i].叫());
            //}
            foreach (var 动物 in _动物们)
            {
                显示一行(动物.叫());
            }
            
        }

        public void 显示一行(string 内容)
        {
            _可以显示的.显示一行(内容);
        }
    }
}
