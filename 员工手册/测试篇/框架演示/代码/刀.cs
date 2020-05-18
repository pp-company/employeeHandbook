using System;
using System.Collections.Generic;
using System.Text;
using Zenject;

namespace 代码
{
    class 刀:锋利的
    {
        protected 长条状的 _长条状;
        protected int _每次要削的长度;

        public 刀(长条状的 长条状, int 每次要削的长度)  //容器在注入这个铅笔的时候要额外注意应该和写东西是同一根铅笔，不能削了一个不相关的铅笔，写字那个不受影响
        {
            _长条状 = 长条状;
            _每次要削的长度 = 每次要削的长度;
        }

        public void 削()
        {
            if(_长条状.长度!=0 && _长条状.长度 !=0 )
            {
                _长条状.长度 -= _每次要削的长度;
            }
            else
            {
                throw new Exception("削到手了");
            }
            
        }
    }
}
