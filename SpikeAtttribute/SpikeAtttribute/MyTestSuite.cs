using System;

namespace SpikeAtttribute
{
    [TestAttribute]
    class MyTestSuite
    {
        public void HelperMethod()
        {
            //That Help our Test get their job done
            Console.WriteLine("this method will never be invoked because it doesn't have a TestMethodAttribute in it");
        }
        [TestMethod]
        public void MyTest1()
        {
            
            Console.WriteLine("Doing some Testing");
        }
        [TestMethod]
        public void MyTestMethod1()
        {
            Console.WriteLine("Doing some other  Testing");
        }
    }
}