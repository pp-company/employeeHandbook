using System;
using System.Collections.Generic;
using System.Text;

namespace _2020._05._05_动物_
{
    class _动物园
    {
        //IEnumerable可以增加扩展性和兼容性
        protected IEnumerable<会叫的>  _动物们;
        public _动物园(IEnumerable<会叫的> 动物们)
        {
            _动物们 = 动物们;
        }

        public void 大合唱()
        {
            //for(int i=0;i< _动物们.Length; i++)
            //{
            //Console.WriteLine(_动物们[i].叫());
            //}
            foreach (var 动物 in _动物们)
            {
                Console.WriteLine(动物.叫());
            }
            
        }
    }
}
