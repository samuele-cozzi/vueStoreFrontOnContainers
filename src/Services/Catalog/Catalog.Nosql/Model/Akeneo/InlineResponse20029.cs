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
    public partial class InlineResponse20029 : IEquatable<InlineResponse20029>
    { 
        /// <summary>
        /// Authentication token that should be given in every authenticated request to the API
        /// </summary>
        /// <value>Authentication token that should be given in every authenticated request to the API</value>
        [DataMember(Name="access_token")]
        public string AccessToken { get; set; }

        /// <summary>
        /// Validity of the token given in seconds, 3600s &#x3D; 1h by default
        /// </summary>
        /// <value>Validity of the token given in seconds, 3600s &#x3D; 1h by default</value>
        [DataMember(Name="expires_in")]
        public int? ExpiresIn { get; set; }

        /// <summary>
        /// Token type, always equal to \&quot;bearer\&quot;
        /// </summary>
        /// <value>Token type, always equal to \&quot;bearer\&quot;</value>
        [DataMember(Name="token_type")]
        public string TokenType { get; set; }

        /// <summary>
        /// Unused, always equal to \&quot;null\&quot;
        /// </summary>
        /// <value>Unused, always equal to \&quot;null\&quot;</value>
        [DataMember(Name="scope")]
        public string Scope { get; set; }

        /// <summary>
        /// Use this token when your access token has expired. See &lt;a href&#x3D;\&quot;/documentation/security.html#refresh-an-expired-token\&quot;&gt;Refresh an expired token&lt;/a&gt; section for more details.
        /// </summary>
        /// <value>Use this token when your access token has expired. See &lt;a href&#x3D;\&quot;/documentation/security.html#refresh-an-expired-token\&quot;&gt;Refresh an expired token&lt;/a&gt; section for more details.</value>
        [DataMember(Name="refresh_token")]
        public string RefreshToken { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InlineResponse20029 {\n");
            sb.Append("  AccessToken: ").Append(AccessToken).Append("\n");
            sb.Append("  ExpiresIn: ").Append(ExpiresIn).Append("\n");
            sb.Append("  TokenType: ").Append(TokenType).Append("\n");
            sb.Append("  Scope: ").Append(Scope).Append("\n");
            sb.Append("  RefreshToken: ").Append(RefreshToken).Append("\n");
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
            return obj.GetType() == GetType() && Equals((InlineResponse20029)obj);
        }

        /// <summary>
        /// Returns true if InlineResponse20029 instances are equal
        /// </summary>
        /// <param name="other">Instance of InlineResponse20029 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineResponse20029 other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    AccessToken == other.AccessToken ||
                    AccessToken != null &&
                    AccessToken.Equals(other.AccessToken)
                ) && 
                (
                    ExpiresIn == other.ExpiresIn ||
                    ExpiresIn != null &&
                    ExpiresIn.Equals(other.ExpiresIn)
                ) && 
                (
                    TokenType == other.TokenType ||
                    TokenType != null &&
                    TokenType.Equals(other.TokenType)
                ) && 
                (
                    Scope == other.Scope ||
                    Scope != null &&
                    Scope.Equals(other.Scope)
                ) && 
                (
                    RefreshToken == other.RefreshToken ||
                    RefreshToken != null &&
                    RefreshToken.Equals(other.RefreshToken)
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
                    if (AccessToken != null)
                    hashCode = hashCode * 59 + AccessToken.GetHashCode();
                    if (ExpiresIn != null)
                    hashCode = hashCode * 59 + ExpiresIn.GetHashCode();
                    if (TokenType != null)
                    hashCode = hashCode * 59 + TokenType.GetHashCode();
                    if (Scope != null)
                    hashCode = hashCode * 59 + Scope.GetHashCode();
                    if (RefreshToken != null)
                    hashCode = hashCode * 59 + RefreshToken.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(InlineResponse20029 left, InlineResponse20029 right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(InlineResponse20029 left, InlineResponse20029 right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
