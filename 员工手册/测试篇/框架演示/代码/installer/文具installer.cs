using System;
using System.Collections.Generic;
using System.Text;
using Zenject;

namespace 代码.installer
{
    class 文具installer : BindingInstaller
    {
        public override void Bind()
        {
            Container.Bind<锋利的>().To<刀>().AsSingle();
            Container.Bind<长条状的>().To<铅笔>().AsSingle();
            Container.Bind<长条状的>().To<木头>().AsTransient().WhenInjectedInto<铅笔>();
            Container.Bind<长条状的>().To<笔芯>().AsTransient().WhenInjectedInto<木头>();
            Container.Bind<int>().FromInstance(100).AsTransient().WhenInjectedInto<铅笔>();
            Container.Bind<int>().FromInstance(100).AsTransient().WhenInjectedInto<木头>();
            Container.Bind<int>().FromInstance(2).AsTransient().WhenInjectedInto<刀>();
        }
    }
}
