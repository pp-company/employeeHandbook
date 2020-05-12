using System;
using System.Collections.Generic;
using System.Text;

namespace 首尾重复
{
    abstract class HelloWorld
    {
        public void all()
        {
            hello();
            language();
            world();
        }
        private void hello()
        {
            Console.WriteLine("hello");
        }
        abstract protected void language();
        private void world()
        {
            Console.WriteLine("world");
        }
       
    }
}
