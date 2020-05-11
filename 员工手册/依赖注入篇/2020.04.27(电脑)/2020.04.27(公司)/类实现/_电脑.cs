using System;
using System.Collections.Generic;
using System.Text;
using _2020._04._27_公司_.接口;

namespace _2020._04._27_公司_.类实现
{
    class _电脑 : 电脑
    {
        public virtual string 名字()
        {
            return "_电脑";
        }

        public string 播放声音()
        {
            return "111111电脑";
        }

        public virtual string 显示()
        {
            return "222222电脑";
        }
    }
}
