// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Security.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Regulatory compliance assessment details and state
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class RegulatoryComplianceAssessment : Resource
    {
        /// <summary>
        /// Initializes a new instance of the RegulatoryComplianceAssessment
        /// class.
        /// </summary>
        public RegulatoryComplianceAssessment()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the RegulatoryComplianceAssessment
        /// class.
        /// </summary>
        /// <param name="id">Resource Id</param>
        /// <param name="name">Resource name</param>
        /// <param name="type">Resource type</param>
        /// <param name="description">The description of the regulatory
        /// compliance assessment</param>
        /// <param name="assessmentType">The expected type of assessment
        /// contained in the AssessmentDetailsLink</param>
        /// <param name="assessmentDetailsLink">Link to more detailed
        /// assessment results data. The response type will be according to the
        /// assessmentType field</param>
        /// <param name="state">Aggregative state based on the assessment's
        /// scanned resources states. Possible values include: 'Passed',
        /// 'Failed', 'Skipped', 'Unsupported'</param>
        /// <param name="passedResources">The given assessment's related
        /// resources count with passed state.</param>
        /// <param name="failedResources">The given assessment's related
        /// resources count with failed state.</param>
        /// <param name="skippedResources">The given assessment's related
        /// resources count with skipped state.</param>
        /// <param name="unsupportedResources">The given assessment's related
        /// resources count with unsupported state.</param>
        public RegulatoryComplianceAssessment(string id = default(string), string name = default(string), string type = default(string), string description = default(string), string assessmentType = default(string), string assessmentDetailsLink = default(string), string state = default(string), int? passedResources = default(int?), int? failedResources = default(int?), int? skippedResources = default(int?), int? unsupportedResources = default(int?))
            : base(id, name, type)
        {
            Description = description;
            AssessmentType = assessmentType;
            AssessmentDetailsLink = assessmentDetailsLink;
            State = state;
            PassedResources = passedResources;
            FailedResources = failedResources;
            SkippedResources = skippedResources;
            UnsupportedResources = unsupportedResources;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the description of the regulatory compliance assessment
        /// </summary>
        [JsonProperty(PropertyName = "properties.description")]
        public string Description { get; private set; }

        /// <summary>
        /// Gets the expected type of assessment contained in the
        /// AssessmentDetailsLink
        /// </summary>
        [JsonProperty(PropertyName = "properties.assessmentType")]
        public string AssessmentType { get; private set; }

        /// <summary>
        /// Gets link to more detailed assessment results data. The response
        /// type will be according to the assessmentType field
        /// </summary>
        [JsonProperty(PropertyName = "properties.assessmentDetailsLink")]
        public string AssessmentDetailsLink { get; private set; }

        /// <summary>
        /// Gets or sets aggregative state based on the assessment's scanned
        /// resources states. Possible values include: 'Passed', 'Failed',
        /// 'Skipped', 'Unsupported'
        /// </summary>
        [JsonProperty(PropertyName = "properties.state")]
        public string State { get; set; }

        /// <summary>
        /// Gets the given assessment's related resources count with passed
        /// state.
        /// </summary>
        [JsonProperty(PropertyName = "properties.passedResources")]
        public int? PassedResources { get; private set; }

        /// <summary>
        /// Gets the given assessment's related resources count with failed
        /// state.
        /// </summary>
        [JsonProperty(PropertyName = "properties.failedResources")]
        public int? FailedResources { get; private set; }

        /// <summary>
        /// Gets the given assessment's related resources count with skipped
        /// state.
        /// </summary>
        [JsonProperty(PropertyName = "properties.skippedResources")]
        public int? SkippedResources { get; private set; }

        /// <summary>
        /// Gets the given assessment's related resources count with
        /// unsupported state.
        /// </summary>
        [JsonProperty(PropertyName = "properties.unsupportedResources")]
        public int? UnsupportedResources { get; private set; }

    }
}
