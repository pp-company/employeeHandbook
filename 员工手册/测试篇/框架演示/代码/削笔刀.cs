using System;
using System.Collections.Generic;
using System.Text;
using Zenject;

namespace 代码
{
    class 削笔刀:锋利的
    {
        [Inject]
        protected 铅笔 _铅笔;
        public 削笔刀(铅笔 铅笔)//容器在注入这个铅笔的时候要额外注意应该和写东西是同一根铅笔，不能削了一个不相关的铅笔，写字那个不受影响
        {
            _铅笔 = 铅笔;
        }

        public void 削()
        {
            _铅笔.削木头();
            _铅笔.削笔芯();
        }
    }
}
