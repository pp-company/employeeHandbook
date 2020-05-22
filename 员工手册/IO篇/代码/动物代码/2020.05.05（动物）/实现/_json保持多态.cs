using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace _2020._05._05_动物_
{
    class _json保持多态 : 可以保持json多态的
    {
        public JsonSerializerSettings 设置json保持多态()
        {
            JsonSerializerSettings Settings = new JsonSerializerSettings()
            {
                TypeNameHandling = TypeNameHandling.All
            };
            return Settings;
        }
    }
}
