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
    /// Campagne
    /// </summary>
    [DataContract(Name = "Campagne")]
    public partial class Campagne : IEquatable<Campagne>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Campagne" /> class.
        /// </summary>
        /// <param name="codeCampagne">codeCampagne.</param>
        /// <param name="dateCampagne">dateCampagne.</param>
        /// <param name="nombreModaliteEcoulement">nombreModaliteEcoulement.</param>
        /// <param name="codeTypeCampagne">codeTypeCampagne.</param>
        /// <param name="libelleTypeCampagne">libelleTypeCampagne.</param>
        /// <param name="codeReseau">codeReseau.</param>
        /// <param name="libelleReseau">libelleReseau.</param>
        /// <param name="uriReseau">uriReseau.</param>
        /// <param name="codeDepartement">codeDepartement.</param>
        /// <param name="libelleDepartement">libelleDepartement.</param>
        public Campagne(int codeCampagne = default(int), DateTime dateCampagne = default(DateTime), int nombreModaliteEcoulement = default(int), int codeTypeCampagne = default(int), string libelleTypeCampagne = default(string), string codeReseau = default(string), string libelleReseau = default(string), string uriReseau = default(string), string codeDepartement = default(string), string libelleDepartement = default(string))
        {
            this.CodeCampagne = codeCampagne;
            this.DateCampagne = dateCampagne;
            this.NombreModaliteEcoulement = nombreModaliteEcoulement;
            this.CodeTypeCampagne = codeTypeCampagne;
            this.LibelleTypeCampagne = libelleTypeCampagne;
            this.CodeReseau = codeReseau;
            this.LibelleReseau = libelleReseau;
            this.UriReseau = uriReseau;
            this.CodeDepartement = codeDepartement;
            this.LibelleDepartement = libelleDepartement;
        }

        /// <summary>
        /// Gets or Sets CodeCampagne
        /// </summary>
        [DataMember(Name = "code_campagne", EmitDefaultValue = false)]
        public int CodeCampagne { get; set; }

        /// <summary>
        /// Gets or Sets DateCampagne
        /// </summary>
        [DataMember(Name = "date_campagne", EmitDefaultValue = false)]
        public DateTime DateCampagne { get; set; }

        /// <summary>
        /// Gets or Sets NombreModaliteEcoulement
        /// </summary>
        [DataMember(Name = "nombre_modalite_ecoulement", EmitDefaultValue = false)]
        public int NombreModaliteEcoulement { get; set; }

        /// <summary>
        /// Gets or Sets CodeTypeCampagne
        /// </summary>
        [DataMember(Name = "code_type_campagne", EmitDefaultValue = false)]
        public int CodeTypeCampagne { get; set; }

        /// <summary>
        /// Gets or Sets LibelleTypeCampagne
        /// </summary>
        [DataMember(Name = "libelle_type_campagne", EmitDefaultValue = false)]
        public string LibelleTypeCampagne { get; set; }

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
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Campagne {\n");
            sb.Append("  CodeCampagne: ").Append(CodeCampagne).Append("\n");
            sb.Append("  DateCampagne: ").Append(DateCampagne).Append("\n");
            sb.Append("  NombreModaliteEcoulement: ").Append(NombreModaliteEcoulement).Append("\n");
            sb.Append("  CodeTypeCampagne: ").Append(CodeTypeCampagne).Append("\n");
            sb.Append("  LibelleTypeCampagne: ").Append(LibelleTypeCampagne).Append("\n");
            sb.Append("  CodeReseau: ").Append(CodeReseau).Append("\n");
            sb.Append("  LibelleReseau: ").Append(LibelleReseau).Append("\n");
            sb.Append("  UriReseau: ").Append(UriReseau).Append("\n");
            sb.Append("  CodeDepartement: ").Append(CodeDepartement).Append("\n");
            sb.Append("  LibelleDepartement: ").Append(LibelleDepartement).Append("\n");
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
            return this.Equals(input as Campagne);
        }

        /// <summary>
        /// Returns true if Campagne instances are equal
        /// </summary>
        /// <param name="input">Instance of Campagne to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Campagne input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CodeCampagne == input.CodeCampagne ||
                    this.CodeCampagne.Equals(input.CodeCampagne)
                ) && 
                (
                    this.DateCampagne == input.DateCampagne ||
                    (this.DateCampagne != null &&
                    this.DateCampagne.Equals(input.DateCampagne))
                ) && 
                (
                    this.NombreModaliteEcoulement == input.NombreModaliteEcoulement ||
                    this.NombreModaliteEcoulement.Equals(input.NombreModaliteEcoulement)
                ) && 
                (
                    this.CodeTypeCampagne == input.CodeTypeCampagne ||
                    this.CodeTypeCampagne.Equals(input.CodeTypeCampagne)
                ) && 
                (
                    this.LibelleTypeCampagne == input.LibelleTypeCampagne ||
                    (this.LibelleTypeCampagne != null &&
                    this.LibelleTypeCampagne.Equals(input.LibelleTypeCampagne))
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
                    this.CodeDepartement == input.CodeDepartement ||
                    (this.CodeDepartement != null &&
                    this.CodeDepartement.Equals(input.CodeDepartement))
                ) && 
                (
                    this.LibelleDepartement == input.LibelleDepartement ||
                    (this.LibelleDepartement != null &&
                    this.LibelleDepartement.Equals(input.LibelleDepartement))
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
                hashCode = (hashCode * 59) + this.CodeCampagne.GetHashCode();
                if (this.DateCampagne != null)
                {
                    hashCode = (hashCode * 59) + this.DateCampagne.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.NombreModaliteEcoulement.GetHashCode();
                hashCode = (hashCode * 59) + this.CodeTypeCampagne.GetHashCode();
                if (this.LibelleTypeCampagne != null)
                {
                    hashCode = (hashCode * 59) + this.LibelleTypeCampagne.GetHashCode();
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
                if (this.CodeDepartement != null)
                {
                    hashCode = (hashCode * 59) + this.CodeDepartement.GetHashCode();
                }
                if (this.LibelleDepartement != null)
                {
                    hashCode = (hashCode * 59) + this.LibelleDepartement.GetHashCode();
                }
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
