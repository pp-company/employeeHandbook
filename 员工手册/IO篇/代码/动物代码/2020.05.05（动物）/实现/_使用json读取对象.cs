using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace _2020._05._05_动物_
{
	class _使用json读取对象 : 从一个路径读到一个东西
	{
		protected JsonSerializerSettings _可以保持json多态的;

		public _使用json读取对象(JsonSerializerSettings 可以保持json多态的)
		{
			_可以保持json多态的 = 可以保持json多态的;
		}

		public void SetParameter(string parameter)
		{
			throw new NotImplementedException();
		}



		public object 读取对象(string 路径)
		{
			return JsonConvert.DeserializeObject<IEnumerable<会叫的>>(File.ReadAllText(路径), _可以保持json多态的);
		}
	}
}
