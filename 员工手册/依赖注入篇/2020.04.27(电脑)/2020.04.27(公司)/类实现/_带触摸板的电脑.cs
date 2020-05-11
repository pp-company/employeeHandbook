using System;
using System.Collections.Generic;
using System.Text;
using _2020._04._27_公司_.接口;
namespace _2020._04._27_公司_.类实现
{
    class _带触摸板的电脑 : _电脑, 带触摸板的电脑
    {
        public override string 名字()
        {
            return "_带触摸板的电脑名字";
        }
        public void 点击(点 d)
        {
            Console.WriteLine(d);
        }
    }
}
