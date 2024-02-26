using NUnit.Framework.Internal;
using JenkinsDemo;
namespace TestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
        [Test]
        public void Test_sayJenkins_1()
        {
            TestMe testMe = new();
            string result = testMe.sayJenkins(2);
            Assert.That(result, Is.EqualTo("JenkinsJenkins"));
        }

        [Test]
        public void Test_sayJenkins_2()
        {
            TestMe testMe = new();
            string result = testMe.sayJenkins(1);
            Assert.That(result, Is.EqualTo("Jenkins"));
        }
    }
}