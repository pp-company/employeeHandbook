using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using Zenject;
using 代码.installer;
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
        [Test]
        public void 测试目测正确的()
        {
            模板();
        }
        public void 模板()
        {
            int num1 = _铅笔.木头;
            int num2 = _铅笔.笔芯;
            削();
            Assert.Greater(num1, _铅笔.木头);
            Assert.Greater(num2, _铅笔.笔芯);
        }
        [Test]
        public void 测试()
        {
            
            模板();
            模板();
            模板();
            模板();
        }
        public void 边界模板()
        {
            int num1 = _铅笔.木头;
            int num2 = _铅笔.笔芯;
            削();
            Assert.AreEqual(num1, _铅笔.木头);//等于或报错
            Assert.AreEqual(num2, _铅笔.笔芯);
        }
        [Test]
        public void 边界情况()
        { 
            if(_铅笔.木头 == 0 || _铅笔.笔芯 == 0)
            {
                ModestTree.Assert.Throws(() => 边界模板());
            }
            
        }

        protected override void SetInstallers()
        {
            installers.Add(new 文具installer());
        }
    }
}
