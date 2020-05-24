using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 代码.installer;

namespace _2020._05._05_动物_.test
{
    [TestFixture]
    public class mysql测试:IO测试
    {

        protected override void SetInstallers()
        {
            installers.Add(new mysqlInstaller());
        }
    }
}
