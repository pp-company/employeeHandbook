using _2020._05._05_动物_.接口;
using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zenject;
using 代码.installer;

namespace _2020._05._05_动物_.test
{
    [TestFixture]
    public class IO测试: UnitTestBase
    {
        [Inject]
        可以从动物园读取动物的 _可以从动物园读取动物的;
        [Inject]
        可以将动物写入到动物园的 _可以将动物写入到动物园的;
        [Inject]
        可以唱的 _可以唱的;
        [Inject]
        可以读取的 _可以读取的;
        [Test]
        public void 空白测试()
        {

        }
        [Test]
        public void 目测正确的测试()
        {

            Assert.AreEqual("喵", 获取到动物叫声数据的模板().ElementAt(0));
        }

        public IEnumerable<string> 获取到动物叫声数据的模板()
        {
            _可以将动物写入到动物园的.写();
            _可以从动物园读取动物的.读();
            _可以唱的.大合唱();
            return _可以读取的.读取数据();
        }
        [Test]
        public void 测试()
        {
            Assert.AreEqual("汪", 获取到动物叫声数据的模板().ElementAt(1));
            Assert.AreEqual("喵", 获取到动物叫声数据的模板().ElementAt(2));
            Assert.AreEqual("汪", 获取到动物叫声数据的模板().ElementAt(3));
            Assert.AreEqual("喵", 获取到动物叫声数据的模板().ElementAt(4));
            Assert.AreEqual("汪", 获取到动物叫声数据的模板().ElementAt(5));
        }

        protected override void SetInstallers()
        {
            installers.Add(new IOInstaller());
        }
    }
}
