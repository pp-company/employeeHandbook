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
    class 刀测试 : UnitTestBase,锋利的
    {
        [Inject]
        protected 锋利的 _刀;
        [Inject]
        protected 长条状的 _长条状;

        

        public void 削()
        {
            _刀.削();
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
            int num1 = _长条状.长度;
            削();
            Assert.Greater(num1, _长条状.长度);
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
            int num1 = _长条状.长度;
            削();
            Assert.AreEqual(num1, _长条状.长度);//等于或报错
        }
        [Test]
        public void 边界情况()
        {
<<<<<<< HEAD:员工手册/测试篇/框架演示/代码/刀测试.cs
            _长条状.长度 = 0;
=======
            _铅笔.木头 = 0;
            _铅笔.笔芯 = 0;
>>>>>>> pp:员工手册/测试篇/框架演示/代码/削笔刀测试.cs
            ModestTree.Assert.Throws(() => 边界模板());
            //边界模板();
        }
<<<<<<< HEAD:员工手册/测试篇/框架演示/代码/刀测试.cs
        [Test]
        public void 简单的测试()
        {
            简单的模板();
        }
        void 简单的模板()
        {
            int num = _长条状.长度;
            削();
            Assert.AreNotEqual(num, _长条状.长度);
        }
=======
>>>>>>> pp:员工手册/测试篇/框架演示/代码/削笔刀测试.cs

        protected override void SetInstallers()
        {
            installers.Add(new 文具installer());
        }
    }
}
