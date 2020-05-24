using System;
using System.Collections.Generic;
using System.Text;
using _2020._05._05_动物_.接口;

namespace _2020._05._05_动物_
{

	interface 从一个路径读到一个东西 : IParameterSetter<string>
	{
		Object 读取对象(string 路径);
	}
}
