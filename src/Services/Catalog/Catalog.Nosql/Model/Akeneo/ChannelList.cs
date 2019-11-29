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
    public partial class ChannelList : IEquatable<ChannelList>
    { 
        /// <summary>
        /// Channel code
        /// </summary>
        /// <value>Channel code</value>
        [Required]
        [DataMember(Name="code")]
        public string Code { get; set; }

        /// <summary>
        /// Codes of activated locales for the channel
        /// </summary>
        /// <value>Codes of activated locales for the channel</value>
        [Required]
        [DataMember(Name="locales")]
        public List<string> Locales { get; set; }

        /// <summary>
        /// Codes of activated currencies for the channel
        /// </summary>
        /// <value>Codes of activated currencies for the channel</value>
        [Required]
        [DataMember(Name="currencies")]
        public List<string> Currencies { get; set; }

        /// <summary>
        /// Code of the category tree linked to the channel
        /// </summary>
        /// <value>Code of the category tree linked to the channel</value>
        [Required]
        [DataMember(Name="category_tree")]
        public string CategoryTree { get; set; }

        /// <summary>
        /// Gets or Sets ConversionUnits
        /// </summary>
        [DataMember(Name="conversion_units")]
        public Apirestv1channelsConversionUnits ConversionUnits { get; set; }

        /// <summary>
        /// Gets or Sets Labels
        /// </summary>
        [DataMember(Name="labels")]
        public Apirestv1channelsLabels Labels { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ChannelList {\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Locales: ").Append(Locales).Append("\n");
            sb.Append("  Currencies: ").Append(Currencies).Append("\n");
            sb.Append("  CategoryTree: ").Append(CategoryTree).Append("\n");
            sb.Append("  ConversionUnits: ").Append(ConversionUnits).Append("\n");
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
            return obj.GetType() == GetType() && Equals((ChannelList)obj);
        }

        /// <summary>
        /// Returns true if ChannelList instances are equal
        /// </summary>
        /// <param name="other">Instance of ChannelList to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ChannelList other)
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
                    Locales == other.Locales ||
                    Locales != null &&
                    Locales.SequenceEqual(other.Locales)
                ) && 
                (
                    Currencies == other.Currencies ||
                    Currencies != null &&
                    Currencies.SequenceEqual(other.Currencies)
                ) && 
                (
                    CategoryTree == other.CategoryTree ||
                    CategoryTree != null &&
                    CategoryTree.Equals(other.CategoryTree)
                ) && 
                (
                    ConversionUnits == other.ConversionUnits ||
                    ConversionUnits != null &&
                    ConversionUnits.Equals(other.ConversionUnits)
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
                    if (Locales != null)
                    hashCode = hashCode * 59 + Locales.GetHashCode();
                    if (Currencies != null)
                    hashCode = hashCode * 59 + Currencies.GetHashCode();
                    if (CategoryTree != null)
                    hashCode = hashCode * 59 + CategoryTree.GetHashCode();
                    if (ConversionUnits != null)
                    hashCode = hashCode * 59 + ConversionUnits.GetHashCode();
                    if (Labels != null)
                    hashCode = hashCode * 59 + Labels.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(ChannelList left, ChannelList right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(ChannelList left, ChannelList right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
