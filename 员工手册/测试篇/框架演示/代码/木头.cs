using System;
using System.Collections.Generic;
using System.Text;

namespace 代码
{
    class 木头 : 长条状的
    {
        protected 长条状的 _笔芯;
        protected int _笔芯的长度0;
        protected int _长度;
        public 木头(长条状的 笔芯,int 笔芯长度)
        {
            this._笔芯 = 笔芯;
            _笔芯的长度0 = 笔芯长度;
            初始化笔芯();
        }

        public int 长度
        {
            get => Math.Max(_长度, _笔芯.长度); 
            set
            {
                _长度 = Math.Min(_长度, value);
                _笔芯.长度 = Math.Min(_笔芯.长度, value);
            }
        }

        void 初始化笔芯()
        {
            _笔芯.长度 = _笔芯的长度0;
        }
        

       

    }
}
