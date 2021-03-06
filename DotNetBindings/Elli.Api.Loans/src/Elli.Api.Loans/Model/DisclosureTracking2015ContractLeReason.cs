/*
* Copyright 2017 Ellie Mae, Inc.
*
* Redistribution and use in source and binary forms, with or without
* modification, are permitted provided that the following conditions are met:
*
*  1. Redistributions of source code must retain the above copyright notice,
*     this list of conditions and the following disclaimer.
*
*  2. Redistributions in binary form must reproduce the above copyright notice,
*     this list of conditions and the following disclaimer in the documentation
*     and/or other materials provided with the distribution.
*
*  3. Neither the name of the copyright holder nor the names of its
*     contributors may be used to endorse or promote products derived from this
*     software without specific prior written permission.
*
* THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS"
* AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE
* IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE
* ARE DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT HOLDER OR CONTRIBUTORS BE
* LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR
* CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF
* SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS
* INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN
* CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE)
* ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE
* POSSIBILITY OF SUCH DAMAGE.
*/


/* 
 * Loan
 *
 * Returns the entire loan or specific entities of a loan.
 *
 * OpenAPI spec version: 1.4.1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = Elli.Api.Loans.Client.SwaggerDateConverter;

namespace Elli.Api.Loans.Model
{
    /// <summary>
    /// DisclosureTracking2015ContractLeReason
    /// </summary>
    [DataContract]
    public partial class DisclosureTracking2015ContractLeReason :  IEquatable<DisclosureTracking2015ContractLeReason>, IValidatableObject
    {
    
        
        /// <summary>
        /// Gets or Sets IsChangedCircumstanceSettlementCharges
        /// </summary>
        [DataMember(Name="isChangedCircumstanceSettlementCharges", EmitDefaultValue=false)]
        public bool? IsChangedCircumstanceSettlementCharges { get; set; }

        /// <summary>
        /// Gets or Sets IsChangedCircumstanceEligibility
        /// </summary>
        [DataMember(Name="isChangedCircumstanceEligibility", EmitDefaultValue=false)]
        public bool? IsChangedCircumstanceEligibility { get; set; }

        /// <summary>
        /// Gets or Sets IsRevisionsRequestedByConsumer
        /// </summary>
        [DataMember(Name="isRevisionsRequestedByConsumer", EmitDefaultValue=false)]
        public bool? IsRevisionsRequestedByConsumer { get; set; }

        /// <summary>
        /// Gets or Sets IsInterestRateDependentCharges
        /// </summary>
        [DataMember(Name="isInterestRateDependentCharges", EmitDefaultValue=false)]
        public bool? IsInterestRateDependentCharges { get; set; }

        /// <summary>
        /// Gets or Sets IsExpiration
        /// </summary>
        [DataMember(Name="isExpiration", EmitDefaultValue=false)]
        public bool? IsExpiration { get; set; }

        /// <summary>
        /// Gets or Sets IsDelayedSettlementOnConstructionLoans
        /// </summary>
        [DataMember(Name="isDelayedSettlementOnConstructionLoans", EmitDefaultValue=false)]
        public bool? IsDelayedSettlementOnConstructionLoans { get; set; }

        /// <summary>
        /// Gets or Sets IsOther
        /// </summary>
        [DataMember(Name="isOther", EmitDefaultValue=false)]
        public bool? IsOther { get; set; }

        /// <summary>
        /// Gets or Sets OtherDescription
        /// </summary>
        [DataMember(Name="otherDescription", EmitDefaultValue=false)]
        public string OtherDescription { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DisclosureTracking2015ContractLeReason {\n");
            sb.Append("  IsChangedCircumstanceSettlementCharges: ").Append(IsChangedCircumstanceSettlementCharges).Append("\n");
            sb.Append("  IsChangedCircumstanceEligibility: ").Append(IsChangedCircumstanceEligibility).Append("\n");
            sb.Append("  IsRevisionsRequestedByConsumer: ").Append(IsRevisionsRequestedByConsumer).Append("\n");
            sb.Append("  IsInterestRateDependentCharges: ").Append(IsInterestRateDependentCharges).Append("\n");
            sb.Append("  IsExpiration: ").Append(IsExpiration).Append("\n");
            sb.Append("  IsDelayedSettlementOnConstructionLoans: ").Append(IsDelayedSettlementOnConstructionLoans).Append("\n");
            sb.Append("  IsOther: ").Append(IsOther).Append("\n");
            sb.Append("  OtherDescription: ").Append(OtherDescription).Append("\n");
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
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as DisclosureTracking2015ContractLeReason);
        }

        /// <summary>
        /// Returns true if DisclosureTracking2015ContractLeReason instances are equal
        /// </summary>
        /// <param name="input">Instance of DisclosureTracking2015ContractLeReason to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DisclosureTracking2015ContractLeReason input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IsChangedCircumstanceSettlementCharges == input.IsChangedCircumstanceSettlementCharges ||
                    (this.IsChangedCircumstanceSettlementCharges != null &&
                    this.IsChangedCircumstanceSettlementCharges.Equals(input.IsChangedCircumstanceSettlementCharges))
                ) && 
                (
                    this.IsChangedCircumstanceEligibility == input.IsChangedCircumstanceEligibility ||
                    (this.IsChangedCircumstanceEligibility != null &&
                    this.IsChangedCircumstanceEligibility.Equals(input.IsChangedCircumstanceEligibility))
                ) && 
                (
                    this.IsRevisionsRequestedByConsumer == input.IsRevisionsRequestedByConsumer ||
                    (this.IsRevisionsRequestedByConsumer != null &&
                    this.IsRevisionsRequestedByConsumer.Equals(input.IsRevisionsRequestedByConsumer))
                ) && 
                (
                    this.IsInterestRateDependentCharges == input.IsInterestRateDependentCharges ||
                    (this.IsInterestRateDependentCharges != null &&
                    this.IsInterestRateDependentCharges.Equals(input.IsInterestRateDependentCharges))
                ) && 
                (
                    this.IsExpiration == input.IsExpiration ||
                    (this.IsExpiration != null &&
                    this.IsExpiration.Equals(input.IsExpiration))
                ) && 
                (
                    this.IsDelayedSettlementOnConstructionLoans == input.IsDelayedSettlementOnConstructionLoans ||
                    (this.IsDelayedSettlementOnConstructionLoans != null &&
                    this.IsDelayedSettlementOnConstructionLoans.Equals(input.IsDelayedSettlementOnConstructionLoans))
                ) && 
                (
                    this.IsOther == input.IsOther ||
                    (this.IsOther != null &&
                    this.IsOther.Equals(input.IsOther))
                ) && 
                (
                    this.OtherDescription == input.OtherDescription ||
                    (this.OtherDescription != null &&
                    this.OtherDescription.Equals(input.OtherDescription))
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
                if (this.IsChangedCircumstanceSettlementCharges != null)
                    hashCode = hashCode * 59 + this.IsChangedCircumstanceSettlementCharges.GetHashCode();
                if (this.IsChangedCircumstanceEligibility != null)
                    hashCode = hashCode * 59 + this.IsChangedCircumstanceEligibility.GetHashCode();
                if (this.IsRevisionsRequestedByConsumer != null)
                    hashCode = hashCode * 59 + this.IsRevisionsRequestedByConsumer.GetHashCode();
                if (this.IsInterestRateDependentCharges != null)
                    hashCode = hashCode * 59 + this.IsInterestRateDependentCharges.GetHashCode();
                if (this.IsExpiration != null)
                    hashCode = hashCode * 59 + this.IsExpiration.GetHashCode();
                if (this.IsDelayedSettlementOnConstructionLoans != null)
                    hashCode = hashCode * 59 + this.IsDelayedSettlementOnConstructionLoans.GetHashCode();
                if (this.IsOther != null)
                    hashCode = hashCode * 59 + this.IsOther.GetHashCode();
                if (this.OtherDescription != null)
                    hashCode = hashCode * 59 + this.OtherDescription.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
