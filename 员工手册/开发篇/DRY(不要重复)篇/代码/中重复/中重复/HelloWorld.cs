using System;
using System.Collections.Generic;
using System.Text;

namespace 中重复
{
    class HelloWorld
    {
        void Java()
        {
            hello();
            Console.WriteLine("Java");
            world();
        }
        void C()
        {
            hello();
            Console.WriteLine("C");
            world();
        }
        void hello()
        {
            Console.WriteLine("hello");
        }
        void world()
        {
            Console.WriteLine("world");
        }
    }
}
