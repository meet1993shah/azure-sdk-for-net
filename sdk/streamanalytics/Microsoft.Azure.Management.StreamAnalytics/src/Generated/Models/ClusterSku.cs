// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.StreamAnalytics.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The SKU of the cluster. This determines the size/capacity of the
    /// cluster. Required on PUT (CreateOrUpdate) requests.
    /// </summary>
    public partial class ClusterSku
    {
        /// <summary>
        /// Initializes a new instance of the ClusterSku class.
        /// </summary>
        public ClusterSku()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ClusterSku class.
        /// </summary>
        /// <param name="name">Specifies the SKU name of the cluster. Required
        /// on PUT (CreateOrUpdate) requests. Possible values include:
        /// 'Default'</param>
        /// <param name="capacity">Denotes the number of streaming units the
        /// cluster can support. Valid values for this property are multiples
        /// of 36 with a minimum value of 36 and maximum value of 216. Required
        /// on PUT (CreateOrUpdate) requests.</param>
        public ClusterSku(string name = default(string), int? capacity = default(int?))
        {
            Name = name;
            Capacity = capacity;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets specifies the SKU name of the cluster. Required on PUT
        /// (CreateOrUpdate) requests. Possible values include: 'Default'
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets denotes the number of streaming units the cluster can
        /// support. Valid values for this property are multiples of 36 with a
        /// minimum value of 36 and maximum value of 216. Required on PUT
        /// (CreateOrUpdate) requests.
        /// </summary>
        [JsonProperty(PropertyName = "capacity")]
        public int? Capacity { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Capacity > 216)
            {
                throw new ValidationException(ValidationRules.InclusiveMaximum, "Capacity", 216);
            }
            if (Capacity < 36)
            {
                throw new ValidationException(ValidationRules.InclusiveMinimum, "Capacity", 36);
            }
        }
    }
}
