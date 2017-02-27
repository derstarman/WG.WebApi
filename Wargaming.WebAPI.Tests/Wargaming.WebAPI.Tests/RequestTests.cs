using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Wargaming.WebAPI.Enums;
using Wargaming.WebAPI.Requests;

namespace Wargaming.WebAPI.Tests
{
    [TestClass]
    public class RequestTests
    {
        public const string TestGroup = "RequestBase - Tests";

        [TestCategory(TestGroup)]
        [TestMethod()]
        public void RequestBaseGenerating()
        {
            var request = new BaseRequest();
            request.Language = Languages.DE;
            request.ApplicationId = "e9e92a3ed6724f0fc66f1fc0b309b221";
            request.AccessToken = "Token";
            request.RequestedFields = new List<string> { "Dummy" };

            var param = request.GetParams();
            Assert.IsNotNull(param);
            Assert.IsTrue(param.Length > 0);
        }
    }

    public class BaseRequest : RequestBase
    {

    }
}
