using _2020._05._05_动物_.接口;
using System;
using System.Collections.Generic;
using System.Text;

namespace _2020._05._05_动物_
{
<<<<<<< HEAD
    class _使用json读动物园: _读动物园, 从一个路径读到一个东西,可以从地方读取对象的
    {
        protected 从一个路径读到一个东西 _从一个路径读到一个东西;
        protected string _路径;
        public _使用json读动物园(从一个路径读到一个东西 从一个路径读到一个东西, string 路径,可以显示的 可以显示的) : base(null, 可以显示的)
        {
            _从一个路径读到一个东西 = 从一个路径读到一个东西;
            _路径 = 路径;
            
        }
        public override void 读()
        {
            _动物们 = (IEnumerable<会叫的>)读取对象(_路径);
=======
	class _使用json读动物园 : _读动物园, 从一个路径读到一个东西, 可以从动物园读取动物的
	{
		protected 从一个路径读到一个东西 _从一个路径读到一个东西;
		protected string _路径;
		public _使用json读动物园(从一个路径读到一个东西 从一个路径读到一个东西, string 路径, 可以显示的 可以显示的) : base(可以显示的)
		{
			_从一个路径读到一个东西 = 从一个路径读到一个东西;
			_路径 = 路径;
>>>>>>> f808137509c21920d25c60903a79f52a329fcfe5

		}

		public void SetParameter(string parameter)
		{
			throw new NotImplementedException();
		}

		public void 读()
		{
			_动物们 = (IEnumerable<会叫的>)读取对象(_路径);

		}

		public object 读取对象(string 路径)
		{
			return _从一个路径读到一个东西.读取对象(路径);
		}
	}
}
