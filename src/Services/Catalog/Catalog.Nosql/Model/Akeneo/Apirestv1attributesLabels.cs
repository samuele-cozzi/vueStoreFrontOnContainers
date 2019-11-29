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
    /// Attribute labels for each locale
    /// </summary>
    [DataContract]
    public partial class Apirestv1attributesLabels : IEquatable<Apirestv1attributesLabels>
    { 
        /// <summary>
        /// Attribute label for the locale &#x60;localeCode&#x60;
        /// </summary>
        /// <value>Attribute label for the locale &#x60;localeCode&#x60;</value>
        [DataMember(Name="localeCode")]
        public string LocaleCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Apirestv1attributesLabels {\n");
            sb.Append("  LocaleCode: ").Append(LocaleCode).Append("\n");
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
            return obj.GetType() == GetType() && Equals((Apirestv1attributesLabels)obj);
        }

        /// <summary>
        /// Returns true if Apirestv1attributesLabels instances are equal
        /// </summary>
        /// <param name="other">Instance of Apirestv1attributesLabels to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Apirestv1attributesLabels other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    LocaleCode == other.LocaleCode ||
                    LocaleCode != null &&
                    LocaleCode.Equals(other.LocaleCode)
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
                    if (LocaleCode != null)
                    hashCode = hashCode * 59 + LocaleCode.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(Apirestv1attributesLabels left, Apirestv1attributesLabels right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Apirestv1attributesLabels left, Apirestv1attributesLabels right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
