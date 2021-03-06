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
    /// More information around the product (only available since the v2.0 in the Enterprise Edition)
    /// </summary>
    [DataContract]
    public partial class Apirestv1productsMetadata : IEquatable<Apirestv1productsMetadata>
    { 
        /// <summary>
        /// Status of the product regarding the user permissions (only available since the v2.0 in the Enterprise Edition)
        /// </summary>
        /// <value>Status of the product regarding the user permissions (only available since the v2.0 in the Enterprise Edition)</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum WorkflowStatusEnum
        {
            
            /// <summary>
            /// Enum ReadOnlyEnum for read_only
            /// </summary>
            [EnumMember(Value = "read_only")]
            ReadOnlyEnum = 1,
            
            /// <summary>
            /// Enum DraftInProgressEnum for draft_in_progress
            /// </summary>
            [EnumMember(Value = "draft_in_progress")]
            DraftInProgressEnum = 2,
            
            /// <summary>
            /// Enum ProposalWaitingForApprovalEnum for proposal_waiting_for_approval
            /// </summary>
            [EnumMember(Value = "proposal_waiting_for_approval")]
            ProposalWaitingForApprovalEnum = 3,
            
            /// <summary>
            /// Enum WorkingCopyEnum for working_copy
            /// </summary>
            [EnumMember(Value = "working_copy")]
            WorkingCopyEnum = 4
        }

        /// <summary>
        /// Status of the product regarding the user permissions (only available since the v2.0 in the Enterprise Edition)
        /// </summary>
        /// <value>Status of the product regarding the user permissions (only available since the v2.0 in the Enterprise Edition)</value>
        [DataMember(Name="workflow_status")]
        public WorkflowStatusEnum? WorkflowStatus { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Apirestv1productsMetadata {\n");
            sb.Append("  WorkflowStatus: ").Append(WorkflowStatus).Append("\n");
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
            return obj.GetType() == GetType() && Equals((Apirestv1productsMetadata)obj);
        }

        /// <summary>
        /// Returns true if Apirestv1productsMetadata instances are equal
        /// </summary>
        /// <param name="other">Instance of Apirestv1productsMetadata to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Apirestv1productsMetadata other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    WorkflowStatus == other.WorkflowStatus ||
                    WorkflowStatus != null &&
                    WorkflowStatus.Equals(other.WorkflowStatus)
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
                    if (WorkflowStatus != null)
                    hashCode = hashCode * 59 + WorkflowStatus.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(Apirestv1productsMetadata left, Apirestv1productsMetadata right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Apirestv1productsMetadata left, Apirestv1productsMetadata right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
