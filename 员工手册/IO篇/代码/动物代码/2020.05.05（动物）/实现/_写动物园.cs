using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using _2020._05._05_动物_.接口;
using LitJson;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace _2020._05._05_动物_
{
<<<<<<< HEAD
    [Serializable]
    class _写动物园 : _动物园,可以将对象写入到地方的
    {
        public _写动物园(IEnumerable<会叫的> 动物们,可以显示的 可以显示的) : base(动物们,可以显示的)
        {
        }
        public virtual void 写()
        {
          
        }
    }
=======
	[Serializable]
	class _写动物园 : _动物园, 可以将动物写入到动物园的
	{
		public _写动物园(IEnumerable<会叫的> 动物们, 可以显示的 可以显示的) : base(动物们, 可以显示的)
		{
		}
		public virtual void 写() //abstract
		{

		}
	}
>>>>>>> f808137509c21920d25c60903a79f52a329fcfe5
}
