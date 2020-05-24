using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using _2020._05._05_动物_.接口;

namespace _2020._05._05_动物_
{
	interface 把一个东西写到一个路径 : IParameterSetter<string>
	{
		void 写入对象(Object 东西, string 路径);
	}
}
