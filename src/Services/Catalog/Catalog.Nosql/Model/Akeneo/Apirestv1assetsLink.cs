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
    /// Links to get and download the variation file
    /// </summary>
    [DataContract]
    public partial class Apirestv1assetsLink : IEquatable<Apirestv1assetsLink>
    { 
        /// <summary>
        /// Gets or Sets Self
        /// </summary>
        [DataMember(Name="self")]
        public Apirestv1assetsLinkSelf Self { get; set; }

        /// <summary>
        /// Gets or Sets Download
        /// </summary>
        [DataMember(Name="download")]
        public Apirestv1assetsLinkDownload Download { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Apirestv1assetsLink {\n");
            sb.Append("  Self: ").Append(Self).Append("\n");
            sb.Append("  Download: ").Append(Download).Append("\n");
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
            return obj.GetType() == GetType() && Equals((Apirestv1assetsLink)obj);
        }

        /// <summary>
        /// Returns true if Apirestv1assetsLink instances are equal
        /// </summary>
        /// <param name="other">Instance of Apirestv1assetsLink to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Apirestv1assetsLink other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Self == other.Self ||
                    Self != null &&
                    Self.Equals(other.Self)
                ) && 
                (
                    Download == other.Download ||
                    Download != null &&
                    Download.Equals(other.Download)
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
                    if (Self != null)
                    hashCode = hashCode * 59 + Self.GetHashCode();
                    if (Download != null)
                    hashCode = hashCode * 59 + Download.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(Apirestv1assetsLink left, Apirestv1assetsLink right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Apirestv1assetsLink left, Apirestv1assetsLink right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
