//using _2020._05._05_动物_.接口;
//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace _2020._05._05_动物_.实现
//{

//	//rm
//	class _存取 : 可以读取的, 可以存的//复杂多余的结构，只需要注入一个，ICollection<string>，且把它bind assingle.
//	{
//		protected IEnumerable<string> _数据;
//		public void 存数据(IEnumerable<string> 数据)
//		{
//			_数据 = 数据;
//		}

//		public IEnumerable<string> 读取数据()
//		{
//			return _数据;
//		}
//	}
//}
