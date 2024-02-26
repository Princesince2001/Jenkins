
using JenkinsDemo;
namespace TestProject2
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test_sayMyname()
        {
            Testone test=new Testone();
            string result = test.sayMyname(2);
            Assert.AreEqual("jenkinspassjenkinspass", result);
        }


        [Test]
        public void Test_sayMyname1()
        {
            Testone test = new Testone();
            string result = test.sayMyname(1);
            Assert.AreEqual("jenkinspass", result);
        }
    }
}