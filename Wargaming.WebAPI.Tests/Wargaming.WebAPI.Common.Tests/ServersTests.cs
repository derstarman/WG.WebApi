using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Wargaming.WebAPI.Common.Requests;
using Wargaming.WebAPI.Common.Responses;
using Wargaming.WebAPI.Enums;
using Wargaming.WebAPI.Tests;

namespace Wargaming.WebAPI.Common.Tests
{
    [TestClass]
    public class ServersTests
    {
        public const string TestGroup = "Servers API - Tests";

        [TestMethod]
        public void DeserializeResponseTest()
        {
            var data = "{\"status\": \"ok\", \"data\": { \"wotb\": [{ \"players_online\": 13165, \"server\": \"EU\" } ], \"wot\": [{ \"players_online\": 22082, \"server\": \"EU2\"}, {\"players_online\": 45794, \"server\": \"EU1\" }], \"wowp\": [{ \"players_online\": 966, \"server\": \"EU\" }]}}";
            var response = default(ServerListResponse);
            response = JsonConvert.DeserializeObject<ServerListResponse>(data);

            Assert.AreEqual(response.Status, "ok");
            Assert.AreEqual<int>(response.Result.Count, 3);
            Assert.AreEqual<int>(response.Result["wotb"].Length, 1);
            Assert.AreEqual<int>(response.Result["wot"].Length, 2);
            Assert.AreEqual<int>(response.Result["wowp"].Length, 1);
        }

        [TestMethod]
        public void ServerListGeneralTest()
        {            
            var response = default(ServerListResponse);
            var request = new ServerListRequest();
            request.ApplicationId = TestConstants.TestApplicationId;

            Task<ServerListResponse> task = request.Execute(Servers.EU);
            task.Wait();
            Assert.IsFalse(task.IsFaulted);
            response = task.Result;

            Thread.Sleep(500);

            Assert.AreEqual(response.Status, "ok");
            Assert.IsTrue(response.Result.Count > 0);
        }

        [TestMethod]
        public void ServerListSingleTest()
        {
            var response = default(ServerListResponse);
            var request = new ServerListRequest();
            request.ApplicationId = TestConstants.TestApplicationId;
            request.RequestedGames.Add(Environments.WOT);

            Task<ServerListResponse> task = request.Execute(Servers.EU);
            task.Wait();
            Assert.IsFalse(task.IsFaulted);
            response = task.Result;

            Thread.Sleep(500);

            Assert.AreEqual(response.Status, "ok");
            Assert.AreEqual<int>(response.Result.Count, 1);
        }
    }
}