/*
 * API Hub'Eau - Ecoulement des cours d'eau
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: vbeta
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = HubEauKit.Client.OpenAPIDateConverter;

namespace HubEauKit.Model
{
    /// <summary>
    /// Observation
    /// </summary>
    [DataContract(Name = "Observation")]
    public partial class Observation : IEquatable<Observation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Observation" /> class.
        /// </summary>
        /// <param name="codeStation">codeStation.</param>
        /// <param name="libelleStation">libelleStation.</param>
        /// <param name="uriStation">uriStation.</param>
        /// <param name="codeDepartement">codeDepartement.</param>
        /// <param name="libelleDepartement">libelleDepartement.</param>
        /// <param name="codeCommune">codeCommune.</param>
        /// <param name="libelleCommune">libelleCommune.</param>
        /// <param name="codeRegion">codeRegion.</param>
        /// <param name="libelleRegion">libelleRegion.</param>
        /// <param name="codeBassin">codeBassin.</param>
        /// <param name="libelleBassin">libelleBassin.</param>
        /// <param name="coordonneeXStation">coordonneeXStation.</param>
        /// <param name="coordonneeYStation">coordonneeYStation.</param>
        /// <param name="codeProjectionStation">codeProjectionStation.</param>
        /// <param name="libelleProjectionStation">libelleProjectionStation.</param>
        /// <param name="codeCoursEau">codeCoursEau.</param>
        /// <param name="libelleCoursEau">libelleCoursEau.</param>
        /// <param name="uriCoursEau">uriCoursEau.</param>
        /// <param name="codeCampagne">codeCampagne.</param>
        /// <param name="codeReseau">codeReseau.</param>
        /// <param name="libelleReseau">libelleReseau.</param>
        /// <param name="uriReseau">uriReseau.</param>
        /// <param name="dateObservation">dateObservation.</param>
        /// <param name="codeEcoulement">codeEcoulement.</param>
        /// <param name="libelleEcoulement">libelleEcoulement.</param>
        /// <param name="latitude">latitude.</param>
        /// <param name="longitude">longitude.</param>
        public Observation(string codeStation = default(string), string libelleStation = default(string), string uriStation = default(string), string codeDepartement = default(string), string libelleDepartement = default(string), string codeCommune = default(string), string libelleCommune = default(string), string codeRegion = default(string), string libelleRegion = default(string), string codeBassin = default(string), string libelleBassin = default(string), double coordonneeXStation = default(double), double coordonneeYStation = default(double), string codeProjectionStation = default(string), string libelleProjectionStation = default(string), string codeCoursEau = default(string), string libelleCoursEau = default(string), string uriCoursEau = default(string), string codeCampagne = default(string), string codeReseau = default(string), string libelleReseau = default(string), string uriReseau = default(string), DateTime dateObservation = default(DateTime), string codeEcoulement = default(string), string libelleEcoulement = default(string), double latitude = default(double), double longitude = default(double))
        {
            this.CodeStation = codeStation;
            this.LibelleStation = libelleStation;
            this.UriStation = uriStation;
            this.CodeDepartement = codeDepartement;
            this.LibelleDepartement = libelleDepartement;
            this.CodeCommune = codeCommune;
            this.LibelleCommune = libelleCommune;
            this.CodeRegion = codeRegion;
            this.LibelleRegion = libelleRegion;
            this.CodeBassin = codeBassin;
            this.LibelleBassin = libelleBassin;
            this.CoordonneeXStation = coordonneeXStation;
            this.CoordonneeYStation = coordonneeYStation;
            this.CodeProjectionStation = codeProjectionStation;
            this.LibelleProjectionStation = libelleProjectionStation;
            this.CodeCoursEau = codeCoursEau;
            this.LibelleCoursEau = libelleCoursEau;
            this.UriCoursEau = uriCoursEau;
            this.CodeCampagne = codeCampagne;
            this.CodeReseau = codeReseau;
            this.LibelleReseau = libelleReseau;
            this.UriReseau = uriReseau;
            this.DateObservation = dateObservation;
            this.CodeEcoulement = codeEcoulement;
            this.LibelleEcoulement = libelleEcoulement;
            this.Latitude = latitude;
            this.Longitude = longitude;
        }

        /// <summary>
        /// Gets or Sets CodeStation
        /// </summary>
        [DataMember(Name = "code_station", EmitDefaultValue = false)]
        public string CodeStation { get; set; }

        /// <summary>
        /// Gets or Sets LibelleStation
        /// </summary>
        [DataMember(Name = "libelle_station", EmitDefaultValue = false)]
        public string LibelleStation { get; set; }

        /// <summary>
        /// Gets or Sets UriStation
        /// </summary>
        [DataMember(Name = "uri_station", EmitDefaultValue = false)]
        public string UriStation { get; set; }

        /// <summary>
        /// Gets or Sets CodeDepartement
        /// </summary>
        [DataMember(Name = "code_departement", EmitDefaultValue = false)]
        public string CodeDepartement { get; set; }

        /// <summary>
        /// Gets or Sets LibelleDepartement
        /// </summary>
        [DataMember(Name = "libelle_departement", EmitDefaultValue = false)]
        public string LibelleDepartement { get; set; }

        /// <summary>
        /// Gets or Sets CodeCommune
        /// </summary>
        [DataMember(Name = "code_commune", EmitDefaultValue = false)]
        public string CodeCommune { get; set; }

        /// <summary>
        /// Gets or Sets LibelleCommune
        /// </summary>
        [DataMember(Name = "libelle_commune", EmitDefaultValue = false)]
        public string LibelleCommune { get; set; }

        /// <summary>
        /// Gets or Sets CodeRegion
        /// </summary>
        [DataMember(Name = "code_region", EmitDefaultValue = false)]
        public string CodeRegion { get; set; }

        /// <summary>
        /// Gets or Sets LibelleRegion
        /// </summary>
        [DataMember(Name = "libelle_region", EmitDefaultValue = false)]
        public string LibelleRegion { get; set; }

        /// <summary>
        /// Gets or Sets CodeBassin
        /// </summary>
        [DataMember(Name = "code_bassin", EmitDefaultValue = false)]
        public string CodeBassin { get; set; }

        /// <summary>
        /// Gets or Sets LibelleBassin
        /// </summary>
        [DataMember(Name = "libelle_bassin", EmitDefaultValue = false)]
        public string LibelleBassin { get; set; }

        /// <summary>
        /// Gets or Sets CoordonneeXStation
        /// </summary>
        [DataMember(Name = "coordonnee_x_station", EmitDefaultValue = false)]
        public double CoordonneeXStation { get; set; }

        /// <summary>
        /// Gets or Sets CoordonneeYStation
        /// </summary>
        [DataMember(Name = "coordonnee_y_station", EmitDefaultValue = false)]
        public double CoordonneeYStation { get; set; }

        /// <summary>
        /// Gets or Sets CodeProjectionStation
        /// </summary>
        [DataMember(Name = "code_projection_station", EmitDefaultValue = false)]
        public string CodeProjectionStation { get; set; }

        /// <summary>
        /// Gets or Sets LibelleProjectionStation
        /// </summary>
        [DataMember(Name = "libelle_projection_station", EmitDefaultValue = false)]
        public string LibelleProjectionStation { get; set; }

        /// <summary>
        /// Gets or Sets CodeCoursEau
        /// </summary>
        [DataMember(Name = "code_cours_eau", EmitDefaultValue = false)]
        public string CodeCoursEau { get; set; }

        /// <summary>
        /// Gets or Sets LibelleCoursEau
        /// </summary>
        [DataMember(Name = "libelle_cours_eau", EmitDefaultValue = false)]
        public string LibelleCoursEau { get; set; }

        /// <summary>
        /// Gets or Sets UriCoursEau
        /// </summary>
        [DataMember(Name = "uri_cours_eau", EmitDefaultValue = false)]
        public string UriCoursEau { get; set; }

        /// <summary>
        /// Gets or Sets CodeCampagne
        /// </summary>
        [DataMember(Name = "code_campagne", EmitDefaultValue = false)]
        public string CodeCampagne { get; set; }

        /// <summary>
        /// Gets or Sets CodeReseau
        /// </summary>
        [DataMember(Name = "code_reseau", EmitDefaultValue = false)]
        public string CodeReseau { get; set; }

        /// <summary>
        /// Gets or Sets LibelleReseau
        /// </summary>
        [DataMember(Name = "libelle_reseau", EmitDefaultValue = false)]
        public string LibelleReseau { get; set; }

        /// <summary>
        /// Gets or Sets UriReseau
        /// </summary>
        [DataMember(Name = "uri_reseau", EmitDefaultValue = false)]
        public string UriReseau { get; set; }

        /// <summary>
        /// Gets or Sets DateObservation
        /// </summary>
        [DataMember(Name = "date_observation", EmitDefaultValue = false)]
        public DateTime DateObservation { get; set; }

        /// <summary>
        /// Gets or Sets CodeEcoulement
        /// </summary>
        [DataMember(Name = "code_ecoulement", EmitDefaultValue = false)]
        public string CodeEcoulement { get; set; }

        /// <summary>
        /// Gets or Sets LibelleEcoulement
        /// </summary>
        [DataMember(Name = "libelle_ecoulement", EmitDefaultValue = false)]
        public string LibelleEcoulement { get; set; }

        /// <summary>
        /// Gets or Sets Latitude
        /// </summary>
        [DataMember(Name = "latitude", EmitDefaultValue = false)]
        public double Latitude { get; set; }

        /// <summary>
        /// Gets or Sets Longitude
        /// </summary>
        [DataMember(Name = "longitude", EmitDefaultValue = false)]
        public double Longitude { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Observation {\n");
            sb.Append("  CodeStation: ").Append(CodeStation).Append("\n");
            sb.Append("  LibelleStation: ").Append(LibelleStation).Append("\n");
            sb.Append("  UriStation: ").Append(UriStation).Append("\n");
            sb.Append("  CodeDepartement: ").Append(CodeDepartement).Append("\n");
            sb.Append("  LibelleDepartement: ").Append(LibelleDepartement).Append("\n");
            sb.Append("  CodeCommune: ").Append(CodeCommune).Append("\n");
            sb.Append("  LibelleCommune: ").Append(LibelleCommune).Append("\n");
            sb.Append("  CodeRegion: ").Append(CodeRegion).Append("\n");
            sb.Append("  LibelleRegion: ").Append(LibelleRegion).Append("\n");
            sb.Append("  CodeBassin: ").Append(CodeBassin).Append("\n");
            sb.Append("  LibelleBassin: ").Append(LibelleBassin).Append("\n");
            sb.Append("  CoordonneeXStation: ").Append(CoordonneeXStation).Append("\n");
            sb.Append("  CoordonneeYStation: ").Append(CoordonneeYStation).Append("\n");
            sb.Append("  CodeProjectionStation: ").Append(CodeProjectionStation).Append("\n");
            sb.Append("  LibelleProjectionStation: ").Append(LibelleProjectionStation).Append("\n");
            sb.Append("  CodeCoursEau: ").Append(CodeCoursEau).Append("\n");
            sb.Append("  LibelleCoursEau: ").Append(LibelleCoursEau).Append("\n");
            sb.Append("  UriCoursEau: ").Append(UriCoursEau).Append("\n");
            sb.Append("  CodeCampagne: ").Append(CodeCampagne).Append("\n");
            sb.Append("  CodeReseau: ").Append(CodeReseau).Append("\n");
            sb.Append("  LibelleReseau: ").Append(LibelleReseau).Append("\n");
            sb.Append("  UriReseau: ").Append(UriReseau).Append("\n");
            sb.Append("  DateObservation: ").Append(DateObservation).Append("\n");
            sb.Append("  CodeEcoulement: ").Append(CodeEcoulement).Append("\n");
            sb.Append("  LibelleEcoulement: ").Append(LibelleEcoulement).Append("\n");
            sb.Append("  Latitude: ").Append(Latitude).Append("\n");
            sb.Append("  Longitude: ").Append(Longitude).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as Observation);
        }

        /// <summary>
        /// Returns true if Observation instances are equal
        /// </summary>
        /// <param name="input">Instance of Observation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Observation input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CodeStation == input.CodeStation ||
                    (this.CodeStation != null &&
                    this.CodeStation.Equals(input.CodeStation))
                ) && 
                (
                    this.LibelleStation == input.LibelleStation ||
                    (this.LibelleStation != null &&
                    this.LibelleStation.Equals(input.LibelleStation))
                ) && 
                (
                    this.UriStation == input.UriStation ||
                    (this.UriStation != null &&
                    this.UriStation.Equals(input.UriStation))
                ) && 
                (
                    this.CodeDepartement == input.CodeDepartement ||
                    (this.CodeDepartement != null &&
                    this.CodeDepartement.Equals(input.CodeDepartement))
                ) && 
                (
                    this.LibelleDepartement == input.LibelleDepartement ||
                    (this.LibelleDepartement != null &&
                    this.LibelleDepartement.Equals(input.LibelleDepartement))
                ) && 
                (
                    this.CodeCommune == input.CodeCommune ||
                    (this.CodeCommune != null &&
                    this.CodeCommune.Equals(input.CodeCommune))
                ) && 
                (
                    this.LibelleCommune == input.LibelleCommune ||
                    (this.LibelleCommune != null &&
                    this.LibelleCommune.Equals(input.LibelleCommune))
                ) && 
                (
                    this.CodeRegion == input.CodeRegion ||
                    (this.CodeRegion != null &&
                    this.CodeRegion.Equals(input.CodeRegion))
                ) && 
                (
                    this.LibelleRegion == input.LibelleRegion ||
                    (this.LibelleRegion != null &&
                    this.LibelleRegion.Equals(input.LibelleRegion))
                ) && 
                (
                    this.CodeBassin == input.CodeBassin ||
                    (this.CodeBassin != null &&
                    this.CodeBassin.Equals(input.CodeBassin))
                ) && 
                (
                    this.LibelleBassin == input.LibelleBassin ||
                    (this.LibelleBassin != null &&
                    this.LibelleBassin.Equals(input.LibelleBassin))
                ) && 
                (
                    this.CoordonneeXStation == input.CoordonneeXStation ||
                    this.CoordonneeXStation.Equals(input.CoordonneeXStation)
                ) && 
                (
                    this.CoordonneeYStation == input.CoordonneeYStation ||
                    this.CoordonneeYStation.Equals(input.CoordonneeYStation)
                ) && 
                (
                    this.CodeProjectionStation == input.CodeProjectionStation ||
                    (this.CodeProjectionStation != null &&
                    this.CodeProjectionStation.Equals(input.CodeProjectionStation))
                ) && 
                (
                    this.LibelleProjectionStation == input.LibelleProjectionStation ||
                    (this.LibelleProjectionStation != null &&
                    this.LibelleProjectionStation.Equals(input.LibelleProjectionStation))
                ) && 
                (
                    this.CodeCoursEau == input.CodeCoursEau ||
                    (this.CodeCoursEau != null &&
                    this.CodeCoursEau.Equals(input.CodeCoursEau))
                ) && 
                (
                    this.LibelleCoursEau == input.LibelleCoursEau ||
                    (this.LibelleCoursEau != null &&
                    this.LibelleCoursEau.Equals(input.LibelleCoursEau))
                ) && 
                (
                    this.UriCoursEau == input.UriCoursEau ||
                    (this.UriCoursEau != null &&
                    this.UriCoursEau.Equals(input.UriCoursEau))
                ) && 
                (
                    this.CodeCampagne == input.CodeCampagne ||
                    (this.CodeCampagne != null &&
                    this.CodeCampagne.Equals(input.CodeCampagne))
                ) && 
                (
                    this.CodeReseau == input.CodeReseau ||
                    (this.CodeReseau != null &&
                    this.CodeReseau.Equals(input.CodeReseau))
                ) && 
                (
                    this.LibelleReseau == input.LibelleReseau ||
                    (this.LibelleReseau != null &&
                    this.LibelleReseau.Equals(input.LibelleReseau))
                ) && 
                (
                    this.UriReseau == input.UriReseau ||
                    (this.UriReseau != null &&
                    this.UriReseau.Equals(input.UriReseau))
                ) && 
                (
                    this.DateObservation == input.DateObservation ||
                    (this.DateObservation != null &&
                    this.DateObservation.Equals(input.DateObservation))
                ) && 
                (
                    this.CodeEcoulement == input.CodeEcoulement ||
                    (this.CodeEcoulement != null &&
                    this.CodeEcoulement.Equals(input.CodeEcoulement))
                ) && 
                (
                    this.LibelleEcoulement == input.LibelleEcoulement ||
                    (this.LibelleEcoulement != null &&
                    this.LibelleEcoulement.Equals(input.LibelleEcoulement))
                ) && 
                (
                    this.Latitude == input.Latitude ||
                    this.Latitude.Equals(input.Latitude)
                ) && 
                (
                    this.Longitude == input.Longitude ||
                    this.Longitude.Equals(input.Longitude)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.CodeStation != null)
                {
                    hashCode = (hashCode * 59) + this.CodeStation.GetHashCode();
                }
                if (this.LibelleStation != null)
                {
                    hashCode = (hashCode * 59) + this.LibelleStation.GetHashCode();
                }
                if (this.UriStation != null)
                {
                    hashCode = (hashCode * 59) + this.UriStation.GetHashCode();
                }
                if (this.CodeDepartement != null)
                {
                    hashCode = (hashCode * 59) + this.CodeDepartement.GetHashCode();
                }
                if (this.LibelleDepartement != null)
                {
                    hashCode = (hashCode * 59) + this.LibelleDepartement.GetHashCode();
                }
                if (this.CodeCommune != null)
                {
                    hashCode = (hashCode * 59) + this.CodeCommune.GetHashCode();
                }
                if (this.LibelleCommune != null)
                {
                    hashCode = (hashCode * 59) + this.LibelleCommune.GetHashCode();
                }
                if (this.CodeRegion != null)
                {
                    hashCode = (hashCode * 59) + this.CodeRegion.GetHashCode();
                }
                if (this.LibelleRegion != null)
                {
                    hashCode = (hashCode * 59) + this.LibelleRegion.GetHashCode();
                }
                if (this.CodeBassin != null)
                {
                    hashCode = (hashCode * 59) + this.CodeBassin.GetHashCode();
                }
                if (this.LibelleBassin != null)
                {
                    hashCode = (hashCode * 59) + this.LibelleBassin.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.CoordonneeXStation.GetHashCode();
                hashCode = (hashCode * 59) + this.CoordonneeYStation.GetHashCode();
                if (this.CodeProjectionStation != null)
                {
                    hashCode = (hashCode * 59) + this.CodeProjectionStation.GetHashCode();
                }
                if (this.LibelleProjectionStation != null)
                {
                    hashCode = (hashCode * 59) + this.LibelleProjectionStation.GetHashCode();
                }
                if (this.CodeCoursEau != null)
                {
                    hashCode = (hashCode * 59) + this.CodeCoursEau.GetHashCode();
                }
                if (this.LibelleCoursEau != null)
                {
                    hashCode = (hashCode * 59) + this.LibelleCoursEau.GetHashCode();
                }
                if (this.UriCoursEau != null)
                {
                    hashCode = (hashCode * 59) + this.UriCoursEau.GetHashCode();
                }
                if (this.CodeCampagne != null)
                {
                    hashCode = (hashCode * 59) + this.CodeCampagne.GetHashCode();
                }
                if (this.CodeReseau != null)
                {
                    hashCode = (hashCode * 59) + this.CodeReseau.GetHashCode();
                }
                if (this.LibelleReseau != null)
                {
                    hashCode = (hashCode * 59) + this.LibelleReseau.GetHashCode();
                }
                if (this.UriReseau != null)
                {
                    hashCode = (hashCode * 59) + this.UriReseau.GetHashCode();
                }
                if (this.DateObservation != null)
                {
                    hashCode = (hashCode * 59) + this.DateObservation.GetHashCode();
                }
                if (this.CodeEcoulement != null)
                {
                    hashCode = (hashCode * 59) + this.CodeEcoulement.GetHashCode();
                }
                if (this.LibelleEcoulement != null)
                {
                    hashCode = (hashCode * 59) + this.LibelleEcoulement.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Latitude.GetHashCode();
                hashCode = (hashCode * 59) + this.Longitude.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
