using CsvHelper;
using CsvHelper.Configuration;
using CsvHelper.Configuration.Attributes;
using FluentAssertions;
using System.Globalization;

namespace HubEauKit.Tests.Integration;

public class EcoulementClientTests
{
    private readonly EcoulementClient _client;

    public EcoulementClientTests()
    {
        _client = new EcoulementClient(new HttpClientRequestAdapter(new AnonymousAuthenticationProvider()));
    }

    [Fact]
    public async Task GetCampagnesTest()
    {
        var response = await _client.Vbeta.Ecoulement.Campagnes.GetAsync(config =>
        {
            config.QueryParameters.Size = 2;
        });
    }

    [Fact]
    public async Task GetObservationsTest()
    {
        var response = await _client.Vbeta.Ecoulement.Observations.GetAsync(config =>
        {
            config.QueryParameters.Size = 2;

        });

        response.Data.Should().NotBeNull();
    }

    [Fact]
    public async Task GetObservationsCsvTest()
    {
        var stream = await _client.Vbeta.Ecoulement.Csv.GetAsync(config =>
        {
            config.QueryParameters.Size = 2;
        });

        var configuration = new CsvConfiguration(CultureInfo.InvariantCulture)
        {
            Delimiter = ";"
        };

        List<ObservationCsv> records;

        using (StreamReader sr = new StreamReader(stream))
        using(CsvReader cr = new CsvReader(sr, configuration))
        {
            records = cr.GetRecords<ObservationCsv>().ToList();
        }


        records.Should().HaveCount(2);
        records[0].Code_station.Should().Be("K3640002");
        records[0].Libelle_station.Should().Be("Ruisseau du Pont Aubert à Mars-Sur-Allier");
        records[0].Uri_station.Should().Be("http://id.eaufrance.fr/StationHydro/K3640002");
        records[0].Code_departement.Should().Be("58");
        records[0].Libelle_departement.Should().Be("Nièvre");
        records[0].Code_commune.Should().Be("58158");
        records[0].Libelle_commune.Should().Be("MARS-SUR-ALLIER");
        records[0].Code_region.Should().Be("27");
        records[0].Libelle_region.Should().Be("Bourgogne-Franche-Comté");
        records[0].Code_bassin.Should().Be("04");
        records[0].Libelle_bassin.Should().Be("Loire-Bretagne");
        records[0].Coordonnee_x_station.Should().Be(706424.9d);
        records[0].Coordonnee_y_station.Should().Be(6638959.5d);
        records[0].Code_projection_station.Should().Be("26");
        records[0].Libelle_projection_station.Should().Be("RGF93 / Lambert 93");
        records[0].Code_cours_eau.Should().Be("K3645000");
        records[0].Libelle_cours_eau.Should().Be("le Pont Aubert");
        records[0].Uri_cours_eau.Should().Be("http://id.eaufrance.fr/CoursEau_Carthage2017/K3645000");
        records[0].Code_campagne.Should().Be("96325");
        records[0].Code_reseau.Should().Be("0000000134");
        records[0].Libelle_reseau.Should().Be("Onde OFB");
        records[0].Uri_reseau.Should().Be("http://id.eaufrance.fr/dc/0000000134");
        records[0].Code_ecoulement.Should().Be("3");
        records[0].Latitude.Should().Be(46.85076724427001d);
        records[0].Longitude.Should().Be(3.0843202694409513);
    }

    [Fact]
    public async Task GetStationsTest()
    {
        var response = await _client.Vbeta.Ecoulement.Stations.GetAsync(config =>
        {
            config.QueryParameters.Size = 2;
            config.QueryParameters.Libelle_cours_eau = new string[] { "La Moselle" };
            config.QueryParameters.Sort = "Code_station";

        });

        response.Data.Should().HaveCount(2);
        response.Data[0].Code_bassin.Should().Be("02");
        response.Data[0].Code_commune.Should().Be("88081");
        response.Data[0].Code_cours_eau.Should().Be("A---0060");
        response.Data[0].Code_departement.Should().Be("88");
        response.Data[0].Code_epsg_station.Should().Be("2154");
        response.Data[0].Code_projection_station.Should().Be("26");
        response.Data[0].Code_region.Should().Be("44");
        response.Data[0].Code_station.Should().Be("A4000001");
        response.Data[0].Coordonnee_x_station.Should().Be(989351.1d);
        response.Data[0].Coordonnee_y_station.Should().Be(6761643);
        response.Data[0].Etat_station.Should().Be("Active");
        response.Data[0].Latitude.Should().Be(47.891296707d);
        response.Data[0].Libelle_bassin.Should().Be("Rhin-Meuse");
        response.Data[0].Libelle_commune.Should().Be("BUSSANG");
        response.Data[0].Libelle_cours_eau.Should().Be("La Moselle");
        response.Data[0].Libelle_departement.Should().Be("Vosges");
        response.Data[0].Libelle_projection_station.Should().Be("RGF93 / Lambert 93");
        response.Data[0].Libelle_region.Should().Be("Grand Est");
        response.Data[0].Libelle_station.Should().Be("La Moselle a Bussang");
        response.Data[0].Longitude.Should().Be(6.873374276d);
    }

    internal class ObservationCsv
    {
        [Name("code_bassin")]
        public string Code_bassin { get; set; }
        [Name("code_campagne")]
        public string Code_campagne { get; set; }
        [Name("code_commune")]
        public string Code_commune { get; set; }
        [Name("code_cours_eau")]
        public string Code_cours_eau { get; set; }
        [Name("code_departement")]
        public string Code_departement { get; set; }
        [Name("code_ecoulement")]
        public string Code_ecoulement { get; set; }
        [Name("code_projection_station")]
        public string Code_projection_station { get; set; }
        [Name("code_region")]
        public string Code_region { get; set; }
        [Name("code_reseau")]
        public string Code_reseau { get; set; }
        [Name("code_station")]
        public string Code_station { get; set; }
        [Name("coordonnee_x_station")]
        public double? Coordonnee_x_station { get; set; }
        [Name("coordonnee_y_station")]
        public double? Coordonnee_y_station { get; set; }
        [Name("date_observation")]
        public DateTimeOffset? Date_observation { get; set; }
        [Name("latitude")]
        public double? Latitude { get; set; }
        [Name("libelle_bassin")]
        public string Libelle_bassin { get; set; }
        [Name("libelle_commune")]
        public string Libelle_commune { get; set; }
        [Name("libelle_cours_eau")]
        public string Libelle_cours_eau { get; set; }
        [Name("libelle_departement")]
        public string Libelle_departement { get; set; }
        [Name("libelle_ecoulement")]
        public string Libelle_ecoulement { get; set; }
        [Name("libelle_projection_station")]
        public string Libelle_projection_station { get; set; }
        [Name("libelle_region")]
        public string Libelle_region { get; set; }
        [Name("libelle_reseau")]
        public string Libelle_reseau { get; set; }
        [Name("libelle_station")]
        public string Libelle_station { get; set; }
        [Name("longitude")]
        public double? Longitude { get; set; }
        [Name("uri_cours_eau")]
        public string Uri_cours_eau { get; set; }
        [Name("uri_reseau")]
        public string Uri_reseau { get; set; }
        [Name("uri_station")]
        public string Uri_station { get; set; }

    }
}
