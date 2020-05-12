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
            Container.Bind<锋利的>().To<削笔刀>().AsSingle();
            Container.Bind<铅笔>().To<铅笔>().AsTransient();
        }
    }
}
