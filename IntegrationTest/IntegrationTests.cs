using myskillsapp;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using myskillsapp.Object;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace MySkills.IntegrationTests
{
    [TestClass]
    public class IntegrationTests
    {
        private readonly HttpClient _client;

        public IntegrationTests()
        {
            TestServer Server = new TestServer(new WebHostBuilder()
                .UseStartup<Startup>());
            _client = Server.CreateClient();
        }

        [Fact]
        public async Task IsLanguageControllerResponseGood()
        {
            var response = await _client.GetAsync("/api/language");            
            HttpResponseMessage message = response.EnsureSuccessStatusCode();
            var responseContent = await response.Content.ReadAsStringAsync();
            List<Language> resultObjects = JsonConvert.DeserializeObject<List<Language>>(responseContent);
            Xunit.Assert.True(message.IsSuccessStatusCode);
            Xunit.Assert.NotNull(resultObjects);
        }

        [Fact]
        public async Task IsCSharpResponseGood()
        {
            var response = await _client.GetAsync("/api/language/2");
            var responseContent = await response.Content.ReadAsStringAsync();
            Language resultObject = JsonConvert.DeserializeObject<Language>(responseContent);            
            Xunit.Assert.True(response.EnsureSuccessStatusCode().IsSuccessStatusCode);
            Xunit.Assert.Equal("C#", resultObject.Name);
            Xunit.Assert.Equal(3, resultObject.Framework.Count);
        }

        [Fact]
        public async Task IsInexistantFrameworkIdReturningGood()
        {
            var response = await _client.GetAsync("/api/framework/42");
            Xunit.Assert.NotEqual(HttpStatusCode.OK, response.StatusCode);
            var responseContent = await response.Content.ReadAsStringAsync();
            Language resultObject = JsonConvert.DeserializeObject<Language>(responseContent);
            Xunit.Assert.Null(resultObject.Name);
        }
    }
}