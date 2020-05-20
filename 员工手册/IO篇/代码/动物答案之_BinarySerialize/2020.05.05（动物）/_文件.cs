using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
namespace _2020._05._05_动物_
{
    class _文件 : 可以创建文件的,可以打开文件的
    {
        protected FileStream _fs;

        public void 创建文件(string 路径)
        {
            _fs = new FileStream(路径, FileMode.Create, FileAccess.ReadWrite);
        }

        public void 打开文件(string 路径)
        {
            _fs = new FileStream(路径, FileMode.Open, FileAccess.ReadWrite);
        }

        public FileStream 获得文件的流()
        {
             return _fs;
        }

    }
}
