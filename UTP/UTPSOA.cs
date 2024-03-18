using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;

namespace UTP
{
    [TestClass]
    public class UTPSOA
    {
        [TestMethod]
        public void TestMethodHello()
        {
            var obj = new SOA.RequestCartesian().SayHello(new SOA.Request { Status = 0, Message = "Success" });
            Console.WriteLine(JsonConvert.SerializeObject(obj));
        }
        [TestMethod]
        public void TestMethodSingleton()
        {
            string msg = "Hello World";
            var obj = new SOA.RequestCartesian().SayHello(new SOA.Request { Status = -2, Message = msg });
            Console.WriteLine(JsonConvert.SerializeObject(obj));
        }
        [TestMethod]
        public void TestMethodMultiplicity()
        {
            var obj = new SOA.RequestCartesian().SayHello(new SOA.Request { Status = 1, Message = "Enumeration" });
            Console.WriteLine(JsonConvert.SerializeObject(obj));
        }
    }
}