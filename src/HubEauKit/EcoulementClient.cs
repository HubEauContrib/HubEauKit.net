using HubEauKit.Vbeta;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Serialization.Json;
using Microsoft.Kiota.Serialization.Text;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
namespace HubEauKit {
    /// <summary>The main entry point of the SDK, exposes the configuration and the fluent API.</summary>
    public class EcoulementClient {
        /// <summary>Path parameters for the request</summary>
        private Dictionary<string, object> PathParameters { get; set; }
        /// <summary>The request adapter to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        /// <summary>Url template to use to build the URL for the current request builder</summary>
        private string UrlTemplate { get; set; }
        /// <summary>The vbeta property</summary>
        public VbetaRequestBuilder Vbeta { get =>
            new VbetaRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new EcoulementClient and sets the default values.
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        /// </summary>
        public EcoulementClient(IRequestAdapter requestAdapter) {
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            PathParameters = new Dictionary<string, object>();
            UrlTemplate = "{+baseurl}";
            RequestAdapter = requestAdapter;
            ApiClientBuilder.RegisterDefaultSerializer<JsonSerializationWriterFactory>();
            ApiClientBuilder.RegisterDefaultSerializer<TextSerializationWriterFactory>();
            ApiClientBuilder.RegisterDefaultDeserializer<JsonParseNodeFactory>();
            ApiClientBuilder.RegisterDefaultDeserializer<TextParseNodeFactory>();
            if (string.IsNullOrEmpty(RequestAdapter.BaseUrl)) {
                RequestAdapter.BaseUrl = "https://hubeau.eaufrance.fr/api";
            }
        }
    }
}
