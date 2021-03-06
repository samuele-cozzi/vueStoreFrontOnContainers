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
    public partial class InlineResponse20023 : IEquatable<InlineResponse20023>
    { 
        /// <summary>
        /// Asset code
        /// </summary>
        /// <value>Asset code</value>
        [Required]
        [DataMember(Name="code")]
        public string Code { get; set; }

        /// <summary>
        /// Codes of the asset categories in which the asset is classified
        /// </summary>
        /// <value>Codes of the asset categories in which the asset is classified</value>
        [DataMember(Name="categories")]
        public List<string> Categories { get; set; }

        /// <summary>
        /// Description of the asset
        /// </summary>
        /// <value>Description of the asset</value>
        [DataMember(Name="description")]
        public string Description { get; set; }

        /// <summary>
        /// Whether the asset is localized or not, meaning if you want to have different reference files for each of your locale
        /// </summary>
        /// <value>Whether the asset is localized or not, meaning if you want to have different reference files for each of your locale</value>
        [DataMember(Name="localizable")]
        public bool? Localizable { get; set; }

        /// <summary>
        /// Tags of the asset
        /// </summary>
        /// <value>Tags of the asset</value>
        [DataMember(Name="tags")]
        public List<string> Tags { get; set; }

        /// <summary>
        /// Date on which the asset expire
        /// </summary>
        /// <value>Date on which the asset expire</value>
        [DataMember(Name="end_of_use")]
        public string EndOfUse { get; set; }

        /// <summary>
        /// Variations of the asset
        /// </summary>
        /// <value>Variations of the asset</value>
        [DataMember(Name="variation_files")]
        public List<Apirestv1assetsVariationFiles> VariationFiles { get; set; }

        /// <summary>
        /// Reference files of the asset
        /// </summary>
        /// <value>Reference files of the asset</value>
        [DataMember(Name="reference_files")]
        public List<Apirestv1assetsReferenceFiles> ReferenceFiles { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InlineResponse20023 {\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Categories: ").Append(Categories).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Localizable: ").Append(Localizable).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  EndOfUse: ").Append(EndOfUse).Append("\n");
            sb.Append("  VariationFiles: ").Append(VariationFiles).Append("\n");
            sb.Append("  ReferenceFiles: ").Append(ReferenceFiles).Append("\n");
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
            return obj.GetType() == GetType() && Equals((InlineResponse20023)obj);
        }

        /// <summary>
        /// Returns true if InlineResponse20023 instances are equal
        /// </summary>
        /// <param name="other">Instance of InlineResponse20023 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineResponse20023 other)
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
                    Categories == other.Categories ||
                    Categories != null &&
                    Categories.SequenceEqual(other.Categories)
                ) && 
                (
                    Description == other.Description ||
                    Description != null &&
                    Description.Equals(other.Description)
                ) && 
                (
                    Localizable == other.Localizable ||
                    Localizable != null &&
                    Localizable.Equals(other.Localizable)
                ) && 
                (
                    Tags == other.Tags ||
                    Tags != null &&
                    Tags.SequenceEqual(other.Tags)
                ) && 
                (
                    EndOfUse == other.EndOfUse ||
                    EndOfUse != null &&
                    EndOfUse.Equals(other.EndOfUse)
                ) && 
                (
                    VariationFiles == other.VariationFiles ||
                    VariationFiles != null &&
                    VariationFiles.SequenceEqual(other.VariationFiles)
                ) && 
                (
                    ReferenceFiles == other.ReferenceFiles ||
                    ReferenceFiles != null &&
                    ReferenceFiles.SequenceEqual(other.ReferenceFiles)
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
                    if (Categories != null)
                    hashCode = hashCode * 59 + Categories.GetHashCode();
                    if (Description != null)
                    hashCode = hashCode * 59 + Description.GetHashCode();
                    if (Localizable != null)
                    hashCode = hashCode * 59 + Localizable.GetHashCode();
                    if (Tags != null)
                    hashCode = hashCode * 59 + Tags.GetHashCode();
                    if (EndOfUse != null)
                    hashCode = hashCode * 59 + EndOfUse.GetHashCode();
                    if (VariationFiles != null)
                    hashCode = hashCode * 59 + VariationFiles.GetHashCode();
                    if (ReferenceFiles != null)
                    hashCode = hashCode * 59 + ReferenceFiles.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(InlineResponse20023 left, InlineResponse20023 right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(InlineResponse20023 left, InlineResponse20023 right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
