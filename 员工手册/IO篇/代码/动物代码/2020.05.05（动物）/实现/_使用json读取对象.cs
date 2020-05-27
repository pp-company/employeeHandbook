using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace _2020._05._05_动物_
{
	class _使用json读取对象 : 从一个路径读到一个东西, 可以保持json多态的
	{
		protected 可以保持json多态的 _可以保持json多态的;

		public _使用json读取对象(可以保持json多态的 可以保持json多态的)//inject JsonSerializerSettings 而不是。。。
		{
			_可以保持json多态的 = 可以保持json多态的;
		}

		public JsonSerializerSettings 设置json保持多态()
		{
			return _可以保持json多态的.设置json保持多态();
		}

		public object 读取对象(string 路径)
		{
			return JsonConvert.DeserializeObject(File.ReadAllText(路径), 设置json保持多态());
		}
	}
}
