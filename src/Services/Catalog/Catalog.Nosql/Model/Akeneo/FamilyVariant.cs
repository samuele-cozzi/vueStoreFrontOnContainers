/*
 * Akeneo PIM API
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: 1.0.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Catalog.Nosql.Model.Akeneo
{ 
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public partial class FamilyVariant : IEquatable<FamilyVariant>
    { 
        /// <summary>
        /// Family variant code
        /// </summary>
        /// <value>Family variant code</value>
        [Required]
        [DataMember(Name="code")]
        public string Code { get; set; }

        /// <summary>
        /// Attributes distribution according to the enrichment level
        /// </summary>
        /// <value>Attributes distribution according to the enrichment level</value>
        [Required]
        [DataMember(Name="variant_attribute_sets")]
        public List<Apirestv1familiesfamilyCodevariantsVariantAttributeSets> VariantAttributeSets { get; set; }

        /// <summary>
        /// Gets or Sets Labels
        /// </summary>
        [DataMember(Name="labels")]
        public Apirestv1familiesfamilyCodevariantsLabels Labels { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FamilyVariant {\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  VariantAttributeSets: ").Append(VariantAttributeSets).Append("\n");
            sb.Append("  Labels: ").Append(Labels).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj.GetType() == GetType() && Equals((FamilyVariant)obj);
        }

        /// <summary>
        /// Returns true if FamilyVariant instances are equal
        /// </summary>
        /// <param name="other">Instance of FamilyVariant to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FamilyVariant other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Code == other.Code ||
                    Code != null &&
                    Code.Equals(other.Code)
                ) && 
                (
                    VariantAttributeSets == other.VariantAttributeSets ||
                    VariantAttributeSets != null &&
                    VariantAttributeSets.SequenceEqual(other.VariantAttributeSets)
                ) && 
                (
                    Labels == other.Labels ||
                    Labels != null &&
                    Labels.Equals(other.Labels)
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
                var hashCode = 41;
                // Suitable nullity checks etc, of course :)
                    if (Code != null)
                    hashCode = hashCode * 59 + Code.GetHashCode();
                    if (VariantAttributeSets != null)
                    hashCode = hashCode * 59 + VariantAttributeSets.GetHashCode();
                    if (Labels != null)
                    hashCode = hashCode * 59 + Labels.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(FamilyVariant left, FamilyVariant right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(FamilyVariant left, FamilyVariant right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
