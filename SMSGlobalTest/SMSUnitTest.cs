using Microsoft.VisualStudio.TestTools.UnitTesting;
using SMSGlobal.api;

namespace SMSGlobalTest
{
    [TestClass]
    public class SMSUnitTest
    {

        [TestMethod]
        public async System.Threading.Tasks.Task TestMethodSendSMS()
        {
            var client = new Client(new Credentials("d373f6687ccabe5e9f8ce9020b430d0f", "2e822d60519d3242fe2d0ee347d8632b"));

            var response = await client.SMS.SMSSend(new
            {
                origin = "Test",
                destination = "447583029584",
                message = "This is a test message"
            });

            Assert.IsNotNull(response);
        }

        [TestMethod]
        public async System.Threading.Tasks.Task TestMethodSendBulkDestinationsSMS()
        {
            var client = new Client(new Credentials("SMSGLOBAL-API-KEY", "SMSGLOBAL-SECRET-KEY"));

            string[] destinations = new string[2];

            destinations[0] = "DESTINATION-NUMBER-1";
            destinations[1] = "DESTINATION-NUMBER-2";

            var response = await client.SMS.SMSSend(new
            {
                origin = "Test",
                destinations = destinations,
                message = "This is a test message"
            });

            Assert.IsNotNull(response);
        }

        [TestMethod]
        public async System.Threading.Tasks.Task TestMethodGetSMS()
        {
            var client = new Client(new Credentials("SMSGLOBAL-API-KEY", "SMSGLOBAL-SECRET-KEY"));

            string filter = "limit=1";
            var response = await client.SMS.SMSGetAll(filter);
            Assert.IsNotNull(response);
        }

        [TestMethod]
        public async System.Threading.Tasks.Task TestMethodGetSMSId()
        {
            var client = new Client(new Credentials("SMSGLOBAL-API-KEY", "SMSGLOBAL-SECRET-KEY"));

            string id = "SMSGLOBAL-OUTGOING-ID";
            var response = await client.SMS.SMSGetId(id);
            Assert.IsNotNull(response);
        }

        [TestMethod]
        public async System.Threading.Tasks.Task TestMethodDeleteSMSId()
        {
            var client = new Client(new Credentials("SMSGLOBAL-API-KEY", "SMSGLOBAL-SECRET-KEY"));

            string id = "SMSGLOBAL-OUTGOING-ID";
            var response = await client.SMS.SMSDeleteId(id);
            Assert.IsNotNull(response);
        }
    }
}
