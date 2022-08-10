using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace HubEauKit.Models {
    /// <summary>Observation</summary>
    public class Observation : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The code_bassin property</summary>
        public string Code_bassin { get; set; }
        /// <summary>The code_campagne property</summary>
        public string Code_campagne { get; set; }
        /// <summary>The code_commune property</summary>
        public string Code_commune { get; set; }
        /// <summary>The code_cours_eau property</summary>
        public string Code_cours_eau { get; set; }
        /// <summary>The code_departement property</summary>
        public string Code_departement { get; set; }
        /// <summary>The code_ecoulement property</summary>
        public string Code_ecoulement { get; set; }
        /// <summary>The code_projection_station property</summary>
        public string Code_projection_station { get; set; }
        /// <summary>The code_region property</summary>
        public string Code_region { get; set; }
        /// <summary>The code_reseau property</summary>
        public string Code_reseau { get; set; }
        /// <summary>The code_station property</summary>
        public string Code_station { get; set; }
        /// <summary>The coordonnee_x_station property</summary>
        public double? Coordonnee_x_station { get; set; }
        /// <summary>The coordonnee_y_station property</summary>
        public double? Coordonnee_y_station { get; set; }
        /// <summary>The date_observation property</summary>
        public DateTimeOffset? Date_observation { get; set; }
        /// <summary>The latitude property</summary>
        public double? Latitude { get; set; }
        /// <summary>The libelle_bassin property</summary>
        public string Libelle_bassin { get; set; }
        /// <summary>The libelle_commune property</summary>
        public string Libelle_commune { get; set; }
        /// <summary>The libelle_cours_eau property</summary>
        public string Libelle_cours_eau { get; set; }
        /// <summary>The libelle_departement property</summary>
        public string Libelle_departement { get; set; }
        /// <summary>The libelle_ecoulement property</summary>
        public string Libelle_ecoulement { get; set; }
        /// <summary>The libelle_projection_station property</summary>
        public string Libelle_projection_station { get; set; }
        /// <summary>The libelle_region property</summary>
        public string Libelle_region { get; set; }
        /// <summary>The libelle_reseau property</summary>
        public string Libelle_reseau { get; set; }
        /// <summary>The libelle_station property</summary>
        public string Libelle_station { get; set; }
        /// <summary>The longitude property</summary>
        public double? Longitude { get; set; }
        /// <summary>The uri_cours_eau property</summary>
        public string Uri_cours_eau { get; set; }
        /// <summary>The uri_reseau property</summary>
        public string Uri_reseau { get; set; }
        /// <summary>The uri_station property</summary>
        public string Uri_station { get; set; }
        /// <summary>
        /// Instantiates a new Observation and sets the default values.
        /// </summary>
        public Observation() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static Observation CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Observation();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"code_bassin", n => { Code_bassin = n.GetStringValue(); } },
                {"code_campagne", n => { Code_campagne = n.GetStringValue(); } },
                {"code_commune", n => { Code_commune = n.GetStringValue(); } },
                {"code_cours_eau", n => { Code_cours_eau = n.GetStringValue(); } },
                {"code_departement", n => { Code_departement = n.GetStringValue(); } },
                {"code_ecoulement", n => { Code_ecoulement = n.GetStringValue(); } },
                {"code_projection_station", n => { Code_projection_station = n.GetStringValue(); } },
                {"code_region", n => { Code_region = n.GetStringValue(); } },
                {"code_reseau", n => { Code_reseau = n.GetStringValue(); } },
                {"code_station", n => { Code_station = n.GetStringValue(); } },
                {"coordonnee_x_station", n => { Coordonnee_x_station = n.GetDoubleValue(); } },
                {"coordonnee_y_station", n => { Coordonnee_y_station = n.GetDoubleValue(); } },
                {"date_observation", n => { Date_observation = n.GetDateTimeOffsetValue(); } },
                {"latitude", n => { Latitude = n.GetDoubleValue(); } },
                {"libelle_bassin", n => { Libelle_bassin = n.GetStringValue(); } },
                {"libelle_commune", n => { Libelle_commune = n.GetStringValue(); } },
                {"libelle_cours_eau", n => { Libelle_cours_eau = n.GetStringValue(); } },
                {"libelle_departement", n => { Libelle_departement = n.GetStringValue(); } },
                {"libelle_ecoulement", n => { Libelle_ecoulement = n.GetStringValue(); } },
                {"libelle_projection_station", n => { Libelle_projection_station = n.GetStringValue(); } },
                {"libelle_region", n => { Libelle_region = n.GetStringValue(); } },
                {"libelle_reseau", n => { Libelle_reseau = n.GetStringValue(); } },
                {"libelle_station", n => { Libelle_station = n.GetStringValue(); } },
                {"longitude", n => { Longitude = n.GetDoubleValue(); } },
                {"uri_cours_eau", n => { Uri_cours_eau = n.GetStringValue(); } },
                {"uri_reseau", n => { Uri_reseau = n.GetStringValue(); } },
                {"uri_station", n => { Uri_station = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("code_bassin", Code_bassin);
            writer.WriteStringValue("code_campagne", Code_campagne);
            writer.WriteStringValue("code_commune", Code_commune);
            writer.WriteStringValue("code_cours_eau", Code_cours_eau);
            writer.WriteStringValue("code_departement", Code_departement);
            writer.WriteStringValue("code_ecoulement", Code_ecoulement);
            writer.WriteStringValue("code_projection_station", Code_projection_station);
            writer.WriteStringValue("code_region", Code_region);
            writer.WriteStringValue("code_reseau", Code_reseau);
            writer.WriteStringValue("code_station", Code_station);
            writer.WriteDoubleValue("coordonnee_x_station", Coordonnee_x_station);
            writer.WriteDoubleValue("coordonnee_y_station", Coordonnee_y_station);
            writer.WriteDateTimeOffsetValue("date_observation", Date_observation);
            writer.WriteDoubleValue("latitude", Latitude);
            writer.WriteStringValue("libelle_bassin", Libelle_bassin);
            writer.WriteStringValue("libelle_commune", Libelle_commune);
            writer.WriteStringValue("libelle_cours_eau", Libelle_cours_eau);
            writer.WriteStringValue("libelle_departement", Libelle_departement);
            writer.WriteStringValue("libelle_ecoulement", Libelle_ecoulement);
            writer.WriteStringValue("libelle_projection_station", Libelle_projection_station);
            writer.WriteStringValue("libelle_region", Libelle_region);
            writer.WriteStringValue("libelle_reseau", Libelle_reseau);
            writer.WriteStringValue("libelle_station", Libelle_station);
            writer.WriteDoubleValue("longitude", Longitude);
            writer.WriteStringValue("uri_cours_eau", Uri_cours_eau);
            writer.WriteStringValue("uri_reseau", Uri_reseau);
            writer.WriteStringValue("uri_station", Uri_station);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
