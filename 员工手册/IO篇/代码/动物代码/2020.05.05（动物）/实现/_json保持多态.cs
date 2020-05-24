using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace _2020._05._05_动物_
{

	//use factory
	class _json保持多态 : IFactory<JsonSerializerSettings>
	{
		public JsonSerializerSettings Create()
		{

			JsonSerializerSettings Settings = new JsonSerializerSettings()
			{
				TypeNameHandling = TypeNameHandling.All
			};
			return Settings;
		}
	}
}
