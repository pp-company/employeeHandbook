using System;
using System.Collections.Generic;
using System.Text;
using _2020._04._27_公司_.接口;
namespace _2020._04._27_公司_.类实现
{
    class _带键盘的电脑 : _电脑,带键盘的电脑
    {
       

        public void 输入文字(string text)
        {
            Console.WriteLine(text);
        }
    }
}
