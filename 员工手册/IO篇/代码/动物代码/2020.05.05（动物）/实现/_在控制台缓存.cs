using _2020._05._05_动物_.接口;
using System;
using System.Collections.Generic;
using System.Text;

namespace _2020._05._05_动物_.实现
{
	class _在控制台缓存 : 可以显示的//, 可以存的
	{
		//protected 可以存的 _可以存的;//复杂多余的结构，只需要注入一个，ICollection<string>，且把它bind assingle.
		protected ICollection<string> _数据;//复杂多余的结构，只需要注入一个，ICollection<string>，且把它bind assingle.

		public _在控制台缓存(ICollection<string> 数据)
		{

			_数据 = 数据;
		}



		public void 显示一行(string 内容)
		{
			_数据.Add(内容);

			Console.WriteLine(内容);
		}
	}
}
