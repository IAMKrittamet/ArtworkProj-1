using Microsoft.VisualStudio.TestTools.UnitTesting;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.Tests
{
    [TestClass()]
    public class EmailServiceTests
    {
        [TestMethod()]
        public void SendTestTest()
        {
            EmailService.SendTest("Test email", "adminartworksystem@thaiunion.com", "krittamet@iamconsulting.co.th","Hello Email Test","");
        }
    }
}