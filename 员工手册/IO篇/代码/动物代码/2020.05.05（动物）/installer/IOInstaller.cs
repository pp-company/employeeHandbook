using _2020._05._05_动物_;
using _2020._05._05_动物_.实现;
using _2020._05._05_动物_.接口;
using System;
using System.Collections.Generic;
using System.Text;
using Zenject;

namespace 代码.installer
{
    class IOInstaller : BindingInstaller
    {
        public override void Bind()
        {
            
            string 路径 = "C:\\Users\\pp\\Desktop\\pp.json";
            Container.Bind<string>().FromInstance(路径).AsSingle().WhenInjectedInto<_使用json读动物园>();
            Container.Bind<string>().FromInstance(路径).AsSingle().WhenInjectedInto<_使用json写动物园>();
            Container.Bind<从一个路径读到一个东西>().To<_使用json读取对象>().AsTransient().WhenInjectedInto<_使用json读动物园>();
            Container.Bind<可以将动物写入到动物园的>().To<_使用json写动物园>().AsTransient();
            Container.Bind<把一个东西写到一个路径>().To<_使用json写入对象>().AsTransient().WhenInjectedInto<_使用json写动物园>();
            _猫[] _猫们 = new _猫[5];
            _狗[] _狗们 = new _狗[5];
            List<会叫的> 动物们 = new List<会叫的>();
            for (int i = 0; i < 5; i++)
            {
                _猫们[i] = new _猫();
                _狗们[i] = new _狗();
            }
            for (int i = 0; i < 5; i++)
            {
                动物们.Add(_猫们[i]);
                动物们.Add(_狗们[i]);
            }
            Container.Bind<可以保持json多态的>().To<_json保持多态>().AsSingle();
            Container.Bind<IEnumerable<会叫的>>().FromInstance(动物们).AsTransient().WhenInjectedInto<_动物园>();

            //这个可以解决,但是不好,因为它强制要求AsSingle,要是不是AsSingle的时候就不能用这个办法了
            //Container.Bind<可以从动物园读取动物的>().To<_使用json读动物园>().AsSingle();
            //Container.Bind<可以唱的>().To<_使用json读动物园>().AsSingle();

            //如果接口太多太乱,会误杀,不建议使用
            //Container.BindInterfacesTo<_使用json读动物园>().AsSingle();

            //
            Container.Bind<可以从动物园读取动物的>().To<_使用json读动物园>().AsSingle();
            Container.Bind<可以唱的>().FromMethod((InjectContext s)=> (可以唱的)Container.Resolve<可以从动物园读取动物的>()).AsSingle();

            Container.Bind<可以读取的>().To<_存取>().AsSingle();
            Container.Bind<可以显示的>().To<_在控制台缓存>().AsTransient();
            Container.Bind<可以存的>().To<_存取>().AsSingle().WhenInjectedInto<_在控制台缓存>();
            ICollection<string> 数据 = new List<string>();
            Container.Bind<ICollection<string>>().FromInstance(数据).AsTransient().WhenInjectedInto<_在控制台缓存>();
        }
    }
}
