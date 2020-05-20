using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace 代码
{
    class 石头 : 可以被削的
    {
        protected double 重量;
        public object Clone()
        {
            return this.MemberwiseClone();
        }
        public int CompareTo([AllowNull] 可以被削的 other)
        {
            

        }

    }
}
