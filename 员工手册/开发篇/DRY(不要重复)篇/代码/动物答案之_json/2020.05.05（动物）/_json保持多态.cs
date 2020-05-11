using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace _2020._05._05_动物_
{
    class _json保持多态 : json保持多态的
    {
        protected JsonSerializerSettings Settings;
        public JsonSerializerSettings 保持多态()
        {
            Settings = new JsonSerializerSettings()
            {
                TypeNameHandling = TypeNameHandling.All
            };
            return Settings;
        }
    }
}
