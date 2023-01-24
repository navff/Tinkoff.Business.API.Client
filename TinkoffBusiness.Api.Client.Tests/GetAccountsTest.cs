using TinkoffBusiness.Api.Client;
using TinkoffBusiness.Api.Client.Common;

namespace Tinkoff.Api.Client.Tests
{
    public class Tests
    {
        private TinkoffApiClient _apiClient;

        public Tests()
        {
            _apiClient = new TinkoffApiClient(
                    new HttpClient(),
                    new TinkoffApiSettings
                    {
                        ApiUrl = "https://business.tinkoff.ru/openapi/api",
                        AuthToken = "SECRET_TOKEN"
                    }
                );
        }

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public async Task GetAccounts_Success_Test()
        {
            var result = await _apiClient.GetAccountsAsync();
            Assert.True(result.Any());
        }
    }
}