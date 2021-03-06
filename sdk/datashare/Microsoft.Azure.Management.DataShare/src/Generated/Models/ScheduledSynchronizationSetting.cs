// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataShare.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// A type of synchronization setting based on schedule
    /// </summary>
    [Newtonsoft.Json.JsonObject("ScheduleBased")]
    [Rest.Serialization.JsonTransformation]
    public partial class ScheduledSynchronizationSetting : SynchronizationSetting
    {
        /// <summary>
        /// Initializes a new instance of the ScheduledSynchronizationSetting
        /// class.
        /// </summary>
        public ScheduledSynchronizationSetting()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ScheduledSynchronizationSetting
        /// class.
        /// </summary>
        /// <param name="recurrenceInterval">Recurrence Interval. Possible
        /// values include: 'Hour', 'Day'</param>
        /// <param name="synchronizationTime">Synchronization time</param>
        /// <param name="id">The resource id of the azure resource</param>
        /// <param name="name">Name of the azure resource</param>
        /// <param name="type">Type of the azure resource</param>
        /// <param name="createdAt">Time at which the synchronization setting
        /// was created.</param>
        /// <param name="provisioningState">Gets or sets the provisioning
        /// state. Possible values include: 'Succeeded', 'Creating',
        /// 'Deleting', 'Moving', 'Failed'</param>
        /// <param name="userName">Name of the user who created the
        /// synchronization setting.</param>
        public ScheduledSynchronizationSetting(string recurrenceInterval, System.DateTime synchronizationTime, string id = default(string), string name = default(string), string type = default(string), System.DateTime? createdAt = default(System.DateTime?), string provisioningState = default(string), string userName = default(string))
            : base(id, name, type)
        {
            CreatedAt = createdAt;
            ProvisioningState = provisioningState;
            RecurrenceInterval = recurrenceInterval;
            SynchronizationTime = synchronizationTime;
            UserName = userName;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets time at which the synchronization setting was created.
        /// </summary>
        [JsonProperty(PropertyName = "properties.createdAt")]
        public System.DateTime? CreatedAt { get; private set; }

        /// <summary>
        /// Gets or sets the provisioning state. Possible values include:
        /// 'Succeeded', 'Creating', 'Deleting', 'Moving', 'Failed'
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// Gets or sets recurrence Interval. Possible values include: 'Hour',
        /// 'Day'
        /// </summary>
        [JsonProperty(PropertyName = "properties.recurrenceInterval")]
        public string RecurrenceInterval { get; set; }

        /// <summary>
        /// Gets or sets synchronization time
        /// </summary>
        [JsonProperty(PropertyName = "properties.synchronizationTime")]
        public System.DateTime SynchronizationTime { get; set; }

        /// <summary>
        /// Gets name of the user who created the synchronization setting.
        /// </summary>
        [JsonProperty(PropertyName = "properties.userName")]
        public string UserName { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (RecurrenceInterval == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "RecurrenceInterval");
            }
        }
    }
}
