using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace _2020._05._05_动物_
{
    class _读写 : 把一个东西写到一个路径, 从一个路径读到一个东西,工厂<Stream>,设置<string>,IFormatter
    {
        protected IFormatter _binFormat;
        protected 工厂<Stream> _工厂出;
        protected 设置<string> _工厂进;

        public _读写(IFormatter binFormat, 工厂<Stream> 工厂出, 设置<string> 工厂进)
        {
            this._binFormat = binFormat;
            _工厂出 = 工厂出;
            _工厂进 = 工厂进;
            if(_工厂出!=_工厂进)
            {
                throw new Exception("_把一个东西写到一个路径类里注入的两个工厂不是同一个工厂");  
                
            }
        }

        public SerializationBinder Binder { get => _binFormat.Binder; set => _binFormat.Binder = value; }
        public StreamingContext Context { get => _binFormat.Context; set => _binFormat.Context = value; }
        public ISurrogateSelector SurrogateSelector { get => _binFormat.SurrogateSelector; set => _binFormat.SurrogateSelector = value; }

        public object Deserialize(Stream serializationStream)
        {
            return _binFormat.Deserialize(serializationStream);
        }

        public void Serialize(Stream serializationStream, object graph)
        {
            _binFormat.Serialize(serializationStream, graph);
        }

        public void 写入对象(object 东西, string 路径)
        {
            设置(路径);
            using (var s = 生产())
            {
                Serialize(s, 东西);
            }
        }

        public object 读取对象(string 路径)
        {
            设置(路径);
            using (var s = 生产())
            {
                return Deserialize(s);
            }
        }

        public Stream 生产()
        {
            return _工厂出.生产();
        }

        public void 设置(string t)
        {
            _工厂进.设置(t);
        }
    }
}
