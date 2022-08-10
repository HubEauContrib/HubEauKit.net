using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace HubEauKit.Models {
    /// <summary>Résultat d&apos;une rêquete sur les campagnes</summary>
    public class CampagneResult : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The api_version property</summary>
        public string Api_version { get; set; }
        /// <summary>The count property</summary>
        public int? Count { get; set; }
        /// <summary>The data property</summary>
        public List<Campagne> Data { get; set; }
        /// <summary>The first property</summary>
        public string First { get; set; }
        /// <summary>The last property</summary>
        public string Last { get; set; }
        /// <summary>The next property</summary>
        public string Next { get; set; }
        /// <summary>The prev property</summary>
        public string Prev { get; set; }
        /// <summary>
        /// Instantiates a new CampagneResult and sets the default values.
        /// </summary>
        public CampagneResult() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static CampagneResult CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CampagneResult();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"api_version", n => { Api_version = n.GetStringValue(); } },
                {"count", n => { Count = n.GetIntValue(); } },
                {"data", n => { Data = n.GetCollectionOfObjectValues<Campagne>(Campagne.CreateFromDiscriminatorValue).ToList(); } },
                {"first", n => { First = n.GetStringValue(); } },
                {"last", n => { Last = n.GetStringValue(); } },
                {"next", n => { Next = n.GetStringValue(); } },
                {"prev", n => { Prev = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("api_version", Api_version);
            writer.WriteIntValue("count", Count);
            writer.WriteCollectionOfObjectValues<Campagne>("data", Data);
            writer.WriteStringValue("first", First);
            writer.WriteStringValue("last", Last);
            writer.WriteStringValue("next", Next);
            writer.WriteStringValue("prev", Prev);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
