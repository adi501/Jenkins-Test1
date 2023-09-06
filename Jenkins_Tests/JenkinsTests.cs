using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Jenkins_Services;

namespace Jenkins_Tests
{
    [TestClass]
    public class JenkinsTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            IDataService dataService = new DataService();
            var hostName = dataService.GetHost();
            Assert.AreEqual(Environment.MachineName, hostName);
        }
    }
}
