using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HubEauKit.Tests.Integration
{
    public class EcoulementClientTests
    {
        private readonly EcoulementClient _client;

        public EcoulementClientTests()
        {


            _client = new EcoulementClient(new HttpClientRequestAdapter(new AnonymousAuthenticationProvider()));
        }

        [Fact]
        public async Task GetStations()
        {
            var response = await _client.Vbeta.Ecoulement.Stations.GetAsync(q =>
            {
                q.QueryParameters.Size = 2;
                q.QueryParameters.Libelle_cours_eau = new string[] { "La Moselle" };
                q.QueryParameters.Sort = "Code_station";

            });
            response.Data.Should().HaveCount(2);
            response.Data[0].Libelle_cours_eau.Should().Be("La Moselle");
            response.Data[0].Code_cours_eau.Should().Be("A---0060");
            response.Data[0].Code_station.Should().Be("A4000001");
        }
    }
}
