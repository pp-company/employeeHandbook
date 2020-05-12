using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using Zenject;
using 代码.test;

namespace 代码
{
    [TestFixture]
    class 削笔刀测试 : UnitTestBase,锋利的
    {
        [Inject]
        protected 锋利的 _削笔刀;
        [Inject]
        protected 铅笔 _铅笔;
        public void 削()
        {
            _削笔刀.削();
        }
        [Test]
        public void test()
        {
        }
        //笔芯也要削
        public void 测试目测正确的()
        {
            模板(_铅笔.木头);
        }
        public void 模板(int num)
        {
            削();
            Assert.Greater(num, _铅笔.木头);
        }
        public void 测试()
        {
            模板(_铅笔.木头);
            模板(_铅笔.木头);
            模板(_铅笔.木头);
            模板(_铅笔.木头);
        }
        public void 边界模板(int num)
        {
            削();
            Assert.AreEqual(num, _铅笔.木头);//等于或报错
        }
        public void 边界情况()
        {
            _铅笔.木头 = 0;     
            ModestTree.Assert.Throws(() => 边界模板(0));
        }

        protected override void SetInstallers()
        {
            throw new NotImplementedException();
        }
    }
}
