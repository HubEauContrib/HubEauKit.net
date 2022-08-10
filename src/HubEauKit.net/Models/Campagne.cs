using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace HubEauKit.Models {
    /// <summary>Campagne</summary>
    public class Campagne : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The code_campagne property</summary>
        public int? Code_campagne { get; set; }
        /// <summary>The code_departement property</summary>
        public string Code_departement { get; set; }
        /// <summary>The code_reseau property</summary>
        public string Code_reseau { get; set; }
        /// <summary>The code_type_campagne property</summary>
        public int? Code_type_campagne { get; set; }
        /// <summary>The date_campagne property</summary>
        public DateTimeOffset? Date_campagne { get; set; }
        /// <summary>The libelle_departement property</summary>
        public string Libelle_departement { get; set; }
        /// <summary>The libelle_reseau property</summary>
        public string Libelle_reseau { get; set; }
        /// <summary>The libelle_type_campagne property</summary>
        public string Libelle_type_campagne { get; set; }
        /// <summary>The nombre_modalite_ecoulement property</summary>
        public int? Nombre_modalite_ecoulement { get; set; }
        /// <summary>The uri_reseau property</summary>
        public string Uri_reseau { get; set; }
        /// <summary>
        /// Instantiates a new Campagne and sets the default values.
        /// </summary>
        public Campagne() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static Campagne CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Campagne();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"code_campagne", n => { Code_campagne = n.GetIntValue(); } },
                {"code_departement", n => { Code_departement = n.GetStringValue(); } },
                {"code_reseau", n => { Code_reseau = n.GetStringValue(); } },
                {"code_type_campagne", n => { Code_type_campagne = n.GetIntValue(); } },
                {"date_campagne", n => { Date_campagne = n.GetDateTimeOffsetValue(); } },
                {"libelle_departement", n => { Libelle_departement = n.GetStringValue(); } },
                {"libelle_reseau", n => { Libelle_reseau = n.GetStringValue(); } },
                {"libelle_type_campagne", n => { Libelle_type_campagne = n.GetStringValue(); } },
                {"nombre_modalite_ecoulement", n => { Nombre_modalite_ecoulement = n.GetIntValue(); } },
                {"uri_reseau", n => { Uri_reseau = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("code_campagne", Code_campagne);
            writer.WriteStringValue("code_departement", Code_departement);
            writer.WriteStringValue("code_reseau", Code_reseau);
            writer.WriteIntValue("code_type_campagne", Code_type_campagne);
            writer.WriteDateTimeOffsetValue("date_campagne", Date_campagne);
            writer.WriteStringValue("libelle_departement", Libelle_departement);
            writer.WriteStringValue("libelle_reseau", Libelle_reseau);
            writer.WriteStringValue("libelle_type_campagne", Libelle_type_campagne);
            writer.WriteIntValue("nombre_modalite_ecoulement", Nombre_modalite_ecoulement);
            writer.WriteStringValue("uri_reseau", Uri_reseau);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
