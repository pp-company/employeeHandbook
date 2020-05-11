using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using LitJson;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace _2020._05._05_动物_
{
    [Serializable]
    class _写动物园_ : _动物园
    {
        protected 可以创建文件的 _可以创建文件的;


        IEnumerable<会叫的> _动物们;
        public _写动物园_(IEnumerable<会叫的> 动物们, 可以创建文件的 可以创建文件的) : base(动物们)
        {
            _动物们 = 动物们;
            _可以创建文件的 = 可以创建文件的;
        }
        public void 写()
        {
            //把动物写到硬盘上
            FileStream fstream = new FileStream("C:\\Users\\pp\\Desktop\\pp.txt", FileMode.Create, FileAccess.Write);
            IFormatter binFormat = new BinaryFormatter();
            binFormat.Serialize(fstream, _动物们);
            fstream.Close();
        }

       
    }
}
