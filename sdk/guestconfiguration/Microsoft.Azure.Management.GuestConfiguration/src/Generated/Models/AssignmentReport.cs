// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.GuestConfiguration.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class AssignmentReport
    {
        /// <summary>
        /// Initializes a new instance of the AssignmentReport class.
        /// </summary>
        public AssignmentReport()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AssignmentReport class.
        /// </summary>
        /// <param name="id">ARM resource id of the report for the guest
        /// configuration assignment.</param>
        /// <param name="reportId">GUID that identifies the guest configuration
        /// assignment report under a subscription, resource group.</param>
        /// <param name="assignment">Configuration details of the guest
        /// configuration assignment.</param>
        /// <param name="vm">Information about the VM.</param>
        /// <param name="startTime">Start date and time of the guest
        /// configuration assignment compliance status check.</param>
        /// <param name="endTime">End date and time of the guest configuration
        /// assignment compliance status check.</param>
        /// <param name="complianceStatus">A value indicating compliance status
        /// of the machine for the assigned guest configuration. Possible
        /// values include: 'Compliant', 'NonCompliant', 'Pending'</param>
        /// <param name="operationType">Type of report, Consistency or Initial.
        /// Possible values include: 'Consistency', 'Initial'</param>
        /// <param name="resources">The list of resources for which guest
        /// configuration assignment compliance is checked.</param>
        public AssignmentReport(string id = default(string), string reportId = default(string), AssignmentInfo assignment = default(AssignmentInfo), VMInfo vm = default(VMInfo), System.DateTime? startTime = default(System.DateTime?), System.DateTime? endTime = default(System.DateTime?), string complianceStatus = default(string), string operationType = default(string), IList<AssignmentReportResource> resources = default(IList<AssignmentReportResource>))
        {
            Id = id;
            ReportId = reportId;
            Assignment = assignment;
            Vm = vm;
            StartTime = startTime;
            EndTime = endTime;
            ComplianceStatus = complianceStatus;
            OperationType = operationType;
            Resources = resources;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets ARM resource id of the report for the guest configuration
        /// assignment.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; private set; }

        /// <summary>
        /// Gets GUID that identifies the guest configuration assignment report
        /// under a subscription, resource group.
        /// </summary>
        [JsonProperty(PropertyName = "reportId")]
        public string ReportId { get; private set; }

        /// <summary>
        /// Gets or sets configuration details of the guest configuration
        /// assignment.
        /// </summary>
        [JsonProperty(PropertyName = "assignment")]
        public AssignmentInfo Assignment { get; set; }

        /// <summary>
        /// Gets or sets information about the VM.
        /// </summary>
        [JsonProperty(PropertyName = "vm")]
        public VMInfo Vm { get; set; }

        /// <summary>
        /// Gets start date and time of the guest configuration assignment
        /// compliance status check.
        /// </summary>
        [JsonProperty(PropertyName = "startTime")]
        public System.DateTime? StartTime { get; private set; }

        /// <summary>
        /// Gets end date and time of the guest configuration assignment
        /// compliance status check.
        /// </summary>
        [JsonProperty(PropertyName = "endTime")]
        public System.DateTime? EndTime { get; private set; }

        /// <summary>
        /// Gets a value indicating compliance status of the machine for the
        /// assigned guest configuration. Possible values include: 'Compliant',
        /// 'NonCompliant', 'Pending'
        /// </summary>
        [JsonProperty(PropertyName = "complianceStatus")]
        public string ComplianceStatus { get; private set; }

        /// <summary>
        /// Gets type of report, Consistency or Initial. Possible values
        /// include: 'Consistency', 'Initial'
        /// </summary>
        [JsonProperty(PropertyName = "operationType")]
        public string OperationType { get; private set; }

        /// <summary>
        /// Gets or sets the list of resources for which guest configuration
        /// assignment compliance is checked.
        /// </summary>
        [JsonProperty(PropertyName = "resources")]
        public IList<AssignmentReportResource> Resources { get; set; }

    }
}