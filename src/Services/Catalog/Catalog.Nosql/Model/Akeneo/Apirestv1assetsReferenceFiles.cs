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
    public partial class Apirestv1assetsReferenceFiles : IEquatable<Apirestv1assetsReferenceFiles>
    { 
        /// <summary>
        /// Gets or Sets Link
        /// </summary>
        [DataMember(Name="_link")]
        public Apirestv1assetsLink1 Link { get; set; }

        /// <summary>
        /// Locale code of the reference file
        /// </summary>
        /// <value>Locale code of the reference file</value>
        [DataMember(Name="locale")]
        public string Locale { get; set; }

        /// <summary>
        /// Code of the reference file
        /// </summary>
        /// <value>Code of the reference file</value>
        [DataMember(Name="code")]
        public string Code { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Apirestv1assetsReferenceFiles {\n");
            sb.Append("  Link: ").Append(Link).Append("\n");
            sb.Append("  Locale: ").Append(Locale).Append("\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
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
            return obj.GetType() == GetType() && Equals((Apirestv1assetsReferenceFiles)obj);
        }

        /// <summary>
        /// Returns true if Apirestv1assetsReferenceFiles instances are equal
        /// </summary>
        /// <param name="other">Instance of Apirestv1assetsReferenceFiles to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Apirestv1assetsReferenceFiles other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Link == other.Link ||
                    Link != null &&
                    Link.Equals(other.Link)
                ) && 
                (
                    Locale == other.Locale ||
                    Locale != null &&
                    Locale.Equals(other.Locale)
                ) && 
                (
                    Code == other.Code ||
                    Code != null &&
                    Code.Equals(other.Code)
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
                    if (Link != null)
                    hashCode = hashCode * 59 + Link.GetHashCode();
                    if (Locale != null)
                    hashCode = hashCode * 59 + Locale.GetHashCode();
                    if (Code != null)
                    hashCode = hashCode * 59 + Code.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(Apirestv1assetsReferenceFiles left, Apirestv1assetsReferenceFiles right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Apirestv1assetsReferenceFiles left, Apirestv1assetsReferenceFiles right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
