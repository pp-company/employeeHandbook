﻿using System;
using System.Collections.Generic;

namespace _2020._05._05_动物_
{
    class Program
    {
        static void Main(string[] args)
        {
            //扮演一个容器的角色
            _猫[] _猫们 = new _猫[5];
            _狗[] _狗们 = new _狗[5];
            List<会叫的> _会叫的动物们 = new List<会叫的>();
            for (int i = 0; i < 5; i++)
            {
                _猫们[i] = new _猫();
                _狗们[i] = new _狗();
            }
            for (int i = 0; i < 5; i++)
            {
                _会叫的动物们.Add(_猫们[i]);
                _会叫的动物们.Add(_狗们[i]);
            }

            //_写动物园_ _写动物园 = new _写动物园_(_会叫的动物们);
            //_写动物园.写();//将动物写到硬盘上
            //_读动物园_ _读动物园 = new _读动物园_(null);
            //_读动物园.大合唱();
            //一个好的IO这个时候大合唱仍然是喵、汪、喵、汪........
            //但是一个不完善的IO唱出来却是不知道怎么叫，不知道怎么叫，不知道怎么叫，不知道怎么叫......
            //我们公司认可的IO有三种BinarySerialize, json, SQL




        }
    }
}
