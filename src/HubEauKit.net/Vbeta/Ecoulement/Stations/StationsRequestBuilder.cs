using HubEauKit.Models;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
namespace HubEauKit.Vbeta.Ecoulement.Stations {
    /// <summary>Builds and executes requests for operations under \vbeta\ecoulement\stations</summary>
    public class StationsRequestBuilder {
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        /// <summary>The request adapter to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        /// <summary>
        /// Instantiates a new StationsRequestBuilder and sets the default values.
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public StationsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) {
            _ = pathParameters ?? throw new ArgumentNullException(nameof(pathParameters));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/vbeta/ecoulement/stations{?format,code_station,libelle_station,code_departement,libelle_departement,code_commune,libelle_commune,code_region,libelle_region,code_bassin,libelle_bassin,code_cours_eau,libelle_cours_eau,longitude,latitude,distance,bbox,sort,Num%C3%A9ro%20de%20la%20page,size,Liste%20des%20champs%20souhait%C3%A9s%20dans%20la%20r%C3%A9ponse%20%28fonctionnalit%C3%A9%20exp%C3%A9rimentale%29%2C%20par%20exemple%20fields%3Dcode_station%2Clocalisation}";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Instantiates a new StationsRequestBuilder and sets the default values.
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public StationsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) {
            if(string.IsNullOrEmpty(rawUrl)) throw new ArgumentNullException(nameof(rawUrl));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/vbeta/ecoulement/stations{?format,code_station,libelle_station,code_departement,libelle_departement,code_commune,libelle_commune,code_region,libelle_region,code_bassin,libelle_bassin,code_cours_eau,libelle_cours_eau,longitude,latitude,distance,bbox,sort,Num%C3%A9ro%20de%20la%20page,size,Liste%20des%20champs%20souhait%C3%A9s%20dans%20la%20r%C3%A9ponse%20%28fonctionnalit%C3%A9%20exp%C3%A9rimentale%29%2C%20par%20exemple%20fields%3Dcode_station%2Clocalisation}";
            var urlTplParams = new Dictionary<string, object>();
            urlTplParams.Add("request-raw-url", rawUrl);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Lister les stations
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// </summary>
        public RequestInformation CreateGetRequestInformation(Action<StationsRequestBuilderGetRequestConfiguration> requestConfiguration = default) {
            var requestInfo = new RequestInformation {
                HttpMethod = Method.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.Headers.Add("Accept", "application/json");
            if (requestConfiguration != null) {
                var requestConfig = new StationsRequestBuilderGetRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddQueryParameters(requestConfig.QueryParameters);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Lister les stations
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
        /// </summary>
        public async Task<HubEauKit.Models.StationResult> GetAsync(Action<StationsRequestBuilderGetRequestConfiguration> requestConfiguration = default, IResponseHandler responseHandler = default, CancellationToken cancellationToken = default) {
            var requestInfo = CreateGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"400", StationResult.CreateFromDiscriminatorValue},
                {"404", StationResult.CreateFromDiscriminatorValue},
                {"500", StationResult.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<HubEauKit.Models.StationResult>(requestInfo, HubEauKit.Models.StationResult.CreateFromDiscriminatorValue, responseHandler, errorMapping, cancellationToken);
        }
        /// <summary>Lister les stations</summary>
        public class StationsRequestBuilderGetQueryParameters {
            /// <summary>Rectangle d&apos;emprise de l&apos;objet demandé, emprise au format : min longitude, min latitude, max longitude, max latitude avec les coordonnées en WGS84 (EPSG:4326), le point doit être utilisé comme séparateur décimal, exemple : 1.6194,47.7965,2.1910,47.9988</summary>
            public double?[] Bbox { get; set; }
            /// <summary>Code(s) Sandre de la circonscription administrative de bassin. Valeurs possibles : http://id.eaufrance.fr/NSA/447. Séparer les valeurs par des virgules. Nombre maximum de valeurs : 15</summary>
            public string[] Code_bassin { get; set; }
            /// <summary>Code(s) INSEE de la commune associée à la station. Séparer les valeurs par des virgules. Nombre maximum de valeurs : 200</summary>
            public string[] Code_commune { get; set; }
            /// <summary>Code(s) Sandre du cours d&apos;eau associé à la station hydrométrique. Valeurs possibles : https://api.sandre.eaufrance.fr/referentiels/v1/cea.json. Séparer les valeurs par des virgules. Nombre maximum de valeurs : 200</summary>
            public string[] Code_cours_eau { get; set; }
            /// <summary>Code(s) INSEE du département associé à la station. Séparer les valeurs par des virgules. Nombre maximum de valeurs : 200</summary>
            public string[] Code_departement { get; set; }
            /// <summary>Code(s) INSEE de la région associée à la station. Séparer les valeurs par des virgules. Nombre maximum de valeurs : 200</summary>
            public string[] Code_region { get; set; }
            /// <summary>Code(s) Sandre de la station hydrométrique. Valeurs possibles : http://services.sandre.eaufrance.fr/geo/hyd?SERVICE=WFS&amp;VERSION=1.1.0&amp;REQUEST=GetFeature&amp;typename=StationHydro_FXX&amp;SRSNAME=EPSG:2154&amp;OUTPUTFORMAT=GEOJSON. Séparer les valeurs par des virgules. Nombre maximum de valeurs : 200</summary>
            public string[] Code_station { get; set; }
            /// <summary>Rayon de recherche en kilomètre, le point doit être utilisé comme séparateur décimal, exemple : 30</summary>
            public double? Distance { get; set; }
            public string Format { get; set; }
            /// <summary>Latitude du point en WGS84 pour la recherche par rayon, le point doit être utilisé comme séparateur décimal, exemple : 47.829</summary>
            public double? Latitude { get; set; }
            /// <summary>Libellé(s) Sandre de la circonscription administrative de bassin. Valeurs possibles : http://id.eaufrance.fr/NSA/447. Séparer les valeurs par des virgules. Nombre maximum de valeurs : 15</summary>
            public string[] Libelle_bassin { get; set; }
            /// <summary>Libellé(s) INSEE de la commune associée à la station. Séparer les valeurs par des virgules. Nombre maximum de valeurs : 200</summary>
            public string[] Libelle_commune { get; set; }
            /// <summary>Libellé(s) Sandre du cours d&apos;eau associée à la station hydrométrique. Valeurs possibles : https://api.sandre.eaufrance.fr/referentiels/v1/cea.json. Séparer les valeurs par des virgules. Nombre maximum de valeurs : 200</summary>
            public string[] Libelle_cours_eau { get; set; }
            /// <summary>Libellé(s) INSEE du département associé à la station. Séparer les valeurs par des virgules. Nombre maximum de valeurs : 200</summary>
            public string[] Libelle_departement { get; set; }
            /// <summary>Libellé(s) INSEE de la région associée à la station. Séparer les valeurs par des virgules. Nombre maximum de valeurs : 200</summary>
            public string[] Libelle_region { get; set; }
            /// <summary>Libellé(s) Sandre de la station hydrométrique. Valeurs possibles : http://services.sandre.eaufrance.fr/geo/hyd?SERVICE=WFS&amp;VERSION=1.1.0&amp;REQUEST=GetFeature&amp;typename=StationHydro_FXX&amp;SRSNAME=EPSG:2154&amp;OUTPUTFORMAT=GEOJSON. Séparer les valeurs par des virgules. Nombre maximum de valeurs : 200</summary>
            public string[] Libelle_station { get; set; }
            [QueryParameter("Liste%20des%20champs%20souhait%C3%A9s%20dans%20la%20r%C3%A9ponse%20%28fonctionnalit%C3%A9%20exp%C3%A9rimentale%29%2C%20par%20exemple%20fields%3Dcode_station%2Clocalisation")]
            public string Listedeschampssouhaitsdanslarponsefonctionnalitexprimentaleparexemplefieldscode_stationlocalisation { get; set; }
            /// <summary>Longitude du point en WGS84 pour la recherche par rayon, le point doit être utilisé comme séparateur décimal, exemple : 1.937</summary>
            public double? Longitude { get; set; }
            [QueryParameter("Num%C3%A9ro%20de%20la%20page")]
            public int? Numrodelapage { get; set; }
            public int? Size { get; set; }
            public string Sort { get; set; }
        }
        /// <summary>Configuration for the request such as headers, query parameters, and middleware options.</summary>
        public class StationsRequestBuilderGetRequestConfiguration {
            /// <summary>Request headers</summary>
            public IDictionary<string, string> Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>Request query parameters</summary>
            public StationsRequestBuilderGetQueryParameters QueryParameters { get; set; } = new StationsRequestBuilderGetQueryParameters();
            /// <summary>
            /// Instantiates a new stationsRequestBuilderGetRequestConfiguration and sets the default values.
            /// </summary>
            public StationsRequestBuilderGetRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new Dictionary<string, string>();
            }
        }
    }
}
