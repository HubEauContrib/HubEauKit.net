using HubEauKit.Vbeta.Ecoulement.Campagnes;
using HubEauKit.Vbeta.Ecoulement.Csv;
using HubEauKit.Vbeta.Ecoulement.Observations;
using HubEauKit.Vbeta.Ecoulement.Stations;
using Microsoft.Kiota.Abstractions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
namespace HubEauKit.Vbeta.Ecoulement {
    /// <summary>Builds and executes requests for operations under \vbeta\ecoulement</summary>
    public class EcoulementRequestBuilder {
        /// <summary>The campagnes property</summary>
        public CampagnesRequestBuilder Campagnes { get =>
            new CampagnesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The csv property</summary>
        public CsvObservationsRequestBuilder Csv { get =>
            new CsvObservationsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The observations property</summary>
        public ObservationsRequestBuilder Observations { get =>
            new ObservationsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        /// <summary>The request adapter to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        /// <summary>The stations property</summary>
        public StationsRequestBuilder Stations { get =>
            new StationsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        /// <summary>
        /// Instantiates a new EcoulementRequestBuilder and sets the default values.
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public EcoulementRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) {
            _ = pathParameters ?? throw new ArgumentNullException(nameof(pathParameters));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/vbeta/ecoulement";
            var urlTplParams = new Dictionary<string, object>(pathParameters);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
        /// <summary>
        /// Instantiates a new EcoulementRequestBuilder and sets the default values.
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public EcoulementRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) {
            if(string.IsNullOrEmpty(rawUrl)) throw new ArgumentNullException(nameof(rawUrl));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            UrlTemplate = "{+baseurl}/vbeta/ecoulement";
            var urlTplParams = new Dictionary<string, object>();
            urlTplParams.Add("request-raw-url", rawUrl);
            PathParameters = urlTplParams;
            RequestAdapter = requestAdapter;
        }
    }
}
