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

		public _使用json读取对象(JsonSerializerSettings 可以保持json多态的)//inject JsonSerializerSettings 而不是。。。
		{
			_可以保持json多态的 = 可以保持json多态的;
		}

		public void SetParameter(string parameter)
		{
			throw new NotImplementedException();
		}



		public object 读取对象(string 路径)
		{
<<<<<<< HEAD
			return JsonConvert.DeserializeObject(File.ReadAllText(路径), 设置json保持多态());
=======
			return JsonConvert.DeserializeObject<IEnumerable<会叫的>>(File.ReadAllText(路径), _可以保持json多态的);
			//你这带了<>也是徒劳，出去后还是object
>>>>>>> f808137509c21920d25c60903a79f52a329fcfe5
		}
	}
}
