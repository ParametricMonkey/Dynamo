using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using ProtoCore.DSASM.Mirror;
using ProtoTest.TD;
using ProtoCore.Lang.Replication;
using ProtoTestFx.TD;
namespace ProtoTest.TD.MultiLangTests
{
    public class RecursionTest
    {
        public TestFrameWork thisTest = new TestFrameWork();
        [SetUp]
        public void Setup()
        {

        }/*
[Test]
[Test]
[Test]
[Test]
[Test]
[Test]

        [Test]
        public void Test()
        {
            String code =
@"
            //Assert.Fail("StackOverflow");
            thisTest.RunScriptSource(code);

        }


        [Test]
        public void TestCallingConstructor()
        {
            string code = @"
            thisTest.VerifyRunScriptSource(code, "");
            thisTest.Verify("r", 1);
        }
    }
}