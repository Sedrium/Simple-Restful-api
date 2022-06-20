using CompanySpy.Api;
using CompanySpy.Integration.Test.DataHelper;
using System;
using System.Net.Http;
using Xunit;

namespace CompanySpy.Integration.Test.Utilities
{
    public class FixtureTestBase : IClassFixture<ApiWebApplicationFactory<Startup>>
    {
        protected readonly HttpClient _client;
        private readonly ApiWebApplicationFactory<Startup> _fixture;

        public FixtureTestBase()
        {
            _fixture = new ApiWebApplicationFactory<Startup>();
            _client = _fixture.CreateClient();
        }

    }
}
