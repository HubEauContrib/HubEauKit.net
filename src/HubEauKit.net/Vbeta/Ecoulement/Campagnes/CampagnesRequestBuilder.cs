using HubEauKit.Models;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace HubEauKit.Vbeta.Ecoulement.Campagnes; 
/// <summary>Builds and executes requests for operations under \vbeta\ecoulement\campagnes</summary>
public class CampagnesRequestBuilder {
    /// <summary>Path parameters for the request</summary>
    private Dictionary<string, object> PathParameters { get; set; }
    /// <summary>The request adapter to use to execute the requests.</summary>
    private IRequestAdapter RequestAdapter { get; set; }
    /// <summary>Url template to use to build the URL for the current request builder</summary>
    private string UrlTemplate { get; set; }
    /// <summary>
    /// Instantiates a new CampagnesRequestBuilder and sets the default values.
    /// <param name="pathParameters">Path parameters for the request</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    /// </summary>
    public CampagnesRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) {
        _ = pathParameters ?? throw new ArgumentNullException(nameof(pathParameters));
        _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
        UrlTemplate = "{+baseurl}/vbeta/ecoulement/campagnes{?code_campagne,date_campagne_min,date_campagne_max,code_type_campagne,libelle_type_campagne,code_reseau,libelle_reseau,code_departement,libelle_departement,Num%C3%A9ro%20de%20la%20page,size,Liste%20des%20champs%20souhait%C3%A9s%20dans%20la%20r%C3%A9ponse%20%28fonctionnalit%C3%A9%20exp%C3%A9rimentale%29%2C%20par%20exemple%20fields%3Dcode_station%2Clocalisation}";
        var urlTplParams = new Dictionary<string, object>(pathParameters);
        PathParameters = urlTplParams;
        RequestAdapter = requestAdapter;
    }
    /// <summary>
    /// Instantiates a new CampagnesRequestBuilder and sets the default values.
    /// <param name="rawUrl">The raw URL to use for the request builder.</param>
    /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
    /// </summary>
    public CampagnesRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) {
        if(string.IsNullOrEmpty(rawUrl)) throw new ArgumentNullException(nameof(rawUrl));
        _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
        UrlTemplate = "{+baseurl}/vbeta/ecoulement/campagnes{?code_campagne,date_campagne_min,date_campagne_max,code_type_campagne,libelle_type_campagne,code_reseau,libelle_reseau,code_departement,libelle_departement,Num%C3%A9ro%20de%20la%20page,size,Liste%20des%20champs%20souhait%C3%A9s%20dans%20la%20r%C3%A9ponse%20%28fonctionnalit%C3%A9%20exp%C3%A9rimentale%29%2C%20par%20exemple%20fields%3Dcode_station%2Clocalisation}";
        var urlTplParams = new Dictionary<string, object>();
        urlTplParams.Add("request-raw-url", rawUrl);
        PathParameters = urlTplParams;
        RequestAdapter = requestAdapter;
    }
    /// <summary>
    /// Lister les campagnes
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// </summary>
    public RequestInformation CreateGetRequestInformation(Action<CampagnesRequestBuilderGetRequestConfiguration> requestConfiguration = default) {
        var requestInfo = new RequestInformation {
            HttpMethod = Method.GET,
            UrlTemplate = UrlTemplate,
            PathParameters = PathParameters,
        };
        requestInfo.Headers.Add("Accept", "application/json");
        if (requestConfiguration != null) {
            var requestConfig = new CampagnesRequestBuilderGetRequestConfiguration();
            requestConfiguration.Invoke(requestConfig);
            requestInfo.AddQueryParameters(requestConfig.QueryParameters);
            requestInfo.AddRequestOptions(requestConfig.Options);
            requestInfo.AddHeaders(requestConfig.Headers);
        }
        return requestInfo;
    }
    /// <summary>
    /// Lister les campagnes
    /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
    /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
    /// <param name="responseHandler">Response handler to use in place of the default response handling provided by the core service</param>
    /// </summary>
    public async Task<HubEauKit.Models.CampagneResult> GetAsync(Action<CampagnesRequestBuilderGetRequestConfiguration> requestConfiguration = default, IResponseHandler responseHandler = default, CancellationToken cancellationToken = default) {
        var requestInfo = CreateGetRequestInformation(requestConfiguration);
        var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
            {"400", CampagneResult.CreateFromDiscriminatorValue},
            {"404", CampagneResult.CreateFromDiscriminatorValue},
            {"500", CampagneResult.CreateFromDiscriminatorValue},
        };
        return await RequestAdapter.SendAsync<HubEauKit.Models.CampagneResult>(requestInfo, HubEauKit.Models.CampagneResult.CreateFromDiscriminatorValue, responseHandler, errorMapping, cancellationToken);
    }
    /// <summary>Lister les campagnes</summary>
    public class CampagnesRequestBuilderGetQueryParameters {
        /// <summary>Code(s) Onde de la campagne. Identfiant numérique auto incrémenté non signifiant, si plusieurs codes les séparer par une virgule, nombre maximum de codes = 20</summary>
        public int?[] Code_campagne { get; set; }
        /// <summary>Code(s) INSEE du département associé à la campagne d&apos;observation. Séparer les valeurs par des virgules. Nombre maximum de valeurs : 200</summary>
        public string[] Code_departement { get; set; }
        /// <summary>Code(s) Sandre du réseau associé à la campagne d&apos;observation. Valeurs possibles : https://api.sandre.eaufrance.fr/referentiels/v1/dc.json. Séparer les valeurs par des virgules. Nombre maximum de valeurs : 200</summary>
        public string[] Code_reseau { get; set; }
        /// <summary>Code du type de campagne d&apos;observation. Valeurs possibles : 1 / 2</summary>
        public int?[] Code_type_campagne { get; set; }
        /// <summary>Date maximale de la campagne (format YYYY-MM-DD) : renvoie les campagnes pour lesquelles date_campagne &lt;= date_campagne_max</summary>
        public DateTimeOffset? Date_campagne_max { get; set; }
        /// <summary>Date minimale de la campagne (format YYYY-MM-DD) : renvoie les campagnes pour lesquelles date_campagne &gt;= date_campagne_min</summary>
        public DateTimeOffset? Date_campagne_min { get; set; }
        /// <summary>Libellé(s) INSEE du département associé à la campagne d&apos;observation. Séparer les valeurs par des virgules. Nombre maximum de valeurs : 200</summary>
        public string[] Libelle_departement { get; set; }
        /// <summary>Libellé(s) Sandre du réseau associé à la campagne d&apos;observation. Valeurs possibles : https://api.sandre.eaufrance.fr/referentiels/v1/dc.json. Séparer les valeurs par des virgules. Nombre maximum de valeurs : 200</summary>
        public string[] Libelle_reseau { get; set; }
        /// <summary>Type de campagne d&apos;observation. Valeurs possibles : Usuelle / Complémentaire</summary>
        public string[] Libelle_type_campagne { get; set; }
        [QueryParameter("Liste%20des%20champs%20souhait%C3%A9s%20dans%20la%20r%C3%A9ponse%20%28fonctionnalit%C3%A9%20exp%C3%A9rimentale%29%2C%20par%20exemple%20fields%3Dcode_station%2Clocalisation")]
        public string Listedeschampssouhaitsdanslarponsefonctionnalitexprimentaleparexemplefieldscode_stationlocalisation { get; set; }
        [QueryParameter("Num%C3%A9ro%20de%20la%20page")]
        public int? Numrodelapage { get; set; }
        public int? Size { get; set; }
    }
    /// <summary>Configuration for the request such as headers, query parameters, and middleware options.</summary>
    public class CampagnesRequestBuilderGetRequestConfiguration {
        /// <summary>Request headers</summary>
        public IDictionary<string, string> Headers { get; set; }
        /// <summary>Request options</summary>
        public IList<IRequestOption> Options { get; set; }
        /// <summary>Request query parameters</summary>
        public CampagnesRequestBuilderGetQueryParameters QueryParameters { get; set; } = new CampagnesRequestBuilderGetQueryParameters();
        /// <summary>
        /// Instantiates a new campagnesRequestBuilderGetRequestConfiguration and sets the default values.
        /// </summary>
        public CampagnesRequestBuilderGetRequestConfiguration() {
            Options = new List<IRequestOption>();
            Headers = new Dictionary<string, string>();
        }
    }
}
