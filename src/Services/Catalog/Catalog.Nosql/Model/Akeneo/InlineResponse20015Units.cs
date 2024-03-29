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
    public partial class InlineResponse20015Units : IEquatable<InlineResponse20015Units>
    { 
        /// <summary>
        /// Measure code
        /// </summary>
        /// <value>Measure code</value>
        [DataMember(Name="code")]
        public string Code { get; set; }

        /// <summary>
        /// Mathematic operation to convert the unit into the standard unit
        /// </summary>
        /// <value>Mathematic operation to convert the unit into the standard unit</value>
        [DataMember(Name="convert")]
        public Object Convert { get; set; }

        /// <summary>
        /// Measure symbol
        /// </summary>
        /// <value>Measure symbol</value>
        [DataMember(Name="symbol")]
        public string Symbol { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InlineResponse20015Units {\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Convert: ").Append(Convert).Append("\n");
            sb.Append("  Symbol: ").Append(Symbol).Append("\n");
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
            return obj.GetType() == GetType() && Equals((InlineResponse20015Units)obj);
        }

        /// <summary>
        /// Returns true if InlineResponse20015Units instances are equal
        /// </summary>
        /// <param name="other">Instance of InlineResponse20015Units to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineResponse20015Units other)
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
                    Convert == other.Convert ||
                    Convert != null &&
                    Convert.Equals(other.Convert)
                ) && 
                (
                    Symbol == other.Symbol ||
                    Symbol != null &&
                    Symbol.Equals(other.Symbol)
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
                    if (Convert != null)
                    hashCode = hashCode * 59 + Convert.GetHashCode();
                    if (Symbol != null)
                    hashCode = hashCode * 59 + Symbol.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(InlineResponse20015Units left, InlineResponse20015Units right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(InlineResponse20015Units left, InlineResponse20015Units right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
