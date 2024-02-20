using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NUnit.Framework;

namespace CI_Test.Assets.Tests
{
    [TestFixture]
    public class BallTests
    {
        float radius = 1.0f;

        [Test]
        public void Test1()
        {
            var ball = new Ball(radius);
            Assert.AreEqual(radius, ball.Radius);
        }
    }
}